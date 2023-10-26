using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBasic
{
    public partial class LuckyNumbers_Frm : Form
    {
        // 创建选号器对象
        private Selector selector = new Selector();
        // 每次得到的随机数
        List<string> randomNum = null;


        public LuckyNumbers_Frm()
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

        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLotteryStart_Click(object sender, EventArgs e)
        {
            this.timeCreateNum.Start(); //启动定时器
            this.btnLotterySelect.Enabled = true;
            this.btnLotteryStart.Enabled = false;
        }

        // 定时器时间：每个50ms调用一次

        private void timeCreateNum_Tick(object sender, EventArgs e)
        {
            // 通过调用选号器，得到随机数
            randomNum = selector.CreateRandomNum();
            // 在下面的列表中显示
            //Console.WriteLine(String.Join("\n", randomNum));
            this.lblNum1.Text = randomNum[0];
            this.lblNum2.Text = randomNum[1];
            this.lblNum3.Text = randomNum[2];
            this.lblNum4.Text = randomNum[3];
            this.lblNum5.Text = randomNum[4];
            this.lblNum6.Text = randomNum[5];
            this.lblNum7.Text = randomNum[6];
            this.lblNum8.Text = randomNum[7];
            this.lblNum9.Text = randomNum[8];
            this.lblNum10.Text = randomNum[9];
            this.lblNum11.Text = randomNum[10];
            this.lblNum12.Text = randomNum[11];
            this.lblNum13.Text = randomNum[12];
            this.lblNum14.Text = randomNum[13];
        }

        /// <summary>
        /// 选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLotterySelect_Click(object sender, EventArgs e)
        {
            this.timeCreateNum.Stop();
            this.btnLotterySelect.Enabled = false;
            this.btnLotteryStart.Enabled = true;
            LuckyNumbers lucky = new LuckyNumbers
            {
                Numbers = this.randomNum
            };
            this.selector.luckyNumbers.Add(lucky);

            // 显示号码
            string num = string.Empty;
            foreach(string item in this.randomNum)
            {
                num += item + " ";
            }
            this.LuckyNumbers.Items.Add(num);
        }

        /// <summary>
        /// 清楚
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLotteryClear_Click(object sender, EventArgs e)
        {
            this.selector.luckyNumbers.Clear();
            this.LuckyNumbers.Items.Clear();
        }
    }
}
