using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdaterTest
{
    /// <summary>
    /// 应用程序上下文
    /// </summary>
    public class AppContext
    {
        /// <summary>
        /// 客户端配置文件
        /// </summary>
        public static AutoUpdateConfig AutoUpdateConfigData { get; set; }
    }
}
