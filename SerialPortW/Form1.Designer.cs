namespace SerialPortW
{
    partial class SerialPortW
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.serialPorts = new System.Windows.Forms.ComboBox();
            this.send = new System.Windows.Forms.Button();
            this.receive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port:";
            // 
            // serialPorts
            // 
            this.serialPorts.FormattingEnabled = true;
            this.serialPorts.Location = new System.Drawing.Point(94, 11);
            this.serialPorts.Name = "serialPorts";
            this.serialPorts.Size = new System.Drawing.Size(84, 20);
            this.serialPorts.TabIndex = 1;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(185, 14);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(78, 41);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // receive
            // 
            this.receive.Location = new System.Drawing.Point(12, 117);
            this.receive.Multiline = true;
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(250, 99);
            this.receive.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate:";
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "50",
            "75",
            "110",
            "134",
            "150",
            "200",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "500000",
            "576000",
            "921600",
            "1000000",
            "1152000",
            "1500000",
            "2000000",
            "2500000",
            "3000000",
            "3500000",
            "4000000"});
            this.baudRate.Location = new System.Drawing.Point(94, 35);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(84, 20);
            this.baudRate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity:";
            // 
            // parity
            // 
            this.parity.FormattingEnabled = true;
            this.parity.Items.AddRange(new object[] {
            "EVEN",
            "ODD"});
            this.parity.Location = new System.Drawing.Point(94, 59);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(84, 20);
            this.parity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop:";
            // 
            // stop
            // 
            this.stop.FormattingEnabled = true;
            this.stop.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stop.Location = new System.Drawing.Point(94, 82);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(84, 20);
            this.stop.TabIndex = 7;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(185, 62);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(78, 40);
            this.start.TabIndex = 9;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // SerialPortW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 228);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.parity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receive);
            this.Controls.Add(this.send);
            this.Controls.Add(this.serialPorts);
            this.Controls.Add(this.label1);
            this.Name = "SerialPortW";
            this.Text = "SerialPortW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialPorts;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox receive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stop;
        private System.Windows.Forms.Button start;

    }
}

