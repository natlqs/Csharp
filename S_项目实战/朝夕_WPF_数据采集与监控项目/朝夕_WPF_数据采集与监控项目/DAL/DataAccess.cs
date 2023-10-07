using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace 朝夕_WPF_数据采集与监控项目.DAL
{
    public class DataAccess
    {
        string dbConfig = ConfigurationManager.ConnectionStrings["db_config"].ToString();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlTransaction trans;


        /// <summary>
        /// 释放由当前类使用的所有资源;
        /// 使用方法：   this.Dispose();
        /// </summary>
        private void Dispose()
        {
            if (adapter != null)
            {
                adapter.Dispose(); adapter = null;
            }
            if (cmd != null)
            {
                cmd.Dispose(); cmd = null;
            }
            if (trans != null)
            {
                trans.Dispose(); trans = null;
            }
            if (conn != null)
            {
                conn.Close(); conn.Dispose(); conn = null;
            }
        }


        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable GetDatas(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(dbConfig);
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
            return dt;
        }


        public DataTable GetStorageArea()
        {
            string strSql = "select * from  storage_area";
            return this.GetDatas(strSql);
        }

        public DataTable GetDevices()
        {
            string strSql = "select * from  devices";
            return this.GetDatas(strSql);
        }

        public DataTable GetMonitorValue()
        {
            string strSql = "select * from  Monitor_Values";
            return this.GetDatas(strSql);
        }
    }
}
