using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 窗口1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.FirstOrDefault(x => x.Name == "Form2") == null)
            {
                Form2 form2 = new Form2();
                form2.FormBorderStyle = FormBorderStyle.None;
                form2.MdiParent = this;
                form2.Dock = DockStyle.Fill;
                form2.Show();
            }
            else
            {
                this.MdiChildren.FirstOrDefault(x => x.Name == "Form2").BringToFront();
            }
        }

        private void 窗口2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.FirstOrDefault(x => x.Name == "Form3") == null)
            {
            Form3 form3 = new Form3();
            form3.FormBorderStyle= FormBorderStyle.None;
            form3.MdiParent = this;
            form3.Dock= DockStyle.Fill;
            form3.Show();
            form3.BringToFront();
            }
            else
            {
                this.MdiChildren.FirstOrDefault(x => x.Name == "Form3").BringToFront();
            }
        }
    }
}
