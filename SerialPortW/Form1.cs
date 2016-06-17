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
        public SerialPortW()
        {
            InitializeComponent();

            String[] serialPortString = SerialPort.GetPortNames();
            ComboBox serialPorts = (ComboBox)GetControl("serialPorts", this);
            if (serialPortString != null && serialPortString.Length != 0 && serialPorts != null)
            {
                Array.Sort<String>(serialPortString);
                foreach (String port in serialPortString)
                {
                    if (port != null && port.Length != 0)
                        serialPorts.Items.Add(port);
                }
                serialPorts.SelectedIndex = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Control GetControl(string name, Control parent)
        {
            foreach (Control Item in parent.Controls)
            {
                if (Item.Name == name)
                {
                    return Item;
                }
                else
                {
                    Control control = GetControl(name, Item);
                    if (control != null)
                    {
                        return control;
                    }
                }
            }
            return null;
        }

        private void send_Click(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort();

            serialPort.PortName = (String)((ComboBox)GetControl("serialPorts", this)).SelectedItem;
            serialPort.BaudRate = 115200;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Parity = Parity.Even;

            serialPort.Open();
            serialPort.Write("FE FE FE 68 AA AA AA AA AA AA 68 13 00 \n");

            Thread.Sleep(100);
            String data = serialPort.ReadExisting();

            serialPort.Close();

            TextBox receive = (TextBox)GetControl("receive", this);
            receive.AppendText(data);
        }
    }
}
