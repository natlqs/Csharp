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
        //public int AddCourse(Course course)
        //{
        //    //定义sql语句,并解析实体数据
        //    string sql = " insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
        //    sql += $"values ('{course.CourseName}', '{course.CourseContent}',{course.ClassHour},{course.Credit},{course.CategoryId},{course.TeacherId})";
        //    //执行SQL语句
        //    return SQLHelper.Update(sql);
        //}
        //以上方法，存在一个问题：单引号使用起来非常麻烦，同时还有可能有注入式攻击的危险
        //微软针对以上方式，有两个解决方案：第一，使用带参数的SQL语句，第二使用存储过程


        public int AddCourse(Course course)
        {
            //定义sql语句,并解析实体数据
            string sql = " insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            sql += " values(@CourseName, @CourseContent, @ClassHour, @Credit, @CategoryId, @TeacherId)";
            //封装SQL语句中的参数
            SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@CourseName",course.CourseName),
                    new SqlParameter("@CourseContent",course.CourseContent),
                    new SqlParameter("@ClassHour",course.ClassHour),
                    new SqlParameter("@Credit",course.Credit),
                    new SqlParameter("@CategoryId",course.CategoryId),
                    new SqlParameter("@TeacherId",course.TeacherId),
                };
            //执行带参数的SQL语句
            return SQLHelper.Update(sql,param);
        }
    }
}
