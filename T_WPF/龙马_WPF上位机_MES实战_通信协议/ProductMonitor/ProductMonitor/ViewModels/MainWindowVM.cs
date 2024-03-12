using ProductMonitor.Models;
using ProductMonitor.UserControls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace ProductMonitor.ViewModels
{
    internal class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        /// <summary>
        /// 视图模型构造函数
        /// </summary>
        public MainWindowVM()
        {
            #region 初始化监控数据
            EnviromentList = new List<EnviromentModel>();

            EnviromentList.Add(new EnviromentModel { EnItemName = "光照(LUX)", EnItemValue = 123 });
            EnviromentList.Add(new EnviromentModel { EnItemName = "噪音(db)", EnItemValue = 55 });
            EnviromentList.Add(new EnviromentModel { EnItemName = "温度(℃)", EnItemValue = 80 });
            EnviromentList.Add(new EnviromentModel { EnItemName = "湿度(%)", EnItemValue = 43 });
            EnviromentList.Add(new EnviromentModel { EnItemName = "PM2.5(m³)", EnItemValue = 20 });
            EnviromentList.Add(new EnviromentModel { EnItemName = "硫化氢(PPM)", EnItemValue = 15 });
            EnviromentList.Add(new EnviromentModel { EnItemName = "氮气(PPM)", EnItemValue = 18 });
            #endregion

            #region 初始化报警列表
            AlarmList = new List<AlarmModel>();
            AlarmList.Add(new AlarmModel { Num = "01", Msg = "设备温度过高", Time = "2023-11-23 18:34:56", Duration = 7 });
            AlarmList.Add(new AlarmModel { Num = "02", Msg = "车间温度过高", Time = "2023-11-23 18:34:56", Duration = 10 });
            AlarmList.Add(new AlarmModel { Num = "03", Msg = "设备转速过快", Time = "2023-11-23 18:34:56", Duration = 12 });
            AlarmList.Add(new AlarmModel { Num = "04", Msg = "设备气压偏低", Time = "2023-11-23 18:34:56", Duration = 90 });
            #endregion

            #region 初始化设备监控
            DeviceList = new List<DeviceModel>();
            DeviceList.Add(new DeviceModel { DeviceItem = "电能(Kw.h)", Value = 60.8 });
            DeviceList.Add(new DeviceModel { DeviceItem = "电压(V)", Value = 390 });
            DeviceList.Add(new DeviceModel { DeviceItem = "电流(A)", Value = 5 });
            DeviceList.Add(new DeviceModel { DeviceItem = "压差(kpa)", Value = 13 });
            DeviceList.Add(new DeviceModel { DeviceItem = "温度(℃)", Value = 36 });
            DeviceList.Add(new DeviceModel { DeviceItem = "振动(mm/s)", Value = 4.1 });
            DeviceList.Add(new DeviceModel { DeviceItem = "转速(r/min)", Value = 2600 });
            DeviceList.Add(new DeviceModel { DeviceItem = "气压(kpa)", Value = 0.5 });
            #endregion

            #region 初始化雷达数据
            RadarList = new List<RadarModel>();
            RadarList.Add(new RadarModel { ItemName = "排烟风机", Value = 90 });
            RadarList.Add(new RadarModel { ItemName = "客梯", Value = 50.00 });
            RadarList.Add(new RadarModel { ItemName = "供水机", Value = 74.89 });
            RadarList.Add(new RadarModel { ItemName = "喷淋水泵", Value = 60.59 });
            RadarList.Add(new RadarModel { ItemName = "稳压设备", Value = 50 });
            #endregion

            #region 初始化人员缺岗信息
            StaffAbsenceList = new List<StaffAbsenceModel>();
            StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "张晓婷", Position = "技术员", AbsenceCount = 123 });
            StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "李晓", Position = "操作员", AbsenceCount = 23 });
            StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "王克俭", Position = "技术员", AbsenceCount = 134 });
            StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "陈家栋", Position = "统计员", AbsenceCount = 153 });
            StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "杨过", Position = "技术员", AbsenceCount = 12 });
            ///以下内容不工作，不能正常显示。是因为当指定类型时，编译器会默认把StaffAbesnceList推断为一个局部变量。而如果不写类型，编译器会推断为下面定义的字段或属性。
            //List<StaffAbsenceModel> StaffAbsenceList = new List<StaffAbsenceModel>();
            //StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "张晓婷", Position = "技术员", AbsenceCount = 123 });
            //StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "李晓", Position = "操作员", AbsenceCount = 23 });
            //StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "王克俭", Position = "技术员", AbsenceCount = 134 });
            //StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "陈家栋", Position = "统计员", AbsenceCount = 153 });
            //StaffAbsenceList.Add(new StaffAbsenceModel { StuffName = "杨过", Position = "技术员", AbsenceCount = 12 });
            #endregion

            #region 初始化车间列表 
            WorkShopList = new List<WorkShopModel>();
            WorkShopList.Add(new WorkShopModel { WorkShopName = "贴片车间", WorkingCount = 32, WaitCount = 8, WrongCount = 4, StopCount = 0 });
            WorkShopList.Add(new WorkShopModel { WorkShopName = "封装车间", WorkingCount = 20, WaitCount = 8, WrongCount = 4, StopCount = 0 });
            WorkShopList.Add(new WorkShopModel { WorkShopName = "焊接车间", WorkingCount = 68, WaitCount = 8, WrongCount = 4, StopCount = 0 });
            WorkShopList.Add(new WorkShopModel { WorkShopName = "贴片车间", WorkingCount = 68, WaitCount = 8, WrongCount = 4, StopCount = 0 });

            #endregion

        }


        #region 监控用户控件

        /// <summary>
        /// 监控用户控件
        /// </summary>
        private UserControl? _MonitorUC;

        /// <summary>
        /// 监控用户控件
        /// </summary>
        public UserControl MonitorUC
        {
            get
            {
                if (_MonitorUC == null)
                {
                    _MonitorUC = new MonitorUC();
                }
                return _MonitorUC;
            }
            set
            {
                _MonitorUC = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MonitorUC"));
                }
            }
        }
        #endregion

        #region 时间 日期


        private string _timeStr = DateTime.Now.ToString("HH:mm:ss");

        /// <summary>
        /// 时间  小时：分钟
        /// </summary>
        public string TimeStr
        {
            get
            {
                return _timeStr;
            }
            set
            {
                _timeStr = DateTime.Now.ToString("HH:mm:ss");
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TimeStr"));
                }
            }
        }


        /// <summary>
        /// 日期  年-月-日
        /// </summary>
        public string DateStr
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }
        }


        public string WeekDayStr
        {
            get
            {
                int index = (int)DateTime.Now.DayOfWeek;
                string[] WeekDay = ["星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六"];
                return WeekDay[index];
            }
        }
        #endregion

        #region 机台数


        /// <summary>
        /// 机台总数
        /// </summary>
        private string _MachineCount = "02981";

        /// <summary>
        /// 机台总数
        /// </summary>
        public string MachineCount
        {
            get { return _MachineCount; }
            set
            {
                _MachineCount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MachineCount"));
                }
            }
        }


        /// <summary>
        /// 生产计数
        /// </summary>
        private string _ProductCount = "015789";

        /// <summary>
        /// 生产计数
        /// </summary>
        public string ProductCount
        {
            get { return _ProductCount; }
            set
            {
                _ProductCount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ProductCount"));
                }

            }
        }


        /// <summary>
        /// 不良计数
        /// </summary>
        private string _FailureCount = "000089";

        /// <summary>
        /// 不良计数
        /// </summary>
        public string FailureCount
        {
            get { return _FailureCount; }
            set
            {
                _FailureCount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FailureCount"));
                }
            }
        }

        #endregion

        #region 环境监控数据

        /// <summary>
        /// 环境监控数据
        /// </summary>
        private List<EnviromentModel> _EnviromentList;

        /// <summary>
        /// 环境监控数据
        /// </summary>
        public List<EnviromentModel> EnviromentList
        {
            get { return _EnviromentList; }
            set
            {
                _EnviromentList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("EnviromentList"));
                }
            }
        }

        #endregion

        #region 报警属性
        /// <summary>
        /// 报警集合
        /// </summary>
        private List<AlarmModel> _AlarmList;
        /// <summary>
        /// 报警集合
        /// </summary>
        public List<AlarmModel> AlarmList
        {
            get { return _AlarmList; }
            set
            {
                _AlarmList = value;
                //if(PropertyChanged != null)
                //{
                //    PropertyChanged(this, new PropertyChangedEventArgs("AlarmList"));
                //}

            }
        }



        #endregion

        #region 设备
        /// <summary>
        /// 设备集合
        /// </summary>
        private List<DeviceModel> _DeviceList;

        /// <summary>
        /// 设备集合
        /// </summary>
        public List<DeviceModel> DeviceList
        {
            get { return _DeviceList; }
            set
            {
                _DeviceList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DeviceList"));
                }
            }
        }
        #endregion

        #region 雷达数据属性
        /// <summary>
        /// 雷达
        /// </summary>
        private List<RadarModel> _RadarList;

        /// <summary>
        /// 雷达
        /// </summary>
        public List<RadarModel> RadarList
        {
            get { return _RadarList; }
            set
            {
                _RadarList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("RadarList"));
                }

            }
        }
        #endregion

        #region 缺岗员工属性
        /// <summary>
        /// 缺岗员工
        /// </summary>
        private List<StaffAbsenceModel> _StaffAbsenceList;

        /// <summary>
        /// 缺岗员工
        /// </summary>
        public List<StaffAbsenceModel> StaffAbsenceList
        {
            get { return _StaffAbsenceList; }
            set
            {
                _StaffAbsenceList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("StaffAbsenceList"));
                }
            }
        }
        #endregion

        #region 车间属性
        /// <summary>
        /// 车间
        /// </summary>
        private List<WorkShopModel> _WorkShopList;

        /// <summary>
        /// 车间
        /// </summary>
        public List<WorkShopModel> WorkShopList
        {
            get { return _WorkShopList; }
            set { _WorkShopList = value; }
        }

        #endregion

    }
}
