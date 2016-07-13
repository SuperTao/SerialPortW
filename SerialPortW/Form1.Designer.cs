﻿namespace SerialPortW
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
            this.dataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.regexbox = new System.Windows.Forms.TextBox();
            this.misline_num = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mismatch_num = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cleanText = new System.Windows.Forms.Button();
            this.sendText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port:";
            // 
            // serialPorts
            // 
            this.serialPorts.FormattingEnabled = true;
            this.serialPorts.Location = new System.Drawing.Point(123, 91);
            this.serialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.serialPorts.Name = "serialPorts";
            this.serialPorts.Size = new System.Drawing.Size(111, 23);
            this.serialPorts.TabIndex = 1;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(17, 22);
            this.send.Margin = new System.Windows.Forms.Padding(4);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(104, 51);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // receive
            // 
            this.receive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.receive.Location = new System.Drawing.Point(0, 0);
            this.receive.Margin = new System.Windows.Forms.Padding(4);
            this.receive.Multiline = true;
            this.receive.Name = "receive";
            this.receive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.receive.Size = new System.Drawing.Size(853, 273);
            this.receive.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
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
            this.baudRate.Location = new System.Drawing.Point(123, 122);
            this.baudRate.Margin = new System.Windows.Forms.Padding(4);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(111, 23);
            this.baudRate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity:";
            // 
            // parity
            // 
            this.parity.FormattingEnabled = true;
            this.parity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.parity.Location = new System.Drawing.Point(123, 186);
            this.parity.Margin = new System.Windows.Forms.Padding(4);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(111, 23);
            this.parity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits:";
            // 
            // stop
            // 
            this.stop.FormattingEnabled = true;
            this.stop.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stop.Location = new System.Drawing.Point(123, 217);
            this.stop.Margin = new System.Windows.Forms.Padding(4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(111, 23);
            this.stop.TabIndex = 7;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(719, 76);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 50);
            this.start.TabIndex = 9;
            this.start.Text = "Open";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // dataBits
            // 
            this.dataBits.FormattingEnabled = true;
            this.dataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBits.Location = new System.Drawing.Point(123, 156);
            this.dataBits.Name = "dataBits";
            this.dataBits.Size = new System.Drawing.Size(111, 23);
            this.dataBits.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Bits:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.regexbox);
            this.panel1.Controls.Add(this.misline_num);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mismatch_num);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cleanText);
            this.panel1.Controls.Add(this.sendText);
            this.panel1.Controls.Add(this.baudRate);
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.serialPorts);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataBits);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.parity);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 264);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "MatchString：";
            // 
            // regexbox
            // 
            this.regexbox.Location = new System.Drawing.Point(396, 91);
            this.regexbox.Name = "regexbox";
            this.regexbox.Size = new System.Drawing.Size(277, 25);
            this.regexbox.TabIndex = 18;
            // 
            // misline_num
            // 
            this.misline_num.AutoSize = true;
            this.misline_num.ForeColor = System.Drawing.Color.Red;
            this.misline_num.Location = new System.Drawing.Point(425, 164);
            this.misline_num.Name = "misline_num";
            this.misline_num.Size = new System.Drawing.Size(15, 15);
            this.misline_num.TabIndex = 17;
            this.misline_num.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "misline：";
            // 
            // mismatch_num
            // 
            this.mismatch_num.AutoSize = true;
            this.mismatch_num.ForeColor = System.Drawing.Color.Red;
            this.mismatch_num.Location = new System.Drawing.Point(425, 130);
            this.mismatch_num.Name = "mismatch_num";
            this.mismatch_num.Size = new System.Drawing.Size(15, 15);
            this.mismatch_num.TabIndex = 15;
            this.mismatch_num.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "mismatch：";
            // 
            // cleanText
            // 
            this.cleanText.Location = new System.Drawing.Point(396, 22);
            this.cleanText.Name = "cleanText";
            this.cleanText.Size = new System.Drawing.Size(75, 51);
            this.cleanText.TabIndex = 13;
            this.cleanText.Text = "Clean";
            this.cleanText.UseVisualStyleBackColor = true;
            this.cleanText.Click += new System.EventHandler(this.cleanText_Click);
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(133, 34);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(248, 25);
            this.sendText.TabIndex = 12;
            // 
            // SerialPortW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.receive);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SerialPortW";
            this.Text = "SerialPortW";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox dataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button cleanText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label misline_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mismatch_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regexbox;
    }
}

