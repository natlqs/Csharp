using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBasic
{
    public partial class SerialSetting : Form
    {
        public SerialSetting()
        {
            InitializeComponent();
        }

        private void SerialSetting_Load(object sender, EventArgs e)
        {
            //int i;
            //{
             //   comboBox_ComNum.Items.Add(i.ToString());        // 添加波特率列表
            //}
            string[] baud = { "4800", "9600","19200","38400","43000", "56000", "576000", "115200", "128000", "230400", "256000", "460800" };
            comboxBox_Baudrate.Items.AddRange(baud);

            comboBox_ComNum.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            // 设置默认值
            comboBox_ComNum.Text = "COM3";
            comboxBox_Baudrate.Text = "115200";
            comboBoxDataBits.Text = "8";
            comboBoxCheckBits.Text = "Even";
            comboBoxStopBits.Text = "1";
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            try
            {
                // 将可能产生一次的代码放置在try中
                //根据当前串口属性来拍段是否打开
                if (serialPort1.IsOpen)
                {
                    // 串口以及处于打开状态
                    serialPort1.Close();    //关闭窗口
                    btnOpenCom.Text = "打开串口";
                    btnOpenCom.BackColor = Color.ForestGreen;
                    comboBox_ComNum.Enabled = true;
                    comboxBox_Baudrate.Enabled = true;
                    comboBoxDataBits.Enabled = true;
                    comboBoxCheckBits.Enabled = true;
                    comboBoxStopBits.Enabled = true;
                    btnCloseCom.Enabled = false;
                    SerialReceive.Text = "";
                }
                else
                {
                    // 串口已处于关闭状态，则设置好串口属性后打开
                    comboBox_ComNum.Enabled = false;
                    comboxBox_Baudrate.Enabled = false;
                    comboBoxDataBits.Enabled = false;
                    comboBoxCheckBits.Enabled = false;
                    comboBoxStopBits.Enabled = false;
                    btnCloseCom.Enabled = true;
                    btnOpenCom.Text = "关闭端口";
                    btnOpenCom.BackColor = Color.Firebrick;
                    btnOpenCom.Enabled = true;
                    serialPort1.PortName = comboBox_ComNum.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboxBox_Baudrate.Text);
                    serialPort1.DataBits = Convert.ToInt16(comboBoxDataBits.Text);

                    if (comboBoxCheckBits.Text.Equals("None"))
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                    else if (comboBoxCheckBits.Text.Equals("Odd"))
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    else if (comboBoxCheckBits.Text.Equals("Even"))
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                    else if (comboBoxCheckBits.Text.Equals("Mark"))
                        serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    else if (comboBoxCheckBits.Text.Equals("Space"))
                        serialPort1.Parity = System.IO.Ports.Parity.Space;

                    if (comboBoxStopBits.Text.Equals("1"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    else if (comboBoxStopBits.Text.Equals("1.5"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    else if (comboBoxStopBits.Text.Equals("2"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    serialPort1.Open(); //打开串口
                    btnCloseCom.BackColor = Color.Firebrick;
                }
            }
            catch (Exception ex)
            {
                // 捕获可能发生的异常并进行处理
                // 捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                // 刷新COM口选项
                comboBox_ComNum.Items.Clear();
                comboBox_ComNum.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                // 响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                btnOpenCom.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                comboBox_ComNum.Enabled = true;
                comboxBox_Baudrate.Enabled = true;
                comboBoxDataBits.Enabled = true;
                comboBoxCheckBits.Enabled = true;
                comboBoxStopBits.Enabled = true;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //因为要访问UI资源，所以需要使用invoke方法同步UI
                this.Invoke((EventHandler)(delegate
                {
                    //this.SerialReceive.Items.Add(serialPort1.ReadExisting());
                    //Console.WriteLine(serialPort1.ReadExisting());
                    TextSerialReceived.AppendText(serialPort1.ReadExisting());
                }
                    )
                );
            }
            catch (Exception ex)
            {
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
