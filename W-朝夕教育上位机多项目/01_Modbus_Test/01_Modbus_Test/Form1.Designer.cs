namespace _01_Modbus_Test
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Relay1 = new System.Windows.Forms.TextBox();
            this.label_Relay1_W = new System.Windows.Forms.Label();
            this.label_Relay1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Relay1_D = new System.Windows.Forms.Label();
            this.btn_Write_Bool = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Read_Bool = new System.Windows.Forms.Button();
            this.textBox_RTU_Humidity_W = new System.Windows.Forms.TextBox();
            this.label_Humidity_W = new System.Windows.Forms.Label();
            this.label_RTU_humidity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Humidity_D = new System.Windows.Forms.Label();
            this.btn_Write_Analog = new System.Windows.Forms.Button();
            this.label_read_humidity = new System.Windows.Forms.Label();
            this.btn_Read_Analog = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Tcp_Realy1 = new System.Windows.Forms.TextBox();
            this.btn_Read_Tcp_Bool = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Read_Tcp_Analog = new System.Windows.Forms.Button();
            this.label_Tcp_Read_bool = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Write_Tcp_Analog = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Write_Tcp_Bool = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_tcp_Humidity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_TCP_humidity_W = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Textbox_S7__Write_Relay1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_S7__Read_Relay1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_S7_Write_Bool = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_S7_Read_Bool = new System.Windows.Forms.Button();
            this.Textbox_S7__Write_DB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label_S7__Read_DB = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_S7_Write_Analog = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_S7_Read_Analog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Relay1);
            this.groupBox1.Controls.Add(this.label_Relay1_W);
            this.groupBox1.Controls.Add(this.label_Relay1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_Relay1_D);
            this.groupBox1.Controls.Add(this.btn_Write_Bool);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_Read_Bool);
            this.groupBox1.Controls.Add(this.textBox_RTU_Humidity_W);
            this.groupBox1.Controls.Add(this.label_Humidity_W);
            this.groupBox1.Controls.Add(this.label_RTU_humidity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_Humidity_D);
            this.groupBox1.Controls.Add(this.btn_Write_Analog);
            this.groupBox1.Controls.Add(this.label_read_humidity);
            this.groupBox1.Controls.Add(this.btn_Read_Analog);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ModbusRTU";
            // 
            // textBox_Relay1
            // 
            this.textBox_Relay1.Location = new System.Drawing.Point(115, 146);
            this.textBox_Relay1.Name = "textBox_Relay1";
            this.textBox_Relay1.Size = new System.Drawing.Size(116, 21);
            this.textBox_Relay1.TabIndex = 10;
            // 
            // label_Relay1_W
            // 
            this.label_Relay1_W.AutoSize = true;
            this.label_Relay1_W.Location = new System.Drawing.Point(27, 149);
            this.label_Relay1_W.Name = "label_Relay1_W";
            this.label_Relay1_W.Size = new System.Drawing.Size(83, 12);
            this.label_Relay1_W.TabIndex = 8;
            this.label_Relay1_W.Text = "继电器1置位：";
            // 
            // label_Relay1
            // 
            this.label_Relay1.AutoSize = true;
            this.label_Relay1.Location = new System.Drawing.Point(113, 111);
            this.label_Relay1.Name = "label_Relay1";
            this.label_Relay1.Size = new System.Drawing.Size(41, 12);
            this.label_Relay1.TabIndex = 11;
            this.label_Relay1.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 6;
            // 
            // label_Relay1_D
            // 
            this.label_Relay1_D.AutoSize = true;
            this.label_Relay1_D.Location = new System.Drawing.Point(27, 111);
            this.label_Relay1_D.Name = "label_Relay1_D";
            this.label_Relay1_D.Size = new System.Drawing.Size(47, 12);
            this.label_Relay1_D.TabIndex = 9;
            this.label_Relay1_D.Text = "继电器1";
            // 
            // btn_Write_Bool
            // 
            this.btn_Write_Bool.Location = new System.Drawing.Point(249, 144);
            this.btn_Write_Bool.Name = "btn_Write_Bool";
            this.btn_Write_Bool.Size = new System.Drawing.Size(105, 23);
            this.btn_Write_Bool.TabIndex = 4;
            this.btn_Write_Bool.Text = "RTU写入布尔量";
            this.btn_Write_Bool.UseVisualStyleBackColor = true;
            this.btn_Write_Bool.Click += new System.EventHandler(this.btn_Write_Bool_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 7;
            // 
            // btn_Read_Bool
            // 
            this.btn_Read_Bool.Location = new System.Drawing.Point(249, 106);
            this.btn_Read_Bool.Name = "btn_Read_Bool";
            this.btn_Read_Bool.Size = new System.Drawing.Size(105, 23);
            this.btn_Read_Bool.TabIndex = 5;
            this.btn_Read_Bool.Text = "RTU读取布尔量";
            this.btn_Read_Bool.UseVisualStyleBackColor = true;
            this.btn_Read_Bool.Click += new System.EventHandler(this.btn_Read_Bool_Click);
            // 
            // textBox_RTU_Humidity_W
            // 
            this.textBox_RTU_Humidity_W.Location = new System.Drawing.Point(115, 65);
            this.textBox_RTU_Humidity_W.Name = "textBox_RTU_Humidity_W";
            this.textBox_RTU_Humidity_W.Size = new System.Drawing.Size(116, 21);
            this.textBox_RTU_Humidity_W.TabIndex = 3;
            // 
            // label_Humidity_W
            // 
            this.label_Humidity_W.AutoSize = true;
            this.label_Humidity_W.Location = new System.Drawing.Point(27, 68);
            this.label_Humidity_W.Name = "label_Humidity_W";
            this.label_Humidity_W.Size = new System.Drawing.Size(41, 12);
            this.label_Humidity_W.TabIndex = 2;
            this.label_Humidity_W.Text = "湿度：";
            // 
            // label_RTU_humidity
            // 
            this.label_RTU_humidity.AutoSize = true;
            this.label_RTU_humidity.Location = new System.Drawing.Point(113, 30);
            this.label_RTU_humidity.Name = "label_RTU_humidity";
            this.label_RTU_humidity.Size = new System.Drawing.Size(41, 12);
            this.label_RTU_humidity.TabIndex = 3;
            this.label_RTU_humidity.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 1;
            // 
            // label_Humidity_D
            // 
            this.label_Humidity_D.AutoSize = true;
            this.label_Humidity_D.Location = new System.Drawing.Point(27, 30);
            this.label_Humidity_D.Name = "label_Humidity_D";
            this.label_Humidity_D.Size = new System.Drawing.Size(41, 12);
            this.label_Humidity_D.TabIndex = 2;
            this.label_Humidity_D.Text = "湿度：";
            // 
            // btn_Write_Analog
            // 
            this.btn_Write_Analog.Location = new System.Drawing.Point(249, 63);
            this.btn_Write_Analog.Name = "btn_Write_Analog";
            this.btn_Write_Analog.Size = new System.Drawing.Size(105, 23);
            this.btn_Write_Analog.TabIndex = 0;
            this.btn_Write_Analog.Text = "RTU写入模拟量";
            this.btn_Write_Analog.UseVisualStyleBackColor = true;
            this.btn_Write_Analog.Click += new System.EventHandler(this.btn_Write_Analog_Click);
            // 
            // label_read_humidity
            // 
            this.label_read_humidity.AutoSize = true;
            this.label_read_humidity.Location = new System.Drawing.Point(160, 30);
            this.label_read_humidity.Name = "label_read_humidity";
            this.label_read_humidity.Size = new System.Drawing.Size(0, 12);
            this.label_read_humidity.TabIndex = 1;
            // 
            // btn_Read_Analog
            // 
            this.btn_Read_Analog.Location = new System.Drawing.Point(249, 25);
            this.btn_Read_Analog.Name = "btn_Read_Analog";
            this.btn_Read_Analog.Size = new System.Drawing.Size(105, 23);
            this.btn_Read_Analog.TabIndex = 0;
            this.btn_Read_Analog.Text = "RTU读取模拟量";
            this.btn_Read_Analog.UseVisualStyleBackColor = true;
            this.btn_Read_Analog.Click += new System.EventHandler(this.btn_Read_Analog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Tcp_Realy1);
            this.groupBox2.Controls.Add(this.btn_Read_Tcp_Bool);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Read_Tcp_Analog);
            this.groupBox2.Controls.Add(this.label_Tcp_Read_bool);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Write_Tcp_Analog);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_Write_Tcp_Bool);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label_tcp_Humidity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_TCP_humidity_W);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 187);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ModbusTCP";
            // 
            // textBox_Tcp_Realy1
            // 
            this.textBox_Tcp_Realy1.Location = new System.Drawing.Point(113, 140);
            this.textBox_Tcp_Realy1.Name = "textBox_Tcp_Realy1";
            this.textBox_Tcp_Realy1.Size = new System.Drawing.Size(116, 21);
            this.textBox_Tcp_Realy1.TabIndex = 26;
            // 
            // btn_Read_Tcp_Bool
            // 
            this.btn_Read_Tcp_Bool.Location = new System.Drawing.Point(247, 100);
            this.btn_Read_Tcp_Bool.Name = "btn_Read_Tcp_Bool";
            this.btn_Read_Tcp_Bool.Size = new System.Drawing.Size(95, 23);
            this.btn_Read_Tcp_Bool.TabIndex = 21;
            this.btn_Read_Tcp_Bool.Text = "TCP读取布尔量";
            this.btn_Read_Tcp_Bool.UseVisualStyleBackColor = true;
            this.btn_Read_Tcp_Bool.Click += new System.EventHandler(this.btn_Read_Tcp_Bool_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "继电器1置位：";
            // 
            // btn_Read_Tcp_Analog
            // 
            this.btn_Read_Tcp_Analog.Location = new System.Drawing.Point(247, 19);
            this.btn_Read_Tcp_Analog.Name = "btn_Read_Tcp_Analog";
            this.btn_Read_Tcp_Analog.Size = new System.Drawing.Size(95, 23);
            this.btn_Read_Tcp_Analog.TabIndex = 13;
            this.btn_Read_Tcp_Analog.Text = "TCP读取模拟量";
            this.btn_Read_Tcp_Analog.UseVisualStyleBackColor = true;
            this.btn_Read_Tcp_Analog.Click += new System.EventHandler(this.btn_Read_Tcp_Analog_Click);
            // 
            // label_Tcp_Read_bool
            // 
            this.label_Tcp_Read_bool.AutoSize = true;
            this.label_Tcp_Read_bool.Location = new System.Drawing.Point(111, 105);
            this.label_Tcp_Read_bool.Name = "label_Tcp_Read_bool";
            this.label_Tcp_Read_bool.Size = new System.Drawing.Size(41, 12);
            this.label_Tcp_Read_bool.TabIndex = 27;
            this.label_Tcp_Read_bool.Text = "label2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 22;
            // 
            // btn_Write_Tcp_Analog
            // 
            this.btn_Write_Tcp_Analog.Location = new System.Drawing.Point(247, 57);
            this.btn_Write_Tcp_Analog.Name = "btn_Write_Tcp_Analog";
            this.btn_Write_Tcp_Analog.Size = new System.Drawing.Size(95, 23);
            this.btn_Write_Tcp_Analog.TabIndex = 12;
            this.btn_Write_Tcp_Analog.Text = "TCP写入模拟量";
            this.btn_Write_Tcp_Analog.UseVisualStyleBackColor = true;
            this.btn_Write_Tcp_Analog.Click += new System.EventHandler(this.btn_Write_Tcp_Analog_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "继电器1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "湿度：";
            // 
            // btn_Write_Tcp_Bool
            // 
            this.btn_Write_Tcp_Bool.Location = new System.Drawing.Point(247, 138);
            this.btn_Write_Tcp_Bool.Name = "btn_Write_Tcp_Bool";
            this.btn_Write_Tcp_Bool.Size = new System.Drawing.Size(95, 23);
            this.btn_Write_Tcp_Bool.TabIndex = 20;
            this.btn_Write_Tcp_Bool.Text = "TCP写入布尔量";
            this.btn_Write_Tcp_Bool.UseVisualStyleBackColor = true;
            this.btn_Write_Tcp_Bool.Click += new System.EventHandler(this.btn_Write_Tcp_Bool_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 12);
            this.label11.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 23;
            // 
            // label_tcp_Humidity
            // 
            this.label_tcp_Humidity.AutoSize = true;
            this.label_tcp_Humidity.Location = new System.Drawing.Point(111, 24);
            this.label_tcp_Humidity.Name = "label_tcp_Humidity";
            this.label_tcp_Humidity.Size = new System.Drawing.Size(41, 12);
            this.label_tcp_Humidity.TabIndex = 19;
            this.label_tcp_Humidity.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "湿度：";
            // 
            // textBox_TCP_humidity_W
            // 
            this.textBox_TCP_humidity_W.Location = new System.Drawing.Point(113, 59);
            this.textBox_TCP_humidity_W.Name = "textBox_TCP_humidity_W";
            this.textBox_TCP_humidity_W.Size = new System.Drawing.Size(116, 21);
            this.textBox_TCP_humidity_W.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Textbox_S7__Write_Relay1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label_S7__Read_Relay1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btn_S7_Write_Bool);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btn_S7_Read_Bool);
            this.groupBox3.Controls.Add(this.Textbox_S7__Write_DB);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label_S7__Read_DB);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.btn_S7_Write_Analog);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.btn_S7_Read_Analog);
            this.groupBox3.Location = new System.Drawing.Point(25, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 199);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "S7<-->PLC";
            // 
            // Textbox_S7__Write_Relay1
            // 
            this.Textbox_S7__Write_Relay1.Location = new System.Drawing.Point(115, 147);
            this.Textbox_S7__Write_Relay1.Name = "Textbox_S7__Write_Relay1";
            this.Textbox_S7__Write_Relay1.Size = new System.Drawing.Size(116, 21);
            this.Textbox_S7__Write_Relay1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "M1.0:";
            // 
            // label_S7__Read_Relay1
            // 
            this.label_S7__Read_Relay1.AutoSize = true;
            this.label_S7__Read_Relay1.Location = new System.Drawing.Point(113, 112);
            this.label_S7__Read_Relay1.Name = "label_S7__Read_Relay1";
            this.label_S7__Read_Relay1.Size = new System.Drawing.Size(41, 12);
            this.label_S7__Read_Relay1.TabIndex = 27;
            this.label_S7__Read_Relay1.Text = "label2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 12);
            this.label14.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "Q0.0:";
            // 
            // btn_S7_Write_Bool
            // 
            this.btn_S7_Write_Bool.Location = new System.Drawing.Point(249, 145);
            this.btn_S7_Write_Bool.Name = "btn_S7_Write_Bool";
            this.btn_S7_Write_Bool.Size = new System.Drawing.Size(105, 23);
            this.btn_S7_Write_Bool.TabIndex = 20;
            this.btn_S7_Write_Bool.Text = "S7写入布尔量";
            this.btn_S7_Write_Bool.UseVisualStyleBackColor = true;
            this.btn_S7_Write_Bool.Click += new System.EventHandler(this.btn_S7_Write_Bool_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 12);
            this.label16.TabIndex = 23;
            // 
            // btn_S7_Read_Bool
            // 
            this.btn_S7_Read_Bool.Location = new System.Drawing.Point(249, 107);
            this.btn_S7_Read_Bool.Name = "btn_S7_Read_Bool";
            this.btn_S7_Read_Bool.Size = new System.Drawing.Size(105, 23);
            this.btn_S7_Read_Bool.TabIndex = 21;
            this.btn_S7_Read_Bool.Text = "S7读取布尔量";
            this.btn_S7_Read_Bool.UseVisualStyleBackColor = true;
            this.btn_S7_Read_Bool.Click += new System.EventHandler(this.btn_S7_Read_Bool_Click);
            // 
            // Textbox_S7__Write_DB
            // 
            this.Textbox_S7__Write_DB.Location = new System.Drawing.Point(115, 66);
            this.Textbox_S7__Write_DB.Name = "Textbox_S7__Write_DB";
            this.Textbox_S7__Write_DB.Size = new System.Drawing.Size(116, 21);
            this.Textbox_S7__Write_DB.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "DB1.DBW2:";
            // 
            // label_S7__Read_DB
            // 
            this.label_S7__Read_DB.AutoSize = true;
            this.label_S7__Read_DB.Location = new System.Drawing.Point(113, 31);
            this.label_S7__Read_DB.Name = "label_S7__Read_DB";
            this.label_S7__Read_DB.Size = new System.Drawing.Size(41, 12);
            this.label_S7__Read_DB.TabIndex = 19;
            this.label_S7__Read_DB.Text = "label2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(160, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 12);
            this.label19.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "DB1.DBW0:";
            // 
            // btn_S7_Write_Analog
            // 
            this.btn_S7_Write_Analog.Location = new System.Drawing.Point(249, 64);
            this.btn_S7_Write_Analog.Name = "btn_S7_Write_Analog";
            this.btn_S7_Write_Analog.Size = new System.Drawing.Size(105, 23);
            this.btn_S7_Write_Analog.TabIndex = 12;
            this.btn_S7_Write_Analog.Text = "S7写入模拟量";
            this.btn_S7_Write_Analog.UseVisualStyleBackColor = true;
            this.btn_S7_Write_Analog.Click += new System.EventHandler(this.btn_S7_Write_Analog_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(160, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 12);
            this.label21.TabIndex = 15;
            // 
            // btn_S7_Read_Analog
            // 
            this.btn_S7_Read_Analog.Location = new System.Drawing.Point(249, 26);
            this.btn_S7_Read_Analog.Name = "btn_S7_Read_Analog";
            this.btn_S7_Read_Analog.Size = new System.Drawing.Size(105, 23);
            this.btn_S7_Read_Analog.TabIndex = 13;
            this.btn_S7_Read_Analog.Text = "S7读取模拟量";
            this.btn_S7_Read_Analog.UseVisualStyleBackColor = true;
            this.btn_S7_Read_Analog.Click += new System.EventHandler(this.btn_S7_Read_Analog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_RTU_humidity;
        private System.Windows.Forms.Label label_Humidity_D;
        private System.Windows.Forms.Label label_read_humidity;
        private System.Windows.Forms.Button btn_Read_Analog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Humidity_W;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Write_Analog;
        private System.Windows.Forms.TextBox textBox_RTU_Humidity_W;
        private System.Windows.Forms.TextBox textBox_Relay1;
        private System.Windows.Forms.Label label_Relay1_W;
        private System.Windows.Forms.Label label_Relay1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Relay1_D;
        private System.Windows.Forms.Button btn_Write_Bool;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Read_Bool;
        private System.Windows.Forms.TextBox textBox_Tcp_Realy1;
        private System.Windows.Forms.Button btn_Read_Tcp_Bool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Read_Tcp_Analog;
        private System.Windows.Forms.Label label_Tcp_Read_bool;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Write_Tcp_Analog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Write_Tcp_Bool;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_tcp_Humidity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_TCP_humidity_W;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Textbox_S7__Write_Relay1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_S7__Read_Relay1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_S7_Write_Bool;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_S7_Read_Bool;
        private System.Windows.Forms.TextBox Textbox_S7__Write_DB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_S7__Read_DB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_S7_Write_Analog;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_S7_Read_Analog;
    }
}

