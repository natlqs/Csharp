using System.Diagnostics;

namespace _19_Thread_多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Process p1 = new Process();
        private Process p2 = new Process();
        private Process p3 = new Process();

        private void button1_Click(object sender, EventArgs e)
        {

            // 如果程序执行文件不在环境目录下，FileName用绝对路径即可！
            p1.StartInfo.FileName = "Notepad.exe";      // 程序： 准备执行记事本
            p1.StartInfo.Arguments = "test1.txt";       // 参数：创建或打开的文档为test1.txt（当前目录有就打开，没有就创建）
            p1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;       // 打开方式为图形化界面（另：最大，最小，普通，隐藏）
            p1.Start();
            // p1 = Process.Start("Notepad.exe", "test1.txt");      // 使用静态方法启动程序，返回为Process对象
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p2.StartInfo.FileName = "mspaint.exe";      // 准备执行画图程序
            p2.StartInfo.WindowStyle = ProcessWindowStyle.Normal; // 打开方式为图形化界面
            p2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p3.StartInfo.FileName = "C:\\WINDOWS\\regedit.exe";  // 准备执行注册表
            p3.StartInfo.WindowStyle = ProcessWindowStyle.Normal;       // 打开方式为图形化界面
            p3.StartInfo.Verb = "runas"; 
            p3.Start();
        }

        /// <summary>
        /// 向进程的主窗口发送关闭消息来关闭拥有用户界面的进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (TryProcess(p1) && !p1.HasExited)
            {
                p1.CloseMainWindow();
            }

            if (TryProcess(p2) && !p2.HasExited)
            {
                p2.CloseMainWindow();
            }

            if (TryProcess(p3) && !p3.HasExited)
            {
                p3.CloseMainWindow();
            }
        }

        /// <summary>
        ///  Kill方法强制终止进程
        /// 而CloseMainWindow仅请求终止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (TryProcess(p1) && !p1.HasExited)
            {
                p1.Kill();
            }

            if (TryProcess(p2) && !p2.HasExited)
            {
                p2.Kill();
            }

            if (TryProcess(p3) && !p3.HasExited)
            {
                p3.Kill(true);      // true终止相关联进程及其后代，false仅终止相关联进程
            }
        }
        public bool TryProcess(Process p)
        {
            try
            {
                // p.Id 获取关联进程的唯一标识符
                int x = p.Id;
                return true;
            }
            catch (Exception)
            {
                // 异常表示Process从未关联过进程
                return false;
            }
        }
    }
}