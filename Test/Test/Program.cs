#if DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public delegate double Cal(double x, double y);
    internal class Program
    {
<<<<<<< HEAD

        static void Main(string[] args)
        {

            thread();
            task();
=======
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Dec(double x, double y)
        {
            return x - y;
        }
        static double Mul(double x, double y)
        {
            return x * y;
        }
        static double Div(double x, double y)
        {
            return x / y;
        }
        static void Test(Cal f)// 参数是一个委托，委托实例化的时候就是一个方法
        {
            Console.WriteLine("请输入X：");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入Y：");
            double y = Convert.ToDouble(Console.ReadLine());
            // 委托方法工作，怎么工作由具体委托决定
            double result = f(x, y);
            Console.WriteLine($"X:{x}与Y：{y}委托方法计算结果为：{result}");
        }
        static void Main(string[] args)
        {
            //Cal cal = new Cal(Add);
            //double result = cal(7, 9);
            //Console.WriteLine($"委托的返回值result是:{result}");

            //01: 新建一个委托实例，把委托作为参数传给方法
            //Cal cal = new Cal(Add);
            //Test(cal);

            //02: 
            //Test(new Cal(Add));

            //03: 直接把方法作为委托参数传递给方法
#if DEBUG

            Debug.Print("test");
            Test(Add);
            Test(Dec);
            Test(Mul);
            Test(Div);

#endif
>>>>>>> 38780c29ac02bb13bef9c41e435521d51fb130d0
            Console.ReadLine();

            // 
        }
<<<<<<< HEAD
        static void thread()
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine(  "hello thread");
                MessageBox.Show("hh");
            });
            thread.Start();
        }
        static async void task()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine(  "hello task");

            });
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("start");
            });
            MessageBox.Show("Test");

        }
=======

>>>>>>> 38780c29ac02bb13bef9c41e435521d51fb130d0
    }
} 
#endif

Console.WriteLine("顶级语句，一行代码就可运行");