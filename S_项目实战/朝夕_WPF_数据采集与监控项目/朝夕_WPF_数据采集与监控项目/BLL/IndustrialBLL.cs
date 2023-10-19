using Communication;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 朝夕_WPF_数据采集与监控项目.DAL;
using 朝夕_WPF_数据采集与监控项目.Model;
using System.Data;

namespace 朝夕_WPF_数据采集与监控项目.BLL
{
    internal class IndustrialBLL
    {
        DataAccess dataAccess = new DataAccess();
        // 获取串口信息
        public DataResult<SerialInfo> InitSerialInfo()
        {
            DataResult<SerialInfo> result = new DataResult<SerialInfo>();
            try
            {
                SerialInfo serialInfo = new SerialInfo();
                serialInfo.PortName = ConfigurationManager.AppSettings["port"].ToString();
                serialInfo.BaudRate = int.Parse(ConfigurationManager.AppSettings["baud"].ToString());
                serialInfo.DataBit = int.Parse(ConfigurationManager.AppSettings["data_bit"].ToString());
                serialInfo.Parity = (Parity)Enum.Parse(typeof(Parity), ConfigurationManager.AppSettings["parity"].ToString(), true);
                serialInfo.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ConfigurationManager.AppSettings["stop_bit"].ToString(), true);

                result.State = true;
                result.Data = serialInfo;
            }
            catch (Exception ex)
            {

                result.Message = ex.Message;
            }
            return result;
        }


        public DataResult<List<StorageModel>> InitStorageModel()
        {
            DataResult<List<StorageModel>> dataResult = new DataResult<List<StorageModel>>();

            try
            {
                var sa = dataAccess.GetStorageArea();
                dataResult.State = true;
                dataResult.Data = (from q in sa.AsEnumerable()
                              select new StorageModel
                              {
                                  id = q.Field<string>("id"),
                                  SlaveAddress = q.Field<Int32>("slave_add"),
                                  FuncCode = q.Field<string>("func_code"),
                                  StartAddress = int.Parse(q.Field<string>("start_reg")),
                                  Length = int.Parse(q.Field<string>("length")),

                              }).ToList();
            }
            catch (Exception ex)
            {
                dataResult.Message = ex.Message;
            }
            return dataResult;
        }


        public DataResult<List<DeviceModel>> InitDevices()
        {
            DataResult<List<DeviceModel>> deviceResult = new DataResult<List<DeviceModel>>();

            try
            {
                var devices = dataAccess.GetDevices();
                var monitorValues = dataAccess.GetMonitorValue();

                List<DeviceModel> deviceList = new List<DeviceModel>();
                foreach( var device in devices.AsEnumerable() )
                {
                    DeviceModel deviceModel = new DeviceModel();
                    deviceList.Add( deviceModel );
                    deviceModel.DeviceID = device.Field<string>("d_id");
                    deviceModel.DeviceName = device.Field<string>("d_name");
                    foreach ( var monitorValue in monitorValues.AsEnumerable().Where(m => m.Field<string>("d_id") == deviceModel.DeviceID))
                    {
                        MonitorValueModel monitorValueModel = new MonitorValueModel();
                        deviceModel.MonitorValueList.Add( monitorValueModel );

                        monitorValueModel.ValueId = monitorValue.Field<string>("value_id");
                        monitorValueModel.ValueName = monitorValue.Field<string>("value_name");
                        monitorValueModel.StorageAreaId = monitorValue.Field<string>("s_area_id");
                        monitorValueModel.StartAddress = monitorValue.Field<Int32>("address");
                        monitorValueModel.DataType = monitorValue.Field<string>("data_type");
                        monitorValueModel.IsAlarm = monitorValue.Field<Int32>("is_alarm") ==1;
                        monitorValueModel.ValueDesc = monitorValue.Field<string>("unit");

                        // 警戒值
                        var column = monitorValue.Field<string>("alarm_lolo");
                        monitorValueModel.LoLoAlarm = column == null ? 0.0 : double.Parse(column);
                        column = monitorValue.Field<string>("alarm_low");
                        monitorValueModel.LowAlarm = column ==null? 0.0 : double.Parse(column);
                        column = monitorValue.Field<string>("alarm_high");
                        monitorValueModel.LowAlarm = column ==null? 0.0 : double.Parse(column);
                        column = monitorValue.Field<string>("alarm_hihi");
                        monitorValueModel.LowAlarm = column ==null? 0.0 : double.Parse(column);

                        monitorValueModel.ValueStateChanged = (state, msg, value_id) =>
                        {
                            var index = deviceModel.WarningMessageList.ToList().FindIndex(w=> w.ValueId == value_id);
                            if (index > -1)
                                deviceModel.WarningMessageList.RemoveAt(index);
                              
                            if(state != Base.MonitorValueState.OK)
                            {
                                deviceModel.IsWarning = true;
                                deviceModel.WarningMessageList.Add(new WarningMessageModel { ValueId = value_id, Message = msg});
                            }

                            var ss = deviceModel.WarningMessageList.Count > 0;
                            if(deviceModel.IsWarning != ss)
                            {
                                deviceModel.IsWarning = ss;
                            }
                        };
                    }
                }

                deviceResult.State = true;
                deviceResult.Data = deviceList;

            }
            catch (Exception ex)
            {
                deviceResult.Message = ex.Message;
                throw;
            }
            return deviceResult;
        } 
    }
}
