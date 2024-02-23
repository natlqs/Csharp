namespace Chapter4_Winform基础
{
    partial class Form2
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxText = new System.Windows.Forms.ListBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.lbxText);
            this.panel.Controls.Add(this.btnAdd);
            this.panel.Location = new System.Drawing.Point(41, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(499, 367);
            this.panel.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxText
            // 
            this.lbxText.FormattingEnabled = true;
            this.lbxText.ItemHeight = 12;
            this.lbxText.Location = new System.Drawing.Point(98, 148);
            this.lbxText.Name = "lbxText";
            this.lbxText.Size = new System.Drawing.Size(314, 172);
            this.lbxText.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Name = "Form2";
            this.Text = "面板";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox lbxText;
        private System.Windows.Forms.Button btnAdd;
    }
}