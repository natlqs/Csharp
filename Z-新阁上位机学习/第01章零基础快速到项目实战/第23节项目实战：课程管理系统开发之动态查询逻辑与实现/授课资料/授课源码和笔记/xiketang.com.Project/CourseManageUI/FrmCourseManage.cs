using CourseManageBLL;
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

namespace CourseManageUI
{
    public partial class FrmCourseManage : Form
    {
        private CourseCategoryManager categoryManager = new CourseCategoryManager();
        private CourseManager courseManager = new CourseManager();

        private List<Course> queryList = null;//创建一个集合，用来缓存查询结果，便于后面修改和删除使用，从而减少数据库的访问

        public FrmCourseManage()
        {
            InitializeComponent();

            List<CourseCategory> list = categoryManager.GetCourseCategories();
            //在集合元素第一个位置插入一个空白
            list.Insert(0, new CourseCategory { CategoryId = -1, CategoryName = "---请选择---" });

            //动态填充课程分类下拉框
            this.cbbCategory.DataSource = list;
            this.cbbCategory.DisplayMember = "CategoryName";//我们在UI中看到的
            this.cbbCategory.ValueMember = "CategoryId";//保存到数据库使用的外键值
            this.cbbCategory.SelectedIndex = -1;

            //禁止自动生成列
            this.dgvCourseList.AutoGenerateColumns = false;

            //隐藏修改面板
            this.panelModify.Visible = false;

            //禁用修改和删除按钮（提高用户体验）
            this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = false;


        }

        //提交查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //【1】条件验证
            if ((this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0)
                && this.txtCourseName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请至少选择一个查询条件！", "查询提示");
                return;
            }
            //【2】提交查询
            //int categoryId = 0;
            //if (this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0)
            //{
            //    categoryId = -1;
            //}
            //else
            //{
            //    categoryId = Convert.ToInt32(this.cbbCategory.SelectedValue);
            //}
            //请大家学会使用三元运算符
            int categoryId = this.cbbCategory.SelectedIndex == -1 ? -1 : Convert.ToInt32(this.cbbCategory.SelectedValue);
            queryList = courseManager.QueryCourse(categoryId, this.txtCourseName.Text.Trim());

            //【3】展示查询
            if (queryList.Count == 0) //如果没有找到结果，清空上一次查询的数据
            {
                this.lblCount.Text = "0";
                this.dgvCourseList.DataSource = null;
                this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = false;
                MessageBox.Show("没有找到查询结果！", "查询提示");
            }
            else  //重新绑定查询结果
            {
                this.dgvCourseList.DataSource = queryList;
                this.lblCount.Text = this.dgvCourseList.RowCount.ToString();
                this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = true;
            }

        }
        //显示修改信息
        private void btnModifyCourse_Click(object sender, EventArgs e)
        {

        }
        //保存修改信息
        private void btnSaveToDB_Click(object sender, EventArgs e)
        {

        }
        //关闭修改窗口
        private void btnCloseModify_Click(object sender, EventArgs e)
        {

        }
        //删除课程
        private void btnDelCourse_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
