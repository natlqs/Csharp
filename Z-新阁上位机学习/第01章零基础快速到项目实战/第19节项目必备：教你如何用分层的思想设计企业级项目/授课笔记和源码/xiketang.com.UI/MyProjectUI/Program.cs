using Models;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectUI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Course> courseList = new CourseManager().QueryCourseById(1020);

            foreach (var item in courseList)
            {
                Console.WriteLine(item.CourseId + "\t" + item.CourseName + "\t" + item.Credit);
            }

            Console.Read();
        }
    }
}
