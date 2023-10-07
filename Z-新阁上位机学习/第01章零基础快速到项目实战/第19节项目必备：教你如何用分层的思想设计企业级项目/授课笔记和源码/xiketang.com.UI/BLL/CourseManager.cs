using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
namespace BLL
{

    /// <summary>
    /// 业务逻辑类两个职责
    /// 
    /// 1.业务传递（隔离）
    /// 
    /// 2.业务处理（一般大的项目才有，我们在预科中）
    /// </summary>
    public class CourseManager
    {
        private CourseService courseService = new CourseService();
             
        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }

        public int UpdateCourse(Course course)
        {
            return courseService.UpdateCourse(course);
        }
     
        public int DeleteCourse(Course course)
        {
            return courseService.DeleteCourse(course);
        }
        /// <summary>
        /// 查询课程总数
        /// </summary>
        /// <returns></returns>
        public object GetCourseCount()
        {
            return courseService.GetCourseCount();
        }
        /// <summary>
        /// 根据课程编号查询，返回集合对象
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public List<Course> QueryCourseById(int courseId)
        {
            return courseService.QueryCourseById(courseId);
        }
    }
}
