using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.PropertyApp
{
    class Course1
    {
        //C#2.0时代的标准属性
        private int courseId = 0;
        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        //C#3.0时代，对标准属性的简化（以后，标准属性，都可以这样用）
        public string CourseName { get; set; }

        //C#6.0时代，增加的属性表达式（一般不这么用，还是使用上面的简写）
        private int unitPrice = 4000;
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }

        //C#4.0时代，我们可以这样直接赋值（以后我们开发的版本，最低都是4.0的）
        private string Type { get; set; } = ".NET系列";

        private DateTime FirstDate { get; set; }  //首发时间

        //公有方法
        public string ShowCourseInfo()
        {
            //局部变量
            string info = $"课程名称：{CourseName} 课程编号：{CourseId}  课程价格：{UnitPrice}";
            //方法返回值
            return info;
        }
    }
    class TestClass1
    {
        public void Dowork1()
        {
            Course1 course = new Course1();
            course.CourseId = 10001;
            course.CourseName = ".NET全栈开发课程";

            string info = course.ShowCourseInfo();
            Console.WriteLine(info);
        }
    }

}
