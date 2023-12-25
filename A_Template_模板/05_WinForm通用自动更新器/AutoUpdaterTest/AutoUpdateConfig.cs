using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdaterTest
{
    /// <summary>
    /// 本地配置AutoUpdateConfig.xml文件的序列化及反序列化实体对象。
    /// </summary>
    public class AutoUpdateConfig
    {
        /// <summary>
        /// 自动升级模式：当前仅支持HTTP
        /// </summary>
        public string AutoUpdateMode {  get; set; }

        /// <summary>
        /// HTTP自动升级模式的URL地址
        /// </summary>
        public string AutoUpdateHttpUrl {  get; set; }
    }
}
