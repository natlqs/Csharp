namespace _19_自制进程管理器
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_GetProcessInfo = new Button();
            listView1 = new ListView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            结束进程ToolStripMenuItem = new ToolStripMenuItem();
            设置进程优先级ToolStripMenuItem = new ToolStripMenuItem();
            实时ToolStripMenuItem = new ToolStripMenuItem();
            高ToolStripMenuItem = new ToolStripMenuItem();
            较高ToolStripMenuItem = new ToolStripMenuItem();
            普通ToolStripMenuItem = new ToolStripMenuItem();
            较低ToolStripMenuItem = new ToolStripMenuItem();
            低ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_GetProcessInfo
            // 
            btn_GetProcessInfo.Location = new Point(1, -1);
            btn_GetProcessInfo.Name = "btn_GetProcessInfo";
            btn_GetProcessInfo.Size = new Size(797, 89);
            btn_GetProcessInfo.TabIndex = 0;
            btn_GetProcessInfo.Text = "刷新系统当前进程信息";
            btn_GetProcessInfo.UseVisualStyleBackColor = true;
            btn_GetProcessInfo.Click += btn_GetProcessInfo_Click;
            // 
            // listView1
            // 
            listView1.ContextMenuStrip = contextMenuStrip2;
            listView1.Location = new Point(1, 94);
            listView1.Name = "listView1";
            listView1.Size = new Size(797, 354);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { 结束进程ToolStripMenuItem, 设置进程优先级ToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(161, 48);
            // 
            // 结束进程ToolStripMenuItem
            // 
            结束进程ToolStripMenuItem.Name = "结束进程ToolStripMenuItem";
            结束进程ToolStripMenuItem.Size = new Size(160, 22);
            结束进程ToolStripMenuItem.Text = "结束进程";
            结束进程ToolStripMenuItem.Click += 结束进程ToolStripMenuItem_Click;
            // 
            // 设置进程优先级ToolStripMenuItem
            // 
            设置进程优先级ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 实时ToolStripMenuItem, 高ToolStripMenuItem, 较高ToolStripMenuItem, 普通ToolStripMenuItem, 较低ToolStripMenuItem, 低ToolStripMenuItem });
            设置进程优先级ToolStripMenuItem.Name = "设置进程优先级ToolStripMenuItem";
            设置进程优先级ToolStripMenuItem.Size = new Size(160, 22);
            设置进程优先级ToolStripMenuItem.Text = "设置进程优先级";
            // 
            // 实时ToolStripMenuItem
            // 
            实时ToolStripMenuItem.Name = "实时ToolStripMenuItem";
            实时ToolStripMenuItem.Size = new Size(100, 22);
            实时ToolStripMenuItem.Text = "实时";
            实时ToolStripMenuItem.Click += 实时ToolStripMenuItem_Click;
            // 
            // 高ToolStripMenuItem
            // 
            高ToolStripMenuItem.Name = "高ToolStripMenuItem";
            高ToolStripMenuItem.Size = new Size(100, 22);
            高ToolStripMenuItem.Text = "高";
            高ToolStripMenuItem.Click += 高ToolStripMenuItem_Click;
            // 
            // 较高ToolStripMenuItem
            // 
            较高ToolStripMenuItem.Name = "较高ToolStripMenuItem";
            较高ToolStripMenuItem.Size = new Size(100, 22);
            较高ToolStripMenuItem.Text = "较高";
            较高ToolStripMenuItem.Click += 较高ToolStripMenuItem_Click;
            // 
            // 普通ToolStripMenuItem
            // 
            普通ToolStripMenuItem.Name = "普通ToolStripMenuItem";
            普通ToolStripMenuItem.Size = new Size(100, 22);
            普通ToolStripMenuItem.Text = "普通";
            普通ToolStripMenuItem.Click += 普通ToolStripMenuItem_Click;
            // 
            // 较低ToolStripMenuItem
            // 
            较低ToolStripMenuItem.Name = "较低ToolStripMenuItem";
            较低ToolStripMenuItem.Size = new Size(100, 22);
            较低ToolStripMenuItem.Text = "较低";
            较低ToolStripMenuItem.Click += 较低ToolStripMenuItem_Click;
            // 
            // 低ToolStripMenuItem
            // 
            低ToolStripMenuItem.Name = "低ToolStripMenuItem";
            低ToolStripMenuItem.Size = new Size(100, 22);
            低ToolStripMenuItem.Text = "低";
            低ToolStripMenuItem.Click += 低ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btn_GetProcessInfo);
            Name = "Form1";
            Text = "进程管理器";
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_GetProcessInfo;
        private ListView listView1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem 结束进程ToolStripMenuItem;
        private ToolStripMenuItem 设置进程优先级ToolStripMenuItem;
        private ToolStripMenuItem 实时ToolStripMenuItem;
        private ToolStripMenuItem 高ToolStripMenuItem;
        private ToolStripMenuItem 较高ToolStripMenuItem;
        private ToolStripMenuItem 普通ToolStripMenuItem;
        private ToolStripMenuItem 较低ToolStripMenuItem;
        private ToolStripMenuItem 低ToolStripMenuItem;
    }
}