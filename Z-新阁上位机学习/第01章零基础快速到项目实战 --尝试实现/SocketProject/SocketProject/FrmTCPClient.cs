using System;
using System.Collections.Generic;
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
                    AddLog(2, "服务器断开连接");
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

        #region 发送消息
        private void btn_SendMsg_Click(object sender, EventArgs e)
        {
            AddLog(0, "发送内容：" + this.text_Sender.Text.Trim());
            socketClient?.Send(Encoding.Default.GetBytes(this.text_Sender.Text.Trim()));

 
        }
        #endregion

        private void FrmTCPClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            socketClient?.Close();

        }
    }
}
