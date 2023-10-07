namespace _19_2_多线程基础_Thread_Task_async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// 单线程，同时只能做1件事，比如在做素菜的时候就不能做其他事，包括移动窗口
            Thread.Sleep(3000);         // 这个线程要暂停3秒
            MessageBox.Show("素菜做好了", "提示");
            Thread.Sleep(5000);
            MessageBox.Show("荤菜做好了", "提示");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /// 将任务包装到单独的线程中，子线程运行时不影响其他线程运行
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(3000);         // 这个线程要暂停3秒
                MessageBox.Show("素菜做好了", "提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "提示");
            });
            thread.Start();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /// 通过Task任务方式，效果和创建子线程一样, Task底层也是Thread，但是提供很多方法方便管理, 性能更好，管理更方便
            Task.Run(() =>
            {
                Thread.Sleep(3000);         // 这个线程要暂停3秒
                MessageBox.Show("素菜做好了", "提示");
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "提示");
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /// 同时处理多个任务，创建多个Task
            Task.Run(() =>
            {
                Thread.Sleep(3000);         // 这个线程要暂停3秒
                MessageBox.Show("素菜做好了", "提示");
            });
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "提示");
            });
        }

        //private async void button4_Click(object sender, EventArgs e)
        //{
        //    ///  await 关键字是等待任务完成后才会执行后面的程序，async是异步，表示和主界面不是一个线程，不会卡主界面 
        //    ///  但是当有多个任务时，多个任务会一个一个执行
        //    await Task.Run(() =>                
        //    {
        //        Thread.Sleep(3000);         // 这个线程要暂停3秒
        //        MessageBox.Show("素菜做好了", "提示");
        //    });
        //    await Task.Run(() =>                
        //    {
        //        Thread.Sleep(5000);
        //        MessageBox.Show("荤菜做好了", "提示");
        //    });
        //    MessageBox.Show("菜都做好了，大家快来吃饭！","提示");
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            /// 创建一个任务列表，等所有任务结束再执行需要执行的任务，任务列表里的任务会同时执行，相当于若干个子线程
            List<Task> tasks = new List<Task>();   // 创建一个任务列表, 将 
            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(3000);         // 这个线程要暂停3秒
                MessageBox.Show("素菜做好了", "提示");
            }));
            tasks.Add(Task.Run(() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("荤菜做好了", "提示");
            }));
            Task.WhenAll(tasks).ContinueWith(t =>
            {
                MessageBox.Show("菜都做好了，大家快来吃饭！", "提示");
            });
        }
    }
}