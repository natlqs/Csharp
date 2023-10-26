using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseService
    {
        /// <summary>
        /// 添加课程（通过实体类作为参数）
        /// </summary>
        /// <param name="course">课程对象</param>
        /// <returns></returns>
        public int AddCourse(Course course)
        {
            //定义sql语句,并解析实体数据
            string sql = " insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            sql += $"values ('{course.CourseName}', '{course.CourseContent}',{course.ClassHour},{course.Credit},{course.CategoryId},{course.TeacherId})";
            //执行SQL语句
            return SQLHelper.Update(sql);
        }

        public int UpdateCourse(Course course)
        {
            //定义sql语句,并解析实体数据(下面完整的SQL语句，请学员自己完成，并调用测试)
            string sql = $" Update Course set  CourseName='{course.CourseName}', CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            sql += $" where CourseId={course.CourseId}";
            return SQLHelper.Update(sql);
        }
        /// <summary>
        /// 删除的时候，我建议大家使用对象，因为后面我们深入学习的会讲ORM，ORM框架里面全部都是对象
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sql = "delete from Course where CourseId=" + course.CourseId;
            return SQLHelper.Update(sql);
        }
        /// <summary>
        /// 查询课程总数
        /// </summary>
        /// <returns></returns>
        public object GetCourseCount()
        {
            string sql = "select Count(*) as 课程总数 from Course";
            return SQLHelper.GetSingleResult(sql);
        }
        /// <summary>
        /// 根据课程编号查询，返回集合对象
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public List<Course> QueryCourseById(int courseId)
        {
            string sql = $"select CourseId,CourseName, CourseContent, ClassHour,Credit,CategoryId,TeacherId from Course where CourseId<{courseId}";

            SqlDataReader reader = SQLHelper.GetReader(sql);

            List<Course> list = new List<Course>();

            while (reader.Read())
            {              
                list.Add(new Course   //下面我们要读取的属性名，必须在上面的sql语句中，出现，否则就会出现找不到的情况
                {
                    CourseName = reader["CourseName"].ToString(),
                    CourseContent = reader["CourseContent"].ToString(),
                    ClassHour = Convert.ToInt32(reader["ClassHour"]),
                    Credit = (int)reader["Credit"],
                    CategoryId = (int)reader["CategoryId"],
                    TeacherId = (int)reader["TeacherId"],
                    CourseId = (int)reader["CourseId"]
                });
            }
            reader.Close();
            return list;
        }
    }
}
