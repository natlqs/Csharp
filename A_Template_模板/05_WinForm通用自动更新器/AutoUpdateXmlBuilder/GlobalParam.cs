using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdateXmlBuilder
{
    /// <summary>
    /// 应用程序全局静态常量
    /// </summary>
    public static class GlobalParam
    {
        /// <summary>
        /// 远端自动更新信息XML文件名
        /// </summary>
        public const string AutoUpdateInfo_XmlFileName = "AutoUpdateInfo.xml";

        /// <summary>
        /// 远端自动更新目录
        /// </summary>
        public const string AutoUpdateDir = "AutoUpdateDir";

        /// <summary>
        /// 远端自动更新文件存放目录
        /// </summary>
        public const string RemoteDir = "AutoUpdateFiles";

        /// <summary>
        /// 主线程名
        /// </summary>
        public const string MainProcess = "AutoUpdaterTest";
    }
}
