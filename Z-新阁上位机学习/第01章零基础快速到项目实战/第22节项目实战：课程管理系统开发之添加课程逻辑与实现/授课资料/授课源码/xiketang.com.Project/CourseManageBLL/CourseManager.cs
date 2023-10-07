using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
