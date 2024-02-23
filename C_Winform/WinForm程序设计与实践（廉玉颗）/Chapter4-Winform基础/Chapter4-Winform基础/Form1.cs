using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4_Winform基础
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsNullOrEmpty(Control.ControlCollection controls)
        {
            bool flag = false;
            foreach (Control item in controls)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    flag = true;
                }
            }
            return flag;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool flag = IsNullOrEmpty(this.Controls);
            if (flag == true)
            {
                MessageBox.Show("请填写全部信息！");
            }
            else
            {
                MessageBox.Show("注册成功！");
            }
        }
    }
}
