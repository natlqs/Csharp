using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args) //程序的入口方法
        {
            Console.WriteLine("现在我们正式和常老师学习C#开发！");

            int a = 20;
            Console.WriteLine(a);

            //调用VB.NET写的代码

            VBCal.MyCalculator testClass = new VBCal.MyCalculator();
            int result = testClass.Add(10, 20);

            Console.WriteLine(result);

            Console.ReadLine();
        }


    }
}
