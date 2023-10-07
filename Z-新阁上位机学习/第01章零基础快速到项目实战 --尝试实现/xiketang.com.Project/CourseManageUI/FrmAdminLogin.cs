using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManageModels;
using CourseManageBLL;

namespace CourseManageUI
{
    public partial class FrmAdminLogin : Form
    {
        private TeacherManager teacherManager=new TeacherManager();
        public FrmAdminLogin()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginSys_Click(object sender, EventArgs e)
        {
            // [1] 输入验证
            if (this.txtLoginAccount.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录账号！", "提示信息");
                this.txtLoginAccount.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录密码！", "提示信息");
                this.txtLoginPwd.Focus();
                return;
            }

            //ps: 在实际开发中，还可以进一步验证邮箱格式、密码长度、非法字符等...


            //[2] 封装登录实体信息
            Teacher teacher = new Teacher()
            {
                LoginAccount = this.txtLoginAccount.Text.Trim(),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };

            //[3] 调用后台登录逻辑
            teacher = teacherManager.TeacherLogin(teacher);

            //[4] 验证登录是否成功
            if (teacher != null)
            {
                //4.1 如果登录成功，我们首先要保存登录信息（保存到全局变量中，以备后续使用）
                Program.currentTeacher = teacher; 

                // 在实际开发项目中，还应该考虑下面的内容：
                //【1】账号有效性
                //【2】用户的权限
                //【3】登录日志保存
                //【4】是否保存一定时间的登录信息（通过序列化方式完成）


                //4.2 设置窗口返回值
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("登录账号或密码有错误！", "登录提示");
            }
        }
    }
}
