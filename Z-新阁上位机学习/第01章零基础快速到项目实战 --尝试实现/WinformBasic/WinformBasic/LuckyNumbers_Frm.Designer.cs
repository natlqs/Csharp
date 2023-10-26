namespace WinformBasic
{
    partial class LuckyNumbers_Frm
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
            this.LuckyNumbers = new System.Windows.Forms.ListBox();
            this.btnLotteryStart = new System.Windows.Forms.Button();
            this.btnLotterySelect = new System.Windows.Forms.Button();
            this.btnLotteryClear = new System.Windows.Forms.Button();
            this.btnLotteryConfirm = new System.Windows.Forms.Button();
            this.lblNum14 = new System.Windows.Forms.Label();
            this.lblNum6 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum12 = new System.Windows.Forms.Label();
            this.lblNum11 = new System.Windows.Forms.Label();
            this.lblNum10 = new System.Windows.Forms.Label();
            this.lblNum9 = new System.Windows.Forms.Label();
            this.lblNum8 = new System.Windows.Forms.Label();
            this.lblNum7 = new System.Windows.Forms.Label();
            this.lblNum13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeCreateNum = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LuckyNumbers
            // 
            this.LuckyNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.LuckyNumbers.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LuckyNumbers.FormattingEnabled = true;
            this.LuckyNumbers.ItemHeight = 16;
            this.LuckyNumbers.Location = new System.Drawing.Point(13, 240);
            this.LuckyNumbers.Name = "LuckyNumbers";
            this.LuckyNumbers.Size = new System.Drawing.Size(890, 308);
            this.LuckyNumbers.TabIndex = 6;
            // 
            // btnLotteryStart
            // 
            this.btnLotteryStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLotteryStart.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLotteryStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLotteryStart.Location = new System.Drawing.Point(18, 152);
            this.btnLotteryStart.Name = "btnLotteryStart";
            this.btnLotteryStart.Size = new System.Drawing.Size(169, 50);
            this.btnLotteryStart.TabIndex = 8;
            this.btnLotteryStart.Text = "启动";
            this.btnLotteryStart.UseVisualStyleBackColor = false;
            this.btnLotteryStart.Click += new System.EventHandler(this.btnLotteryStart_Click);
            // 
            // btnLotterySelect
            // 
            this.btnLotterySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLotterySelect.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLotterySelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLotterySelect.Location = new System.Drawing.Point(248, 152);
            this.btnLotterySelect.Name = "btnLotterySelect";
            this.btnLotterySelect.Size = new System.Drawing.Size(169, 50);
            this.btnLotterySelect.TabIndex = 8;
            this.btnLotterySelect.Text = "选择";
            this.btnLotterySelect.UseVisualStyleBackColor = false;
            this.btnLotterySelect.Click += new System.EventHandler(this.btnLotterySelect_Click);
            // 
            // btnLotteryClear
            // 
            this.btnLotteryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLotteryClear.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLotteryClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLotteryClear.Location = new System.Drawing.Point(486, 152);
            this.btnLotteryClear.Name = "btnLotteryClear";
            this.btnLotteryClear.Size = new System.Drawing.Size(169, 50);
            this.btnLotteryClear.TabIndex = 8;
            this.btnLotteryClear.Text = "清除";
            this.btnLotteryClear.UseVisualStyleBackColor = false;
            this.btnLotteryClear.Click += new System.EventHandler(this.btnLotteryClear_Click);
            // 
            // btnLotteryConfirm
            // 
            this.btnLotteryConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLotteryConfirm.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLotteryConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLotteryConfirm.Location = new System.Drawing.Point(711, 152);
            this.btnLotteryConfirm.Name = "btnLotteryConfirm";
            this.btnLotteryConfirm.Size = new System.Drawing.Size(169, 50);
            this.btnLotteryConfirm.TabIndex = 8;
            this.btnLotteryConfirm.Text = "确认OK";
            this.btnLotteryConfirm.UseVisualStyleBackColor = false;
            // 
            // lblNum14
            // 
            this.lblNum14.BackColor = System.Drawing.Color.White;
            this.lblNum14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum14.ForeColor = System.Drawing.Color.Lime;
            this.lblNum14.Location = new System.Drawing.Point(778, 75);
            this.lblNum14.Name = "lblNum14";
            this.lblNum14.Size = new System.Drawing.Size(48, 50);
            this.lblNum14.TabIndex = 33;
            this.lblNum14.Text = "00";
            this.lblNum14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum6
            // 
            this.lblNum6.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum6.BackColor = System.Drawing.Color.White;
            this.lblNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum6.ForeColor = System.Drawing.Color.Black;
            this.lblNum6.Location = new System.Drawing.Point(339, 75);
            this.lblNum6.Name = "lblNum6";
            this.lblNum6.Size = new System.Drawing.Size(48, 45);
            this.lblNum6.TabIndex = 34;
            this.lblNum6.Text = "00";
            this.lblNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum5
            // 
            this.lblNum5.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum5.BackColor = System.Drawing.Color.White;
            this.lblNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum5.ForeColor = System.Drawing.Color.Black;
            this.lblNum5.Location = new System.Drawing.Point(285, 75);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(48, 45);
            this.lblNum5.TabIndex = 35;
            this.lblNum5.Text = "00";
            this.lblNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum4
            // 
            this.lblNum4.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum4.BackColor = System.Drawing.Color.White;
            this.lblNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum4.ForeColor = System.Drawing.Color.Black;
            this.lblNum4.Location = new System.Drawing.Point(231, 75);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(48, 45);
            this.lblNum4.TabIndex = 36;
            this.lblNum4.Text = "00";
            this.lblNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            this.lblNum3.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum3.BackColor = System.Drawing.Color.White;
            this.lblNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.ForeColor = System.Drawing.Color.Black;
            this.lblNum3.Location = new System.Drawing.Point(177, 75);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(48, 45);
            this.lblNum3.TabIndex = 37;
            this.lblNum3.Text = "00";
            this.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum2
            // 
            this.lblNum2.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum2.BackColor = System.Drawing.Color.White;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.Black;
            this.lblNum2.Location = new System.Drawing.Point(123, 75);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(48, 45);
            this.lblNum2.TabIndex = 38;
            this.lblNum2.Text = "00";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum1
            // 
            this.lblNum1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum1.BackColor = System.Drawing.Color.White;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.Black;
            this.lblNum1.Location = new System.Drawing.Point(69, 75);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(48, 45);
            this.lblNum1.TabIndex = 39;
            this.lblNum1.Text = "00";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum12
            // 
            this.lblNum12.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum12.BackColor = System.Drawing.Color.White;
            this.lblNum12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum12.ForeColor = System.Drawing.Color.Black;
            this.lblNum12.Location = new System.Drawing.Point(670, 75);
            this.lblNum12.Name = "lblNum12";
            this.lblNum12.Size = new System.Drawing.Size(48, 45);
            this.lblNum12.TabIndex = 40;
            this.lblNum12.Text = "00";
            this.lblNum12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum11
            // 
            this.lblNum11.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum11.BackColor = System.Drawing.Color.White;
            this.lblNum11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum11.ForeColor = System.Drawing.Color.Black;
            this.lblNum11.Location = new System.Drawing.Point(616, 75);
            this.lblNum11.Name = "lblNum11";
            this.lblNum11.Size = new System.Drawing.Size(48, 45);
            this.lblNum11.TabIndex = 41;
            this.lblNum11.Text = "00";
            this.lblNum11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum10
            // 
            this.lblNum10.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum10.BackColor = System.Drawing.Color.White;
            this.lblNum10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum10.ForeColor = System.Drawing.Color.Black;
            this.lblNum10.Location = new System.Drawing.Point(562, 75);
            this.lblNum10.Name = "lblNum10";
            this.lblNum10.Size = new System.Drawing.Size(48, 45);
            this.lblNum10.TabIndex = 42;
            this.lblNum10.Text = "00";
            this.lblNum10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum9
            // 
            this.lblNum9.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum9.BackColor = System.Drawing.Color.White;
            this.lblNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum9.ForeColor = System.Drawing.Color.Black;
            this.lblNum9.Location = new System.Drawing.Point(508, 75);
            this.lblNum9.Name = "lblNum9";
            this.lblNum9.Size = new System.Drawing.Size(48, 45);
            this.lblNum9.TabIndex = 43;
            this.lblNum9.Text = "00";
            this.lblNum9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum8
            // 
            this.lblNum8.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum8.BackColor = System.Drawing.Color.White;
            this.lblNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum8.ForeColor = System.Drawing.Color.Black;
            this.lblNum8.Location = new System.Drawing.Point(454, 75);
            this.lblNum8.Name = "lblNum8";
            this.lblNum8.Size = new System.Drawing.Size(48, 45);
            this.lblNum8.TabIndex = 44;
            this.lblNum8.Text = "00";
            this.lblNum8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum7
            // 
            this.lblNum7.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.lblNum7.BackColor = System.Drawing.Color.White;
            this.lblNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum7.ForeColor = System.Drawing.Color.Black;
            this.lblNum7.Location = new System.Drawing.Point(400, 75);
            this.lblNum7.Name = "lblNum7";
            this.lblNum7.Size = new System.Drawing.Size(48, 45);
            this.lblNum7.TabIndex = 45;
            this.lblNum7.Text = "00";
            this.lblNum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum13
            // 
            this.lblNum13.BackColor = System.Drawing.Color.White;
            this.lblNum13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum13.ForeColor = System.Drawing.Color.Lime;
            this.lblNum13.Location = new System.Drawing.Point(724, 75);
            this.lblNum13.Name = "lblNum13";
            this.lblNum13.Size = new System.Drawing.Size(48, 50);
            this.lblNum13.TabIndex = 46;
            this.lblNum13.Text = "00";
            this.lblNum13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(269, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 38);
            this.label8.TabIndex = 47;
            this.label8.Text = "Lucky Number Selector";
            // 
            // timeCreateNum
            // 
            this.timeCreateNum.Interval = 50;
            this.timeCreateNum.Tick += new System.EventHandler(this.timeCreateNum_Tick);
            // 
            // LuckyNumbers_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(189)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(915, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNum13);
            this.Controls.Add(this.lblNum12);
            this.Controls.Add(this.lblNum11);
            this.Controls.Add(this.lblNum10);
            this.Controls.Add(this.lblNum9);
            this.Controls.Add(this.lblNum8);
            this.Controls.Add(this.lblNum7);
            this.Controls.Add(this.lblNum14);
            this.Controls.Add(this.lblNum6);
            this.Controls.Add(this.lblNum5);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.LuckyNumbers);
            this.Controls.Add(this.btnLotteryConfirm);
            this.Controls.Add(this.btnLotteryClear);
            this.Controls.Add(this.btnLotterySelect);
            this.Controls.Add(this.btnLotteryStart);
            this.Name = "LuckyNumbers_Frm";
            this.Text = "Lottery_Frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LuckyNumbers;
        private System.Windows.Forms.Button btnLotteryStart;
        private System.Windows.Forms.Button btnLotterySelect;
        private System.Windows.Forms.Button btnLotteryClear;
        private System.Windows.Forms.Button btnLotteryConfirm;
        private System.Windows.Forms.Label lblNum14;
        private System.Windows.Forms.Label lblNum6;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum12;
        private System.Windows.Forms.Label lblNum11;
        private System.Windows.Forms.Label lblNum10;
        private System.Windows.Forms.Label lblNum9;
        private System.Windows.Forms.Label lblNum8;
        private System.Windows.Forms.Label lblNum7;
        private System.Windows.Forms.Label lblNum13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timeCreateNum;
    }
}