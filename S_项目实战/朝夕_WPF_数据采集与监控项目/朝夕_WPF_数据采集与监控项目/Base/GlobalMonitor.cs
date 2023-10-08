using Communication;
using Communication.Modbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 朝夕_WPF_数据采集与监控项目.BLL;
using 朝夕_WPF_数据采集与监控项目.Model;

namespace 朝夕_WPF_数据采集与监控项目.Base
{
    public class GlobalMonitor
    {
        public static List<StorageModel> StorageList { get; set; }
        public static List<DeviceModel> DeviceList { get; set; } = new List<DeviceModel>();
        public static SerialInfo SerialInfo { get; set; }

        static bool isRunning = true;
        static Task mainTask = null;
        static RTU rtuInstance = null;
        public static void Start( Action successAciton, Action<string> faultAction)
        {
            mainTask = Task.Run(() =>
            {
                IndustrialBLL industrialBLL = new IndustrialBLL();
                // 获取串口配置信息
                var serialinfo = industrialBLL.InitSerialInfo();
                if (serialinfo.State)
                    SerialInfo = serialinfo.Data;
                else
                {
                    faultAction(serialinfo.Message);
                    return;
                }

                // 获取存储区信息
                var sa = industrialBLL.InitStorageModel();
                if (sa.State)
                    StorageList = sa.Data;
                else
                {
                    faultAction(sa.Message);
                    return;
                }


                // 初始化设备变量集合及警戒值
                var dr = industrialBLL.InitDevices();
                if(dr.State)
                    DeviceList = dr.Data;
                else
                {
                    faultAction(dr.Message); 
                    return;
                }

                // 初始化串口通信
                rtuInstance = RTU.getInstance(SerialInfo);
                if (rtuInstance.Connection())
                {
                    successAciton();
                    while (isRunning)
                    {

                    }
                }
                else
                {
                    faultAction("程序无法启动，串口连接初始化失败！请检查设备是否连接正常。");
                }
            });
        }
        public static void Dispose()
        {
            isRunning = false;
            
            if(rtuInstance != null)
                rtuInstance.Dispose();
            if (mainTask != null)
            {
                mainTask.Wait();
            }
        }
    }
}
