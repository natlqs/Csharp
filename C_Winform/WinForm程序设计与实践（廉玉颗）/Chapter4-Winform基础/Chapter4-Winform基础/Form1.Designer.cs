namespace Chapter4_Winform基础
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.raFemale = new System.Windows.Forms.RadioButton();
            this.city = new System.Windows.Forms.ComboBox();
            this.net = new System.Windows.Forms.CheckBox();
            this.c = new System.Windows.Forms.CheckBox();
            this.java = new System.Windows.Forms.CheckBox();
            this.interest = new System.Windows.Forms.ListBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(227, 115);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(227, 156);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(35, 16);
            this.rdMale.TabIndex = 8;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "男";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // raFemale
            // 
            this.raFemale.AutoSize = true;
            this.raFemale.Location = new System.Drawing.Point(328, 156);
            this.raFemale.Name = "raFemale";
            this.raFemale.Size = new System.Drawing.Size(35, 16);
            this.raFemale.TabIndex = 9;
            this.raFemale.Text = "女";
            this.raFemale.UseVisualStyleBackColor = true;
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(new object[] {
            "北京",
            "上海",
            "哈尔滨",
            "大连",
            "深圳",
            "广州"});
            this.city.Location = new System.Drawing.Point(227, 188);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 20);
            this.city.TabIndex = 10;
            // 
            // net
            // 
            this.net.AutoSize = true;
            this.net.Location = new System.Drawing.Point(227, 222);
            this.net.Name = "net";
            this.net.Size = new System.Drawing.Size(48, 16);
            this.net.TabIndex = 11;
            this.net.Text = ".NET";
            this.net.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(311, 221);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(30, 16);
            this.c.TabIndex = 12;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(395, 222);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(48, 16);
            this.java.TabIndex = 13;
            this.java.Text = "JAVA";
            this.java.UseVisualStyleBackColor = true;
            this.java.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // interest
            // 
            this.interest.FormattingEnabled = true;
            this.interest.ItemHeight = 12;
            this.interest.Items.AddRange(new object[] {
            "travel",
            "reading",
            "sports"});
            this.interest.Location = new System.Drawing.Point(227, 267);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(120, 88);
            this.interest.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(230, 388);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.java);
            this.Controls.Add(this.c);
            this.Controls.Add(this.net);
            this.Controls.Add(this.city);
            this.Controls.Add(this.raFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "主窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton raFemale;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.CheckBox net;
        private System.Windows.Forms.CheckBox c;
        private System.Windows.Forms.CheckBox java;
        private System.Windows.Forms.ListBox interest;
        private System.Windows.Forms.Button btnRegister;
    }
}

