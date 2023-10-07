using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _01_Hello_WPF
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        /* 
         * Application的生命周期：
         * 包含一些虚方法，可以重写，加入所需的处理逻辑
         * OnStartup: 程序启动时就执行
         * OnActivated： 点击后执行
         * OnDactived：不点击的时候执行
         * OnExit：退出后执行
         */
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);      // 执行Application父类的OnStartup方法
            Console.WriteLine("1.OnStartUp被执行");
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Console.WriteLine("2.OnActivated被执行");
        }
        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            Console.WriteLine("3.OnDeactivated被执行");
        }
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            Console.WriteLine("4.OnExit被执行");
        }
    }
}
