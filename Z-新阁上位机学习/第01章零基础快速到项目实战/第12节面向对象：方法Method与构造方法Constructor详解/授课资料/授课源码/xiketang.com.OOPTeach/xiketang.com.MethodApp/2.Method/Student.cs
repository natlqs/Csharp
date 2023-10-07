using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.MethodApp
{
    public class Student
    {
        #region 构造方法

        /// <summary>
        ///默认的构造方法：如果不写，会自动生成
        /// </summary>
        public Student()
        { }
        public Student(int studentId, string studentName)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
        }
        public Student(int studentId, string studentName, DateTime dateOfBirth)
            : this(studentId, studentName)
        {
            this.DateOfBirth = dateOfBirth;
        }

        #endregion

        #region 属性

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
        }
        //还可以使用属性表达式（更简洁，先了解）
        public int StudentAge => DateTime.Now.Year - DateOfBirth.Year;

        #endregion

        #region 实例方法的5种形式

        /// <summary>
        /// 【1】没有返回值，没有参数的方法
        /// </summary>
        public void GetVoidStudent()
        {
            string info = $"姓名：{StudentName}  学号：{StudentId}";
            Console.WriteLine("这个是第1个方法：没有返回值，没有参数\r\n-----------------------------------------");
        }
        /// <summary>
        /// 【2】没有返回值，有参数
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="studentId"></param>
        public void GetVoidStudent(string studentName, int studentId)
        {
            string info = $"姓名：{studentName}  学号：{studentId}";
            Console.WriteLine(info);
            Console.WriteLine("这个是第2个方法：没有返回值，有参数\r\n-----------------------------------------");
        }
        /// <summary>
        /// 【3】有返回值、没有参数
        /// </summary>
        /// <returns></returns>
        public string GetStringStudent()
        {
            string info = $"姓名：{StudentName}  学号：{StudentId}";
            Console.WriteLine("这个是第3个方法：有返回值，没有参数\r\n-----------------------------------------");
            return info;
        }
        /// <summary>
        /// 【4】有返回值，有参数
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public string GetStringStudent(string studentName, int studentId)
        {
            string info = $"姓名：{studentName}  学号：{studentId}";
            Console.WriteLine("这个是第4个方法：有返回值，有参数\r\n-----------------------------------------");

            //如果去掉最后一个else，会出现返回值错误问题！请学员思考！
            if (studentId == 10001)
                return info;
            else if (studentId == 10002)
                return info + ":10002";
            else
                return info + ":10000";
        }
        /// <summary>
        /// 【5】参数带默认值的方法
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="studentName"></param>
        /// <returns></returns>
        public string GetStudent(int studentId, string studentName = "匿名学员")
        {
            string info = $"姓名：{studentName}  学号：{studentId}";
            Console.WriteLine("这个是第5个方法：参数带默认值的方法\r\n-----------------------------------------");
            return info;
        }

        #endregion

        /// <summary>
        /// 静态方法：（调用的时候是通过类名.方法名称调用的）
        /// </summary>
        /// <returns></returns>
        public static string[] GetCourseList()
        {
            //我们可以从数据库中获取
            string[] courseArray = { ".Net全栈开发VIP课程", ".Net/C#工控上位机VIP课程", ".NET高级进阶VIP课程", "微信小程序VIP课程" };
            string[] courseInfo = new string[courseArray.Length];
            for (int i = 0; i < courseArray.Length; i++)
            {
                courseInfo[i] = $"第{i + 1}门课程名称：{courseArray[i]}";
            }
            return courseInfo;
        }
    }
    class TestClass2
    {
        public void Dowork1()
        {
            Student student = new Student()
            {
                DateOfBirth = Convert.ToDateTime("1996-09-10"),
                StudentId = 1003,
                StudentName = "全栈VIP课程学员小李"
            };

            //【1】调用没有返回值、没有参数的方法
            student.GetVoidStudent();

            //【2】调用没有返回值的、有参数的方法 
            student.GetVoidStudent("新学员小赵", 20001);

            //【3】调用有返回值、没有参数的方法           
            string result = student.GetStringStudent();
            Console.WriteLine(result);

            //【4.1】调用有返回值、有参数的方法   
            result = student.GetStringStudent("老学员小张", 20002);
            Console.WriteLine(result);

            //【4.2】使用《命名参数》(调用的时候使用)
            // result = student.GetStringStudent(20002, "老学员小张");//这个方法调用参数是错误的
            result = student.GetStringStudent(studentId: 20002, studentName: "上位机学员李四");
            //希望我们初学者一开始就掌握！因为我们在阅读别人代码的时候会遇到

            //【5.1】有返回值、有参数（参数使用默认值）
            Console.WriteLine("这个是带默认值参数的方法");
            result = student.GetStudent(20003);
            Console.WriteLine(result);

            //【5.2】默认值也可以有参数 
            result = student.GetStudent(2004, "我的新学员小浩");
            Console.WriteLine(result);

          
        }

        public void Dowork2()
        {
            //静态方法的调用
            Console.WriteLine("展示一下我报名的课程：");
            string[] course = Student.GetCourseList();
            foreach (var item in course)
            {
                Console.WriteLine(item);
            }
        }
    }

}
