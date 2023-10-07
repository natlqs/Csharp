using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = new StudentService().DeleteStudentById("100001"); 
            if (result == 1)
                Console.WriteLine("删除成功！");
            else
                Console.WriteLine("删除失败！");
            Console.ReadLine();
        }
    }
}
