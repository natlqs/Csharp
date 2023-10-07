using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DemoException
{
    class StudentService
    {
        /// <summary>
        /// 根据学号删除学员对象
        /// </summary>
        /// <param name="studentId">学号</param>
        /// <returns></returns>
        //public int DeleteStudentById(string studentId)
        //{
        //    string sql = "delete from Students where StudentId=" + studentId;
        //    return SQLHelper.Update(sql);
        //}

        public int DeleteStudentById(string studentId)
        {
            string sql = "delete from Students where StudentId=" + studentId;
            try //【1】可能发生异常的代码
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    throw new Exception("该学员被其他数据表使用，不能直接删除！");
                else
                    throw new Exception("数据库操作出现问题，不能执行删除！具体信息：" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("数据库操作出现问题，不能执行删除！具体信息：" + ex.Message);
            }
        }
    }
}
