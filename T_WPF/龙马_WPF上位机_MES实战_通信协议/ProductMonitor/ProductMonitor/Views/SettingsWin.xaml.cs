using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProductMonitor.Views
{
    /// <summary>
    /// SettingWin.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsWin : Window
    {
        public SettingsWin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 定位到配置页面相应的标题位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            string tag = "";
            var btn = sender as RadioButton;
            if (btn != null)
            {
                tag = btn.Tag.ToString();
            }
            // 程序集（授权） 路径
            // # 表示定位到片段
            frame.Navigate(new Uri("pack://application:,,,/ProductMonitor;component/Views/SettingsPage.xaml#" + tag, UriKind.RelativeOrAbsolute));

            // 如果要引用的资源都在一个文件夹，就可以简写成如下内容
            //frame.Navigate(new Uri("pack://application:,,,/Views/SettingsPage.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
