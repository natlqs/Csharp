using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoException
{
    class StudentService
    {
        /// <summary>
        /// 根据学号删除学员对象
        /// </summary>
        /// <param name="studentId">学号 </param>
        /// <returns></returns>
        public int DeleteStudentById(string studentId)
        {
            string sql = "delete from Students where StudentId=" + studentId;
            return SQLHelper.Update(sql);
        }
    }
}
