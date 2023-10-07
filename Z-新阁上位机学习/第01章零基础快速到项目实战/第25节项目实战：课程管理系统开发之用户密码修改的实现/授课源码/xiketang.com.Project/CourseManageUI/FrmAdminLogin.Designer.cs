namespace CourseManageUI
{
    partial class FrmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginAccount = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.ckbSavePwd = new System.Windows.Forms.CheckBox();
            this.btnLoginSys = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "管理员密码：";
            // 
            // txtLoginAccount
            // 
            this.txtLoginAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginAccount.Location = new System.Drawing.Point(160, 132);
            this.txtLoginAccount.Name = "txtLoginAccount";
            this.txtLoginAccount.Size = new System.Drawing.Size(150, 21);
            this.txtLoginAccount.TabIndex = 1;
            this.txtLoginAccount.Text = "xiketang01";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPwd.Location = new System.Drawing.Point(160, 161);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(150, 21);
            this.txtLoginPwd.TabIndex = 1;
            this.txtLoginPwd.Text = "123456";
            this.txtLoginPwd.UseSystemPasswordChar = true;
            // 
            // ckbSavePwd
            // 
            this.ckbSavePwd.AutoSize = true;
            this.ckbSavePwd.Checked = true;
            this.ckbSavePwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSavePwd.Location = new System.Drawing.Point(82, 203);
            this.ckbSavePwd.Name = "ckbSavePwd";
            this.ckbSavePwd.Size = new System.Drawing.Size(72, 16);
            this.ckbSavePwd.TabIndex = 2;
            this.ckbSavePwd.Text = "记住密码";
            this.ckbSavePwd.UseVisualStyleBackColor = true;
            // 
            // btnLoginSys
            // 
            this.btnLoginSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnLoginSys.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoginSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSys.ForeColor = System.Drawing.Color.White;
            this.btnLoginSys.Location = new System.Drawing.Point(160, 194);
            this.btnLoginSys.Name = "btnLoginSys";
            this.btnLoginSys.Size = new System.Drawing.Size(150, 30);
            this.btnLoginSys.TabIndex = 3;
            this.btnLoginSys.Text = "登 录 系 统";
            this.btnLoginSys.UseVisualStyleBackColor = false;
            this.btnLoginSys.Click += new System.EventHandler(this.btnLoginSys_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(361, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 24);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(393, 260);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoginSys);
            this.Controls.Add(this.ckbSavePwd);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登录";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginAccount;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.CheckBox ckbSavePwd;
        private System.Windows.Forms.Button btnLoginSys;
        private System.Windows.Forms.Button btnClose;
    }
}

