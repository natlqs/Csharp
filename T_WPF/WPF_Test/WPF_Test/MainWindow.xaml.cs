﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private DispatcherTimer ShowTimer;

        public MainWindow()
        {
            InitializeComponent();
            //ShowTime();    //在这里窗体加载的时候不执行文本框赋值，窗体上不会及时的把时间显示出来，而是等待了片刻才显示了出来

            DispatcherTimer ShowTimer = new System.Windows.Threading.DispatcherTimer();

            ShowTimer.Tick += new EventHandler(ShowCurTimer);//起个Timer一直获取当前时间

            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);

            ShowTimer.Start();
        }
        public void ShowCurTimer(object sender, EventArgs e)

        {

            ShowTime();

        }

        //ShowTime方法

        private void ShowTime()
        {
            //获得年月日
            this.tbDateText.Text = DateTime.Now.ToString("yyyy/MM/dd");   //yyyy/MM/dd
            //获得时分秒
            this.tbTimeText.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}