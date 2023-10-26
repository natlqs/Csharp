namespace CourseManageUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnTeacherManage = new System.Windows.Forms.Button();
            this.btnCousreManage = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 66);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(889, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 24);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(54)))), ((int)(((byte)(115)))));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("lblCurrentUser.Image")));
            this.lblCurrentUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentUser.Location = new System.Drawing.Point(812, 25);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(74, 23);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "常老师";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.btnModifyPwd);
            this.panel2.Controls.Add(this.btnTeacherManage);
            this.panel2.Controls.Add(this.btnCousreManage);
            this.panel2.Controls.Add(this.btnAddCourse);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(7, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 468);
            this.panel2.TabIndex = 1;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyPwd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnModifyPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModifyPwd.ForeColor = System.Drawing.Color.White;
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(24, 408);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(151, 38);
            this.btnModifyPwd.TabIndex = 0;
            this.btnModifyPwd.Text = "修 改 登 录 密 码 ";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = false;
            this.btnModifyPwd.Click += new System.EventHandler(this.btnModifyPwd_Click);
            // 
            // btnTeacherManage
            // 
            this.btnTeacherManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTeacherManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTeacherManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherManage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTeacherManage.ForeColor = System.Drawing.Color.White;
            this.btnTeacherManage.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherManage.Image")));
            this.btnTeacherManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherManage.Location = new System.Drawing.Point(24, 294);
            this.btnTeacherManage.Name = "btnTeacherManage";
            this.btnTeacherManage.Size = new System.Drawing.Size(151, 38);
            this.btnTeacherManage.TabIndex = 0;
            this.btnTeacherManage.Text = "讲 师 信 息 管 理 ";
            this.btnTeacherManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeacherManage.UseVisualStyleBackColor = false;
            this.btnTeacherManage.Click += new System.EventHandler(this.btnTeacherManage_Click);
            // 
            // btnCousreManage
            // 
            this.btnCousreManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCousreManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCousreManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCousreManage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCousreManage.ForeColor = System.Drawing.Color.White;
            this.btnCousreManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCousreManage.Image")));
            this.btnCousreManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCousreManage.Location = new System.Drawing.Point(24, 250);
            this.btnCousreManage.Name = "btnCousreManage";
            this.btnCousreManage.Size = new System.Drawing.Size(151, 38);
            this.btnCousreManage.TabIndex = 0;
            this.btnCousreManage.Text = "课 程 信 息 管 理 ";
            this.btnCousreManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCousreManage.UseVisualStyleBackColor = false;
            this.btnCousreManage.Click += new System.EventHandler(this.btnCousreManage_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(24, 206);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(151, 38);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "添 加 课 程 信 息 ";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(-5, -2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.Location = new System.Drawing.Point(222, 73);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(690, 470);
            this.panelRight.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(184)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnTeacherManage;
        private System.Windows.Forms.Button btnCousreManage;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnClose;
    }
}