using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xiketang.com.WinformBase
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 构造方法：初始化所有的控件
        /// </summary>
        public FrmMain()
        {
            // this.btnTest.Text = "11";//在初始化的方法前面，不要写任何代码！

            InitializeComponent();//调用后面Desinger类中的方法，用于控件初始化

            //将控件的Click事件和事件方法关联
            this.btnTest.Click += new System.EventHandler(this.btnMyTest_Click);

            //我们想完成控件或其他初始化内容，请在构造方法中写！

       
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.button1.Click += new System.EventHandler(this.btnTest_Click);
        }

        ////事件方法
        // private void btnTest_Click(object sender, EventArgs e)
        // {

        // }
        private void btnMyTest_Click(object sender, EventArgs e)
        {
            //sender表示当前控件的对象
            //Button btn = sender as Button;
            Button btn = (Button)sender;

            MessageBox.Show(btn.Tag.ToString());

            //我们也可以动态的取消事件的关联
            this.btnTest.Click -= new System.EventHandler(this.btnMyTest_Click);
        }

        private void btnTest_MouseEnter(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;

            //MessageBox.Show(btn.Tag.ToString());
        }

        //窗体所有控件和初始化完毕后要执行的事件，我们通常不用
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //不建议在这里编写初始化内容...
        }

        //窗体关闭之前发生的
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认要关闭窗体吗？", "关闭确认", 
                MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)//用户取消关闭
            {
                e.Cancel = true;
            }
        }
        //窗体关闭后发生的
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //可以在这个地方编写你要做的其他任务...

            MessageBox.Show("窗体已经关闭");
        }

        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
