using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManageBLL;
using CourseManageModels;

namespace CourseManageUI
{
    public partial class FrmCourseManage : Form
    {
        private CourseCategoryManager categoryManager = new CourseCategoryManager();
        private CourseManager courseManager = new CourseManager();
        private List<Course> queryList = null;  // 创建一个集合，用来缓存查询结果，便于后面修改和删除使用，从而减少数据库的访问 

        public FrmCourseManage()
        {
            InitializeComponent();

            List<CourseCategory> list = categoryManager.GetCourseCategories();
            // 在集合第一个位置插入一个空白
            list.Insert(0, new CourseCategory { CategoryId = -1, CategoryName = "---请选择---" });



            // 动态填充课程分类下拉框
            this.cbbCategory.DataSource = list;
            this.cbbCategory.DisplayMember = "CategoryName";
            this.cbbCategory.ValueMember = "CategoryId";

            this.cbbCategory.SelectedIndex = -1;

            // 禁止自动生成列
            this.dgvCourseList.AutoGenerateColumns = false;
            // 隐藏修改面板
            this.panelModify.Visible = false;

            // 禁用修改和删除按钮（提高用户体验）
            this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = false;

            // 绑定修改用的课程分类
            //this.cbbCategory_Modify.DataSource = list;  // 如果直接使用前面的集合，会造成两个下拉框联动
            this.cbbCategory_Modify.DataSource = new List<CourseCategory>(list); // 将前面的集合重新辅助后再做数据源
            this.cbbCategory_Modify.DisplayMember = "CategoryName";
            this.cbbCategory_Modify.ValueMember = "CategoryId";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // 【1】条件验证
            #region 简单方法 
            //if ((this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0) && this.txtCourseName.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("请至少选择一个查询条件！", "查询提示");
            //    return;
            //}
            //// 【2】提交查询
            //int categoryId = 0;
            //if (this.cbbCategory.SelectedIndex == -1 || this.cbbCategory.SelectedIndex == 0)
            //{
            //    categoryId = -1;
            //}
            //else
            //{
            //    categoryId = Convert.ToInt32(this.cbbCategory.SelectedValue);
            //}
            #endregion
            if((this.cbbCategory.SelectedIndex==-1 || this.cbbCategory.SelectedIndex==0)&& this.txtCourseName.Text.Trim().Length ==0)
            {
                MessageBox.Show("请至少选择一个查询条件！", "查询提示");
                return;
            }

            #region 三元运算符
            int categoryId = this.cbbCategory.SelectedIndex == -1 ? -1 : Convert.ToInt32(this.cbbCategory.SelectedValue);
            #endregion

            // 【2】提交查询
            queryList  =  courseManager.QueryCourse(categoryId, this.txtCourseName.Text.Trim());

            // 【3】展示查询
            if (queryList.Count == 0) // 如果没有找到结果，清空上一次查询的数据
            {
                this.lblCount.Text = "0";
                this.dgvCourseList.DataSource = null;
                MessageBox.Show("没有找到查询结果！", "查询提示");
                this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = false;
            }
            else // 重新绑定查询结果
            {
            this.dgvCourseList.DataSource = queryList;
            this.lblCount.Text=this.dgvCourseList.RowCount.ToString();
            this.btnModifyCourse.Enabled = this.btnDelCourse.Enabled = true;
            }
            this.panelModify.Visible = false; // 每次查询都要隐藏修改面板，提高用户体验  

        }

        private void btnModifyCourse_Click(object sender, EventArgs e)
        {
            if(this.dgvCourseList.CurrentRow == null)
            {
                MessageBox.Show("请首先选择一行!", "修改提示");
                return;
            }
            // 【1】 获取当前选中行的对应的课程ID
            int courseId = (int)this.dgvCourseList.CurrentRow.Cells["CourseId"].Value;

            // 【2】 根据课程ID从集合中查询课程对象
            Course currentCourse = null;

            // 以下适合初学者理解，实际开发中，有更高校的方法
            //    foreach (var item in this.queryList)
            //    {
            //        if (item.CourseID == courseId)
            //        {
            //            currentCourse = item;
            //            break;
            //        }
            //    }
            

            currentCourse = (from c in this.queryList where c.CourseID.Equals(courseId) select c).First();
            //currentCourse = this.queryList.Where(c => c.CourseID.Equals(courseId)).First();

            // 【3】显示要修改的课程对象
            this.txtCoureName_Modify.Text = currentCourse.CourseName;
            this.txtCredit.Text = currentCourse.Credit.ToString();
            this.txtClassHour.Text = currentCourse.ClassHour.ToString();
            this.txtCourseContent.Text = currentCourse.CourseContent;
            this.lblCourseId.Text = currentCourse.CourseID.ToString(); // 为提交修改使用
            this.panelModify.Visible = true;

            // 将当前课程分类和下拉框选择同步
            this.cbbCategory_Modify.SelectedValue = currentCourse.CategoryId;
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            // 【1】 数据验证：对要修改的信息检查

            // 【2】封装对象
            Course course = new Course
            {
                CourseName = this.txtCoureName_Modify.Text.Trim(),
                CourseContent = this.txtCourseContent.Text.Trim(),
                ClassHour = Convert.ToInt32(this.txtClassHour.Text.Trim()),
                Credit = Convert.ToInt32(this.txtCredit.Text.Trim()),
                CategoryId = Convert.ToInt32(this.cbbCategory_Modify.SelectedValue),
                TeacherId = Program.currentTeacher.TeacherId, // 默认用登录用户
                CategoryName = this.cbbCategory_Modify.Text,
                CourseID = Convert.ToInt32(this.lblCourseId.Text)
            };

            // 【3】 调用后台
            courseManager.ModifyCourse(course);
            this.panelModify.Visible = false;

            // 【4】同步显示修改后的信息（改进用户体验）（依然是从缓存中修改对象...）
            Course currentCourse = (from c in this.queryList where c.CourseID.Equals(course.CourseID) select c).First();
            currentCourse.CourseName = course.CourseName; 
            currentCourse.CategoryName= course.CategoryName;
            currentCourse.CategoryId= course.CategoryId;
            currentCourse.CourseContent= course.CourseContent;
            currentCourse.Credit = course.Credit;
            currentCourse.ClassHour= course.ClassHour;

            this.dgvCourseList.Refresh();   // 同步刷新dgv 显示

        }

        // 取消修改
        private void btnCloseModify_Click(object sender, EventArgs e)
        {
            this.panelModify.Visible = false;

        }

        // 删除课程
        private void btnDelCourse_Click(object sender, EventArgs e)
        {
            if (this.dgvCourseList.CurrentRow == null){
                MessageBox.Show("请先选择一行!", "删除提示");
                return;
            }
            // 【1】 获取当前选择行对应的ID
            int courseId = (int)this.dgvCourseList.CurrentRow.Cells["CourseId"].Value;

            // 【2】 删除前确认
            DialogResult result = MessageBox.Show($"您确认要删除编号为：{courseId}的课程吗？", "删除确认", MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;

            // 【3】后台执行删除
            int deleteCourse = courseManager.DeleteCourse(new Course { CourseID = courseId });

            // 【4】从集合中删除
            // 初学者可以使用前面遍历的方法

            // 使用Linq查询
            this.queryList.Remove(this.queryList.Where(c=>c.CourseID == courseId).First());

            // 同步刷新显示
            this.dgvCourseList.DataSource = null;
            this.dgvCourseList.DataSource = this.queryList;
            this.lblCount.Text = this.queryList.Count.ToString();

        }
    }
}
