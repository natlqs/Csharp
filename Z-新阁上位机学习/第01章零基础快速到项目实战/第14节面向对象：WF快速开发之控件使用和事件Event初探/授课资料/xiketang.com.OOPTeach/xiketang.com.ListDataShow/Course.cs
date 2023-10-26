using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace xiketang.com.GenericList
{
    /// <summary>
    /// 课程类
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
        public int CourseId { get; set; }//课程编号
        public string CourseName { get; set; }//课程名称
        public int ClassHour { get; set; }//课时
        public string Teacher { get; set; }//主讲老师

    }



    #region 自定义排序类：根据需要，添加对应个数的排序类

    /// <summary>
    /// 课程编号升序
    /// </summary>
    class CourseIdASC : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return x.CourseId.CompareTo(y.CourseId);
        }
    }
    /// <summary>
    /// 课程编号降序
    /// </summary>
    class CourseIdDESC : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return y.CourseId.CompareTo(x.CourseId);
        }
    }
    /// <summary>
    /// 课时升序
    /// </summary>
    class CourseClassASC : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            return x.ClassHour.CompareTo(y.ClassHour);
        }
    }
    #endregion 

}
