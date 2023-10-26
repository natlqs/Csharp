using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManageBLL;
using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL
{
    public class CourseManager
    {
        private CourseService courseService = new CourseService();

        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }
        public List<Course> QueryCourse(int categoryId, string courseName)
        {
            return courseService.QueryCourse(categoryId, courseName);
        }

        public int ModifyCourse(Course course)
        {
            return courseService.ModifyCourse(course);
        }

        public int DeleteCourse(Course course)
        {
            return courseService.DeleteCourse(course);
        }
    }
}
