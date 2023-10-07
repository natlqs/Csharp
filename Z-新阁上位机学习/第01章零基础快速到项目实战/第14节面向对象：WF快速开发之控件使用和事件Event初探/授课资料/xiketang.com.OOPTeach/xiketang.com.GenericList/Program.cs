using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.GenericList
{
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

            //test.QueryElements(courseList);


            test.ListOrder();

            Console.Read();
        }
    }
}
