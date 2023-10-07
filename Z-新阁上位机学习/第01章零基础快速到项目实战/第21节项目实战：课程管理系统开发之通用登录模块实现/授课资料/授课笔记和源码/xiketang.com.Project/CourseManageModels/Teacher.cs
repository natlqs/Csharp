using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageModels
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string LoginAccount { get; set; }
        public string LoginPwd { get; set; }
        public string TeacherName { get; set; }
        public string PhoneNumber { get; set; }
        public string NowAddress { get; set; }
    }
}
