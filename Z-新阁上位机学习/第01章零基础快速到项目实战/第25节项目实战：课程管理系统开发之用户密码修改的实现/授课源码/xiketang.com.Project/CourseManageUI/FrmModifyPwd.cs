using CourseManageBLL;
using CourseManageModels;
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
    public partial class FrmModifyPwd : Form
    {

        public FrmModifyPwd()
        {
            InitializeComponent();
        }
        //保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            //基础数据验证（请自行完成）非空的验证，其次，密码长度的验证、


            //判断原密码是否正确
            if (!Program.currentTeacher.LoginPwd.Equals(this.txtOldPwd.Text.Trim()))
            {
                MessageBox.Show("原密码不正确！", "修改提示");
                this.txtOldPwd.SelectAll();
                this.txtOldPwd.Focus();
                return;
            }
            if (!this.txtNewPwd.Text.Trim().Equals(this.txtConfirmNewPwd.Text.Trim()))
            {
                MessageBox.Show("两次输入的信息密码不一致！", "修改提示");
                return;
            }
            //【2】封装对象
            Teacher teacher = new Teacher
            {
                TeacherId = Program.currentTeacher.TeacherId,
                LoginPwd = this.txtNewPwd.Text.Trim()
            };
            //【3】调用修改(可以添加异常处理)
            int result = new TeacherManager().ModifyPwd(teacher);

            if (result == 1) //如果修改成功，则当前就保存
            {
                Program.currentTeacher.LoginPwd = this.txtNewPwd.Text.Trim();
                MessageBox.Show("密码修改成功！","成功提示");
            }
            //其他情况，通常是有异常，如果你添加了异常，后面直接捕获就行了。

          
            this.Close();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
