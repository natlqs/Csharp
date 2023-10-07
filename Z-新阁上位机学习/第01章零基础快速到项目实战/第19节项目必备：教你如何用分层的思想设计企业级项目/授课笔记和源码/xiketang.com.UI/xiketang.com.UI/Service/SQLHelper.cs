using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Configuration;

namespace xiketang.com.UI
{
    /// <summary>
    /// 通用数据访问类
    /// 
    /// 封装变化的，抽取不变的。变化的作为参数，不变的作为方法体！
    /// </summary>
    public class SQLHelper
    {
        // private static string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";

        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        ///// <summary>
        ///// 执行增删改操作的方法
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public static int Update(string sql)
        //{
        //    //【1】创建连接对象          
        //    SqlConnection conn = new SqlConnection(connString);
        //    //【2】创建Command对象         
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    //【3】打开数据库连接
        //    conn.Open();
        //    //【4】执行操作(下面这个方法，只能用于执行insert、update、delete操作，不能执行select)
        //    int result = cmd.ExecuteNonQuery();
        //    //【5】关闭连接
        //    conn.Close();
        //    return result;
        //}

        /// <summary>
        /// 执行增删改操作的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //可以在这个地方捕获ex对象相关信息，然后保存到日志文件中...

                throw new Exception("执行方法public static int Update(string sql)发生异常：" + ex.Message);
            }
            finally  //不管前面是否发生异常都要执行的代码
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行单一结果返回的查询方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //可以在这个地方捕获ex对象相关信息，然后保存到日志文件中...

                throw new Exception("执行方法 public static object GetSingleResult(string sql)发生异常：" + ex.Message);
            }
            finally  //不管前面是否发生异常都要执行的代码
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行返回结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                //我们添加枚举CommandBehavior.CloseConnection之后，将来reader对象的链接会跟随reader对象的关闭自动关闭
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //可以在这个地方捕获ex对象相关信息，然后保存到日志文件中...

                throw new Exception("执行方法 public static object GetSingleResult(string sql)发生异常：" + ex.Message);
            }
            //finally  //在这个方法里面，绝对不能直接把链接关掉，否则出错
            //{
            //    conn.Close();
            //}
        }
    }
}
