namespace TextFile
{
    partial class FrmFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFile));
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnWriteAll = new System.Windows.Forms.Button();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnWriteLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelAllFiles = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnShowSubDir = new System.Windows.Forms.Button();
            this.btnShowAllFiles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 12);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(222, 280);
            this.txtContent.TabIndex = 0;
            // 
            // btnWriteAll
            // 
            this.btnWriteAll.Location = new System.Drawing.Point(13, 29);
            this.btnWriteAll.Name = "btnWriteAll";
            this.btnWriteAll.Size = new System.Drawing.Size(119, 23);
            this.btnWriteAll.TabIndex = 1;
            this.btnWriteAll.Text = "写入文本文件";
            this.btnWriteAll.UseVisualStyleBackColor = true;
            this.btnWriteAll.Click += new System.EventHandler(this.btnWriteAll_Click);
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(155, 29);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(133, 23);
            this.btnReadAll.TabIndex = 1;
            this.btnReadAll.Text = "从文本文件中读取";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // btnWriteLine
            // 
            this.btnWriteLine.Location = new System.Drawing.Point(315, 29);
            this.btnWriteLine.Name = "btnWriteLine";
            this.btnWriteLine.Size = new System.Drawing.Size(122, 23);
            this.btnWriteLine.TabIndex = 2;
            this.btnWriteLine.Text = "模拟写入系统日志";
            this.btnWriteLine.UseVisualStyleBackColor = true;
            this.btnWriteLine.Click += new System.EventHandler(this.btnWriteLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "源文件路径:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "目的文件路径:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(78, 25);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(131, 21);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.Text = "C:\\\\myfile.txt";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(325, 25);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(125, 21);
            this.txtTo.TabIndex = 4;
            this.txtTo.Text = "D:\\\\myfile.txt";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(155, 56);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "复制文件";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(315, 56);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "移动文件";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(13, 56);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除文件";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadAll);
            this.groupBox1.Controls.Add(this.btnWriteAll);
            this.groupBox1.Controls.Add(this.btnWriteLine);
            this.groupBox1.Location = new System.Drawing.Point(240, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文本文件读写";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Location = new System.Drawing.Point(240, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件操作";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelAllFiles);
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.btnShowSubDir);
            this.groupBox3.Controls.Add(this.btnShowAllFiles);
            this.groupBox3.Location = new System.Drawing.Point(241, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件目录操作";
            // 
            // btnDelAllFiles
            // 
            this.btnDelAllFiles.Location = new System.Drawing.Point(235, 66);
            this.btnDelAllFiles.Name = "btnDelAllFiles";
            this.btnDelAllFiles.Size = new System.Drawing.Size(225, 23);
            this.btnDelAllFiles.TabIndex = 3;
            this.btnDelAllFiles.Text = "删除指定目录下的所有子目录和文件";
            this.btnDelAllFiles.UseVisualStyleBackColor = true;
            this.btnDelAllFiles.Click += new System.EventHandler(this.btnDelAllFiles_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 66);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(196, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "在指定目录下创建一个子目录";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnShowSubDir
            // 
            this.btnShowSubDir.Location = new System.Drawing.Point(235, 30);
            this.btnShowSubDir.Name = "btnShowSubDir";
            this.btnShowSubDir.Size = new System.Drawing.Size(186, 23);
            this.btnShowSubDir.TabIndex = 1;
            this.btnShowSubDir.Text = "显示指定目录下的所有子目录";
            this.btnShowSubDir.UseVisualStyleBackColor = true;
            this.btnShowSubDir.Click += new System.EventHandler(this.btnShowSubDir_Click);
            // 
            // btnShowAllFiles
            // 
            this.btnShowAllFiles.Location = new System.Drawing.Point(12, 30);
            this.btnShowAllFiles.Name = "btnShowAllFiles";
            this.btnShowAllFiles.Size = new System.Drawing.Size(196, 23);
            this.btnShowAllFiles.TabIndex = 0;
            this.btnShowAllFiles.Text = "显示指定目录下的所有文件";
            this.btnShowAllFiles.UseVisualStyleBackColor = true;
            this.btnShowAllFiles.Click += new System.EventHandler(this.btnShowAllFiles_Click);
            // 
            // FrmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 306);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件操作";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnWriteAll;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnWriteLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowAllFiles;
        private System.Windows.Forms.Button btnShowSubDir;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelAllFiles;
    }
}

