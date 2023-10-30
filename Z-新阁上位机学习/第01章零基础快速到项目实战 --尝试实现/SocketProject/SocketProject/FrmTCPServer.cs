using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SocketProject
{
    public enum MessageType
    {
        ASCII,
        UTF8,
        Hex,
        File,
        JSON
    }
    public partial class FrmTCPServer : Form
    {
        public FrmTCPServer()
        {
            InitializeComponent();
            this.Load += FrmTCPServer_Load; //动态实现第二列的宽度
        }

        private void FrmTCPServer_Load(object sender, EventArgs e)
        {
            // 设置ListView第二列的宽度
            this.Lst_Receive.Columns[1].Width = this.Lst_Receive.ClientSize.Width - this.Lst_Receive.Columns[0].Width;
        }


        // 申明一个Socket对象
        private Socket socketServer;

        //创建字典集合，键是ClientIp, 值是SocketClient
        private Dictionary<string, Socket> CurrentClientlist= new Dictionary<string, Socket>();

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartService_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Engine Start", "Start");
            // 第一步：调用Socket()函数创建一个用于通信的套接字
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 第二部： 给已经创建的套接字绑定一个端口号，这一版通过设置网络套接接口地址和调用bind（）函数实现
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(this.text_IP.Text), int.Parse(this.text_Port.Text));

            try
            {
                socketServer.Bind(ipe);
            }
            catch (Exception ex)
            {
                // 写入日志
                AddLog(2, "服务器开启失败: " + ex.Message);
                return;
            }

            // 第三步：调用listen()函数使套接字成为一个监听套接字。
            socketServer.Listen(10);    // 缓冲池的大小，不是同时连接数的大小


            // 创建一个监听的线程
            Task.Run(new Action(() =>
            {
                CheckListening();
            }));
            AddLog(0, "服务器开启成功");
            this.btn_StartService.Enabled = false;
        }

        /// <summary>
        /// 检查监听的线程方法体
        /// </summary>
        private void CheckListening()
        {
            while (true)
            {
                // 第四步： 调用accept（）函数来接受客户端的连接，这时就可以和客户端通信了
                Socket socketClient = socketServer.Accept();

                string client = socketClient.RemoteEndPoint.ToString();
                CurrentClientlist.Add(client, socketClient);
                AddLog(0, client+"上线了");
                UpdateOnline(client, true);

                Task.Run(new Action(() =>
                {
                    ReceiveMessage(socketClient);
                }));
            }
        }

        #region 多线程接收数据
        /// <summary>
        /// 接受客户端数据的方法体
        /// </summary>
        /// <param name="socketClient"></param>
        private void ReceiveMessage(Socket socketClient)
        {
            while (true)
            {
                // 创建一个缓冲区
                byte[] buffer = new byte[1024 * 1024 * 10];
                int length = -1;
                string client = socketClient.RemoteEndPoint.ToString();
                // 第五步：处理客户端的连接请求。
                try
                {
                    length = socketClient.Receive(buffer);
                }
                catch (Exception ex)
                {
                    UpdateOnline(client, false);
                    AddLog(0, client + "意外下线了"+ex);
                    CurrentClientlist.Remove(client);
                    break;
                }


                string msg = string.Empty;
                if (length > 0)
                {
                    MessageType type = (MessageType)buffer[0];
                    switch (type)
                    {
                        case MessageType.ASCII:
                            msg = Encoding.ASCII.GetString(buffer, 1, length-1);
                            AddLog(0, client + ": " + msg);
                            break;
                        case MessageType.UTF8:
                            msg = Encoding.UTF8.GetString(buffer, 1, length-1);
                            AddLog(0, client + ": " + msg);
                            break;
                        case MessageType.Hex:
                             msg = HexGetString(buffer, 1, length-1);
                            AddLog(0, client + ": " + msg);
                            break;
                        case MessageType.File:
                            break;
                        case MessageType.JSON:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    UpdateOnline(client, false);
                    AddLog(0, client + "下线了");
                    CurrentClientlist.Remove(client);
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

        #region  在线列表更新
        private void UpdateOnline(string client, bool operate)
        {
            if (!this.list_Online.InvokeRequired)
            {
                if (operate)
                {
                    this.list_Online.Items.Add(client);
                }
                else
                {
                    foreach (var item in this.list_Online.Items)
                    {
                        if (item.ToString()== client)
                        {
                            this.list_Online.Items.Remove(item);
                            break;
                        }
                    }
                }
            }
            else
            {
                Invoke(new Action(() =>
                {
                    if (operate)
                    {
                        this.list_Online.Items.Add(client);
                    }
                    else
                    {
                        foreach (string item in this.list_Online.Items)
                        {
                            if (item == client)
                            {
                                this.list_Online.Items.Remove(item);
                                break;
                            }
                        }
                    }
                }));
            }
        }



        #endregion

        #region 发送信息
        private void btn_Send_Message_Click(object sender, EventArgs e)
        {
            if(this.list_Online.SelectedItems != null)
            {
                foreach(var item in this.list_Online.SelectedItems)
                {
                    string client = item.ToString();
                    CurrentClientlist[client].Send(Encoding.Default.GetBytes(this.text_Sender.Text.Trim()));

                }
                AddLog(0, "发送内容："+this.text_Sender.Text.Trim());

            }
            else
            {
                MessageBox.Show("请选择你要发送的客户端对象!");
            }

        }
        #endregion

        #region 16进制字符串处理
        private string HexGetString(byte[] buffer, int start, int length)
        {
            string result = string.Empty;
            if (buffer != null && buffer.Length >= start + length)
            {
                // 截取字节数组
                byte[] res = new byte[length];
                Array.Copy(buffer, start, res, 0, length);
                string Hex = Encoding.Default.GetString(res, 0, res.Length);
                if (Hex.Contains(" "))
                {
                    string[] str = Regex.Split(Hex, "\\s+", RegexOptions.IgnoreCase);
                    foreach (var item in str)
                    {
                        result += "0x" + item + " ";
                    }
                }
                else
                {
                    result += "0x" + Hex;
                }
            }
            else
            {
                result = "Error";
            }
            return result;
        }
        #endregion

        #region 发送信息给所有客户端
        private void btn_Send_all_Click(object sender, EventArgs e)
        {
            if(this.list_Online.Items.Count > 0)
            {
                foreach (string item in this.list_Online.Items)
                {
                    CurrentClientlist[item].Send(Encoding.Default.GetBytes(this.text_Sender.Text.Trim()));
                }
            }
            else
            {
                MessageBox.Show("当前连接的客户端对象数量为0！","发送消息");
            }
        }
        #endregion

        private void btn_Client_Click(object sender, EventArgs e)
        {
            new FrmTCPClient().Show();

        }
    }
}
