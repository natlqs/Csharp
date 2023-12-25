using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdaterTest
{
    /// <summary>
    /// 应用程序配置
    /// </summary>
    public class AppConfig
    {
        private static readonly object _lock = new object();
        private static AppConfig _instance = null;

        #region 自动更新配置
        /// <summary>
        /// 自动更新配置数据
        /// </summary>
        public AutoUpdateConfig AutoUpdateConfigData { get; set; }

        private AppConfig()
        {
            AutoUpdateConfigData = new AutoUpdateConfig();
        }

        public static AppConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new AppConfig();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// 本地自动更新下载临时文件夹路径
        /// </summary>
        public string TempPath
        {
            get
            {
                return string.Format("{0}\\{1}", Application.StartupPath, GlobalParam.TempDir);
            }
        }

        /// <summary>
        /// 初始化系统配置信息
        /// </summary>
        public void InitialSystemConfig()
        {
            AutoUpdateConfigData.AutoUpdateMode = AppContext.AutoUpdateConfigData.AutoUpdateMode;
            AutoUpdateConfigData.AutoUpdateHttpUrl = AppContext.AutoUpdateConfigData.AutoUpdateHttpUrl;
        }
        #endregion
    }
}
