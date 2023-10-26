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
        //创建选号器对象
        private Selector newSelector = new Selector();

        //每次得到的随机数
        List<string> randomNum = null;


        public FrmMain()
        {
            InitializeComponent();
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
            this.timerCreateNum.Start();//启动定时器
            this.btnSelect.Enabled = true;
            this.btnStart.Enabled = false;
        }
        //定时器事件：每隔50ms调用一次
        private void timerCreateNum_Tick(object sender, EventArgs e)
        {
            //通过调用选号器，得到随机数
            randomNum = newSelector.CreateRandomNum();
            //在下面的列表中显示
            this.lblNum1.Text = randomNum[0];
            this.lblNum2.Text = randomNum[1];
            this.lblNum3.Text = randomNum[2];
            this.lblNum4.Text = randomNum[3];
            this.lblNum5.Text = randomNum[4];
            this.lblNum6.Text = randomNum[5];
            this.lblNum7.Text = randomNum[6];
        }
        //选择
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.timerCreateNum.Stop();
            this.btnSelect.Enabled = false;
            this.btnStart.Enabled = true;

            //创建双色球对象
            DoubleChromosphere dc = new DoubleChromosphere
            {
                //Numbers = new List<string>()
                //{
                //    this.lblNum1.Text,
                //    this.lblNum2.Text,
                //    this.lblNum3.Text,
                //    this.lblNum4.Text,
                //    this.lblNum5.Text,
                //    this.lblNum6.Text,
                //    this.lblNum7.Text
                //}
                Numbers = this.randomNum  //我们因为已经保存了当前的一组数字，所以可以直接复制
            };

            //添加到选号池，以备后面的打印、远程保存等方法使用
            this.newSelector.SelectedNums.Add(dc);

            //显示号码
            string num = string.Empty;
            foreach (string item in this.randomNum)
            {
                num += item + "  ";
            }
            this.lbNumberList.Items.Add(num);
        }
        //清除
        private void btnDel_Click(object sender, EventArgs e)
        {
            this.newSelector.SelectedNums.Clear(); //从集合中清除
            this.lbNumberList.Items.Clear();//从列表中清除
        }

        //确认购买：需要保存到远程数据库或服务器（也可以通过webapi远程提交）
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //首先打印

            //远程保存
        }

    }
}
