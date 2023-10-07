      /*
             *1.定义委托
             *2.定义事件
             *3.注册事件
             *4.触发事件
             *5.定义回调
             *6.执行回调
             */

namespace _14_Event_事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Person person = new Person();
            person.EatEvent += Person_EatEvent;     // 实例1：3.(订阅)注册事件
            person.EatAndSleepEvent += Person_EatAndSleepEvent;    // 实例2：3.(订阅)注册事件


            person.ClassEvent += Person_ClassEvent;     // 实例3：3.(订阅)注册事件

            person.TwoClassEvent += Person_TwoClassEvent;   // 实例4：3.(订阅)注册事件

              }


        // 实例1：5. 定义回调
        private void Person_EatEvent(string msg)
        {
            // 实例1：6.执行回调
            MessageBox.Show("张三说" + msg);
        }
        
        // 实例2：5. 定义回调
        private void Person_EatAndSleepEvent(string msg, string msg1)
        {
            // 实例2：6.执行回调
            MessageBox.Show("张三说" + msg + msg1);
        }

        // 实例3：5. 定义回调
        private void Person_ClassEvent(object sender, string msg)
        {
            // 实例3：6. 执行回调  , 此时sender就是触发事件里发送过来的类
            if(sender is  Person)
            {
                MessageBox.Show("我收到传过来的类啦！");
            }
        }

        // 实例4：5. 定义回调
        private void Person_TwoClassEvent(object sender, MyEventArgs myEventArgs)
        {
            // 实例4：6. 执行回调  , 此时sender就是触发事件里发送过来的类, myEventArgs就是传过来的第二个类
            if(sender is  Person)
            {
                MessageBox.Show("张三说：" + myEventArgs.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你单击我了");
        }
    }
}