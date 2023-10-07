using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace TestException
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入取款金额：");
                //调用可能引发取款异常的方法
                InputAmount(int.Parse(Console.ReadLine()));
                //取款成功
                Console.WriteLine("取款成功！请选择其他操作");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 用户通过ATM机取款
        /// </summary>
        /// <param name="amount">取款金额</param>
        static void InputAmount(int amount)
        {
            if (amount < 50)
                throw new Exception("取款金额必须大于50！");
            else if (amount > 3000)
                throw new Exception("单笔取款金额不能大于3000！");
            else
            {
                //执行取款的其他验证操作


            }
        }
    }
}
