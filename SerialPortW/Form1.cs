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

            String[] serialPortArray = SerialPort.GetPortNames();
            if (serialPortArray != null && serialPortArray.Length != 0)
            {
                Array.Sort<String>(serialPortArray);
                foreach (String port in serialPortArray)
                {
                    if (port != null && port.Length != 0)
                        serialPorts.Items.Add(port);
                }
            }

            serialPorts.SelectedIndex = 0;
            baudRate.SelectedIndex = 16;
            parity.SelectedIndex = 0;
            stop.SelectedIndex = 0;

            send.BackColor = Color.Gray;

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
                serialPort.Write("FE FE FE 68 AA AA AA AA AA AA 68 13 00 \n");

        }

        private void setPort()
        {
            try
            {
                serialPort.PortName = (String)(serialPorts.SelectedItem);
                serialPort.BaudRate = int.Parse((String)(baudRate.SelectedItem));
                serialPort.DataBits = 8;
                serialPort.StopBits = int.Parse((String)(baudRate.SelectedItem)) == 0 ? StopBits.One : StopBits.Two;
                serialPort.Parity = int.Parse((String)(baudRate.SelectedItem)) == 0 ? Parity.Even : Parity.Odd;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (start.Text == "Start")
            {
                if (serialPort.IsOpen)
                    serialPort.Close();

                setPort();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(dealReceive) ;

                serialPort.Open();

                start.Text = "Stop";
                send.BackColor = Color.GreenYellow;
            }
            else
            {
                serialPort.Close();

                start.Text = "Start";
                send.BackColor = Color.Gray;
            }
        }
    }
}
