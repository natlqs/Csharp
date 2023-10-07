using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL
{
    public class TeacherManager
    {
        private TeacherService TeacherService = new TeacherService();
        public Teacher TeacherLogin(Teacher teacher)
        {
            // 调用后台实现登录
            teacher = TeacherService.TeacherLogin(teacher);

            // 如果需要读取用户权限，在这里可以根据需要再次调用权限读取的方法...

            return teacher;
        }

        public int ModifyPwd(Teacher teacher)
        {
            return TeacherService.ModifyPwd(teacher);
        }
    }
}
