using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建几个对象
            Student student1 = new Student { StudentId = 1001, StudentName = "VIP学员1", Age = 21 };
            Student student2 = new Student { StudentId = 1002, StudentName = "VIP学员2", Age = 22 };
            Student student3 = new Student { StudentId = 1003, StudentName = "VIP学员3", Age = 23 };
            Student student4 = new Student { StudentId = 1004, StudentName = "VIP学员4", Age = 24 };
            Student student5 = new Student { StudentId = 1005, StudentName = "VIP学员5", Age = 25 };


            //使用Add方法添加
            Dictionary<string, Student> stuDic1 = new Dictionary<string, Student>();
            stuDic1.Add("VIP1", student1);
            stuDic1.Add("VIP2", student2);
            stuDic1.Add("VIP3", student3);
            stuDic1.Add("VIP4", student4);
            stuDic1.Add("VIP5", student5);

            //使用集合初始化器
            Dictionary<string, Student> stuDic2 = new Dictionary<string, Student>()
            {
                ["VIP1"]=student1,
                ["VIP2"] = student2,
                ["VIP3"] = student3,
                ["VIP4"] = student4,
                ["VIP5"] = student5,
            };

            //集合的嵌套（比如：1班 5个学生成绩   2 班有5个学员成绩....）
            List<int> class1List = new List<int> { 90, 80, 60, 79, 82 };
            List<int> class2List = new List<int> { 93, 85, 60, 79, 82 };
            List<int> class3List = new List<int> { 92, 80, 60, 89, 88 };

            Dictionary<string, List<int>> classList = new Dictionary<string, List<int>>()
            {
                ["软件1班"]= class1List,
                ["软件2班"] = class2List,
                ["软件3班"] = class3List
            };

            //通过key访问value
            Student student = stuDic1["VIP3"];
            Console.WriteLine(student.StudentName);
            Console.WriteLine("------------------------------");

            //遍历集合keys
            foreach (string key in stuDic1.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("------------------------------");
            //遍历集合values
            foreach (Student item in stuDic1.Values)
            {
                Console.WriteLine(item.StudentId+"\t" + item.StudentName + "\t" + item.Age);
            }
            Console.WriteLine("------------------------------");

            //计算所有班级的平均分数
            foreach (string className in classList.Keys)
            {
                Console.WriteLine($"{className}  平均分数：{classList[className].Average()}");
            }
            Console.Read();
        }
    }
}
