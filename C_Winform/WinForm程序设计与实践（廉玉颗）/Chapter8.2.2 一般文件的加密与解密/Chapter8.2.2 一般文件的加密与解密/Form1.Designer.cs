namespace Chapter8._2._2_一般文件的加密与解密
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtEncryptFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(283, 293);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(383, 293);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "加密密钥（8位）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "加密后文件路径";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(328, 59);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(205, 21);
            this.txtFile.TabIndex = 2;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(328, 109);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(205, 21);
            this.txtKey.TabIndex = 2;
            this.txtKey.UseSystemPasswordChar = true;
            // 
            // txtEncryptFile
            // 
            this.txtEncryptFile.Location = new System.Drawing.Point(328, 163);
            this.txtEncryptFile.Name = "txtEncryptFile";
            this.txtEncryptFile.Size = new System.Drawing.Size(205, 21);
            this.txtEncryptFile.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEncryptFile);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "文件加密解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtEncryptFile;
    }
}

