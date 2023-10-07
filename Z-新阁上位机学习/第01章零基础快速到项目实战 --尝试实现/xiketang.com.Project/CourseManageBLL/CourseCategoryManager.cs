using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL
{
    public class CourseCategoryManager
    {
        private CourseCategoryService categoryService = new CourseCategoryService();
        public List<CourseCategory> GetCourseCategories()
        {
            return categoryService.GetCourseCategories();
        }
    }
}
