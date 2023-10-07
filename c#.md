# C#从入门到精通

### C#介绍

C# 是微软公司设计的一种编程语言，是从c和c++基础上开发出来的一种简单、面向对象和类型安全的编程语言，并且能够与.NET Framework完美结合。

#### C#的特点
- 语法简介
- 面向对象设计
- 与Web紧密结合
- 兼容性高
- 安全性机制
- 错误机制异常处理

#### C#应用领域
- 游戏
- 企业管理系统
- windows phone 应用
- web 应用
- windows桌面应用

#### .NET Framework

.NET Framework 是微软推出的一种完全面向对象的软件开发平台

## C#基础
#### C#中的命名空间
	C#程序中的一种代码组织形式，主要用来标识类的可见范围
- 语法 	namepace 命名空间名称
- 引用	using命名空间名；

#### C#中程序的启动器----Main方法
** Main方法的要求**

- Main方法必须定义为static
- Main方法首字母必须大写
- 返回值可以是void或者int
- 命令行参数可选

**Main方法的语法**

``` c#
static void Main(string[] args) {}
static void Main() {}
static int Main(string[] args) {}
static int Main(){}
```

#### C#中的标识符

类名、变量名、方法名、数组名……都是标识符

首字母必须是**字母** 或**下划线**， 其余部分可以是数字、字母或下划线。

#### C#中的语句

> C#语句实质上就是实现各种功能的C#代码。

#### 程序编写规范

| 尽量使用接口编程           | 关键语句一定编写注释          |
| -------------------------- | ----------------------------- |
| 局部变量随用随声明         | 尽量少用goto语句              |
| 如果参数多，建议使用结构   | 避免对大段代码使用try……catch  |
| 同一个文件中避免编写多个类 | 字符串多变时，用StringBuilder |
| if语句块中使用“{}”         | switch语句中一定编写default   |




















## 方法与函数

### 基础知识

#### 系统函数（库函数）

由编译系统提供，用户不必自己定义，可以直接使用。

#### 用户自定义函数

用以解决用户专门需要。

#### 函数的参数与返回值

- 函数括号中的内容为**参数**，根据函数有没有参数可以把函数分为**有参数函数**和**无参数函数**。

- 函数的返回值一次只能返回一个返回值。

#### 函数定义的四条规律

### 方法的重载和高级参数

#### 

### ref 高级参数，实现形参与实参的数据同步

在使用函数和定义函数时，在要同步的参数前加 <u>**ref**</u> 关键字。


```c#
{
	static void Main(string[] args)
	{
		Console.WriteLine("please input a number:");
		sting str = Console.ReadLine();
		int num = Convert.ToInt32(str);
	
		jisuan(ref num); //有参无返
		Console.WriteLine("square is : " + num)
		Console.ReadKey();
	}
	static void jisuan(ref int n)
	{
		n = n * n;
	}
}
```

### 异常与处理
异常：程序代码语法编写没有错误，但是程序在逻辑上存在错误。Bug

**例1**

```C#
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 2;
            try  //尝试捕获异常，如果没有异常，则执行try里的内容
            {
                int num3 = num1 / num2;
                Console.WriteLine(num3);
            }
            catch  // 如果发生了异常，就执行catch里的内容
            {
                Console.WriteLine("0不能是除数");
            }
            finally
            {
                Console.WriteLine("计算结束!");
            }
            Console.ReadKey();
        }
    }
}
```

**例2**	从键盘录入一个数，如果是数字就输出数字的 平方，如果不是就提示输入的不是数字。

```C#
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("从键盘录入一个数：");
                string str = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(str);//异常
                    Console.WriteLine("平方是" + num * num);
                }
                catch 
                {
                    Console.WriteLine("你输入的不是数字！");
                }
            }
            Console.ReadKey();
        }
    }
}
```

**例3** 从键盘上输入两个数字，然后计算这两个数字之间所有整数的和；

- 用户只能输入数字；
- 要求第一个数字必须比第二个数字小，否则重新输入；
- 额外要求：输出两个数字之间有多少个整数。

