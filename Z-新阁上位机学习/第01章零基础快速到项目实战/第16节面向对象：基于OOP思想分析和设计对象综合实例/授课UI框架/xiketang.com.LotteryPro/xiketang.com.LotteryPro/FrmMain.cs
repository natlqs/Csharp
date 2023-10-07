using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace xiketang.com.LotteryPro
{
    public partial class FrmMain : Form
    {

       
        public FrmMain()
        {
            InitializeComponent();         
        }

        #region  拖动和关闭窗体

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        //启动选号
        private void btnStart_Click(object sender, EventArgs e)
        {
          
        }
      

        //开始选号
        private void btnSelect_Click(object sender, EventArgs e)
        {
           
        }
        //清除
        private void btnDel_Click(object sender, EventArgs e)
        {
         
        }       
        //确认购买
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
