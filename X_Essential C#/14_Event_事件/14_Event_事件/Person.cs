namespace _14_Event_事件
{
    public class MyEventArgs : EventArgs
    {
        public int Id;
        public string Name;

        public MyEventArgs()
        { }
    }

    // 参数都是字符串
    public delegate void EatHandler(string msg);    // 实例1: 1. 定义委托

    public delegate void EatAndSleepHandler(string msg, string msg1);   // 实例2: 1. 定义委托

    // 有一个参数是类（就可以把类本身传进去）
    public delegate void ClassEvent(object sender, string msg); // 实例3: 1.定义委托

    // 两个参数都是类
    public delegate void TwoClassEvent(object sender, MyEventArgs myEventArgs);  // 实例4: 1.定义委托

    internal class Person
    {
        public event EatHandler EatEvent;    // 实例1：2.定义事件

        public event EatAndSleepHandler EatAndSleepEvent;   // 实例2：2.定义事件

        public event ClassEvent ClassEvent; // 实例3：2.定义事件

        public event TwoClassEvent TwoClassEvent;   // 实例4： 2.定义事件

        public Person()
        {
            //EatEvent?.Invoke("我饿了，想吃东西了");      // 不能在构造函数中立刻触发本身的事件！
            //因为事件是先触发后回调，类先实例化后就直接执行了构造函数，然后再去定义回调和执行回调就晚了。
            // 可以在子线程中晚点触发事件.

            // 实例1：4. 触发事件
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                EatEvent?.Invoke("我饿了");
            });

            // 实例2：4. 触发事件
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                EatAndSleepEvent?.Invoke("吃饱了", "我想睡觉了");
            });

            // 实例3：4.触发事件 , 类传回
            Task.Run((() =>
            {
                Thread.Sleep(5000);
                ClassEvent?.Invoke(this, "我把类本身当参数传出去了");
            }));

            // 实例4：4. 事件触发，传回两个类
            Task.Run((() =>
            {
                Thread.Sleep(8000);
                MyEventArgs myEventArgs = new MyEventArgs();
                myEventArgs.Id = 1;
                myEventArgs.Name = "张四";
                TwoClassEvent?.Invoke(this, myEventArgs);
            }));
        }
    }
}