# Winformȫ���쳣����
### ��Program.cs�ļ���������´���
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ȫ���쳣����_�������������޷��鿴���屨����Ϣ_
{
    internal static class Program
    {
        /// <summary>
        /// Ӧ�ó��������ڵ㡣
        /// </summary>
        [STAThread]
        static void Main()
        {
 #region ȫ���쳣������������´���
            // ����δ�����쳣�������
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
 #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
 #region ȫ���쳣������������´���
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // �����߳��쳣
            MessageBox.Show("������δ������쳣��" + e.Exception.Message + "\r\n" + e.Exception.StackTrace, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // ����Ӧ�ó������е��쳣
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                MessageBox.Show("������δ������쳣��" + ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("������δ������쳣��" , "����",MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }
 #endregion
    }
}

```