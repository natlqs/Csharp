using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdaterTest
{
    /// <summary>
    /// 应用程序全局静态常量。全局参数都在此设置，方便统一管理。注：客户端是否检测更新，也在此设置默认值
    /// </summary>
    public static class GlobalParam
    {
        #region 自动更新参数
        /// <summary>
        /// 是否检查自动更新：默认是true
        /// </summary>
        public static string CheckAutoUpdate = "true";

        /// <summary>
        /// 本地自动更新配置XML文件名
        /// </summary>
        public const string AutoUpdateConfig_XmlFileName = "AutoUpdateConfig.xml";

        /// <summary>
        /// 本地自动更新下载临时存放目录
        /// </summary>
        public const string TempDir = "Temp";

        /// <summary>
        /// 远端自动更新信息XML文件名
        /// </summary>
        public const string AutoUpdateInfo_XmlFileName = "AutoUpdateInfo.xml";

        /// <summary>
        /// 远端自动更新文件存放目录
        /// </summary>
        public const string RemoteDir = "AutoUpdateFiles";

        /// <summary>
        /// 主线程名
        /// </summary>
        public const string MainProcess = "AutoUpdaterTest";
        #endregion
    }
}
