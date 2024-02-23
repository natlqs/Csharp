namespace Chapter4_Winform基础
{
    partial class Form4
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 254);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(96, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(258, 40);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(339, 40);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 1;
            this.btnCut.Text = "剪切";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(96, 69);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "粘贴";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(177, 69);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackColor.TabIndex = 1;
            this.btnBackColor.Text = "背景色";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(258, 69);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "颜色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(339, 69);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "字体";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form4";
            this.Text = "编辑器";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
    }
}