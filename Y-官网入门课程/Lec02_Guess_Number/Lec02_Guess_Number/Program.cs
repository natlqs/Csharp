using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec02_Guess_Number
{
    internal class Program
    {
        static Random random = new Random();

        static int GenRandomInt()
        {
            var number = random.Next(0, 100);
            return number;
        }
        static int totalCount = 0;
        static void Main(string[] args)
        {
            int systemNumber = GenRandomInt();
            Console.WriteLine(systemNumber);
            while (true)
            {
                Console.WriteLine("请输入一个0~99的数字，按回车键结束：");
                var inputStr = Console.ReadLine();
                int inputNumber = int.Parse(inputStr);
                totalCount++;
                if (inputNumber == systemNumber)
                {
                    Console.WriteLine($"太厉害了，你只猜了{totalCount}次，就答对了！");
                    systemNumber = GenRandomInt();
                    totalCount = 0;
                }
                else
                {
                    if (inputNumber > systemNumber)
                    {
                        Console.WriteLine("太大了");
                    }
                    else
                    {
                        Console.WriteLine("太小了");
                    }
                }
            }
            Console.ReadLine(); 
        }
    }
}
