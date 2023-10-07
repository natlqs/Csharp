using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 朝夕_WPF_数据采集与监控项目.Model
{
    public class StorageModel
    {
        public string id { get; set; }
        public int SlaveAddress { get; set; }
        public string FuncCode { get; set; }
        public int StartAddress { get; set; }
        public int Length { get; set; }
    }
}
