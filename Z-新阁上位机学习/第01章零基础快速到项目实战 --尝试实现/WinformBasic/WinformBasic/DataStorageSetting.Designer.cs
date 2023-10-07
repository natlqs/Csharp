namespace WinformBasic
{
    partial class DataStorageSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataStorageSetting));
            this.btnSelectTargetFolder = new System.Windows.Forms.Button();
            this.btnStartAutoSave = new System.Windows.Forms.Button();
            this.btnSetSourceFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectTargetFolder
            // 
            this.btnSelectTargetFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSelectTargetFolder.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectTargetFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectTargetFolder.Location = new System.Drawing.Point(243, 102);
            this.btnSelectTargetFolder.Name = "btnSelectTargetFolder";
            this.btnSelectTargetFolder.Size = new System.Drawing.Size(185, 59);
            this.btnSelectTargetFolder.TabIndex = 1;
            this.btnSelectTargetFolder.Text = "选择目的文件夹";
            this.btnSelectTargetFolder.UseVisualStyleBackColor = false;
            this.btnSelectTargetFolder.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnStartAutoSave
            // 
            this.btnStartAutoSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStartAutoSave.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartAutoSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartAutoSave.Location = new System.Drawing.Point(262, 178);
            this.btnStartAutoSave.Name = "btnStartAutoSave";
            this.btnStartAutoSave.Size = new System.Drawing.Size(151, 59);
            this.btnStartAutoSave.TabIndex = 2;
            this.btnStartAutoSave.Text = "开始自动保存";
            this.btnStartAutoSave.UseVisualStyleBackColor = false;
            // 
            // btnSetSourceFolder
            // 
            this.btnSetSourceFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSetSourceFolder.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetSourceFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetSourceFolder.Location = new System.Drawing.Point(243, 28);
            this.btnSetSourceFolder.Name = "btnSetSourceFolder";
            this.btnSetSourceFolder.Size = new System.Drawing.Size(185, 59);
            this.btnSetSourceFolder.TabIndex = 3;
            this.btnSetSourceFolder.Text = "选择源数据文件夹";
            this.btnSetSourceFolder.UseVisualStyleBackColor = false;
            this.btnSetSourceFolder.Click += new System.EventHandler(this.button3_Click);
            // 
            // DataStorageSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(189)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnSelectTargetFolder);
            this.Controls.Add(this.btnStartAutoSave);
            this.Controls.Add(this.btnSetSourceFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataStorageSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataStorageSetting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectTargetFolder;
        private System.Windows.Forms.Button btnStartAutoSave;
        private System.Windows.Forms.Button btnSetSourceFolder;
    }
}