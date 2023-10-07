///委托使用三步：
///1.定义委托
///2.实例化委托
///3.执行委托

namespace _13_Delegate
{
    /// 第1步：定义委托

    /// <summary>
    ///  定义委托类型
    ///  委托也是可以定义在类中
    ///  委托与类是平级的，都是类型
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public delegate double Cal(double x, double y);
    internal class Program
    {
        ///申明一个把委托作为参数的方法
        /// <summary>
        /// 形参为委托类型
        /// </summary>
        /// <param name="f">委托方法</param>
        static void Test(Cal f)
        {
            Console.WriteLine("请输入 X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入Y：");
            double y = Convert.ToDouble(Console.ReadLine());
            // 委托方法工作，怎么方法工作由具体委托决定
            double result = f(x, y);
            Console.WriteLine($"X:{x}与Y:{y}委托方法计算结果为：{result} ");
        }
        static void Main(string[] args)
        {
            /// 第2步：实例化委托
            //Cal cal = new Cal(Add); //实例化委托方法1
            //Cal cal2 = Add;         // 实例化委托方法2

            /// 第3步：直接使用委托
            //double result = cal(5, 8);
            //Console.WriteLine(result);

            /// 将委托作为参数传递给方法
            Cal cal = Dec;      // 实例化委托1
            Cal cal2 = Add;     // 实例化委托2
            Test(cal);      // 将实例化的委托1作为参数传递给方法
            Test(cal2);     // 将实例化的委托2作为参数传递给方法

            Test(new Cal(Mul));     // 直接在参数中实例化
            Test(Div);          // 直接将方法作为参数传递给方法
            Console.ReadLine();
        }
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
            return (x * y);
        }
        static double Div(double x, double y)
        {
            return x / y;
        }
    }
}