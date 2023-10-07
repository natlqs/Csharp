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
    public partial class FrmEventApp : Form
    {
        public FrmEventApp()
        {
            InitializeComponent();
        }


        #region 窗体移动

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmEventApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmEventApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmEventApp_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion


        public void openForm(Form childForm)
        {
            foreach(Form frm in Application.OpenForms)
            {
                if (frm is SerialSetting)
                {
                    frm.Close();
                    break;
                }
                else if (frm is DataStorageSetting)
                {
                    frm.Close();
                    break;
                }
            }
            childForm.Show();
            childForm.Focus();
            childForm.StartPosition = FormStartPosition.Manual;
        }

        private void FrmEventApp_Load(object sender, EventArgs e)
        {
            Console.WriteLine("hello world");
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {

        }


        private void btnSerialSetting_Click(object sender, EventArgs e)
        {
            openForm(new SerialSetting());
        }

        private void btnDataStorageSetting_Click(object sender, EventArgs e)
        {
            openForm(new DataStorageSetting());
        }

        private void btnStartCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnStopCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnLuckyNumber_Click(object sender, EventArgs e)
        {
            openForm(new LuckyNumbers_Frm());
        }
    }
}
