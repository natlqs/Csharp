using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9._1_基本绘图工具
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //Graphics g = this.CreateGraphics();// 创建Graphics对象
            //Pen p = new Pen(Color.Red, 1);      // 定义红色画笔
            //g.DrawEllipse(p, 0, 0, 200, 200);   // 花圆形
            //g.Dispose();            // 释放Graphics使用的资源

            Graphics g = this.CreateGraphics();// 创建Graphics对象
            Brush brush = new SolidBrush(Color.Yellow);
            g.FillEllipse(brush, 0, 0, 200, 200);
            g.Dispose();            // 释放Graphics使用的资源




        }
    }
}
