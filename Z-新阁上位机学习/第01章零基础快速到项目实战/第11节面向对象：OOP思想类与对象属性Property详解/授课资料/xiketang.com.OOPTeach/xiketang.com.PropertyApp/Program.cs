using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.PropertyApp
{
    /// <summary>
    /// 欢迎参加喜科堂互联教育.Net全栈开发和上位机课程
    /// 课程网址：xiketang.ke.qq.com
    /// 常老师QQ：2934008878          课程助教QQ：995551859（更多资料获取）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家参加《喜科堂常老师的C#课程学习》");
            Console.WriteLine("常老师QQ：2934008878");
            Console.WriteLine("客服老师QQ：995551859   PPT、作业等资料获取，请加客服老师。");
            Console.WriteLine("-----------------------------------------------------------------");
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
