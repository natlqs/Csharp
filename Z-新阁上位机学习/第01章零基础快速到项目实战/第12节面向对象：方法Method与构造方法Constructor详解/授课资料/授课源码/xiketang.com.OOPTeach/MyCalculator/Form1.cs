using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operation = "";//保存当前的操作符

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.label1.Text += "+";
            operation= "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.label1.Text += "-";
            operation = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.label1.Text += "×";
            operation = "×";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.label1.Text += "÷";
            operation = "÷";
        }
        //计算
        private void button20_Click(object sender, EventArgs e)
        {
            string data = this.label1.Text;

            string num1 = data.Substring(0, data.IndexOf(operation));
            string num2 = data.Substring(data.IndexOf(operation)+1);

            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);

            int result = 0;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "×":
                    result = a * b;
                    break;
                case "÷":
                    result = a / b;
                    break;              
            }

            this.label1.Text += "=" + result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
        }
    }
}
