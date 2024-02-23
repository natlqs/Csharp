using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4._4._2_基于多文档的窗体设计_MDI_
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        static bool formShow1 = false;   // 标记窗体1是否打开

        // 添加属性FormShow1， 用于关闭子窗体1时，修改标记
        static public bool FormShow1
        {
            get { return formShow1; }
            set { formShow1 = value; }
        }

        static bool formShow2 = false;   // 标记窗体2是否打开

        // 添加属性FormShow2， 用于关闭子窗体2时，修改标记
        static public bool FormShow2
        {
            get { return formShow2; }
            set { formShow2 = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormShow1)
            {
                Form12 f = new Form12();
                f.MdiParent = this;
                f.Show();
                formShow1 = true;
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormShow2)
            {
                Form13 f = new Form13();
                f.MdiParent = this;
                f.Show();
                formShow2 = true;
            }

        }
    }
}
