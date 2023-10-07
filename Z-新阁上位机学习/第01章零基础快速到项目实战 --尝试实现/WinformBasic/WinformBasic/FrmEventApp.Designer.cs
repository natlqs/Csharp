namespace WinformBasic
{
    partial class FrmEventApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventApp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SerialState = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSerialSetting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataStorageStatus = new System.Windows.Forms.ListBox();
            this.btnDataStorageSetting = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckResult = new System.Windows.Forms.ListBox();
            this.btnStartCheck = new System.Windows.Forms.Button();
            this.btnStopCheck = new System.Windows.Forms.Button();
            this.btnLuckyNumber = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(189)))), ((int)(((byte)(185)))));
            this.groupBox1.Controls.Add(this.SerialState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSerialSetting);
            this.groupBox1.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口选项";
            // 
            // SerialState
            // 
            this.SerialState.FormattingEnabled = true;
            this.SerialState.ItemHeight = 16;
            this.SerialState.Location = new System.Drawing.Point(221, 45);
            this.SerialState.Name = "SerialState";
            this.SerialState.Size = new System.Drawing.Size(213, 68);
            this.SerialState.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "串口状态";
            // 
            // btnSerialSetting
            // 
            this.btnSerialSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSerialSetting.Location = new System.Drawing.Point(6, 44);
            this.btnSerialSetting.Name = "btnSerialSetting";
            this.btnSerialSetting.Size = new System.Drawing.Size(190, 55);
            this.btnSerialSetting.TabIndex = 3;
            this.btnSerialSetting.Text = "串口设置";
            this.btnSerialSetting.UseVisualStyleBackColor = false;
            this.btnSerialSetting.Click += new System.EventHandler(this.btnSerialSetting_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataStorageStatus);
            this.groupBox2.Controls.Add(this.btnDataStorageSetting);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(459, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件选项";
            // 
            // DataStorageStatus
            // 
            this.DataStorageStatus.FormattingEnabled = true;
            this.DataStorageStatus.ItemHeight = 16;
            this.DataStorageStatus.Location = new System.Drawing.Point(208, 45);
            this.DataStorageStatus.Name = "DataStorageStatus";
            this.DataStorageStatus.Size = new System.Drawing.Size(213, 68);
            this.DataStorageStatus.TabIndex = 5;
            // 
            // btnDataStorageSetting
            // 
            this.btnDataStorageSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDataStorageSetting.Location = new System.Drawing.Point(6, 44);
            this.btnDataStorageSetting.Name = "btnDataStorageSetting";
            this.btnDataStorageSetting.Size = new System.Drawing.Size(190, 55);
            this.btnDataStorageSetting.TabIndex = 4;
            this.btnDataStorageSetting.Text = "数据保存设置";
            this.btnDataStorageSetting.UseVisualStyleBackColor = false;
            this.btnDataStorageSetting.Click += new System.EventHandler(this.btnDataStorageSetting_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据保存状态";
            // 
            // CheckResult
            // 
            this.CheckResult.BackColor = System.Drawing.SystemColors.Window;
            this.CheckResult.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckResult.FormattingEnabled = true;
            this.CheckResult.ItemHeight = 16;
            this.CheckResult.Location = new System.Drawing.Point(13, 239);
            this.CheckResult.Name = "CheckResult";
            this.CheckResult.Size = new System.Drawing.Size(890, 308);
            this.CheckResult.TabIndex = 3;
            // 
            // btnStartCheck
            // 
            this.btnStartCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStartCheck.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartCheck.Location = new System.Drawing.Point(1, 151);
            this.btnStartCheck.Name = "btnStartCheck";
            this.btnStartCheck.Size = new System.Drawing.Size(300, 80);
            this.btnStartCheck.TabIndex = 3;
            this.btnStartCheck.Text = "开始检查";
            this.btnStartCheck.UseVisualStyleBackColor = false;
            this.btnStartCheck.Click += new System.EventHandler(this.btnStartCheck_Click);
            // 
            // btnStopCheck
            // 
            this.btnStopCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStopCheck.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStopCheck.Location = new System.Drawing.Point(307, 151);
            this.btnStopCheck.Name = "btnStopCheck";
            this.btnStopCheck.Size = new System.Drawing.Size(300, 80);
            this.btnStopCheck.TabIndex = 3;
            this.btnStopCheck.Text = "停止检查";
            this.btnStopCheck.UseVisualStyleBackColor = false;
            this.btnStopCheck.Click += new System.EventHandler(this.btnStopCheck_Click);
            // 
            // btnLuckyNumber
            // 
            this.btnLuckyNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLuckyNumber.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLuckyNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuckyNumber.Location = new System.Drawing.Point(613, 151);
            this.btnLuckyNumber.Name = "btnLuckyNumber";
            this.btnLuckyNumber.Size = new System.Drawing.Size(300, 80);
            this.btnLuckyNumber.TabIndex = 4;
            this.btnLuckyNumber.Text = "LuckyNumber";
            this.btnLuckyNumber.UseVisualStyleBackColor = false;
            this.btnLuckyNumber.Click += new System.EventHandler(this.btnLuckyNumber_Click);
            // 
            // FrmEventApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(189)))), ((int)(((byte)(185)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(915, 561);
            this.Controls.Add(this.btnLuckyNumber);
            this.Controls.Add(this.CheckResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStopCheck);
            this.Controls.Add(this.btnStartCheck);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEventApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSCB G Value Checker";
            this.Load += new System.EventHandler(this.FrmEventApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSerialSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDataStorageSetting;
        private System.Windows.Forms.ListBox CheckResult;
        private System.Windows.Forms.ListBox SerialState;
        private System.Windows.Forms.ListBox DataStorageStatus;
        private System.Windows.Forms.Button btnStartCheck;
        private System.Windows.Forms.Button btnStopCheck;
        private System.Windows.Forms.Button btnLuckyNumber;
    }
}