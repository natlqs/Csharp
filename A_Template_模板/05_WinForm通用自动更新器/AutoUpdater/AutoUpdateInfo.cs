using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater
{
    /// <summary>
    /// 自动更新内容信息
    /// </summary>
    [Serializable]
    public class AutoUpdateInfo
    {
        /// <summary>
        /// 新版本号
        /// </summary>
        public string NewVersion { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public string UpdateTime { get; set; }

        /// <summary>
        /// 更新内容说明
        /// </summary>
        public string UpdateContent { get; set; }

        /// <summary>
        /// 更新文件列表
        /// </summary>
        public List<string> FileList { get; set; }
    }
}
