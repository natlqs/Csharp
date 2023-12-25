using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdaterTest
{
    public partial class MainForm : Form
    {
        private static MainForm _Instance;

        /// <summary>
        /// MainForm主窗体实例
        /// </summary>
        public static MainForm Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MainForm();
                }
                return _Instance;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
