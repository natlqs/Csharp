using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketProject
{
    public partial class FrmTCPClient : Form
    {
        public FrmTCPClient()
        {
            InitializeComponent();
            this.Load += FrmTCPClient_Load; //动态实现第二列的宽度
        }

        private void FrmTCPClient_Load(object sender, EventArgs e)
        {
            // 设置ListView第二列的宽度
            this.Lst_Receive.Columns[1].Width = this.Lst_Receive.ClientSize.Width - this.Lst_Receive.Columns[0].Width;
        }

        /*
        客户端程序编写步骤：
        第一步：调用Socket()函数创建一个用于通信的套接字
        第二步：通过设置套接字地址结构，说明客户端与之通信的服务器的IP地址和端口号
        第三步：调用Connect()函数来建立与服务器的连接
        第四步：调用读写函数发送或者接收数据
        第五步：终止连接
         */

        private Socket socketClient;


#region 连接服务器
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            AddLog(0, "与服务器连接中");
            //第一步：调用Socket()函数创建一个用于通信的套接字
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //第二步：通过设置套接字地址结构，说明客户端与之通信的服务器的IP地址和端口号
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(this.text_IP.Text.Trim()),int.Parse(this.text_Port.Text.Trim()));

            //第三步：调用Connect()函数来建立与服务器的连接
            try
            {
                socketClient.Connect(ipe);
            }
            catch (Exception ex)
            {
                AddLog(2, "与服务器连接失败" + ex.Message);
                return;
            }

            Task.Run(new Action(() =>
            {
                CheckReceiveMsg();
            }));


            AddLog(0, "与服务器连接成功");
            this.btn_Connect.Enabled = false;
        }
#endregion

#region 多线程接收数据
        private void CheckReceiveMsg()
        {
            while (true)
            {
                //创建一个缓冲区
                byte[] buffer = new byte[1024 * 1024 * 10];
                int length = -1;
                // 第四步：调用读写函数发送或者接收数据。
                try
                {
                    length = socketClient.Receive(buffer);

                }
                catch (Exception)
                {
                    try
                    {
                    AddLog(2, "服务器断开连接");
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                }
                if(length>0)
                {
                    //处理
                    string msg = Encoding.Default.GetString(buffer, 0, length);
                    AddLog(0, "来自服务器：" + msg);
                }
                else
                {
                    AddLog(2, "服务器断开连接");
                    break;
                }
            }
        }
#endregion

#region 接收信息的方法
        /// <summary>
        /// 当前时间属性
        /// </summary>
        private string CurrentTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"); }
        }
        private void AddLog(int index, string info)
        {
            if (!this.Lst_Receive.InvokeRequired)
            {
                ListViewItem lst = new ListViewItem(" " + CurrentTime, index);
                lst.SubItems.Add(info);
                Lst_Receive.Items.Insert(0, lst);
            }
            else
            {
                Invoke(new Action(() =>
                {
                    ListViewItem lst = new ListViewItem("  " + CurrentTime, index);
                    lst.SubItems.Add(info);
                    Lst_Receive.Items.Insert(0, lst);
                }));
            }
        }
#endregion

#region 窗体关闭
        private void FrmTCPClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            socketClient?.Close();
        }
#endregion


        private void btn_Send_all_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Message_Click(object sender, EventArgs e)
        {

        }

        private void btn_Client_Click(object sender, EventArgs e)
        {

        }

        private void btn_StartService_Click(object sender, EventArgs e)
        {

        }

#region 断开服务器
        private void btn_Disconn_Click(object sender, EventArgs e)
        {
            socketClient?.Close();
            this.btn_Connect.Enabled = true;
        }
#endregion

#region 发送ASCII
        private void btn_Send_ASCII_Click(object sender, EventArgs e)
        {
            AddLog(0, "发送内容：" + this.text_Sender.Text.Trim());

            // 编码为ASCII格式
            byte[] send = Encoding.ASCII.GetBytes(this.text_Sender.Text.Trim());    

            // 创建最终要发送的数组, 比要发送的数据长1个字节，多出来的一个字节用来放编码格式
            byte[] sendMsg = new byte[send.Length + 1];                         

            // 整体拷贝数组
            Array.Copy(send, 0, sendMsg, 1, send.Length);
            
            // 给首字节赋值
            sendMsg[0] = (byte)MessageType.ASCII;
            socketClient?.Send(sendMsg);
            this.text_Sender.Clear();
        }

#endregion

#region 发送UTF8
        private void btn_Send_UTF8_Click(object sender, EventArgs e)
        {
            AddLog(0, "发送内容：" + this.text_Sender.Text.Trim());

            // 编码为UTF8格式
            byte[] send = Encoding.UTF8.GetBytes(this.text_Sender.Text.Trim());    

            // 创建最终要发送的数组, 比要发送的数据长1个字节，多出来的一个字节用来放编码格式
            byte[] sendMsg = new byte[send.Length + 1];                         

            // 整体拷贝数组
            Array.Copy(send, 0, sendMsg, 1, send.Length);
            
            // 给首字节赋值
            sendMsg[0] = (byte)MessageType.UTF8;
            socketClient?.Send(sendMsg);
            this.text_Sender.Clear();
 
        }
#endregion

#region 发送Hex
        private void btn_Send_Hex_Click(object sender, EventArgs e)
        {
            AddLog(0, "发送内容：" + this.text_Sender.Text.Trim());

            // 编码为Hex格式
            byte[] send = Encoding.Default.GetBytes(this.text_Sender.Text.Trim());    

            // 创建最终要发送的数组, 比要发送的数据长1个字节，多出来的一个字节用来放编码格式
            byte[] sendMsg = new byte[send.Length + 1];                         

            // 整体拷贝数组
            Array.Copy(send, 0, sendMsg, 1, send.Length);
            
            // 给首字节赋值
            sendMsg[0] = (byte)MessageType.Hex;
            socketClient?.Send(sendMsg);
            this.text_Sender.Clear();
        }
        #endregion

#region 选择文件
        private void btn_Select_File_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            //设置默认的路径
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.text_File.Text = ofd.FileName;
                AddLog(0, "选择文件：" + this.text_File.Text);
            }
        }
        #endregion

        #region 发送文件
        private void btn_Send_File_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.text_File.Text))
            {
                MessageBox.Show("请先选择你要发送的文件路径", "发送文件");
                return;
            }
            else
            {
                //发送两次
                using (FileStream fs = new FileStream(this.text_File.Text, FileMode.Open))
                {
                    // 第一次发送文件名称
                    //获取文件名称
                    string filename = Path.GetFileName(this.text_File.Text);
                    // 获取后缀名
                    string fileExtension = Path.GetExtension(this.text_File.Text);

                    string strMsg = "发送文件：" + filename + "." + fileExtension;

                    byte[] send1 = Encoding.UTF8.GetBytes(strMsg);

                    byte[] send1Msg = new byte[send1.Length + 1];

                    Array.Copy(send1, 0, send1Msg, 1, send1.Length);

                    send1Msg[0] = (byte)MessageType.UTF8;

                    socketClient?.Send(send1Msg);

                    // 第二次发送文件内容
                    byte[] send2 = new byte[1024 * 1024 * 10];
                    // 有效长度
                    int length = fs.Read(send2, 0, send2.Length);

                    byte[] send2Msg = new byte[length  + 1];

                    Array.Copy(send2, 0, send2Msg, 1, length);

                    send2Msg[0] = (byte)MessageType.File;

                    socketClient?.Send(send2Msg);

                    this.text_File.Clear();
                    AddLog(0, strMsg);
                }
            }
        }
 
        #endregion
   }
}
