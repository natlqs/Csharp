using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Optimization
{
    /// <summary>
    /// 计算器封装
    /// </summary>
    public class Calculator
    {
        //当前的操作符
        public string Operation { get; set; }

        /// <summary>
        /// 封装逻辑算法
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int StartCalculator(string data)
        {
            //获取操作数
            string num1 = data.Substring(0, data.IndexOf(Operation));
            string num2 = data.Substring(data.IndexOf(Operation) + 1);
            //类型转换
            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);

            //按照类型运算
            int result = 0;
            switch (Operation)
            {
                case "+":
                    result = Add(a,b);
                    break;
                case "-":
                    result = Sub(a, b);
                    break;
                case "×":
                    result = Mul(a, b);                
                    break;
                case "÷":
                    result = Div(a, b);
                    break;
            }
            return result;
        }

        //内部私有方法【封装】
        private  int Add(int a, int b)
        {
            return a + b;
        }
        private int Sub(int a, int b)
        {
            return a - b;
        }
        private int Div(int a, int b)
        {
            return a / b;
        }
        private int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
