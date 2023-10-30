namespace SocketProject
{
    partial class FrmTCPServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTCPServer));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.text_File = new System.Windows.Forms.TextBox();
            this.text_Sender = new System.Windows.Forms.TextBox();
            this.Lst_Receive = new System.Windows.Forms.ListView();
            this.InfoTme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btn_Send_File = new System.Windows.Forms.Button();
            this.btn_Send_all = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Send_Message = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.btn_StartService = new System.Windows.Forms.Button();
            this.list_Online = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_IP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP传输服务器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 98);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.text_File);
            this.splitContainer1.Panel1.Controls.Add(this.text_Sender);
            this.splitContainer1.Panel1.Controls.Add(this.Lst_Receive);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_File);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_all);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_Message);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Client);
            this.splitContainer1.Panel2.Controls.Add(this.btn_StartService);
            this.splitContainer1.Panel2.Controls.Add(this.list_Online);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.text_Port);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.text_IP);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 542);
            this.splitContainer1.SplitterDistance = 684;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // text_File
            // 
            this.text_File.Location = new System.Drawing.Point(10, 492);
            this.text_File.Name = "text_File";
            this.text_File.Size = new System.Drawing.Size(423, 24);
            this.text_File.TabIndex = 2;
            // 
            // text_Sender
            // 
            this.text_Sender.Location = new System.Drawing.Point(10, 317);
            this.text_Sender.Multiline = true;
            this.text_Sender.Name = "text_Sender";
            this.text_Sender.Size = new System.Drawing.Size(664, 150);
            this.text_Sender.TabIndex = 1;
            // 
            // Lst_Receive
            // 
            this.Lst_Receive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InfoTme,
            this.Info});
            this.Lst_Receive.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lst_Receive.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Lst_Receive.HideSelection = false;
            this.Lst_Receive.Location = new System.Drawing.Point(10, 10);
            this.Lst_Receive.Margin = new System.Windows.Forms.Padding(10);
            this.Lst_Receive.Name = "Lst_Receive";
            this.Lst_Receive.Size = new System.Drawing.Size(664, 294);
            this.Lst_Receive.SmallImageList = this.imageList;
            this.Lst_Receive.TabIndex = 0;
            this.Lst_Receive.UseCompatibleStateImageBehavior = false;
            this.Lst_Receive.View = System.Windows.Forms.View.Details;
            // 
            // InfoTme
            // 
            this.InfoTme.Text = "日志时间";
            this.InfoTme.Width = 200;
            // 
            // Info
            // 
            this.Info.Text = "日志信息";
            this.Info.Width = 200;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "info.ico");
            this.imageList.Images.SetKeyName(1, "warning.ico");
            this.imageList.Images.SetKeyName(2, "error.ico");
            // 
            // btn_Send_File
            // 
            this.btn_Send_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Send_File.Location = new System.Drawing.Point(198, 417);
            this.btn_Send_File.Name = "btn_Send_File";
            this.btn_Send_File.Size = new System.Drawing.Size(126, 48);
            this.btn_Send_File.TabIndex = 3;
            this.btn_Send_File.Text = "发送文件";
            this.btn_Send_File.UseVisualStyleBackColor = false;
            // 
            // btn_Send_all
            // 
            this.btn_Send_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Send_all.Location = new System.Drawing.Point(198, 476);
            this.btn_Send_all.Name = "btn_Send_all";
            this.btn_Send_all.Size = new System.Drawing.Size(126, 48);
            this.btn_Send_all.TabIndex = 3;
            this.btn_Send_all.Text = "群发消息";
            this.btn_Send_all.UseVisualStyleBackColor = false;
            this.btn_Send_all.Click += new System.EventHandler(this.btn_Send_all_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(34, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "发送JSON";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_Send_Message_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(34, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "发送Hex";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_Send_Message_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(198, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "发送UTF8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Send_Message_Click);
            // 
            // btn_Send_Message
            // 
            this.btn_Send_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Send_Message.Location = new System.Drawing.Point(34, 359);
            this.btn_Send_Message.Name = "btn_Send_Message";
            this.btn_Send_Message.Size = new System.Drawing.Size(126, 48);
            this.btn_Send_Message.TabIndex = 3;
            this.btn_Send_Message.Text = "发送ASCII";
            this.btn_Send_Message.UseVisualStyleBackColor = false;
            this.btn_Send_Message.Click += new System.EventHandler(this.btn_Send_Message_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.BackColor = System.Drawing.Color.Cyan;
            this.btn_Client.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client.Location = new System.Drawing.Point(198, 292);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(136, 52);
            this.btn_Client.TabIndex = 3;
            this.btn_Client.Text = "启用客户端";
            this.btn_Client.UseVisualStyleBackColor = false;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // btn_StartService
            // 
            this.btn_StartService.BackColor = System.Drawing.Color.Lime;
            this.btn_StartService.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartService.Location = new System.Drawing.Point(24, 292);
            this.btn_StartService.Name = "btn_StartService";
            this.btn_StartService.Size = new System.Drawing.Size(136, 52);
            this.btn_StartService.TabIndex = 3;
            this.btn_StartService.Text = "启动服务";
            this.btn_StartService.UseVisualStyleBackColor = false;
            this.btn_StartService.Click += new System.EventHandler(this.btn_StartService_Click);
            // 
            // list_Online
            // 
            this.list_Online.FormattingEnabled = true;
            this.list_Online.ItemHeight = 17;
            this.list_Online.Location = new System.Drawing.Point(17, 171);
            this.list_Online.Name = "list_Online";
            this.list_Online.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_Online.Size = new System.Drawing.Size(329, 106);
            this.list_Online.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "在线列表：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "服务器端口：";
            // 
            // text_Port
            // 
            this.text_Port.Location = new System.Drawing.Point(112, 81);
            this.text_Port.Name = "text_Port";
            this.text_Port.ReadOnly = true;
            this.text_Port.Size = new System.Drawing.Size(234, 24);
            this.text_Port.TabIndex = 0;
            this.text_Port.Text = "8001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务器IP地址：";
            // 
            // text_IP
            // 
            this.text_IP.Location = new System.Drawing.Point(112, 22);
            this.text_IP.Name = "text_IP";
            this.text_IP.ReadOnly = true;
            this.text_IP.Size = new System.Drawing.Size(234, 24);
            this.text_IP.TabIndex = 0;
            this.text_IP.Text = "127.0.0.1";
            // 
            // FrmTCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmTCPServer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 基于Socket实现的TCP服务器";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox text_Sender;
        private System.Windows.Forms.ListView Lst_Receive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_File;
        private System.Windows.Forms.Button btn_Send_File;
        private System.Windows.Forms.Button btn_Send_all;
        private System.Windows.Forms.Button btn_Send_Message;
        private System.Windows.Forms.Button btn_StartService;
        private System.Windows.Forms.ListBox list_Online;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.ColumnHeader InfoTme;
        private System.Windows.Forms.ColumnHeader Info;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

