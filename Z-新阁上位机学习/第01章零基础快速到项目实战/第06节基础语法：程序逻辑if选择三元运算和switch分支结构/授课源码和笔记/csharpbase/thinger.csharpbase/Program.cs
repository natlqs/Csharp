using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thinger.csharpbase
{
    /// <summary>
    /// 这个是控制台核心类
    /// 主要是供我们练习使用
    /// </summary>
    class Program
    {
        //更多资料请加助教微信：xiketang777   xiketang666

        static void Main(string[] args)
        {
            // Test1();
            //int result = Add(10, 20);
            //Test2();
            //Test3();
            //Test4();
            //Test5();
            //Test6();
            //Test7();
            //Test8();
            //Test9();
            //Test10();
            //Test11();
            //Test12();
            //Test13();
            //Test14();
            //Test15();
            //Test16();
            //Test17();
            //Test18();
            //Test19();
            //Test20();
            //Test21();
            //Test22();
            Test23();

            //更多资料请加助教微信：xiketang777   xiketang666
            Console.ReadLine();
        }

        #region 01. 变量的基础使用

        static void Test1()
        {
            int score;  //变量类型  变量名称

            score = 98; //给变量赋值    

            string subject = "C#基础语法"; //声明变量同时赋值

            //使用变量
            Console.WriteLine("科目：" + subject + "   分数：" + score);
        }
        /// <summary>
        /// 实现两个数相加
        /// </summary>
        /// <param name="a">第一个整数</param>
        /// <param name="b">第二个整数</param>
        /// <returns>返回两个数的和</returns>
        static int Add(int a, int b)
        {
            return a + b;
        }

        #endregion

        #region 02. 控制台的使用技巧：输入输出和字符串格式化的方法

        //输入输出方法基本使用
        static void Test2()
        {
            //int score = 90;
            //string name = "jack";

            Console.Write("请输入学员姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入学员成绩：");
            int score = int.Parse(Console.ReadLine());

            //double  avgScore=double.Parse(Console.ReadLine());
            //Console.WriteLine(90);
            //Console.WriteLine("C#编程");

            Console.WriteLine("姓名：" + name + "   成绩：" + score);
            //string  sum = 10 + "";
        }

        //字符串格式化方法和控制台输出格式化
        static void Test3()
        {
            Console.Write("请输入学员姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入学员成绩：");
            int score = int.Parse(Console.ReadLine());
            Console.Write("请输入班级：");
            string className = Console.ReadLine();

            //使用+拼接字符串
            string info1 = "姓名：" + name + "   成绩：" + score;

            //使用占位符拼接字符串
            string info2 = string.Format("姓名：{0}   成绩：{1}  班级：{2}", name, score, className);

            Console.WriteLine(info2);
            Console.WriteLine();

            //WriteLine方法支持直接的格式化方法
            Console.WriteLine("姓名：{0}   成绩：{1}  班级：{2}", name, score, className);


            Console.WriteLine("**************下面是新特性的格式化方法*************");
            //使用新特性简化字符串格式化（建议使用的方法）
            string info3 = $"姓名：{name}   成绩：{score}  班级：{className}";
            Console.WriteLine(info3);
            Console.WriteLine($"姓名：{name}   成绩：{score}  班级：{className}");
        }

        #endregion

        #region 03. 赋值和算数运算符的使用

        static void Test4()
        {
            int a = 10;
            int b = 20;
            int result = a + b;
            Console.WriteLine($"a+b={result}");

            result = a - b;
            Console.WriteLine($"a-b={result}");

            result = a * b;
            Console.WriteLine($"a*b={result}");

            result = a / b;
            Console.WriteLine($"a/b={result}");

            result = b / a;
            Console.WriteLine($"b/a={result}");

            int c = 12;
            result = c % a;
            Console.WriteLine($"c%a={result}");

            result = a * (b - c) / 2;

            Console.WriteLine($" a * (b - c) / 2={result}");

            a = a + b;
            Console.WriteLine("a=" + a);
            a = a - b;
            Console.WriteLine("a=" + a);

            a += b;
            Console.WriteLine("a += b    -->" + a);

            a -= b;
            Console.WriteLine("a -= b    -->" + a);

            a *= b;
            Console.WriteLine("a *= b    -->" + a);

            int d = 100;
            d++;
            Console.WriteLine("d=" + d);

            d--;
            Console.WriteLine("d=" + d);

            ++d;
            Console.WriteLine("d=" + d);

            --d;
            Console.WriteLine("d=" + d);

            int i = 200;
            Console.WriteLine($"i++ 后的值：{i++}");
            Console.WriteLine($"i值：{i}");

            int e = 300;
            Console.WriteLine($"++e 后的值：{++e}");

            int f = 400;
            Console.WriteLine($"f-- 后的值：{f--}");
            Console.WriteLine($"f值：{f}");

            int h = 500;
            Console.WriteLine($"--h 后的值：{--h}");
        }

        #endregion

        #region 04. 本阶段练习

        static void Test5()
        {
            Console.Write("请输入第1位学员的成绩：");
            int stuScore1 = int.Parse(Console.ReadLine());
            Console.Write("请输入第2位学员的成绩：");
            int stuScore2 = int.Parse(Console.ReadLine());
            Console.Write("请输入第3位学员的成绩：");
            int stuScore3 = int.Parse(Console.ReadLine());
            Console.Write("请输入第4位学员的成绩：");
            int stuScore4 = int.Parse(Console.ReadLine());
            Console.Write("请输入第5位学员的成绩：");
            int stuScore5 = int.Parse(Console.ReadLine());
            //计算平均成绩
            int avgScore = (stuScore1 + stuScore2 + stuScore3 + stuScore4 + stuScore5) / 5;
            Console.WriteLine($"5位学员的平均成绩：{avgScore}");

        }

        static void Test6()
        {
            Console.Write("请输入第1位进入本楼的人员姓名：");
            string name_1 = Console.ReadLine();
            Console.Write("请输入第2位进入本楼的人员姓名：");
            string name_2 = Console.ReadLine();
            Console.Write("请输入第3位进入本楼的人员姓名：");
            string name_3 = Console.ReadLine();
            Console.WriteLine("**********************************");
            string info1 = "刚才进出的3位人员是：" + name_1 + ";" + name_2 + ";" + name_3;
            string info2 = "刚才进出的3位人员是：" + string.Format("{0};{1}{2}", name_1, name_2, name_3);
            string info3 = $"刚才进出的3位人员是：{name_1};{name_2};{name_3}";

            Console.WriteLine(info1);
            Console.WriteLine(info2);
            Console.WriteLine(info3);
        }
        #endregion

        #region  05. 比较运算符

        static void Test7()
        {
            string name1 = "james";
            string name2 = "jacks";
            string name3 = "james";

            // bool result1 = name1.Equals(name2);
            Console.WriteLine(name1 == name2);
            Console.WriteLine(name1 == name3);
            Console.WriteLine(name1 != name2);

            //if (name1 == name2)
            //{ 

            //}
            Console.WriteLine("************************");
            int a = 100;
            int b = 200;
            int c = b - a;

            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
            Console.WriteLine(b != c);

            Console.WriteLine(a > b);
            Console.WriteLine(a <= c);
        }

        #endregion

        #region 06. 自动类型转换：值类型之间

        static void Test8()
        {
            double a = 100.5;
            int b = 200;

            double result = a + b; //这个转换是自动完成的
            Console.WriteLine($"自动实现类型转换：100.5 + 200={result}");
        }

        //static void Test9()
        //{
        //    double a = 100.5;
        //    int b = 200;

        //    int result = a + b; //这个转换不能自动实现
        //    Console.WriteLine($"自动实现类型转换：100.5 + 200={result}");
        //}    
        #endregion

        #region 07. 强制类型转换：值类型之间

        static void Test9()
        {
            double a = 100.5;
            int b = 200;

            int result = (int)a + b; //这种语法的转换，一般是值类型之间可以用。
            Console.WriteLine($"强制类型转换一：100.5 + 200={result}");

            //结论：这种方式，会出现精度丢失！
        }
        //特别的：如果要转换的类型是object类型，也可以使用这种语法。
        static void Test10()
        {
            object a = 100.5;
            int b = 200;

            int result = (int)(double)a + b; //object属于引用类型
            Console.WriteLine($"强制类型转换一：100.5 + 200={result}");
        }

        //总结：当我们使用（数据类型）这种强制转换方法的时候，要求被转换的变量“大类型”必须和目标大类型一致。
        #endregion

        #region 08. 强制类型转换：字符串和值类型之间
        static void Test11()
        {

            //只有“有效的”字符类型，才能转换成对应的值类型。有效的：也就是说字符串内容必须符合目标类型
            double a = double.Parse("100.5");
            float b = float.Parse("20.36");
            int c = int.Parse("500");

            //下面的作为了解
            // int d = int.Parse("19.56");  //这种方式会出错，因为“19.56”不是int的有效表示形式
            int d = (int)double.Parse("19.56");
            double e = double.Parse("100");

            //总结转换方法：目标类型  变量=目标类型.Parse("字符串的有效表示");

            //-->值类型==》字符串
            string s1 = a.ToString();
            string s2 = b.ToString();
        }

        #endregion

        #region 09. 强制类型转换：万能转换器Convert
        static void Test12()
        {
            //double a = double.Parse("100.5");
            //float b = float.Parse("20.36");
            //int c = int.Parse("500");

            double a = Convert.ToDouble("100.5");
            float b = Convert.ToSingle("20.36");
            int c = Convert.ToInt32("500");
            DateTime dt = Convert.ToDateTime("2022-10-1");

            int d = Convert.ToInt32(a);

            //注意：以上情况，同样要求，字符串或者要转换的类型，必须是目标类型的有效表示形式
            c = (int)Convert.ToDouble("500.5");
        }

        #endregion

        #region 10. if条件选择与逻辑运算符

        static void Test13()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();

            //判断
            //if (uName == null)   //在控制台输入中，如果用户什么都没有输入，返回但是空字符串，不是空值null
            //{
            //    Console.WriteLine("用户名不能为空！");
            //}

            //判断字符串是空通常用下面的三种方式（注意不是null）
            if (uName == "")
            {
                Console.WriteLine("【1】用户名不能为空！");
            }
            if (uName == string.Empty)
            {
                Console.WriteLine("【2】用户名不能为空！");
            }
            if (uName.Length == 0)
            {
                Console.WriteLine("【3】用户名不能为空！");
            }
            Console.WriteLine("".Length);

            if (uPwd == "")
            {
                Console.WriteLine("用户密码不能为空！");
            }
        }


        static void Test14()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();
            if (uName == "" || uPwd == "")
            {
                Console.WriteLine("用户名或密码不能为空！");
            }
            //这种或运算符符，只要检测到一个条件满足，后面的就不再检测（短路）           

        }

        static void Test15()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();

            if (uName != "" && uPwd != "")
            {
                if (uName == "thinger" && uPwd == "123")
                {
                    Console.WriteLine("用户登录成功！");
                }
            }
        }

        static void Test16()
        {
            Console.Write("请输入用户名：");
            string uName = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string uPwd = Console.ReadLine();
            Console.Write("您是管理员吗？");
            bool isAdmin = Convert.ToBoolean(Console.ReadLine());

            if (uName == "thinger" && uPwd == "123")
            {
                Console.WriteLine("用户登录成功！");
            }

            if (!isAdmin)
            {
                Console.WriteLine("当前用户不是管理员！");
            }
        }

        #endregion

        #region 11. if条件选择与逻辑运算符

        static void Test17()
        {
            Console.Write("请输入笔试成绩：");
            int writeScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入机试成绩：");
            int LabScore = int.Parse(Console.ReadLine());

            if (writeScore >= 80 && LabScore >= 90)
            {
                Console.WriteLine("考试成绩优秀！");
            }

            if ((writeScore == 100 && LabScore > 60) || (LabScore == 100 && writeScore > 60))
            {
                Console.WriteLine("考试成绩优秀！");
            }
        }

        #endregion

        #region 12. if-else 条件选择与三元运算符

        static void Test18()
        {
            Console.Write("请输入笔试成绩：");
            int writeScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入机试成绩：");
            int LabScore = int.Parse(Console.ReadLine());

            if (writeScore >= 80 && LabScore >= 90)
            {
                Console.WriteLine("考试成绩优秀！");
            }
            else
            {
                Console.WriteLine("请继续努力哦！争取下次考试优秀！");
            }
        }

        static void Test19()
        {
            Console.Write("请输入笔试成绩：");
            int writeScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入机试成绩：");
            int LabScore = int.Parse(Console.ReadLine());
            string result = "";
            if (writeScore > LabScore)
                result = "请加强机试练习";
            else
                result = "请加强笔试练习";
            Console.WriteLine(result);
            Console.WriteLine("**********************");
            //三元运算符适合if-else的简单条件和简单赋值的语句
            result =
                writeScore > LabScore ? "请加强机试练习" : "请加强笔试练习";
            Console.WriteLine(result);
            int a = 10;
            int b = 20;
            int c = a - b > 0 ? a * b : a + b;
            Console.WriteLine(c);
        }
        #endregion

        #region 13. 多条件选择else-if与选择嵌套

        static void Test20()
        {
            Console.WriteLine("请输入客户消费金额：");
            int totalMoney = int.Parse(Console.ReadLine());
            if (totalMoney >= 1000 && totalMoney < 2000)
                Console.WriteLine("需付款：" + totalMoney * 0.8);
            if (totalMoney >= 2000 && totalMoney < 3000)
                Console.WriteLine("需付款：" + totalMoney * 0.7);
            if (totalMoney >= 3000 && totalMoney < 4000)
                Console.WriteLine("需付款：" + totalMoney * 0.6);
            if (totalMoney >= 4000)
                Console.WriteLine("需付款：" + totalMoney * 0.5);
            if (totalMoney < 1000)
                Console.WriteLine("需付款：" + totalMoney);
        }

        static void Test21()
        {
            Console.WriteLine("请输入客户消费金额：");
            int totalMoney = int.Parse(Console.ReadLine());
            if (totalMoney >= 1000 && totalMoney < 2000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.8);
            }
            else if (totalMoney >= 2000 && totalMoney < 3000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.7);
            }
            else if (totalMoney >= 3000 && totalMoney < 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.6);
            }
            else if (totalMoney >= 4000)
            {
                Console.WriteLine("需付款：" + totalMoney * 0.5);
            }
            else
            {
                Console.WriteLine("需付款：" + totalMoney);
            }
        }

        static void Test22()
        {
            Console.Write("请输入客户消费金额：");
            int totalMoney = int.Parse(Console.ReadLine());
            if (totalMoney >= 1000)
            {
                Console.WriteLine("需要付款：" + (totalMoney - 500));
                Console.Write("请输入会员类型：");
                string customerType = Console.ReadLine();
                if (customerType == "普通")//再次判断                
                    Console.WriteLine("同时送100元代金券！");
                else if (customerType.Equals("vip"))
                    Console.WriteLine("同时送200元代金券！");
            }
            else
                Console.WriteLine($"需要付款：{totalMoney}");
        }

        #endregion

        #region 13. switch分支结构

        static void Test23()
        {
            Console.Write("请输入您购买的课程类型：");
            string type = Console.ReadLine();
            switch (type)
            {
                case "A":
                    Console.WriteLine("可以抽奖安卓手机！");
                    break;
                case "B":
                    Console.WriteLine("可以抽奖平板电脑！");
                    break;
                case "C":
                    Console.WriteLine("可以抽奖固态硬盘！");
                    break;
                default:
                    Console.WriteLine("您不能参与抽奖！");
                    break;
            }
        }


        #endregion

    }
}
