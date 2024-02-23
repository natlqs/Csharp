using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4_Winform基础
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());       // ListBox
            //Application.Run(new Form2());       // Panel
            //Application.Run(new Form3());       // Tabcontrol
            Application.Run(new Form4());
        }
    }
}
