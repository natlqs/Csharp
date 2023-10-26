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
    /// <summary>
    /// 讲师数据访问类
    /// </summary>
    public class TeacherService
    {
        // 不懂程序的人，不懂oop的人采用的方式
        //public void TeacherLogin(string loginAccount, string pwd)
        //{
        //}
        /// <summary>
        /// 讲师登录
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public Teacher TeacherLogin(Teacher teacher)
        {
            //[1] 封装sql语句
            string sql = $"select TeacherName, TeacherId from Teacher where LoginAccount='{teacher.LoginAccount}'and LoginPwd='{teacher.LoginPwd}'"; 

            //[2] 提交查询
            SqlDataReader reader = SQLHelper.GetReader(sql);

            //[3] 判断是否正确，如果正确就封装ID和Name
            if (reader.Read())
            {
                teacher.TeacherId = (int)reader["TeacherId"];
                teacher.TeacherName = reader["TeacherName"].ToString();
            }
            else
            {
                teacher=null;// 表示当前账号或密码不正确
            }
            reader.Close();
            return teacher;
        }


        /// <summary>
        /// 修改登录密码
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public int ModifyPwd(Teacher teacher)
        {
            string sql = "update Teacher set LoginPwd=@LoginPwd where TeacherId = @TeacherId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginPwd", teacher.LoginPwd),
                new SqlParameter("@TeacherId", teacher.TeacherId)
            };
            return SQLHelper.Update(sql, param);
        }
    }
}
