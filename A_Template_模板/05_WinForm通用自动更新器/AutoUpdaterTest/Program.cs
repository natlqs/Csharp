using LinkTo.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdaterTest
{
    /// <summary>
    /// 检测应用程序是否需要自动更新，如果需要则检测远程服务器的版本号。假如远程服务器有新版本，则调用自动更新器AutoUpdater并向其传递4个参数
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            //尝试设置访问权限
            FileUtility.AddSecurityControll2Folder("Users", Application.StartupPath);

            //未捕获的异常处理
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            //是否检查自动更新赋值
            if (args.Length > 0)
            {
                GlobalParam.CheckAutoUpdate = args[0];
            }

            //加载自动更新配置文件，给上下文AppServiceConfig对象赋值。
            var config = AutoUpdateHelper.Load();
            AppContext.AutoUpdateConfigData = config;

            //窗体互斥体
            var instance = new Mutex(true, GlobalParam.MainProcess, out bool isNewInstance);
            if (isNewInstance == true)
            {
                if (GlobalParam.CheckAutoUpdate.ToBoolean())
                {
                    if (CheckUpdater())
                        ProcessUtility.KillProcess(GlobalParam.MainProcess);
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(MainForm.Instance);
                instance.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("已经启动了一个程序，请先退出。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// 自动更新检测
        /// </summary>
        /// <returns></returns>
        private static bool CheckUpdater()
        {
            if (GlobalParam.CheckAutoUpdate.ToBoolean() == false) return false;

            #region 检查版本更新
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool blFinish = false;
            AppConfig.Instance.InitialSystemConfig();
            var helper = new AutoUpdateHelper(AppConfig.Instance.AutoUpdateConfigData.AutoUpdateMode);
            string fileVersion = FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion;

            long localVersion = 0;
            long remoteVersion = 0;
            try
            {
                localVersion = fileVersion.Replace(".", "").ToLong();
                remoteVersion = helper.GetRemoteAutoUpdateInfoVersion().Replace(".", "").ToLong();

                if ((localVersion > 0) && (localVersion < remoteVersion))
                {
                    blFinish = true;
                    string autoUpdateConfigXmlPath = helper.WriteLocalAutoUpdateInfoXml();
                    string autoUpdateInfoXmlPath = Path.Combine(AppConfig.Instance.TempPath, GlobalParam.AutoUpdateInfo_XmlFileName);
                    string argument1 = autoUpdateConfigXmlPath;
                    string argument2 = autoUpdateInfoXmlPath;
                    string argument3 = GlobalParam.MainProcess;
                    string argument4 = GlobalParam.RemoteDir;
                    string arguments = argument1 + " " + argument2 + " " + argument3 + " " + argument4;
                    Process.Start("AutoUpdater.exe", arguments);
                    Application.Exit();
                }
            }
            catch (TimeoutException)
            {
                blFinish = false;
            }
            catch (WebException)
            {
                blFinish = false;
            }
            catch (Exception)
            {
                blFinish = false;
            }

            return blFinish;
            #endregion
        }

        /// <summary>
        /// UI线程未捕获异常处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string strError = "", strLog = "", strDateInfo = DateTime.Now.ToString() + " 出现应用程序未处理的异常：\r\n";
            var error = e.Exception;

            if (error != null)
            {
                strError = strDateInfo + $"异常类型：{error.GetType().Name}\r\n异常消息：{error.Message}";
                strLog = strDateInfo + $"异常类型：{error.GetType().Name}\r\n异常消息：{error.Message}\r\n堆栈信息：{error.StackTrace}\r\n来源信息：{error.Source}\r\n";
            }
            else
            {
                strError = $"Application ThreadException：{e}";
            }

            WriteLog(strLog);
            MessageBox.Show(strError, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 非UI线程未捕获异常处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string strError = "", strLog = "", strDateInfo = DateTime.Now.ToString() + " 出现应用程序未处理的异常：\r\n";

            if (e.ExceptionObject is Exception error)
            {
                strError = strDateInfo + $"异常消息：{error.Message}";
                strLog = strDateInfo + $"异常消息：{error.Message}\r\n堆栈信息：{error.StackTrace}";
            }
            else
            {
                strError = $"Application UnhandledError：{e}";
            }

            WriteLog(strLog);
            MessageBox.Show(strError, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="strLog"></param>
        private static void WriteLog(string strLog)
        {
            string dirPath = @"Log\MainProcess", fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string strLine = "----------------------------------------------------------------------------------------------------";

            FileUtility.WriteFile(Path.Combine(dirPath, fileName), strLog);
            FileUtility.WriteFile(Path.Combine(dirPath, fileName), strLine);
        }
    }
}
