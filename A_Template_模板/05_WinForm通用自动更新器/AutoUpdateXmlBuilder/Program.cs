using LinkTo.Toolkit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdateXmlBuilder
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
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
            string dirPath = @"Log\XmlBuilder", fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string strLine = "----------------------------------------------------------------------------------------------------";

            FileUtility.WriteFile(Path.Combine(dirPath, fileName), strLog);
            FileUtility.WriteFile(Path.Combine(dirPath, fileName), strLine);
        }
    }
}
