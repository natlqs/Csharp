using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iniFileOperation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }

        private string ConfigPath = Application.StartupPath + "\\Config.ini";

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.txt_IP.Text = IniConfigHelper.ReadIniData("PLC参数", "IP", "", ConfigPath);
            this.txt_Port.Text = IniConfigHelper.ReadIniData("PLC参数", "Port", "", ConfigPath);

        }

            private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ConfigPath))
            {
                FileStream fs = new FileStream(ConfigPath, FileMode.Create);
                fs.Close();
            }

            bool Result = true;
            Result &= IniConfigHelper.WriteIniData("PLC参数", "IP", this.txt_IP.Text.Trim(), ConfigPath);
            
            Result &= IniConfigHelper.WriteIniData("PLC参数", "Port", this.txt_Port.Text.Trim(), ConfigPath);

            if (Result)
            {
                MessageBox.Show("参数保存成功", "参数保存");

            }
            else
            {
                MessageBox.Show("参数保存失败", "参数保存");
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
