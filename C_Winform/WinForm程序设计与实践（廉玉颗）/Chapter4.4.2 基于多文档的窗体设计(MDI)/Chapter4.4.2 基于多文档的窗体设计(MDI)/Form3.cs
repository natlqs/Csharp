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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form11.FormShow2 = false;
        }
    }
}
