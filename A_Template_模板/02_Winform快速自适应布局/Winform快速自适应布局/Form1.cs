using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoWindowsSize;
using System.Windows.Forms;

namespace Winform快速自适应布局
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

       
        AutoAdaptWindowsSize AutoSize;

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoSize = new AutoAdaptWindowsSize(this);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSize != null) // 一定加这个判断，电脑缩放布局不是100%的时候，会报错
            {
                AutoSize.FormSizeChanged();
            }
        }

        #region 窗体移动

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        #endregion


    }
    }
