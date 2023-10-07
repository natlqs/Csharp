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
    public class CourseCategoryService
    {
        /// <summary>
        /// 查询全部课程分类对象，并封装到集合中
        /// </summary>
        /// <returns></returns>
        public List<CourseCategory> GetCourseCategories()
        {
            string sql = "select CategoryName,CategoryId from CourseCategory";
            SqlDataReader reader = SQLHelper.GetReader(sql);
            List<CourseCategory> list = new List<CourseCategory>();
            while (reader.Read())
            {
                list.Add(new CourseCategory
                {
                    CategoryId = (int)reader["CategoryId"],
                    CategoryName = reader["CategoryName"].ToString()
                });
            }
            reader.Close();
            return list;
        }
    }
}
