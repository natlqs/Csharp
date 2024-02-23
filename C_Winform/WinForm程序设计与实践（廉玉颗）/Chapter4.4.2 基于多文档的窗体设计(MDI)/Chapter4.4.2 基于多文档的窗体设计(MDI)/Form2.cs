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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form11.FormShow1 = false;
        }
    }
}
