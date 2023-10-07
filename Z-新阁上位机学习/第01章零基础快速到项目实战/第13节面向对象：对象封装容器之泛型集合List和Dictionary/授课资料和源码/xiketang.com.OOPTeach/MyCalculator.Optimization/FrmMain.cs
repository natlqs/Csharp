using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator.Optimization
{
    public partial class FrmMain : Form
    {
        private Calculator myCalculator = new Calculator();

        public FrmMain()
        {
            InitializeComponent();
            InitBtn();
        }

        #region 数字键关联事件


        public void InitBtn()
        {
            this.btn0.Click += new EventHandler(btn_Click);
            this.btn1.Click += new EventHandler(btn_Click);
            this.btn2.Click += new EventHandler(btn_Click);
            this.btn3.Click += new EventHandler(btn_Click);
            this.btn4.Click += new EventHandler(btn_Click);
            this.btn5.Click += new EventHandler(btn_Click);
            this.btn6.Click += new EventHandler(btn_Click);
            this.btn7.Click += new EventHandler(btn_Click);
            this.btn8.Click += new EventHandler(btn_Click);
            this.btn9.Click += new EventHandler(btn_Click);

            this.btn_Multiply.Click += new System.EventHandler(this.btn_Cal_Click);
            this.btn_Add.Click += new System.EventHandler(this.btn_Cal_Click);
            this.btn_div.Click += new System.EventHandler(this.btn_Cal_Click);
            this.btn_Sub.Click += new System.EventHandler(this.btn_Cal_Click);
        }


        #endregion

        //在屏幕上显示数字
        private void btn_Click(object sender, EventArgs e)
        {         
            this.lblResult.Text += ((Button)sender).Tag.ToString();
        }
        //保存操作符
        private void btn_Cal_Click(object sender, EventArgs e)
        {          
            myCalculator.Operation = ((Button)sender).Tag.ToString();
            this.lblResult.Text += myCalculator.Operation;
        }
        //开始运算
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int result = myCalculator.StartCalculator(this.lblResult.Text);
            this.lblResult.Text += "=" + result;
        }
        //清除
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.lblResult.Text = "";
        }
    }
}
