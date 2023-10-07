using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CourseManageModels;

namespace CourseManageDAL
{
    public class CourseService
    {
        #region 添加课程
        public int AddCourse(Course course)
        {
            //    #region

            //    // 定义sql语句,并解析实体数据
            //    string sql = "insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            //    sql += $"values('{course.CourseName}','{course.CourseContent}',{course.ClassHour},{course.Credit},{course.CategoryId},{course.TeacherId}";
            //    // 执行SQL语句
            //    return SQLHelper.Update(sql);
            //}
            //// 以上方法，存在一个问题：单引号使用起来非常麻烦，同时还有可能注入式攻击的危险
            //// 微软针对以上方式，有两个解决方案：第一，使用带参数的SQL语句，第二使用存储过程
            //#endregion

            string sql = "insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            sql += " values(@CourseName, @CourseContent, @ClassHour, @Credit, @CategoryId, @TeacherId)";

            // 封装sql语句中的参数
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@CourseContent",course.CourseContent),
                new SqlParameter("@ClassHour",course.ClassHour),
                new SqlParameter("@Credit",course.Credit),
                new SqlParameter("@CategoryId",course.CategoryId),
                new SqlParameter("@TeacherId",course.TeacherId),
            };


            // 执行带参数的SQL语句
            return SQLHelper.Update(sql, param);
        }
        #endregion

        #region 查询课程
        /// <summary>
        /// 根据多个查询条件动态组合查询
        /// </summary>
        /// <param name="categoryId">课程分类编号</param>
        /// <param name="courseName">课程名称</param>
        /// <returns></returns>
        public List<Course> QueryCourse(int categoryId, string courseName)
        {
            //【1】定义基本的sql语句
            string sql = "select CourseId, CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherName, Course.TeacherId from Course";
            sql += " inner join Teacher on Teacher.TeacherId=Course.TeacherId where";

            // 【2】 定义组合条件
            string whereSql = string.Empty;
            if(categoryId != -1)
            {
                whereSql += " and CategoryId=" + categoryId;
            }
            if(courseName != "")    // 这个地方没有必要检查null，因为我们通过文本框架文本传递的数据永远不可能为null
            {
                whereSql += $" and CourseName like '{courseName}%'";
            }
            // 实际开发中，如果还有其他条件，请在这里继续添加if判断即可...


            // 将动态的查询条件和前面基本查询语句结合
            sql += whereSql.Substring(4);


            // 【3】 执行查询
            SqlDataReader reader = SQLHelper.GetReader(sql);

            // 【4】 封装结果
            List<Course> list = new List<Course>();
            while (reader.Read())
            {
                list.Add(new Course
                {
                    CourseID = (int)reader["CourseId"],
                    CourseName = reader["CourseName"].ToString(),
                    CourseContent = reader["CourseContent"].ToString(),
                    ClassHour = (int)reader["ClassHour"],
                    Credit= (int)reader["Credit"],
                    CategoryId = (int)reader["CategoryId"],
                    TeacherId = (int)reader["TeacherId"],
                    TeacherName = reader["TeacherName"].ToString()
                }) ;
            }
            reader.Close();
            return list;
    }

        #endregion

        #region 修改课程
        public int ModifyCourse(Course course)
        {
            // 定义sql语句
            string sql = $"update Course Set CourseName=@CourseName, CourseContent=@CourseContent, ClassHour=@ClassHour, Credit=@Credit, CategoryId=@CategoryId";
            sql += " where CourseId=@CourseId";

           // 封装参数
             SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CourseName",course.CourseName),
                new SqlParameter("@CourseContent",course.CourseContent),
                new SqlParameter("@ClassHour",course.ClassHour),
                new SqlParameter("@Credit",course.Credit),
                new SqlParameter("@CategoryId",course.CategoryId),
                new SqlParameter("@CourseId",course.CourseID),
            };

            //提交保存
            return SQLHelper.Update(sql, param);


        }
        #endregion

        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public int DeleteCourse(Course course)
        {
            string sql = "delete from Course where CourseId=" + course.CourseID;
            return SQLHelper.Update(sql);
        }

    }
}
