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
        private TeacherService teacherService = new TeacherService();

        public Teacher TeacherLogin(Teacher teacher)
        {
            //调用后台实现登录
            teacher = teacherService.TeacherLogin(teacher);

            //如果需要读取用户权限，在这里可以根据需要再次调用权限读取的方法...
            //PS：如果账号设置了有效性，要根据有效性决定是否读取权限等相关任务...

            return teacher;
        }
        public int ModifyPwd(Teacher teacher)
        {
            return teacherService.ModifyPwd(teacher);
        }
    }
}
