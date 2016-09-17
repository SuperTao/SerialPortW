using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace SerialPortW
{
    public partial class SerialPortW : Form
    {

        SerialPort serialPort;
        System.Timers.Timer tmr;

        //定义委托SetTextCallback, 返回值是void，参数类型String
        delegate void SetTextCallback(String text);

        // 构造函数
        public SerialPortW()
        {
            InitializeComponent();
        }

        // Form_Load 事件，程序打开Form的时候触发
        private void SerialPortW_Load(object sender, EventArgs e)
        {
            //这个类中我们不检查跨线程的调用是否合法
            Control.CheckForIllegalCrossThreadCalls = false;
            portInit();
        }

        private void portInit()
        {
            //获取串口
            getAvailablePort();
            //设置初始显示的值 
            comboBoxBaudRate.SelectedIndex = 16;
            comboBoxDataBits.SelectedIndex = 3;
            comboBoxParity.SelectedIndex = 0;
            comboBoxStop.SelectedIndex = 0;

            //按键不使能，只有open的时候，send才使能
            buttonSend.Enabled = false;

            // 发送端默认发送字节
            //TextBoxSend.Text = "abcdefghijklmnopqrstuvwxyz0123456789";

            //定时器时间间隔, ms
            textBoxTimer.Text = "1000";
            //初始化定时器
            tmr = new System.Timers.Timer();
            // 这里只需要创建一个事件就行,以前的操作每次点击open按键就创建一次，浪费资源
            // 操作中，通过，start()，stop()函数进行控制
            tmr.Elapsed += new ElapsedEventHandler(tmr_timeout);

            //创建串口对象
            serialPort = new SerialPort();

            // 创建串口接收事件
            // 这里只需要创建一个事件就行,以前的操作每次点击open按键就创建一次，浪费资源
            // 操作中，通过，start()，stop()函数进行控制
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dealReceive) ;
        }

        private void getAvailablePort()
        {
            try
            {
                // 获取系统的串口
                String[] serialPortArray = SerialPort.GetPortNames();
                // 电脑没有串口,抛出异常
                if (serialPortArray.Length == 0)
                {
                     throw (new System.IO.IOException("This computer don't have serial port!"));
                }
                // 串口显示在comboBox中
                if (serialPortArray != null && serialPortArray.Length != 0)
                {
                    //对串口进行排序, 泛型的值是string，按照string类型进行排序
                    Array.Sort<String>(serialPortArray);
                    foreach (String port in serialPortArray)
                    {
                        //添加到combox的item
                        if (port != null && port.Length != 0)
                            comboBoxSerialPorts.Items.Add(port);
                        Console.WriteLine(port);
                    }
                    //默认选择第一个com，需要在if里面设置，如果没有检查到串口，在if外卖你设置就会出错。 
                    comboBoxSerialPorts.SelectedIndex = 0;
                }
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dealReceive(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                // 缓存中有'\n'才会将数据读取，否则读取得到的数据为空
                //String data = serialPort.ReadLine();
                // 读取缓存中的数据,不管有没有'\n'
                String data = serialPort.ReadExisting();
                if (data != String.Empty)
                {
                    // 线程更新UI
                    this.BeginInvoke(new SetTextCallback(SetText), new object[] { data });
                }
            }
        }

        private void SetText(String text)
        {
            // 设置焦点到richTextBoxReceive
            //richTextBoxReceive.Focus();
            // 需要手动设置richTextBox的滚动条，否则不会自动更新,只显示最开始的内容
            // 设置光标的位置到文本尾   
            richTextBoxReceive.Select(richTextBoxReceive.TextLength, 0);
            // 滚动到控件光标处   
            richTextBoxReceive.ScrollToCaret();
            // 在末尾添加新内容
            richTextBoxReceive.AppendText(text);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                //根据checkBox判断发送的数据最后是否添加'\n'
                if (checkBox_newline.Checked == true)
                    serialPort.Write(TextBoxSend.Text.ToString() + '\n');
                else if (checkBox_newline.Checked == false)
                    serialPort.Write(TextBoxSend.Text.ToString());
            }
        }

        private void setPort()
        {
            try
            {
                serialPort.PortName = (String)(comboBoxSerialPorts.SelectedItem);
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.SelectedItem);
                serialPort.DataBits = Convert.ToInt32(comboBoxDataBits.SelectedItem);
                
                switch (comboBoxStop.SelectedIndex)
                {
                    case 0:
                        serialPort.StopBits = StopBits.One;
                        break;
                    case 1:   
                        serialPort.StopBits = StopBits.OnePointFive;
                        break;
                    case 2:
                        serialPort.StopBits = StopBits.Two;
                        break;
                }
                
                switch (comboBoxParity.SelectedIndex)
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
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (buttonOpen.Text == "Open")
            {
                try
                {
                    setPort();
                    serialPort.Open();
                    buttonOpen.Text = "Close";
                    buttonSend.Enabled = true;

                    // 是否打开定时器
                    if (checkBoxRepeat.Checked == true)
                    {
                        // 打开了定时器之后，定时的时间就不能设置
                        textBoxTimer.Enabled = false;
                        // 设置时间
                        tmr.Interval = (double)(int.Parse(textBoxTimer.Text));  //ms
                        tmr.Enabled = true;
                        tmr.AutoReset = true;      //false:只定时一次, true：重复执行
                        tmr.Start();
                    }
                    else
                    {
                        // 如果定时器没打开，就可以设置定时的时间
                        textBoxTimer.Enabled = true;
                    }
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("current port has been used by other application! \nor some other error may happened!\n");
                }
                catch (System.IO.IOException)
                {
                    // 如果程序打开时存在串口设备，就会显示在UI上
                    // 但是如果将串口（例如usb转串口转换器）拔了，这个电脑就不存在串口，但UI还是显示这个设备存在
                    // 打开时就会出现异常
                    MessageBox.Show("current port don't exist!\n");
                }
            }
            else
            {
                serialPort.Close();
                buttonOpen.Text = "Open";
                buttonSend.Enabled = false;
                // 根据checkBoxRepeat检查定时器是否打开
                if (checkBoxRepeat.Checked == true)
                {
                    // 检查定时器是否使能
                    if (tmr.Enabled == true)
                    { 
                        // stop 
                        tmr.Stop();
                        tmr.Enabled = false;
                    }
                    // 不能设置定时时间
                    textBoxTimer.Enabled = false;
                }
                else
                {
                    // 可以设置定时时间
                    textBoxTimer.Enabled = true;
                }
            }

        }
        //清除接收框中的内容
        private void cleanText_Click(object sender, EventArgs e)
        {
            richTextBoxReceive.Clear();
        }

        // Todo: 模仿超级终端等软件，在接受框中输入能够与串口连接的设备进行交互
        // if you don't need it ,just comment or delete it!
        // 接受框按键事件处理
        private void richTextBoxReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)13) // enter key  
            {
                //serialPort.Write("\r");
                //byte by = 0x0A; '\n'
                byte[] by = {0x0A };
                //byte by = 0x0D; '\r'
                //byte[] by = {0x0D };
                // enter
                serialPort.Write(by, 0, by.Length);
                //serialPort.DiscardInBuffer();
                //byte by = 0x0A;
                //serialPort.BytesToWrite(by);
                //serialPort.Write("\r\n");
                //serialport.wir.Write("\r\n");
                //rtbOutgoing.Text = "";
            }
            else if (e.KeyChar == (char)3)
            {
                MessageBox.Show("You pressed control + c");
                byte[] by = { 0x03 };
                serialPort.Write(by, 0, by.Length);
                //return true;
//                serialPort.Write('^C');
            }
            else if (e.KeyChar < 32 || e.KeyChar > 126)
            {
                e.Handled = true; // ignores anything else outside printable ASCII range
            }
            else
            {
                //ComPort.Write(e.KeyChar.ToString());
                serialPort.Write(e.KeyChar.ToString());
            }
            */
        }
        
        // Todo:
        // if you don't need it ,just comment or delete it!
        // 方向键按键事件处理,通过重载processCmdKey函数实现
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            /*
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                MessageBox.Show("You pressed Up arrow key");
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                MessageBox.Show("You pressed Down arrow key");
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                MessageBox.Show("You pressed Left arrow key");
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                MessageBox.Show("You pressed Right arrow key");
                return true;
            }
           if (keyData == (Keys.Control | Keys.C))
            {
                MessageBox.Show("You pressed control + c");
                return true;

            }
            */
            return base.ProcessCmdKey(ref msg, keyData);
        }
        void tmr_timeout(object sender, ElapsedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                try
                {
                    if (serialPort.IsOpen == true && tmr.Enabled == true)
                    {
                        if (checkBox_newline.Checked == true)
                            serialPort.Write(TextBoxSend.Text.ToString() + '\n');
                        else if (checkBox_newline.Checked == false)
                            serialPort.Write(TextBoxSend.Text.ToString());
                    }
                }
                catch (System.InvalidOperationException)
                {
                    Console.WriteLine("invalid exception ------");
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("io exception ------");
                }
            }
        }

        // checkBox状态改变出发事件
        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            // 串口打开
            if (serialPort.IsOpen == true)
            {
                    // 检查此时checkBox状态
                    if (checkBoxRepeat.Checked == true)
                    {
                        // 开启定时器
                        if (tmr.Enabled == false)
                        { 
                            tmr.Interval = (double)(int.Parse(textBoxTimer.Text));  //ms
                            tmr.Start();
                            tmr.Enabled = true;

                            textBoxTimer.Enabled = false;
                        }
                    }
                    else if (checkBoxRepeat.Checked == false)
                    {
                        // 定时器如果打开, 关闭定时器
                        if (tmr.Enabled == true)
                        {
                            // stop
                            tmr.Stop();
                            tmr.Enabled = false;
                        }
                        textBoxTimer.Enabled = true;
                    }
            }
            else        //串口没打开           
            {
                // 只设置textBoxTimer是否时能
                if (textBoxTimer.Enabled)
                    textBoxTimer.Enabled = false;
                else
                    textBoxTimer.Enabled = true;
            }
        }

    }
}