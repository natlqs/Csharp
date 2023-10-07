using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 全局异常处理_用来解决编译后无法查看具体报错信息_
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
 #region 全局异常处理需添加如下代码
            // 设置未捕获异常处理程序
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
 #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
 #region 全局异常处理需添加如下代码
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // 处理线程异常
            MessageBox.Show("发生了未处理的异常：" + e.Exception.Message + "\r\n" + e.Exception.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // 处理应用程序域中的异常
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                MessageBox.Show("发生了未处理的异常：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("发生了未处理的异常：" , "错误",MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }
 #endregion
    }
}
