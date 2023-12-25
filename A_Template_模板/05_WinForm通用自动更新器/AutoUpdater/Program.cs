using LinkTo.Toolkit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdater
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region 测试
            //string strArgs = @"E:\LinkTo.AutoUpdater\AutoUpdaterTest\bin\Debug\Temp\AutoUpdateConfig.xml"+" "+@"E:\LinkTo.AutoUpdater\AutoUpdaterTest\bin\Debug\Temp\AutoUpdateInfo.xml"+" "+"AutoUpdaterTest"+" "+"AutoUpdateFiles";
            //args = strArgs.Split(' ');
            #endregion

            if (args.Length > 0)
            {
                string autoUpdateConfigXmlPath = args[0].ToString();
                string autoUpdateInfoXmlPath = args[1].ToString();
                GlobalParam.MainProcess = args[2].ToString();
                GlobalParam.RemoteDir = args[3].ToString();

                var autoUpdateConfigXml = FileUtility.ReadFile(autoUpdateConfigXmlPath);
                var autoUpdateInfoXml = FileUtility.ReadFile(autoUpdateInfoXmlPath);
                AutoUpdateConfig config = XmlUtility.Deserialize(typeof(AutoUpdateConfig), autoUpdateConfigXml) as AutoUpdateConfig;
                AutoUpdateInfo info = XmlUtility.Deserialize(typeof(AutoUpdateInfo), autoUpdateInfoXml) as AutoUpdateInfo;

                if (config.AutoUpdateMode.ToUpper() == "HTTP")
                {
                    Application.Run(new HttpStartUp(config.AutoUpdateHttpUrl, info));
                }
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// UI线程未捕获异常处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
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
        public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
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
            string dirPath = @"Log\AutoUpdater", fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string strLine = "----------------------------------------------------------------------------------------------------";

            FileUtility.WriteFile(Path.Combine(dirPath, fileName), strLog);
            FileUtility.WriteFile(Path.Combine(dirPath, fileName), strLine);
        }
    }
}
