using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4_Winform基础
{
    public partial class Form4 : Form
    {
        //string file = "bianji.rtf";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.LoadFile(f.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.SaveFile(f.FileName);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            //背景色更改为黄色
            richTextBox1.SelectionBackColor = Color.Yellow;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // 文字颜色更改为红色
            ColorDialog f = new ColorDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = f.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            DialogResult re = f.ShowDialog();
            if (re == DialogResult.OK)
            {
                richTextBox1.SelectionFont = f.Font;
            }
            //字体更改为20号黑体
            //Font font = new Font("黑色", 20);
            //richTextBox1.SelectionFont = Font;
        }
    }
}
