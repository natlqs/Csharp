using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.MethodApp
{
    public class Course
    {
        //在这个地方，请自己断点调试，观察执行顺序
        private int courseId = 0;
        private string courseName = string.Empty;

        /// <summary>
        /// 无参数构造方法
        /// </summary>
        public Course()
        {
            CourseId = 10001;
            CourseName = ".NET全栈开发、上位机开发";
            Type = ".NET系列";
            //在这里还可以编写读取相关文件或者从其他数据源读取的方法或逻辑...

        }
        public Course(int courseId, string courseName)
        {
            this.CourseId = courseId;
            this.CourseName = courseName;
            //   this.CourseName = this.courseName;  //也就是说成员变量和局部变量同名的时候，一般是就近原则取变量
            //如果我们需要舍近求远，则必须添加this
        }
        public Course(int courseId, string courseName, string type)
            : this(courseId, courseName)
        {
            //this.CourseId = courseId;
            //this.CourseName = courseName;
            this.Type = type;
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Type { get; set; }

        public string ShowCourseInfo()
        {
            return $"课程名称：{CourseName} 课程编号：{CourseId}  课程系列：{Type}";
        }

        //析构函数
        ~Course()
        {
            Console.WriteLine("对象被释放，析构函数被调用...");
        }
    }

    class TestClass1
    {
        public void Dowork1()
        {
            Course course1 = new Course();
            Console.WriteLine("【无参数构造方法】" + course1.ShowCourseInfo());

            Course course2 = new Course(10002, "C#面向对象编程");
            Console.WriteLine("【2个参数构造方法】" + course2.ShowCourseInfo());

            Course course3 = new Course(10003, "C#面向对象", ".NET开发系列");
            Console.WriteLine("【3个参数构造方法】" + course3.ShowCourseInfo());

            string info = $"课程名称：{course3.CourseName} 课程编号：{course3.CourseId}  课程系列：{course1.Type}";
            Console.WriteLine(info);

            Course course4 = new Course();
            course4.CourseId = 100005;
            course4.CourseName = "新课程";
        }

        public void Dowork2()
        {
            Course course1 = new Course()
            {
                CourseId = 2000,
                CourseName = "C#上位机课程"
            };

            //Course course2 = new Course(10002, "C#面向对象编程")
            //{
            //    Type = ""
            //};

            course1 = null; //显式的清除对象的引用，也就是course1只是一个变量名，没有具体对象指向

           GC.Collect();  //这个其实是由虚拟机帮我们完成，我们没必要多管闲事！
        }
    }
}
