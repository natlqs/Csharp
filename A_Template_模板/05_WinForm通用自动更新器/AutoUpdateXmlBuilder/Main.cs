using LinkTo.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoUpdateXmlBuilder
{
    public partial class Main : Form
    {
        //自动更新目录路径
        private static readonly string AutoUpdateDirPath = Application.StartupPath + @"\" + GlobalParam.AutoUpdateDir;
        //自动更新信息XML文件路径
        private static readonly string AutoUpdateInfoXmlPath = Path.Combine(AutoUpdateDirPath, GlobalParam.AutoUpdateInfo_XmlFileName);
        //自动更新文件目录路径
        private static readonly string RemoteDirPath = Application.StartupPath + @"\" + GlobalParam.AutoUpdateDir + @"\" + GlobalParam.RemoteDir;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(RemoteDirPath))
            {
                Directory.CreateDirectory(RemoteDirPath);
            }
            LoadBaseInfo();
            LoadDirectoryFileList();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBaseInfo();
            LoadDirectoryFileList();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void LoadBaseInfo()
        {
            dtUpdateTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtNewVersion.Text = GetMainProcessFileVersion();
            CreateHeaderAndFillListView();
        }

        /// <summary>
        /// 获取主程序文件版本
        /// </summary>
        /// <returns></returns>
        private string GetMainProcessFileVersion()
        {
            string fileVersion = "";
            if (File.Exists(RemoteDirPath + "\\" + GlobalParam.MainProcess + ".exe"))   //如果更新中有主程序文件
            {
                FileVersionInfo info = FileVersionInfo.GetVersionInfo(RemoteDirPath + "\\" + GlobalParam.MainProcess + ".exe");
                fileVersion = info.FileVersion;
            }
            return fileVersion;
        }

        /// <summary>
        /// 添加ListView列名
        /// </summary>
        private void CreateHeaderAndFillListView()
        {
            lstFileList.Columns.Clear();
            int lvWithd = lstFileList.Width;
            ColumnHeader columnHeader;

            //First Header
            columnHeader = new ColumnHeader
            {
                Text = "#",
                Width = 38
            };
            lstFileList.Columns.Add(columnHeader);

            //Second Header
            columnHeader = new ColumnHeader
            {
                Text = "文件名",
                Width = (lvWithd - 38) / 2
            };
            lstFileList.Columns.Add(columnHeader);

            //Third Header
            columnHeader = new ColumnHeader
            {
                Text = "更新路径",
                Width = (lvWithd - 38) / 2
            };
            lstFileList.Columns.Add(columnHeader);
        }

        /// <summary>
        /// 加载目录文件列表
        /// </summary>
        private void LoadDirectoryFileList()
        {
            if (!Directory.Exists(RemoteDirPath))
            {
                Directory.CreateDirectory(RemoteDirPath);
            }
            FileHelper fileHelper = new FileHelper(RemoteDirPath);
            var fileArrary = fileHelper.GetUpdateList(fileHelper.GetAllFilesInDirectory(RemoteDirPath)).ToList();
            var lastFile = fileArrary.FirstOrDefault(s => s == GlobalParam.MainProcess + ".exe");
            //exe作为最后的文件更新，防止更新过程中出现网络错误，导致文件未全部更新。
            if (lastFile != null)
            {
                fileArrary.Remove(lastFile);
                fileArrary.Add(lastFile);
            }
            PopulateListViewWithArray(fileArrary.ToArray());
        }

        /// <summary>
        /// 使用路径字符数组填充列表
        /// </summary>
        /// <param name="strArray"></param>
        private void PopulateListViewWithArray(string[] strArray)
        {
            lstFileList.Items.Clear();
            if (strArray != null)
            {
                //只过滤根目录下的特殊文件
                strArray = strArray.Where(s => !new string[] { GlobalParam.AutoUpdateInfo_XmlFileName }.Contains(s.Substring(s.IndexOf('\\') + 1))).ToArray();
                for (int i = 0; i < strArray.Length; i++)
                {
                    ListViewItem lvi = new ListViewItem
                    {
                        Text = (i + 1).ToString()
                    };
                    int intStart = strArray[i].LastIndexOf('\\') + 1;
                    lvi.SubItems.Add(strArray[i].Substring(intStart, strArray[i].Length - intStart));
                    lvi.SubItems.Add(strArray[i]);
                    lstFileList.Items.Add(lvi);
                }
            }
        }

        /// <summary>
        /// 生成更新XML文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewVersion.Text))
            {
                MessageBox.Show("更新版本号不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewVersion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMainProcessName.Text))
            {
                MessageBox.Show("主进程名不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMainProcessName.Focus();
                return;
            }

            AutoUpdateInfo info = new AutoUpdateInfo()
            {
                NewVersion = txtNewVersion.Text.Trim(),
                UpdateTime = dtUpdateTime.Value.ToString("yyyy-MM-dd"),
                UpdateContent = txtUpdateContent.Text,
                FileList = lstFileList.Items.Cast<ListViewItem>().Select(s => s.SubItems[2].Text).ToList()
            };

            string xmlValue = XmlUtility.Serializer(typeof(AutoUpdateInfo), info);
            using (StreamWriter sw = new StreamWriter(AutoUpdateInfoXmlPath))
            {
                sw.WriteLine(xmlValue);
                sw.Flush();
                sw.Close();
            }
            MessageBox.Show("生成成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 打开本地目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe")
            {
                Arguments = AutoUpdateDirPath
            };
            Process.Start(psi);
        }
    }
}