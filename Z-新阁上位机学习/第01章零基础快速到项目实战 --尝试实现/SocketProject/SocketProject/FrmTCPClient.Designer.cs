namespace SocketProject
{
    partial class FrmTCPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTCPClient));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.text_File = new System.Windows.Forms.TextBox();
            this.text_Sender = new System.Windows.Forms.TextBox();
            this.Lst_Receive = new System.Windows.Forms.ListView();
            this.InfoTme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.text_UserName = new System.Windows.Forms.TextBox();
            this.btn_SendJson = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP传输客户端";
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
            this.splitContainer1.Panel2.Controls.Add(this.text_UserName);
            this.splitContainer1.Panel2.Controls.Add(this.btn_SendJson);
            this.splitContainer1.Panel2.Controls.Add(this.btn_SendFile);
            this.splitContainer1.Panel2.Controls.Add(this.btn_SendMsg);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Connect);
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
            // text_UserName
            // 
            this.text_UserName.Location = new System.Drawing.Point(112, 139);
            this.text_UserName.Name = "text_UserName";
            this.text_UserName.Size = new System.Drawing.Size(234, 24);
            this.text_UserName.TabIndex = 4;
            this.text_UserName.Text = "natlqs";
            // 
            // btn_SendJson
            // 
            this.btn_SendJson.Location = new System.Drawing.Point(86, 467);
            this.btn_SendJson.Name = "btn_SendJson";
            this.btn_SendJson.Size = new System.Drawing.Size(184, 49);
            this.btn_SendJson.TabIndex = 3;
            this.btn_SendJson.Text = "发送JSON对象";
            this.btn_SendJson.UseVisualStyleBackColor = true;
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(86, 376);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(184, 49);
            this.btn_SendFile.TabIndex = 3;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(86, 289);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(184, 49);
            this.btn_SendMsg.TabIndex = 3;
            this.btn_SendMsg.Text = "发送消息";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.btn_SendMsg_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(86, 205);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(184, 49);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "连接服务器";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "用户名称：";
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
            this.text_IP.Size = new System.Drawing.Size(234, 24);
            this.text_IP.TabIndex = 0;
            this.text_IP.Text = "127.0.0.1";
            // 
            // FrmTCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmTCPClient";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 基于Socket实现的TCP服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTCPClient_FormClosing);
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
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.ColumnHeader InfoTme;
        private System.Windows.Forms.ColumnHeader Info;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox text_UserName;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_SendMsg;
        private System.Windows.Forms.Button btn_SendJson;
    }
}

