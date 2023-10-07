/// 泛型委托是固定格式，比委托少了一步定义委托
/// 无返回值的委托 Action
/// 有返回值的委托 Func
///2.实例化委托
///3.执行委托

namespace _13_Generic_Delegate_泛型委托
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 无参无返的泛型委托
            // 1.直接实例化委托
            Action action = SaiHi; // 无参无返的
            // 2.执行委托
            action();

            /// 有1个参数无返的泛型委托
            // 1.直接实例化委托
            Action<string> action1= SaiHi; // 有1个参数无返的
            // 2.执行委托
            action1("string");

            /// 有2个参数无返的泛型委托
            // 1.直接实例化委托
            Action<string, string> action2= SaiHi;  //  有1个参数无返的
            // 2.执行委托
            action2("Hello", "Generic Delegate");


            /// 有2个参数1个返回值的泛型委托
            /// Func<第1个参数类型，第2个参数类型，......返回值类型> 
            // 1. 实例化委托
            Func<double, double, double> func = Add;
            // 2. 执行委托
            double result = func(1.2, 2.2);
            Console.WriteLine(result);



            Console.ReadLine();
        }
        static void  SaiHi(string msg, string  name)
        {
            Console.WriteLine($"{msg} {name}");
        }
        static void SaiHi(string msg)
        {
            Console.WriteLine(msg);
        }
        static void SaiHi()
        {
            Console.WriteLine("Generic Delegate");
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