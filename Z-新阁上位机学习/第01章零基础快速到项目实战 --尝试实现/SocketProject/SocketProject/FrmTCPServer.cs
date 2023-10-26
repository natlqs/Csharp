using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace SocketProject
{
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
                Socket socketClient =  socketServer.Accept();

                string client = socketClient.RemoteEndPoint.ToString();
                UpdateOnline(client, true);

                Task.Run(new Action(() =>
                {
                    ReceiveMessage(socketClient);
                }));
            }
        }

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
                // 第五步：处理客户端的连接请求。
                try
                {
                length = socketClient.Receive(buffer);
                }
                catch (Exception ex)
                {
                    AddLog(2, "服务器开启失败: " + ex.Message);
                }
                if (length > 0)
                {
                    //处理
                }
                else
                {
                    UpdateOnline(socketClient.RemoteEndPoint.ToString(), false);
                }
            }
        }


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
            if(!this.Lst_Receive.InvokeRequired)
            {
                ListViewItem lst = new ListViewItem(" "+ CurrentTime, index);
                lst.SubItems.Add(info);
                Lst_Receive.Items.Insert(0, lst);
            }
            else
            {
                Invoke(new Action(() =>
                {
                    ListViewItem lst = new ListViewItem("  "+ CurrentTime, index);
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
                if(operate)
                {
                    this.list_Online.Items.Add(client);
                }
                else
                {
                    foreach(var item in this.list_Online.Items)
                    {
                        if(item == client)
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

    }
}
