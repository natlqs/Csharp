using S7.Net.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Modbus_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Modbus TCP


        /// <summary>
        /// Modbus TCP 读取模拟量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Read_Tcp_Analog_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //while (true)
                {
                    try
                    {
                        using (TcpClient tcpClient = new TcpClient())
                        {
                            tcpClient.Connect("127.0.0.1", 502);
                            Modbus.Device.ModbusIpMaster modbusIpMaster = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient);
                            // 读取1号从站1号地址1个数据保存寄存器
                            ushort[] datas = modbusIpMaster.ReadHoldingRegisters(1, 1, 1);
                            if (datas != null && datas.Length > 0)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    this.label_tcp_Humidity.Text = datas[0].ToString();
                                }));
                            }
                            tcpClient.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            });
        }


        /// <summary>
        /// Modbus TCP 写入模拟量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Write_Tcp_Analog_Click(object sender, EventArgs e)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Connect("127.0.0.1", 502);
                    Modbus.Device.ModbusIpMaster modbusIpMaster = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient);
                    ushort value = ushort.Parse(this.textBox_TCP_humidity_W.Text);
                    // 写入1号从站1号地址一个数值
                    modbusIpMaster.WriteSingleRegister(1, 1, value);
                    tcpClient.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        ///  Modbus TCP 读取布尔值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Read_Tcp_Bool_Click(object sender, EventArgs e)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Connect("127.0.0.1", 502);
                    Modbus.Device.ModbusIpMaster modbusIpMaster = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient);
                    bool[] boolResult = modbusIpMaster.ReadCoils(1, 0, 1);
                    this.label_Tcp_Read_bool.Text = boolResult[0].ToString();
                    tcpClient.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        ///  Modbus TCP 写入布尔值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Write_Tcp_Bool_Click(object sender, EventArgs e)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Connect("127.0.0.1", 502);
                    Modbus.Device.ModbusIpMaster modbusIpMaster = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient);
                    bool value = Convert.ToBoolean(Convert.ToInt32(this.textBox_Tcp_Realy1.Text));
                    modbusIpMaster.WriteSingleCoil(1, 0, value);
                    tcpClient.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Modbus RTU


        /// <summary>
        /// Modbus RTU读取模拟量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Read_Analog_Click(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
                //while (true)
                {
                    try
                    {
                        // Modbus RTU 模式读取数值
                        using (SerialPort port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One))
                        {
                            port.Open();
                            // 串口只做一个连接
                            Modbus.Device.ModbusSerialMaster master = Modbus.Device.ModbusSerialMaster.CreateRtu(port);
                            // 读取1号从站中的1号保存型寄存器
                            ushort[] datas = master.ReadHoldingRegisters(1, 1, 1);
                            if (datas != null && datas.Length > 0)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    this.label_RTU_humidity.Text = datas[0].ToString();
                                }));
                            }
                            port.Close();
                            //Thread.Sleep(50);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            });
        }


        /// <summary>
        ///  Modbus RTU 写入模拟量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Write_Analog_Click(object sender, EventArgs e)
        {
            try
            {
                using (SerialPort port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One))
                {
                    port.Open();
                    // 串口只做一个连接
                    Modbus.Device.ModbusSerialMaster master = Modbus.Device.ModbusSerialMaster.CreateRtu(port);
                    // 写入1号从站中的1号保存型寄存器
                    ushort value = ushort.Parse(this.textBox_RTU_Humidity_W.Text);
                    master.WriteSingleRegister(1, 1, value);
                    port.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// ModbusRTU读取布尔量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Read_Bool_Click(object sender, EventArgs e)
        {
            // Modbus RTU 模式读取数值
            using (SerialPort port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One))
            {
                try
                {

                    port.Open();
                    // 串口只做一个连接
                    Modbus.Device.ModbusSerialMaster master = Modbus.Device.ModbusSerialMaster.CreateRtu(port);
                    // 读取1号从站中的1号线圈状态
                    bool[] boolresult = master.ReadCoils(1, 0, 1);
                    this.label_Relay1.Text = boolresult[0].ToString();
                    port.Close();
                    //Thread.Sleep(50);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// <summary>
        /// ModbusRTU写入布尔量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Write_Bool_Click(object sender, EventArgs e)
        {
            try
            {
                using (SerialPort port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One))
                {
                    port.Open();
                    // 串口只做一个连接
                    Modbus.Device.ModbusSerialMaster master = Modbus.Device.ModbusSerialMaster.CreateRtu(port);
                    // 写入1号站， 布尔量
                    bool value = Convert.ToBoolean(Convert.ToInt32(this.textBox_Relay1.Text));
                    master.WriteSingleCoil(1, 0, value);
                    port.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion


        #region S7 读取写入PLC


        /// <summary>
        /// S7 读取模拟量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_S7_Read_Analog_Click(object sender, EventArgs e)
        {
            using (S7.Net.Plc plc = new S7.Net.Plc(S7.Net.CpuType.S71500, "10.230.102.69", 0, 1))
            {
                plc.Open();
                // 直接按照字符串读地址，
                //var result = plc.Read("DB1.DBW0");

                // 按照数据类型，地址等读取
                var result = plc.Read(S7.Net.DataType.DataBlock, 1, 0, S7.Net.VarType.Word, 1);
                this.Invoke(new Action(() =>
                {
                    this.label_S7__Read_DB.Text = result.ToString();
                }));
            }
        }


        /// <summary>
        /// S7 写入模拟量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_S7_Write_Analog_Click(object sender, EventArgs e)
        {
            using (S7.Net.Plc plc = new S7.Net.Plc(S7.Net.CpuType.S71500, "10.230.102.69", 0, 1))
            {
                plc.Open();
                ushort value = ushort.Parse(this.Textbox_S7__Write_DB.Text);

                // 单个 直接按照字符串写地址，
                //plc.Write("DB1.DBW2", value);

                // 单个 按照数据类型，地址等读取
                //plc.Write(S7.Net.DataType.DataBlock,1,2,value);

                // 多个  按照dataItem方式写入
                DataItem dataItem1 = new DataItem();
                dataItem1.DataType = S7.Net.DataType.DataBlock;     // 存储区类型     
                dataItem1.Value = value;                    // 写入的值
                dataItem1.VarType = S7.Net.VarType.Word;        // 值的类型
                dataItem1.StartByteAdr = 0;                 // 起始地址
                dataItem1.DB = 1;                           // DB块编号

                DataItem dataItem2 = new DataItem();
                dataItem2.DataType = S7.Net.DataType.DataBlock;     // 存储区类型     
                dataItem2.Value = value;                    // 写入的值
                dataItem2.VarType = S7.Net.VarType.Word;        // 值的类型
                dataItem2.StartByteAdr = 2;                 // 起始地址
                dataItem2.DB = 1;                           // DB块编号
                plc.Write(dataItem1, dataItem2);
            }
        }



        private void btn_S7_Read_Bool_Click(object sender, EventArgs e)
        {
            using (S7.Net.Plc plc = new S7.Net.Plc(S7.Net.CpuType.S71500, "10.230.102.69", 0, 1))
            {
                plc.Open();
                // 直接按照字符串读地址，
                //var result = plc.Read("Q0.0");

                // 按照数据类型，地址等读取
                var result = plc.Read(S7.Net.DataType.Output, 0, 0, S7.Net.VarType.Bit, 1);
                this.Invoke(new Action(() =>
                {
                    this.label_S7__Read_Relay1.Text = result.ToString();
                }));
            }
        }

        private void btn_S7_Write_Bool_Click(object sender, EventArgs e)
        {
            using (S7.Net.Plc plc = new S7.Net.Plc(S7.Net.CpuType.S71500, "10.230.102.69", 0, 1))
            {
                plc.Open();
                bool value = Convert.ToBoolean(Convert.ToInt32(this.Textbox_S7__Write_Relay1.Text));
                // 单个 直接按照字符串写地址，
                plc.Write("M1.0", value);

                // 单个 按照数据类型，地址等读取
                //plc.Write(S7.Net.DataType.DataBlock,1,2,value);
            }
        }

        #endregion
    }
}
