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
        //public static int Update(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    conn.Open();
        //    int result = cmd.ExecuteNonQuery();
        //    conn.Close();
        //    return result;
        //}
        //public static int Update(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    try //【1】可能发生异常的代码块
        //    {
        //        conn.Open();
        //        int result = cmd.ExecuteNonQuery();
        //        conn.Close();
        //        return result;
        //    }
        //    catch (Exception ex) //【2】异常处理代码块
        //    {
        //        Console.WriteLine(ex.Message); //输出异常信息
        //        return -1; //-1表示出现异常
        //    }
        //}
        //public static int Update(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    try   //【1】可能发生异常的代码
        //    {
        //        conn.Open();
        //        return cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)  //【2】异常处理代码
        //    {
        //        Console.WriteLine(ex.Message);
        //        return -1;
        //    }
        //    finally //【3】异常是否发生都会执行的代码
        //    {
        //        conn.Close();
        //    }
        //}    

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
                //将异常信息保存在日志中（略）...

                throw ex; 
            }
            finally
            {
                conn.Close();
            }
        }      
    }
}
