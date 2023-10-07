using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// 注意：下面的实现方法，是垃圾代码的编写方式！
///            我们需要使用OOP的方法，通过设计类，让整个的程序变得优雅！
///            
///            如果你感觉下面的代码实现都难，您就应该认真思考一下，你该如何学习了！
///            
///            希望常老师的课程，能够让你告别垃圾代码的编写！
///            
///            常老师的QQ：2934008878     课程深入学习客服咨询QQ：995551859
///            
///            课程官网：xiketang.com        
/// </summary>

namespace xiketang.com.NonOOPDemo
{
    public partial class FrmMain : Form
    {
        private List<string> redNumberList; //红色球池
        List<string> blueNumberList;//蓝色球池
        List<string> selectedNums = new List<string>();//存储选择的号码
        Random random = new Random();//随机数生成器

        public FrmMain()
        {
            InitializeComponent();

            //初始化
            redNumberList = new List<string>
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16","17","18","19","20",
                "21","22","23","24","25","26","27","28","29","30",
                "31","32","33"
            };
            blueNumberList = new List<string>
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16"
            };

            this.btnSelect.Enabled = false;
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
            this.timerCreateNum.Start();
            this.btnStart.Enabled = false;
            this.btnSelect.Enabled = true;
        }
        //定时器随机选号
        private void timerCreateNum_Tick(object sender, EventArgs e)
        {
            List<string> numList = new List<string>();
            while (true)   //生成6个红色球
            {
                if (numList.Count == 6) break;
                string num = redNumberList[random.Next(33)];
                if (numList.Contains(num)) continue;
                else
                {
                    numList.Add(num);
                }
            }
            numList.Add(blueNumberList[random.Next(16)]);  //生成一个蓝色球
            //显示随时生成的球
            this.lblNum1.Text = numList[0];
            this.lblNum2.Text = numList[1];
            this.lblNum3.Text = numList[2];
            this.lblNum4.Text = numList[3];
            this.lblNum5.Text = numList[4];
            this.lblNum6.Text = numList[5];
            this.lblNum7.Text = numList[6];
        }

        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.timerCreateNum.Stop();
            this.btnStart.Enabled = true;
            this.btnSelect.Enabled = false;

            //组合所选号码,并添加到下面的列表
            string num =
                this.lblNum1.Text + "  " +
                this.lblNum2.Text + "  " +
                this.lblNum3.Text + "  " +
                this.lblNum4.Text + "  " +
                this.lblNum5.Text + "  " +
                this.lblNum6.Text + "  " +
                this.lblNum7.Text;
            this.lbNumberList.Items.Add(num);
            this.selectedNums.Add(num);
        }
        //清除
        private void btnDel_Click(object sender, EventArgs e)
        {
            this.lbNumberList.Items.Clear();
            this.selectedNums.Clear();
        }
        //确认购买（VIP课程，后续深入系统讲解...）
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

    }
}
