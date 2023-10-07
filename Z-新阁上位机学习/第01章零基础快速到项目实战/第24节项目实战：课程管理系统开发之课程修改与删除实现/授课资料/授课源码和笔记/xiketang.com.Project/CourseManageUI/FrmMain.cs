using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManageUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //显示当前登录用户名
            this.lblCurrentUser.Text = Program.currentTeacher.TeacherName;

            //如果读取了用户的权限，请在这里设置...


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

        private void OpenForm(Form childFrom)
        {
            //首先判断容器中是否有其他的窗体
            foreach (Control item in this.panelRight.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            //嵌入新的窗体
            childFrom.TopLevel = false;//将子窗体设置成非顶级控件
            // childFrom.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框（目前不需要了）
            childFrom.Parent = this.panelRight;//设置窗体的容器
            childFrom.Dock = DockStyle.Fill;//随着容器大小自动调整窗体大小（目前可能没有效果）
            childFrom.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //课程信息管理
        private void btnCousreManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCourseManage());
        }
        //添加课程
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAddCourse());
        }
        //修改登录密码
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmModifyPwd()); 
        }
        //讲师管理
        private void btnTeacherManage_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTeacherManage());
        }
    }
}
