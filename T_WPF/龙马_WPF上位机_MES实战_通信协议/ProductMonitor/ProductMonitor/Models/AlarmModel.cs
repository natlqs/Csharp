using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    /// <summary>
    /// 报警数据类型
    /// </summary>
    class AlarmModel
    {
        public string Num { get; set; }
        public string Msg { get; set; }
        public string Time { get; set; }


        /// <summary>
        /// 报警时长，单位是秒
        /// </summary>
        public int Duration { get; set; }
    }
}
