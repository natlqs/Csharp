using System.ComponentModel;

namespace _19_3_多线程_进度条
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;     // 是否报告当前线程运行状态报告出来
            backgroundWorker1.WorkerSupportsCancellation = true;    // 是否可以取消
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // 新线程，新任务
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 1; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;        // 更改运行返回状态
                    break;
                }
                else
                {
                    Thread.Sleep(50);       // 实际编码时，替换为工作代码
                    //worker.ReportProgress(i);     // 只报告i

                    var data = Tuple.Create("zhangsan", true, 22);
                    worker.ReportProgress(i, data);     // 报告i 和想要返回的数据
                }
            }
            e.Result = e.Argument;
        }

        /// <summary>
        /// 开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)           // 检查组件是否忙
            {
                //backgroundWorker1.RunWorkerAsync();
                backgroundWorker1.RunWorkerAsync("元宝");     // 以异步的方法启动组件，组件的启动的方法，一个有参数，一个没有参数，
            }
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)        // 检查组件是否支持取消
            {
                backgroundWorker1.CancelAsync();            // 取消，异步方法
            }
        }

        /// <summary>
        /// 进度变化事件处理方法,是异步的，在创建BackgroundWorker线程上执行,和引发事件的代码不在同一个线程上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage; // 显示任务进度
            resultLabel.Text = ("当前进度：" + e.ProgressPercentage.ToString() + "%");        // 显示百分比进度

            Tuple<string, bool, int>? data = (Tuple<string, bool, int>?)e.UserState;
            label2.Text = $"{data.Item1}, {data.Item2}, {data.Item3}";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                label3.Text = "canceled!";
            }
            else if (e.Error != null)
            {
                label3.Text = "Error" + e.Error.Message;
            }
            else
            {
                label3.Text = "Done! Result= " + e.Result;
            }

        }
    }
}