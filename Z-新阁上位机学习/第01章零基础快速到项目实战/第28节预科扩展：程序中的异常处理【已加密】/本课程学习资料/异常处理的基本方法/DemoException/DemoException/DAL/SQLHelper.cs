using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DemoException
{
    class SQLHelper
    {
        static string connString =
            "Server=.;DataBase=StudentManageDB;Uid=sa;Pwd=password01!";
        /// <summary>
        /// 执行增、删、改操作
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
                int result = cmd.ExecuteNonQuery();           
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
      
         
        }
    }
}
