using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xiketang.com.GenericList;

namespace xiketang.com.ListDataShow
{
    public partial class FrmDgvList : Form
    {

        private List<Course> courseList = null;
        public FrmDgvList()
        {
            InitializeComponent();

            InitList();
        }

        public void InitList()
        {
            Course course1 = new Course();
            course1.CourseId = 10001;
            course1.CourseName = "C#面向对象中集合的应用";
            course1.ClassHour = 2;
            course1.Teacher = "常老师";
            //通过对象初始化器
            Course course2 = new Course { CourseId = 10002, CourseName = "SQLServer数据库开发", ClassHour = 5, Teacher = "常老师" };
            //通过有参数的构造方法创建对象
            Course course3 = new Course(10003, ".Net/C#全栈VIP课程", 200, "常老师");
            Course course4 = new Course(10004, ".Net/C#上位机VIP课程", 500, "常老师");
            Course course5 = new Course(10005, ".Net/C#高级进阶VIP课程", 300, "常老师");

            courseList = new List<Course>() { course1, course2, course3, course4, course5 };
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            this.dgvCourseList.DataSource = courseList;
            this.dgvCourseList.AutoResizeColumns();
        }
        //编号降序
        private void btnCourseIdDESC_Click(object sender, EventArgs e)
        {
            courseList.Sort(new CourseIdDESC());
            this.dgvCourseList.Refresh();
        }
        //课时升序
        private void btnClassHourASC_Click(object sender, EventArgs e)
        {
            courseList.Sort(new CourseClassASC());
            this.dgvCourseList.Refresh();
        }
    }
}
