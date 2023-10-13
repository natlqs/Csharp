using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Security.Permissions;

namespace 朝夕_WPF_数据采集与监控项目.Model
{
    public class DeviceModel
    {
        public string DeviceID { get; set; }
        public string DeviceName { get; set; }
        public bool IsRunning { get; set; }
        public bool IsWarning { get; set; }
        public ObservableCollection<MonitorValueModel> MonitorValueList { get; set; } = new ObservableCollection<MonitorValueModel>();
        public ObservableCollection<WarningMessageModel> WarningMessageList { get; set; } = new ObservableCollection<WarningMessageModel>();
    }
}
