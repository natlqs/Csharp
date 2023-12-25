using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater
{
    /// <summary>
    /// 配置自动更新模式及相关
    /// </summary>
    /// <summary>
    /// 自动更新配置信息
    /// </summary>
    public class AutoUpdateConfig
    {
        /// <summary>
        /// 自动升级模式：当前仅支持HTTP
        /// </summary>
        public string AutoUpdateMode { get; set; }

        /// <summary>
        /// HTTP自动升级模式时的URL地址
        /// </summary>
        public string AutoUpdateHttpUrl { get; set; }
    }
}
