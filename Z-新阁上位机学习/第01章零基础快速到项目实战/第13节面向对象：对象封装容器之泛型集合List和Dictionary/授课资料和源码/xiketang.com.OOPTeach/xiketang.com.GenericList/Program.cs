using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.GenericList
{
    /// <summary>
    /// 欢迎参加喜科堂互联教育.Net全栈开发和上位机课程
    /// 课程网址：xiketang.ke.qq.com
    /// 常老师QQ：2934008878          课程助教QQ：995551859（更多资料获取）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来听喜科堂常老师的课程！");
            Console.WriteLine("课程官网：xiketang.com");
            Console.WriteLine("常老师QQ：2934008878");
            Console.WriteLine("客服老师QQ：995551859");
            Console.WriteLine("*****************************************");

            TestGenericList test = new TestGenericList();
            List<Course> courseList = test.CreateCourses();

            //test.TraversalList1(courseList);
            //test.TraversalList2(courseList);

            //test.QueryElements(courseList);15822002757


            test.ListOrder();

            Console.Read();
        }
    }
}
