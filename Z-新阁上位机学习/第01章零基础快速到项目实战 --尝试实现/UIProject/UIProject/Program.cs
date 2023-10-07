using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using BLL;

namespace UIProject
{
     public class Program
    {
        static void Main(string[] args)
        {
            List<Course> courseList = new CourseManager().QueryCourseById(1058);

            foreach(var item in courseList)
            {
                Console.WriteLine(item.CourseId + "\t" + item.CourseName + "\t" + item.Credit);
            }
            Console.Read();
        }
    }
}
