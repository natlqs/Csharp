using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家学习喜科堂常老师主讲的《C#面向对象编程-方法Method》");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("课程网址：xiketang.ke.qq.com");
            Console.WriteLine("-------------------------------------------------------------\r\n\r\n");

            //构造方法的使用
            TestClass1 testClass1 = new TestClass1();
            testClass1.Dowork1();

            testClass1.Dowork2();

            TestClass2 testClass2 = new TestClass2();
            testClass2.Dowork1();

            testClass2.Dowork2();

            Console.Read();
        }
    }
}
