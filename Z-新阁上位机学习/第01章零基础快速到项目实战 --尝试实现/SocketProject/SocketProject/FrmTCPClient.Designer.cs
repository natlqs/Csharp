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
            this.btn_Select_File = new System.Windows.Forms.Button();
            this.text_File = new System.Windows.Forms.TextBox();
            this.text_Sender = new System.Windows.Forms.TextBox();
            this.Lst_Receive = new System.Windows.Forms.ListView();
            this.InfoTme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btn_Send_File = new System.Windows.Forms.Button();
            this.btn_Send_all = new System.Windows.Forms.Button();
            this.btn_Send_JSON = new System.Windows.Forms.Button();
            this.btn_Send_Hex = new System.Windows.Forms.Button();
            this.btn_Send_UTF8 = new System.Windows.Forms.Button();
            this.btn_Send_ASCII = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.text_UserName = new System.Windows.Forms.TextBox();
            this.btn_Disconn = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_Select_File);
            this.splitContainer1.Panel1.Controls.Add(this.text_File);
            this.splitContainer1.Panel1.Controls.Add(this.text_Sender);
            this.splitContainer1.Panel1.Controls.Add(this.Lst_Receive);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_File);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_all);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_JSON);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_Hex);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_UTF8);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send_ASCII);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.text_UserName);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Disconn);
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
            // btn_Select_File
            // 
            this.btn_Select_File.Location = new System.Drawing.Point(489, 492);
            this.btn_Select_File.Name = "btn_Select_File";
            this.btn_Select_File.Size = new System.Drawing.Size(126, 33);
            this.btn_Select_File.TabIndex = 3;
            this.btn_Select_File.Text = "选择文件";
            this.btn_Select_File.UseVisualStyleBackColor = true;
            this.btn_Select_File.Click += new System.EventHandler(this.btn_Select_File_Click);
            // 
            // text_File
            // 
            this.text_File.Location = new System.Drawing.Point(10, 492);
            this.text_File.Name = "text_File";
            this.text_File.Size = new System.Drawing.Size(423, 33);
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
            this.btn_Send_File.Location = new System.Drawing.Point(198, 387);
            this.btn_Send_File.Name = "btn_Send_File";
            this.btn_Send_File.Size = new System.Drawing.Size(126, 49);
            this.btn_Send_File.TabIndex = 3;
            this.btn_Send_File.Text = "发送文件";
            this.btn_Send_File.UseVisualStyleBackColor = false;
            this.btn_Send_File.Click += new System.EventHandler(this.btn_Send_File_Click);
            // 
            // btn_Send_all
            // 
            this.btn_Send_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Send_all.Location = new System.Drawing.Point(198, 476);
            this.btn_Send_all.Name = "btn_Send_all";
            this.btn_Send_all.Size = new System.Drawing.Size(126, 49);
            this.btn_Send_all.TabIndex = 3;
            this.btn_Send_all.Text = "群发消息";
            this.btn_Send_all.UseVisualStyleBackColor = false;
            // 
            // btn_Send_JSON
            // 
            this.btn_Send_JSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Send_JSON.Location = new System.Drawing.Point(34, 476);
            this.btn_Send_JSON.Name = "btn_Send_JSON";
            this.btn_Send_JSON.Size = new System.Drawing.Size(126, 49);
            this.btn_Send_JSON.TabIndex = 3;
            this.btn_Send_JSON.Text = "发送JSON";
            this.btn_Send_JSON.UseVisualStyleBackColor = false;
            this.btn_Send_JSON.Click += new System.EventHandler(this.btn_Send_JSON_Click);
            // 
            // btn_Send_Hex
            // 
            this.btn_Send_Hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Send_Hex.Location = new System.Drawing.Point(34, 387);
            this.btn_Send_Hex.Name = "btn_Send_Hex";
            this.btn_Send_Hex.Size = new System.Drawing.Size(126, 49);
            this.btn_Send_Hex.TabIndex = 3;
            this.btn_Send_Hex.Text = "发送Hex";
            this.btn_Send_Hex.UseVisualStyleBackColor = false;
            this.btn_Send_Hex.Click += new System.EventHandler(this.btn_Send_Hex_Click);
            // 
            // btn_Send_UTF8
            // 
            this.btn_Send_UTF8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Send_UTF8.Location = new System.Drawing.Point(198, 295);
            this.btn_Send_UTF8.Name = "btn_Send_UTF8";
            this.btn_Send_UTF8.Size = new System.Drawing.Size(126, 49);
            this.btn_Send_UTF8.TabIndex = 3;
            this.btn_Send_UTF8.Text = "发送UTF8";
            this.btn_Send_UTF8.UseVisualStyleBackColor = false;
            this.btn_Send_UTF8.Click += new System.EventHandler(this.btn_Send_UTF8_Click);
            // 
            // btn_Send_ASCII
            // 
            this.btn_Send_ASCII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Send_ASCII.Location = new System.Drawing.Point(34, 295);
            this.btn_Send_ASCII.Name = "btn_Send_ASCII";
            this.btn_Send_ASCII.Size = new System.Drawing.Size(126, 49);
            this.btn_Send_ASCII.TabIndex = 3;
            this.btn_Send_ASCII.Text = "发送ASCII";
            this.btn_Send_ASCII.UseVisualStyleBackColor = false;
            this.btn_Send_ASCII.Click += new System.EventHandler(this.btn_Send_ASCII_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "在线列表：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "服务器端口：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(234, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "8001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "服务器IP地址：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(234, 33);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "127.0.0.1";
            // 
            // text_UserName
            // 
            this.text_UserName.Location = new System.Drawing.Point(112, 139);
            this.text_UserName.Name = "text_UserName";
            this.text_UserName.Size = new System.Drawing.Size(234, 33);
            this.text_UserName.TabIndex = 4;
            this.text_UserName.Text = "natlqs";
            // 
            // btn_Disconn
            // 
            this.btn_Disconn.BackColor = System.Drawing.Color.Red;
            this.btn_Disconn.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disconn.Location = new System.Drawing.Point(198, 198);
            this.btn_Disconn.Name = "btn_Disconn";
            this.btn_Disconn.Size = new System.Drawing.Size(139, 66);
            this.btn_Disconn.TabIndex = 3;
            this.btn_Disconn.Text = "断开服务器";
            this.btn_Disconn.UseVisualStyleBackColor = false;
            this.btn_Disconn.Click += new System.EventHandler(this.btn_Disconn_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.Lime;
            this.btn_Connect.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(19, 198);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(141, 66);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "连接服务器";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "用户名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "服务器端口：";
            // 
            // text_Port
            // 
            this.text_Port.Location = new System.Drawing.Point(112, 81);
            this.text_Port.Name = "text_Port";
            this.text_Port.Size = new System.Drawing.Size(234, 33);
            this.text_Port.TabIndex = 0;
            this.text_Port.Text = "8001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务器IP地址：";
            // 
            // text_IP
            // 
            this.text_IP.Location = new System.Drawing.Point(112, 22);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(234, 33);
            this.text_IP.TabIndex = 0;
            this.text_IP.Text = "127.0.0.1";
            // 
            // FrmTCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.Text = " ";
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
        private System.Windows.Forms.Button btn_Select_File;
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
        private System.Windows.Forms.Button btn_Send_File;
        private System.Windows.Forms.Button btn_Send_all;
        private System.Windows.Forms.Button btn_Send_JSON;
        private System.Windows.Forms.Button btn_Send_Hex;
        private System.Windows.Forms.Button btn_Send_UTF8;
        private System.Windows.Forms.Button btn_Send_ASCII;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Disconn;
    }
}

