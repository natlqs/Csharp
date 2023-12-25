using LinkTo.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdater
{
    public partial class HttpStartUp : Form
    {
        private bool _blSuccess = false;
        private string _autoUpdateHttpUrl = null;
        private AutoUpdateInfo _autoUpdateInfo = null;

        public HttpStartUp(string autoUpdateHttpUrl, AutoUpdateInfo autoUpdateInfo)
        {
            InitializeComponent();
            _autoUpdateHttpUrl = autoUpdateHttpUrl;
            _autoUpdateInfo = autoUpdateInfo;
            _blSuccess = false;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Text = GlobalParam.MainProcess + "-更新程序";
            lblUpdateTime.Text = _autoUpdateInfo.UpdateTime;
            lblNewVersion.Text = _autoUpdateInfo.NewVersion;
            txtUpdate.Text = _autoUpdateInfo.UpdateContent;
        }

        /// <summary>
        /// 立即更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            ProcessUtility.KillProcess(GlobalParam.MainProcess);
            btnRun.Enabled = false;
            btnLeave.Enabled = false;
            
            Thread thread = new Thread(() =>
            {
                try
                {
                    var downFileList = _autoUpdateInfo.FileList.OrderByDescending(s => s.IndexOf("\\"));
                    foreach (var fileName in downFileList)
                    {
                        string fileUrl = string.Empty, fileVaildPath = string.Empty;
                        if (fileName.StartsWith("\\"))
                        {
                            fileVaildPath = fileName.Substring(fileName.IndexOf("\\"));
                        }
                        else
                        {
                            fileVaildPath = fileName;
                        }
                        fileUrl = _autoUpdateHttpUrl.TrimEnd(new char[] { '/' }) + @"/" + GlobalParam.RemoteDir + @"/" + fileVaildPath.Replace("\\", "/");    //替换文件目录中的路径为网络路径
                        DownloadFileDetail(fileUrl, fileName);
                    }
                    _blSuccess = true;
                }
                catch (Exception ex)
                {
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        throw ex;
                    }));
                }
                finally
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        btnRun.Enabled = true;
                        btnLeave.Enabled = true;
                    }));
                }
                if (_blSuccess)
                {
                    Process.Start(GlobalParam.MainProcess + ".exe");
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        Close();
                        Application.Exit();
                    }));
                }
            })
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void DownloadFileDetail(string httpUrl, string filename)
        {
            string fileName = Application.StartupPath + "\\" + filename;
            string dirPath = GetDirPath(fileName);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(httpUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream httpStream = response.GetResponseStream();
            long totalBytes = response.ContentLength;
            if (progressBar != null)
            {
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    lblDownInfo.Text = "开始下载...";
                    progressBar.Maximum = (int)totalBytes;
                    progressBar.Minimum = 0;
                }));
            }
            FileStream outputStream = new FileStream(fileName, FileMode.Create);
            int bufferSize = 2048;
            int readCount;
            byte[] buffer = new byte[bufferSize];
            readCount = httpStream.Read(buffer, 0, bufferSize);
            int allByte = (int)response.ContentLength;
            int startByte = 0;
            BeginInvoke(new MethodInvoker(delegate ()
            {
                progressBar.Maximum = allByte;
                progressBar.Minimum = 0;
            }));
            while (readCount > 0)
            {
                outputStream.Write(buffer, 0, readCount);
                readCount = httpStream.Read(buffer, 0, bufferSize);
                startByte += readCount;
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    lblDownInfo.Text = "已下载：" + startByte / 1024 + "KB/" + "总长度："+ allByte / 1024 + "KB" + " " + " 文件名：" + filename;         
                    progressBar.Value = startByte;
                }));
                Application.DoEvents();
                Thread.Sleep(5);
            }
            BeginInvoke(new MethodInvoker(delegate ()
            {
                lblDownInfo.Text = "下载完成。";
            }));
            httpStream.Close();
            outputStream.Close();
            response.Close();
        }

        public static string GetDirPath(string filePath)
        {
            if (filePath.LastIndexOf("\\") > 0)
            {
                return filePath.Substring(0, filePath.LastIndexOf("\\"));
            }
            return filePath;
        }

        /// <summary>
        /// 暂不更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要放弃此次更新吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(GlobalParam.MainProcess + ".exe", "false");
                Close();
                Application.Exit();
            }
        }      
    }
}
