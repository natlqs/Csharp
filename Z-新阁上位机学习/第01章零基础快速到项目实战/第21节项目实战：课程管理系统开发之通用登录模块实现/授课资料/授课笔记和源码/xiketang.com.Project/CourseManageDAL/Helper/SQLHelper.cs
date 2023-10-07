using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CourseManageDAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        /// <summary>
        /// 执行insert、update、delete类型的SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>受影响的行数</returns>
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


                throw new Exception("执行 public static int Update(string sql)发生异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行单一结果查询
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


                throw new Exception("执行 public static object GetSingleResult(string sql)发生异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行一个结果集的查询
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
                return cmd.ExecuteReader(CommandBehavior.CloseConnection );
            }
            catch (Exception ex)
            {
                //可以在这个地方捕获ex对象相关信息，然后保存到日志文件中...


                throw new Exception("执行 public static SqlDataReader GetReader(string sql)发生异常：" + ex.Message);
            }          
        }
        //后面深入学习的时候，还有更多更强大的方法...

    }
}
