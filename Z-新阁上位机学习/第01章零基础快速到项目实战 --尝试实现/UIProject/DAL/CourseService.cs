using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

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
            string sqlScript = $"insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)values('{course.CourseName}','{course.CourseContent}',{course.ClassHour},{course.Credit},{course.CategoryId},{course.TeacherId})";
            return SQLHelper.ExcuteUpdate(sqlScript);
        }

        /// <summary>
        /// 添加课程（通过添加参数）
        /// </summary>
        /// <param name="courseName"></param>
        /// <param name="courseContent"></param>
        /// <param name="classHour"></param>
        /// <param name="credit"></param>
        /// <param name="categoryId"></param>
        /// <param name="teacherId"></param>
        /// <returns></returns>

        public int AddCourse(string courseName, string courseContent, int classHour, int credit, int categoryId, int teacherId)
        {
            //定义sql语句
            string sqlScript = $"insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)values('{courseName}','{courseContent}',{classHour},{credit},{categoryId},{teacherId})";
            return SQLHelper.ExcuteUpdate(sqlScript);
        }


        /// <summary>
        /// 更新课程信息
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int UpdateCourse(Course course)
        {
            // 定义sql语句，并解析实体数据
            string sql = $"update Course set CourseName='{course.CourseName}'";//, CourseContent, ClassHour, Credit, CategoryId, TeacherId";
            sql += $" where CourseId={course.CourseId}";
            return SQLHelper.ExcuteUpdate(sql);
        }


        /// <summary>
        /// 删除课程信息，删除的时候，我建议大家使用对象，因为后面我们深入学习的会讲ORM，ORM框架里面全部都是对象
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sqlScript = $"delete from Course where CourseId=" + course.CourseId;
            return SQLHelper.ExcuteUpdate(sqlScript);
        }


        /// <summary>
        /// 查询课程总数
        /// </summary>
        /// <returns></returns>
        public object GetCourseCount()
        {
            string sql = "select Count(*) as 课程总数 from Course";
            return SQLHelper.ExcuteSingleResult(sql);
        }


        /// <summary>
        /// 根据课程编号查询，返回集合对象
        /// </summary>
        /// <returns></returns>
        public List<Course> QueryCourseById(int courseId)
        {
            string sql = $"select CourseId, CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId from Course where CourseId < {courseId}";
            SqlDataReader reader = SQLHelper.ExcuteReader(sql);
            List<Course> list = new List<Course>();
            while (reader.Read())
            {
                #region
                list.Add(new Course         // 下面要读取的属性名，必须在上面的sql语句中，出现，否则就会出现找不到的情况
                {
                    CourseName = reader["CourseName"].ToString(),
                    CourseContent = reader["CourseContent"].ToString(),
                    ClassHour = Convert.ToInt32(reader["ClassHour"]),
                    Credit = (int)reader["Credit"],
                    CategoryId = (int)reader["CategoryId"],
                    TeacherId = (int)reader["TeacherId"],
                    CourseId = (int)reader["CourseId"]
                });
                #endregion
            }
            reader.Close();
            return list;
        }

    }
}