```c#
namespace 双数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            tishi(1);
            string strNum1 = input();
            //调用一个方法 --- 数据类型的转换
            int n1 = GetNum(strNum1);
            tishi(2);
            string strNum2 = input();
            int n2 = GetNum(strNum2);
            //调用方法
            //判断大小
            JudgeNum(ref n1, ref n2);
            //求和
            GetSum(n1, n2);
            //求整数
            GetCount(n1, n2);
            Console.ReadKey();
        }

        static void GetCount(int n1, int n2)
        {
            Console.WriteLine("{0}到{1}之间有{2}个整数！", n1, n2, (n2 - n1 - 1));

        }
        static void GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i<=n2; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("从{0}到{1}的和是: {2}", n1, n2, sum);
        }

        static void JudgeNum(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    //符合题意
                    return;
                }
                else // n1>n2
                {
                    Console.WriteLine("你输入的第1个数不能大于或等于2个数，请重新输入第1个数！");
                    string s1 = input();
                    n1 = GetNum(s1);
                    Console.WriteLine("你输入的第1个数不能大于或等于2个数，请重新输入第2个数！");
                    string s2 = input();
                    n2 = GetNum(s2);
                }
            }
        }
        static int GetNum(string s)
        {
            while (true)
            {
                //异常
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入错误！请重新输入数字：");
                    s = input();
                }
            }
        }
        static string input()
        {
            return Console.ReadLine();
        }

        static void tishi(int i)
        {
            Console.WriteLine("请输入第{0}个数字：",i);
        }
    }
}
```



### 面向对象程序设计

#### 面向对象的概念

**对象**：能够被计算机处理的信息，在现实生活中能被抽象感知的物品。有效信息的被动发生。

**对象的行为**： 对象所能执行的动作和功能

**对象的属性**：描述对象的外貌特征和状态

#### 类和对象

**类的概念**：类（class）表示对现实世界中一类具有共同特征的事物的抽象，实际上是对某种类型的**对象**定义变量和方法的原型（模板）

##### 类的定义

```C#
namespace 射击游戏
{
    public class player
    {
        //属性 -- 字段 --变量
        public string name;
        public int hp;//HP 生命值
        //行为 -- 方法 --函数
        public void shoot(int shanghai)
        {
            hp = hp - shanghai;//中弹
            if (hp <=0)
            {
                Console.WriteLine("死亡");
            }
            else
            {
                Console.WriteLine("未死亡");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //生成两个玩家，+ 自己 = 3个人
            //由类生成对象的过程
            player p1 = new player(); //生成了p1
            player p2 = new player();   //生成了p2
            //p1 和p2就是两个对象
            p1.name = "dabai";
            p1.hp = 100;
            p2.name = "xiaobai";
            p2.hp = 60;

            Console.WriteLine("游戏开始！");
            Console.WriteLine("现在有2个玩家： ");
            // 选枪
            Console.WriteLine("1 ----> AKM,  伤害是：50");
            Console.WriteLine("2 ----> M416, 伤害是：70");
            Console.WriteLine("3 ----> 98K,  伤害是：120");
            Console.WriteLine("你要用什么武器打他？");
            int hurt;
            string strArms = Console.ReadLine();
            if (strArms == "1")
            {
                Console.WriteLine("当前武器是：AKM");
                hurt = 50;
            }
            else if (strArms == "2")
            {
                Console.WriteLine("当前武器是：M416");
                hurt = 70;
            }
            else if (strArms == "3")
            {
                Console.WriteLine("当前武器是：98K");
                hurt = 120;
            }
            else
            {
                Console.WriteLine("选择错误！");
                hurt = 0;
            }
            Console.WriteLine("玩家1的名字是：{0}， 生命值是：{1}", p1.name, p1.hp);
            Console.WriteLine("玩家2的名字是：{0}， 生命值是：{1}", p2.name, p2.hp);
            Console.Write("你要打谁？");
            string str = Console.ReadLine();
            int i = Convert.ToInt32(str);
            if (str == "1")//打1
            {
                Console.WriteLine("现在要打" + p1.name);
                p1.shoot(hurt);//p1被打了一枪
            }
            else//打2
            {
                Console.WriteLine("现在要打" + p2.name);
                p2.shoot(hurt);//p2被打了一枪
            }
            Console.ReadKey();
        }
    }
}
```







