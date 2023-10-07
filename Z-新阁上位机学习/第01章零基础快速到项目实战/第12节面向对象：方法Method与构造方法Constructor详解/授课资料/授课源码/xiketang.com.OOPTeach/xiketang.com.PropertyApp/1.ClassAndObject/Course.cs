using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.PropertyApp
{
    /// <summary>
    /// 课程类
    /// </summary>
    class Course
    {
        //公有的成员变量（存储数据，或对外提供数据）
        public int CourseId;

        public string CourseName;

        private int UnitPrice = 4000;

        public string Type = ".NET系列";

        public DateTime FirstDate;//首发时间

        //公有方法
        public string ShowCourseInfo()
        {
            //局部变量
            string info = $"课程名称：{CourseName} 课程编号：{CourseId}  课程价格：{UnitPrice}";
            //方法返回值
            return info;
        }
        //public void Test()
        //{
        //    CourseId = 100;
        //}
    }

    class TestClass
    {

        public void Dowork1()
        {
            //创建一个对象
            Course course = new Course();
            //给对象的字段的赋值
            course.CourseId = 10001;
            course.CourseName = ".NET全栈开发课程";

            //获取对象的数据
            Console.WriteLine(course.Type);

            //调用对象的方法
            string info = course.ShowCourseInfo();

            Console.WriteLine(info);
        }

        public void Dowork2()
        {
            //创建一个对象
            Course course = new Course();
            //给对象的字段的赋值
            course.CourseId = -10001; //不安全的数据出现！
            course.CourseName = ".NET全栈开发课程";

            //获取对象的数据
            Console.WriteLine(course.Type);

            //调用对象的方法
            string info = course.ShowCourseInfo();

            Console.WriteLine(info);
        }
    }
}

