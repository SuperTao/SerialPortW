using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialPortW
{
    public partial class SerialPortW : Form
    {

        SerialPort serialPort;

        public SerialPortW()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //获取串口
            String[] serialPortArray = SerialPort.GetPortNames();
            if (serialPortArray != null && serialPortArray.Length != 0)
            {
                //对串口进行排序
                Array.Sort<String>(serialPortArray);
                foreach (String port in serialPortArray)
                {
                    //添加到combox的item
                    if (port != null && port.Length != 0)
                        serialPorts.Items.Add(port);
                }
            }
            //设置初始显示的值 
            serialPorts.SelectedIndex = 0;
            baudRate.SelectedIndex = 16;
            dataBits.SelectedIndex = 3;
            parity.SelectedIndex = 0;
            stop.SelectedIndex = 0;

            send.BackColor = Color.Gray;
            //创建串口对象
            serialPort = new SerialPort();
        }

        private void dealReceive(object sender, SerialDataReceivedEventArgs e)
        {
            String data = serialPort.ReadExisting();
            receive.AppendText(data);
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Write(sendText.Text.ToString() + "\n");
        }

        private void setPort()
        {
            try
            {
                serialPort.PortName = (String)(serialPorts.SelectedItem);
                serialPort.BaudRate = int.Parse((String)(baudRate.SelectedItem));
                serialPort.DataBits = int.Parse((String)(dataBits.SelectedItem));
                
                switch (stop.SelectedIndex)
                {
                    case 0:
                        serialPort.StopBits = StopBits.One;
                        break;
                    // 不支持 StopBits.None, 不知为何OnePointFive的时候回出错,因此没有设置
                    //case 1:   
                    //    serialPort.StopBits = StopBits.OnePointFive;
                    //    break;
                    case 1:
                        serialPort.StopBits = StopBits.Two;
                        break;
                }
                
                switch (parity.SelectedIndex)
                {
                    case 0:
                        serialPort.Parity = Parity.None;
                        break;
                    case 1:
                        serialPort.Parity = Parity.Odd;
                        break;
                    case 2:
                        serialPort.Parity = Parity.Even;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //open or close
        private void start_Click(object sender, EventArgs e)
        {
            if (start.Text == "Open")
            {
                if (serialPort.IsOpen)
                    serialPort.Close();

                try
                {
                    setPort();
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(dealReceive) ;
                    serialPort.Open();
                    start.Text = "Close";
                    send.BackColor = Color.GreenYellow;
                }
                catch (Exception ex)
                //catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("current port has been used by other application! \nor some other error may happened!\n");
                }
            }
            else
            {
                serialPort.Close();
                start.Text = "Open";
                send.BackColor = Color.Gray;
            }
        }
        //清除接收框中的内容
        private void cleanText_Click(object sender, EventArgs e)
        {
            receive.Clear();
        }
    }
}
