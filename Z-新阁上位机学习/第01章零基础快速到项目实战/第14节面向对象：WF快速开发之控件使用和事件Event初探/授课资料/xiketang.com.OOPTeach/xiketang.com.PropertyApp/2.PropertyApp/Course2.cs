using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.PropertyApp
{
    #region 属性特性1-扩展安全机制

    class Course2
    {
        private int courseId = 0;
        public int CourseId
        {
            get { return courseId; }
            set
            {
                if (value < 0)
                    courseId = 1000;
                else
                    courseId = value;
            }
        }
        public string CourseName { get; set; }

        //公有方法
        public string ShowCourseInfo()
        {
            //局部变量
            string info = $"课程名称：{CourseName} 课程编号：{CourseId} ";
            //方法返回值
            return info;
        }
    }

    #endregion

    #region 属性特性2-控制读写操作

    class Course3
    {
        private int courseId = 0;
        public int CourseId
        {
            get { return courseId; }
           // get { return CourseId; }  //属性常见错误：没注意大小写，导致死循环！
            set
            {
                if (value < 0)
                    courseId = 1000;
                else
                    courseId = value;
            }
        }
        //只读属性1，直接去掉set方法，可以在定义的时候初始化
        public string CourseName { get; } = ".NET全栈开发课程";

        //只读属性2，直接去掉set方法，并在get中添加业务逻辑
        public string CourseInfo
        {
            get { return $"课程名称：{CourseName} 课程编号：{CourseId} "; }
        }

        /// <summary>
        /// 这个是方法！不是属性！
        /// </summary>
        /// <returns></returns>
        public string ShowCourseInfo()
        {        
            return $"课程名称：{CourseName} 课程编号：{CourseId} ";          
        }
    }

    #endregion

    class TestClass2
    {
        public void Dowork1()
        {
            Course2 course = new Course2();
            course.CourseId = -10001;
            course.CourseName = ".NET全栈开发课程+上位机开发课程";
            string info = course.ShowCourseInfo();
            Console.WriteLine(info);
        }

        public void Dowork2()
        {
            Course3 course = new Course3();
            course.CourseId = 10001;         
         
            Console.WriteLine(course.CourseInfo);
        }
    }
}
