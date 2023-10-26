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
    public class Course : IComparable<Course>
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

        //接口对应的比较方法（这个方法的签名，千万不要动）
        public int CompareTo(Course other)
        {
            //return this.CourseId.CompareTo(other.CourseId);
            return other.CourseId.CompareTo(CourseId);
            //如果把this放到前面，表示按照升序排列，other放到前面就是按照降序排列
        }
    }

    class TestGenericList
    {
        #region 对象集合添加和删除的几种方式    
        public List<Course> CreateCourses()
        {
            Course course1 = new Course();
            course1.CourseId = 10001;
            course1.CourseName = "C#面向对象中集合的应用";
            course1.ClassHour = 2;
            course1.Teacher = "常老师";
            //通过对象初始化器
            Course course2 = new Course { CourseId = 10002, CourseName = "SQLServer数据库开发", ClassHour = 5, Teacher = "常老师" };
            //通过有参数的构造方法创建对象
            Course course3 = new Course(10003, ".Net/C#全栈VIP课程", 200, "常老师");
            Course course4 = new Course(10004, ".Net/C#上位机VIP课程", 500, "常老师");
            Course course5 = new Course(10005, ".Net/C#高级进阶VIP课程", 300, "常老师");

            //如果将前面的对象添加到数组中
            Course[] courseArray = new Course[5];
            courseArray[0] = course1;

            //如果我们创建的对象个数并不是固定的，想，能不能我们不限制数组中元素的个数呢？

            //集合：定义的时候，无需规定元素的个数。
            //泛型：表示一种程序特性，也就是我们在定义的时候，无需指定特定的类型，而在使用的时候，我们必须明确类型
            //应用：集合中、方法中、类中
            //表示：<T>
            //要求：添加到集合中的元素类型，必须和泛型集合定义时规定的数据类型完全一致

            //List<Course> courseList = new List<Course>();
            //courseList.Add(course1);
            //courseList.Add(course2);
            //courseList.Add(course3);
            //courseList.Add(course4);
            //courseList.Add(course5);
            // courseList.Add(10);

            //使用集合初始化器，将元素一次性的初始化到集合中
            List<Course> courseList = new List<Course>() { course1, course2, course3, course4, course5 };
            Course[] courseArray1 = new Course[] { course1, course2, course3, course4, course5 };

            //如果给我们一个数组，我们能不能把数组中的元素添加到集合中？
            List<Course> courseListFromArray = new List<Course>();
            courseListFromArray.AddRange(courseArray1);

            //集合能否转换到数组?
            Course[] courseArray2 = courseList.ToArray();
            //数组能否直接转换到集合？
            List<Course> courseList3 = courseArray2.ToList();

            //删除元素
            //Console.WriteLine("\r\n---------------------删除后元素列表------------------\r\n");
            //public bool Remove(T item);          
            //public int RemoveAll(Predicate<T> match);        
            //public void RemoveAt(int index);          
            //public void RemoveRange(int index, int count);

            //courseList.Remove(course3);//必须要掌握
            //courseList.RemoveAll(c => c.CourseId > 10002);//了解
            // courseList.RemoveAt(2);

            //courseList.RemoveRange(1, 2);

            // Console.WriteLine("集合中对象的总数：" + courseList.Count);

            return courseList;
        }

        #endregion

        #region 集合元素的遍历和快速查找
        //集合遍历的两种方式
        public void TraversalList1(List<Course> courseList)
        {
            for (int i = 0; i < courseList.Count; i++)
            {
                Console.WriteLine($"{courseList[i].CourseId}\t{courseList[i].CourseName}\t{courseList[i].ClassHour}\t{courseList[i].Teacher}");
            }
        }
        public void TraversalList2(List<Course> courseList)
        {
            foreach (Course item in courseList)
            {
                Console.WriteLine($"{item.CourseId}\t{item.CourseName}\t{item.ClassHour}\t{item.Teacher}");
            }
        }
        /// <summary>
        /// 集合快速查询方法（是我们VIP后期深入学习的时候详细讲解的）
        /// </summary>
        /// <param name="courseList"></param>
        public void QueryElements(List<Course> courseList)
        {
            //集合查询方法1
            List<Course> result1 = courseList.FindAll(c => c.CourseId > 10003);

            //集合查询方法2
            var result2 = from c in courseList where c.CourseId > 10003 select c;
            var result3 = result2.ToList();
        }
        #endregion

        #region 集合元素排序

        public void ListOrder()
        {
            #region 值类型元素的排序

            Console.WriteLine("\r\n----------------------值类型元素排序------------------\r\n");
            List<int> ageList = new List<int> { 20, 19, 25, 30, 26 };
            ageList.Sort();//默认按照升序排列

            foreach (int item in ageList)
            {
                Console.WriteLine(item);
            }
            ageList.Reverse();
            Console.WriteLine("-------------");
            foreach (int item in ageList)
            {
                Console.WriteLine(item);
            }

            #endregion

            //对象集合元素排序（默认）
            Console.WriteLine("\r\n----------------------集合默认排序------------------\r\n");
            List<Course> courseList = CreateCourses();

            courseList.Sort();

            //以上Sort方法默认会报错的！所以在Course类中实现系统接口IComparable<Course>
            TraversalList1(courseList);
            //以上我们使用默认比较器进行排序，很不方便，如果我们需要多种排序，怎么办？

            //比较器接口：其实就是我们可以任意的指定对象属性排序，从而实现动态排序。
            //集合元素动态排序
            Console.WriteLine("\r\n----------------------集合动态排序------------------\r\n");

            //排序方法的定义： public void Sort(IComparer<T> comparer);
            courseList.Sort(new CourseIdASC());
            Console.WriteLine("-----------按照编号升序---------\r\n");
            TraversalList1(courseList);

            Console.WriteLine("\r\n-----------按照编号将序---------\r\n");
            courseList.Sort(new CourseIdDESC());
            TraversalList1(courseList);

            //其实上面我们的练习，我希望大家，能够自己写出来，但是更重要的是理解多态的原理，因为Sort这个重载的方法就是多态原理的一个应用。
            //我们后面深入学习架构开发等更高级的理论，技能，设计模式等，处处都在用多态！

            //通过上面的练习，我们发现实际应用中，还是有点麻烦的。大家如果跟着常老师深入系统学习VIP课程，会给大家讲解更好的方法。

            //高级阶级我们用的方法：这里先体验（了解）
            Console.WriteLine("\r\n--------后面高级课程中，使用LINQ实现排序------------");
            var list1 = from c in courseList orderby c.CourseId ascending select c;
            TraversalList1(list1.ToList());

            Console.WriteLine("\r\n--------后面高级课程中，使用扩展方法OrderByDescending实现降序------------");
            var list2 = courseList.OrderByDescending(c => c.CourseId);
            TraversalList1(list2.ToList());

            Console.WriteLine("\r\n--------后面高级课程中，使用扩展方法OrderBy实现升序序------------");
            var list3 = courseList.OrderBy(c => c.ClassHour);
            TraversalList1(list3.ToList());

        }

        #endregion
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
