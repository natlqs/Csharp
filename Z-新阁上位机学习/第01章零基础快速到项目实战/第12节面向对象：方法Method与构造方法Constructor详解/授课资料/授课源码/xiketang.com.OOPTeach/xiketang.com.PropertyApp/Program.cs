using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.PropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestClass testClass = new TestClass();
            //testClass.Dowork1();
            //testClass.Dowork2();

            TestClass1 testClass1 = new TestClass1();
            testClass1.Dowork1();

            TestClass2 testClass2= new TestClass2();
            testClass2.Dowork1();

            testClass2.Dowork2();

            Console.ReadLine();
        }
    }
}
