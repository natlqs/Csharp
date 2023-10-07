namespace 进程单例_同一程序只允许运行一个进程_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// 互斥锁(Mutex)，用于多线程中防止两条线程同时对一个公共资源进行读写的机制。
            /// 第1个参数：是否为创建者，如果是创建者直接获得对象的控制权； 
            /// 第2个参数：GUID  菜单栏->工具->创建GUID    
            /// 第3个参数：输出型参数，这个bool值如果是true代表你是这个对象的创建者，如果是false代表你不是这个对象的创建者，系统中已经有这个对象，你获取的仅仅是这个对象的引用
            Mutex mutex = new Mutex(true, "{FFE911AF-476E-41F5-B964-EC0B6F12BB38}", out bool createNew);                    
            if(!createNew)
            {
                MessageBox.Show($"{Application.ProductName} 已经在运行", "提示");
                return;
            }



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}