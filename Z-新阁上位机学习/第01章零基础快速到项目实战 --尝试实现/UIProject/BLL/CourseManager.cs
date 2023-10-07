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
    /// 1. 业务传递（隔离）
    /// 
    /// 2. 业务处理（一般大的项目才有）
    /// </summary>
    public class CourseManager
    {
        private CourseService courseServise = new CourseService();


        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            return courseServise.AddCourse(course);
        }


        /// <summary>
        /// 更改课程内容
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int UpdateCourse(Course course)
        {
            return courseServise.UpdateCourse(course);
        }


        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            return courseServise.DeleteCourse(course);
        }


        /// <summary>
        /// 查询课程总数
        /// </summary>
        /// <returns></returns>
        public object GetCourseCount()
        {
            return courseServise.GetCourseCount();
        }


        /// <summary>
        /// 根据课程编号查询，返回集合对象
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public List<Course> QueryCourseById(int courseId)
        {
            return courseServise.QueryCourseById(courseId);
        }
    }
}
