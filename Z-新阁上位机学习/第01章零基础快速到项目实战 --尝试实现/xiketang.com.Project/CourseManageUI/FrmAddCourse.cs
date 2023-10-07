using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseManageModels;
using System.Drawing;
using CourseManageBLL;

namespace CourseManageUI
{
    public partial class FrmAddCourse : Form
    {
        private CourseCategoryManager categoryManager= new CourseCategoryManager();
        private CourseManager courseManager = new CourseManager();
        //用来缓存添加的课程对象
        private List<Course> addedCourse = new List<Course>();
        public FrmAddCourse()
        {
            InitializeComponent();
            // 动态填充课程分类下拉框
            this.cbbCategory.DataSource= categoryManager.GetCourseCategories();
            this.cbbCategory.DisplayMember = "CategoryName";// 我们在UI中看到的
            this.cbbCategory.ValueMember = "CategoryId";//保存到数据库使用的外键

            // 禁止自动生成列
            this.dgvCourseList.AutoGenerateColumns = false;
        }

        //保存到数据库
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            // 【1】 数据校验（检查用户输入的数据是否符合要求，适当的时候可以使用正则表达式
            // 为空的判断

            // 【2】 封装数据：把用户输入的数据封装到实体对象中
            Course course = new Course
            {
                CourseName = this.txtCourseName.Text.Trim(),
                CourseContent = this.txtCourseContent.Text.Trim(),
                ClassHour = Convert.ToInt32(this.txtClassHour.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCredit.Text.Trim()),
                CategoryId = Convert.ToInt32(this.cbbCategory.SelectedValue),
                TeacherId = Program.currentTeacher.TeacherId,
                CategoryName = this.cbbCategory.Text,
            };

            // 【3】 调用后台提交保存(可以添加异常处理...)
            int result = courseManager.AddCourse(course);

            // 【4】 将添加成功的课程信息保存到缓存中
            addedCourse.Add(course);
            this.dgvCourseList.DataSource = null;   // 如果不清空，后面不会同步显示新添加的。
            this.dgvCourseList.DataSource = this.addedCourse;

            // 

        }

        #region 其他

        //添加行号
        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(this.dgvCourseList.RowHeadersDefaultCellStyle.ForeColor);
            int lineNo = e.RowIndex + 1;
            e.Graphics.DrawString(lineNo.ToString(), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
