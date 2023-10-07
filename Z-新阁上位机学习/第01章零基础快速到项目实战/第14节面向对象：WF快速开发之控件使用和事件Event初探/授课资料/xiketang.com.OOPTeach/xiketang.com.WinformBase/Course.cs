using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.WinformBase
{
    /// <summary>
    /// 课程实体类（后面我们还会详细讲解）
    /// </summary>
    public class Course
    {
        public Course() { }
        public Course(int courseId, string courseName, int classHour, string teacher)
        {
            this.CourseId = courseId;
            this.CourseName = courseName;
            this.ClassHour = classHour;
            this.Teacher = teacher;
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int ClassHour { get; set; }//课时
        public string Teacher { get; set; }//主讲老师
    }
}
