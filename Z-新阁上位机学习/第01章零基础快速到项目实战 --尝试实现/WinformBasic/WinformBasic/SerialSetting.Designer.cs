namespace WinformBasic
{
    partial class SerialSetting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialSetting));
            this.comboxBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_ComNum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseCom = new System.Windows.Forms.Button();
            this.btnStartCheck = new System.Windows.Forms.Button();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialReceive = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.TextSerialReceived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboxBox_Baudrate
            // 
            this.comboxBox_Baudrate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxBox_Baudrate.FormattingEnabled = true;
            this.comboxBox_Baudrate.Location = new System.Drawing.Point(356, 57);
            this.comboxBox_Baudrate.Name = "comboxBox_Baudrate";
            this.comboxBox_Baudrate.Size = new System.Drawing.Size(166, 24);
            this.comboxBox_Baudrate.TabIndex = 8;
            // 
            // comboBox_ComNum
            // 
            this.comboBox_ComNum.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ComNum.FormattingEnabled = true;
            this.comboBox_ComNum.Location = new System.Drawing.Point(102, 57);
            this.comboBox_ComNum.Name = "comboBox_ComNum";
            this.comboBox_ComNum.Size = new System.Drawing.Size(150, 24);
            this.comboBox_ComNum.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(258, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "波特率：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "串口号：";
            // 
            // btnCloseCom
            // 
            this.btnCloseCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCloseCom.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseCom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseCom.Location = new System.Drawing.Point(364, 153);
            this.btnCloseCom.Name = "btnCloseCom";
            this.btnCloseCom.Size = new System.Drawing.Size(150, 60);
            this.btnCloseCom.TabIndex = 3;
            this.btnCloseCom.Text = "关闭端口";
            this.btnCloseCom.UseVisualStyleBackColor = false;
            // 
            // btnStartCheck
            // 
            this.btnStartCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStartCheck.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartCheck.Location = new System.Drawing.Point(187, 153);
            this.btnStartCheck.Name = "btnStartCheck";
            this.btnStartCheck.Size = new System.Drawing.Size(150, 60);
            this.btnStartCheck.TabIndex = 4;
            this.btnStartCheck.Text = "开始检查";
            this.btnStartCheck.UseVisualStyleBackColor = false;
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOpenCom.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenCom.Location = new System.Drawing.Point(16, 153);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(150, 60);
            this.btnOpenCom.TabIndex = 5;
            this.btnOpenCom.Text = "打开端口";
            this.btnOpenCom.UseVisualStyleBackColor = false;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "请选择串口号及波特率";
            // 
            // SerialReceive
            // 
            this.SerialReceive.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Bold);
            this.SerialReceive.FormattingEnabled = true;
            this.SerialReceive.ItemHeight = 16;
            this.SerialReceive.Location = new System.Drawing.Point(12, 219);
            this.SerialReceive.Name = "SerialReceive";
            this.SerialReceive.Size = new System.Drawing.Size(508, 340);
            this.SerialReceive.TabIndex = 11;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(258, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "校验位：";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(102, 87);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(150, 24);
            this.comboBoxDataBits.TabIndex = 9;
            // 
            // comboBoxCheckBits
            // 
            this.comboBoxCheckBits.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCheckBits.FormattingEnabled = true;
            this.comboBoxCheckBits.Location = new System.Drawing.Point(356, 87);
            this.comboBoxCheckBits.Name = "comboBoxCheckBits";
            this.comboBoxCheckBits.Size = new System.Drawing.Size(166, 24);
            this.comboBoxCheckBits.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "停止位：";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(102, 117);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(150, 24);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // TextSerialReceived
            // 
            this.TextSerialReceived.Location = new System.Drawing.Point(62, 265);
            this.TextSerialReceived.Multiline = true;
            this.TextSerialReceived.Name = "TextSerialReceived";
            this.TextSerialReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextSerialReceived.Size = new System.Drawing.Size(397, 229);
            this.TextSerialReceived.TabIndex = 12;
            // 
            // SerialSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(189)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.TextSerialReceived);
            this.Controls.Add(this.SerialReceive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCheckBits);
            this.Controls.Add(this.comboxBox_Baudrate);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_ComNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseCom);
            this.Controls.Add(this.btnStartCheck);
            this.Controls.Add(this.btnOpenCom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialSetting";
            this.Load += new System.EventHandler(this.SerialSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxBox_Baudrate;
        private System.Windows.Forms.ComboBox comboBox_ComNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseCom;
        private System.Windows.Forms.Button btnStartCheck;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SerialReceive;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxCheckBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.TextBox TextSerialReceived;
    }
}