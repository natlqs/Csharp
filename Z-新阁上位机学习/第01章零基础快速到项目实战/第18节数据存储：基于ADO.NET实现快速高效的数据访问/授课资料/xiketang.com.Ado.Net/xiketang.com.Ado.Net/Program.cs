using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//引入需要的命名空间
using System.Data.SqlClient;
using System.Data;

using System.Data.OleDb;

namespace xiketang.com.Ado.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家参加喜科堂常老师的.NET全栈和上位机课程！");
            Console.WriteLine("常老师QQ：2934008878   客服老师QQ：995551859");
            Console.WriteLine("课程官网：xiketang.com");
            Console.WriteLine("您今天学的内容是：ADO.NET数据访问技术");
            Console.WriteLine("目的：学好数据访问技术，轻松实现C#和数据库交互，是项目开发的核心必备！");
            Console.WriteLine("------------------------------------------");

            // ConnectDB();

            // ExecuteInsert();

            //ExecuteUpdate();

            //ExecuteDelete();

            // ExecuteSingleResult();

            // ExecuteReader();

            // ExecuteInsertByHelper();

            //ExecuteSingleResultByHelper();

            ExecuteReaderByHelper();

            Console.Read();
        }

        #region 基础CRUD方法编写
     
        static void ConnectDB()
        {
            //创建数据库连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            //打开连接
            conn.Open();
            if (conn.State == ConnectionState.Open) Console.WriteLine("连接成功！");

            //关闭连接
            conn.Close();

            if (conn.State == ConnectionState.Closed) Console.WriteLine("关闭成功！");
        }

        static void ExecuteInsert()
        {
            //【1】创建连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            //定义sql语句
            string sql = " insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            sql += "values ('.Net全栈开发VIP课程', 'C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF', 500, 12, 10, 1000)";

            //【2】创建Command对象
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = sql;
            //cmd.Connection = conn;
            SqlCommand cmd = new SqlCommand(sql, conn);

            //【3】打开数据库连接
            conn.Open();

            //【4】执行操作(下面这个方法，只能用于执行insert、update、delete操作，不能执行select)
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine("受影响的行数=" + result);

            //【5】关闭连接
            conn.Close();
        }

        static void ExecuteUpdate()
        {
            //【1】创建连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            //定义sql语句
            string sql = "update Course set CourseName='.Net高级进阶VIP', CourseContent='更高级的.Net开发基础',";
            sql += "ClassHour=20, CategoryId=10, TeacherId=1001";
            sql += " where CourseId=1042";

            //【2】创建Command对象         
            SqlCommand cmd = new SqlCommand(sql, conn);

            //【3】打开数据库连接
            conn.Open();

            //【4】执行操作(下面这个方法，只能用于执行insert、update、delete操作，不能执行select)
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine("受影响的行数=" + result);

            //【5】关闭连接
            conn.Close();
        }

        static void ExecuteDelete()
        {
            //【1】创建连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            //定义sql语句
            string sql = "delete from Course where CourseId=1042";

            //【2】创建Command对象         
            SqlCommand cmd = new SqlCommand(sql, conn);

            //【3】打开数据库连接
            conn.Open();

            //【4】执行操作(下面这个方法，只能用于执行insert、update、delete操作，不能执行select)
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine("受影响的行数=" + result);

            //【5】关闭连接
            conn.Close();
        }

        //执行单一结果的查询

        static void ExecuteSingleResult()
        {
            //【1】创建连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            //定义sql语句
            string sql = "select Count(*) as 课程总数 from Course";

            //【2】创建Command对象         
            SqlCommand cmd = new SqlCommand(sql, conn);

            //【3】打开数据库连接
            conn.Open();

            //【4】执行查询(下面这个方法，一般执行的都是查询，但是有时候也可以同时执行insert、update、delete操作，我们在VIP深入系统学习的时候会讲到)
            object result = cmd.ExecuteScalar();

            Console.WriteLine("查询结果=" + result);

            //【5】关闭连接
            conn.Close();
        }

        static void ExecuteReader()
        {
            //【1】创建连接对象
            string connString = "Server=.;DataBase=CourseManageDB;Uid=sa;Pwd=a123456";
            SqlConnection conn = new SqlConnection(connString);

            //定义sql语句
            string sql = "select CourseName, CourseContent, ClassHour from Course where CourseId<1020";

            //【2】创建Command对象         
            SqlCommand cmd = new SqlCommand(sql, conn);

            //【3】打开数据库连接
            conn.Open();

            //【4】执行查询
            SqlDataReader reader = cmd.ExecuteReader();

            //判断是否有查询结果，来决定读取数据
            while (reader.Read())
            {
                Console.WriteLine($"{reader["CourseName"]}\t{reader[1]}\t{reader["ClassHour"]}");
            }
            reader.Close();//关闭读取器对象（千万不要忘记）

            //【5】关闭连接
            conn.Close();
        }

        #endregion

        #region 通过通用SQLHelper类简化CRUD操作

        static void ExecuteInsertByHelper()
        {
            //定义sql语句
            string sql = " insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            sql += "values ('.Net/C#工控上位机开发VIP课程', 'C#基础/OOP/SQL/WinForm/ASP.NET/WPF/PLC控制系统', 200, 12, 10, 1000)";

            int result = SQLHelper.Update(sql);
            Console.WriteLine(result);
        }

        static void ExecuteSingleResultByHelper()
        {
            string sql = "select Count(*) as 课程总数 from Course";
            object result = SQLHelper.GetSingleResult(sql);
            Console.WriteLine(result);
        }

        static void ExecuteReaderByHelper()
        {
            string sql = "select CourseName, CourseContent, ClassHour from Course where CourseId<1020";

            SqlDataReader reader = SQLHelper.GetReader(sql);

            //判断是否有查询结果，来决定读取数据
            while (reader.Read())
            {
                Console.WriteLine($"{reader["CourseName"]}\t{reader[1]}\t{reader["ClassHour"]}");
            }
            reader.Close();//关闭读取器对象（千万不要忘记）在这个地方执行关闭时，会首先自动把它使用的链接对象关闭！
        }

        #endregion
    }
}
