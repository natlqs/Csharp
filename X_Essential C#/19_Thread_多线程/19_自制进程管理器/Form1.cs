using System.Diagnostics;
using System.Net.WebSockets;

namespace _19_自制进程管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;  // 详情模式
            listView1.FullRowSelect = true; // 整行选择模式
            listView1.Columns.Add("id", 80);
            listView1.Columns.Add("进程句柄", 80);
            listView1.Columns.Add("进程名", 100);
            listView1.Columns.Add("线程数", 80);
            listView1.Columns.Add("优先级", 100);
            listView1.Columns.Add("启动时间", 80);
            listView1.Columns.Add("物理内存", 100);
        }
        private void btn_GetProcessInfo_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();        // 清除当前显示项
            Process[] ps = Process.GetProcesses();      // 获取当前系统所有的进程列表，返回的是数组
            foreach (var p in ps)
            {
                try
                {
                    ListViewItem i = new ListViewItem(p.Id.ToString(), 0);      // 进程ID
                    i.SubItems.Add(p.Handle.ToString());            // 句柄
                    i.SubItems.Add(p.ProcessName);              // 进程名
                    i.SubItems.Add(p.Threads.Count.ToString());         // 线程数
                    i.SubItems.Add(p.PriorityClass.ToString());             // 优先级
                    i.SubItems.Add(p.StartTime.ToLongTimeString());     // 启动时间 
                    i.SubItems.Add(Convert.ToString(p.WorkingSet64 / (1024 * 1024)) + "M");     // 物理内存，获取到的数值是Byte
                    listView1.Items.Add(i);
                }
                catch { }
            }
        }
        private void 结束进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string name = listView1.SelectedItems[0].SubItems[2].Text;      // 获取选择项
                if (KillByName(name))
                {
                    btn_GetProcessInfo.PerformClick();
                }
                else
                {
                    MessageBox.Show(name + "关闭失败", "友情提示");
                }
            }
        }

        public bool KillByName(string name)
        {
            Process[] ps = Process.GetProcessesByName(name);
            if (ps.Length > 0)
            {
                try
                {
                    foreach (var p in ps)
                    {
                        int id = p.Id;
                        p.Kill();
                    }
                    return true;
                }
                catch { }
            }
            return false;
        }
    
        private void 实时ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPriority(ProcessPriorityClass.RealTime);
        }
        private void 高ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPriority(ProcessPriorityClass.High);
        }
        private void 较高ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPriority(ProcessPriorityClass.AboveNormal);
        }
        private void 普通ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPriority(ProcessPriorityClass.Normal);
        }
        private void 较低ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPriority(ProcessPriorityClass.BelowNormal);
        }
        private void 低ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPriority(ProcessPriorityClass.Idle);
        }
        void SetPriority(ProcessPriorityClass priority)         // 设置进程优先级
        {
            if (listView1.SelectedItems.Count == 0) return;
            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            Process p = Process.GetProcessById(id);
            if (p is not null) p.PriorityClass = priority;
            btn_GetProcessInfo.PerformClick();
        }
    }
}