namespace AutoUpdateXmlBuilder
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.lstFileList = new System.Windows.Forms.ListView();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelUpDateTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtUpdateTime = new System.Windows.Forms.DateTimePicker();
            this.txtNewVersion = new System.Windows.Forms.TextBox();
            this.txtMainProcessName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateContent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPageConfig = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPageConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 505);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "刷新(&R)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(323, 505);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(125, 23);
            this.btnBuild.TabIndex = 10;
            this.btnBuild.Text = "生成更新XML文件(&B)";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // lstFileList
            // 
            this.lstFileList.BackColor = System.Drawing.Color.White;
            this.lstFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFileList.FullRowSelect = true;
            this.lstFileList.GridLines = true;
            this.lstFileList.HideSelection = false;
            this.lstFileList.Location = new System.Drawing.Point(3, 17);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(433, 238);
            this.lstFileList.TabIndex = 8;
            this.lstFileList.UseCompatibleStateImageBehavior = false;
            this.lstFileList.View = System.Windows.Forms.View.Details;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(229, 19);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(65, 12);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "更新版本：";
            // 
            // labelUpDateTime
            // 
            this.labelUpDateTime.AutoSize = true;
            this.labelUpDateTime.Location = new System.Drawing.Point(6, 19);
            this.labelUpDateTime.Name = "labelUpDateTime";
            this.labelUpDateTime.Size = new System.Drawing.Size(65, 12);
            this.labelUpDateTime.TabIndex = 5;
            this.labelUpDateTime.Text = "更新日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "主进程名：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtUpdateTime);
            this.groupBox1.Controls.Add(this.txtNewVersion);
            this.groupBox1.Controls.Add(this.txtMainProcessName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUpdateContent);
            this.groupBox1.Controls.Add(this.labelUpDateTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelVersion);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 227);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // dtUpdateTime
            // 
            this.dtUpdateTime.CustomFormat = "yyyy-MM-dd";
            this.dtUpdateTime.Location = new System.Drawing.Point(78, 15);
            this.dtUpdateTime.Name = "dtUpdateTime";
            this.dtUpdateTime.Size = new System.Drawing.Size(145, 21);
            this.dtUpdateTime.TabIndex = 23;
            // 
            // txtNewVersion
            // 
            this.txtNewVersion.Location = new System.Drawing.Point(300, 16);
            this.txtNewVersion.Name = "txtNewVersion";
            this.txtNewVersion.Size = new System.Drawing.Size(133, 21);
            this.txtNewVersion.TabIndex = 21;
            // 
            // txtMainProcessName
            // 
            this.txtMainProcessName.BackColor = System.Drawing.Color.White;
            this.txtMainProcessName.Location = new System.Drawing.Point(78, 42);
            this.txtMainProcessName.Name = "txtMainProcessName";
            this.txtMainProcessName.Size = new System.Drawing.Size(355, 21);
            this.txtMainProcessName.TabIndex = 18;
            this.txtMainProcessName.Text = "AutoUpdaterTest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "更新内容：";
            // 
            // txtUpdateContent
            // 
            this.txtUpdateContent.Location = new System.Drawing.Point(6, 91);
            this.txtUpdateContent.Multiline = true;
            this.txtUpdateContent.Name = "txtUpdateContent";
            this.txtUpdateContent.Size = new System.Drawing.Size(427, 130);
            this.txtUpdateContent.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstFileList);
            this.groupBox2.Location = new System.Drawing.Point(9, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 258);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件信息";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(179, 505);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(138, 23);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "打开本地更新目录(&O)";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPageConfig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 562);
            this.tabControl1.TabIndex = 18;
            // 
            // tbPageConfig
            // 
            this.tbPageConfig.BackColor = System.Drawing.Color.White;
            this.tbPageConfig.Controls.Add(this.groupBox1);
            this.tbPageConfig.Controls.Add(this.btnOpen);
            this.tbPageConfig.Controls.Add(this.groupBox2);
            this.tbPageConfig.Controls.Add(this.btnRefresh);
            this.tbPageConfig.Controls.Add(this.btnBuild);
            this.tbPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tbPageConfig.Name = "tbPageConfig";
            this.tbPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConfig.Size = new System.Drawing.Size(456, 536);
            this.tbPageConfig.TabIndex = 0;
            this.tbPageConfig.Text = "❉配置生成";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Documents and Settings\\Administrator\\My Documents\\我的文档\\桌面";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 562);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动更新打包工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPageConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.ListView lstFileList;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelUpDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMainProcessName;
        private System.Windows.Forms.TextBox txtUpdateContent;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtNewVersion;
        private System.Windows.Forms.DateTimePicker dtUpdateTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPageConfig;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

