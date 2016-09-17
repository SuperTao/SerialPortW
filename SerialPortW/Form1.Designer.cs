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
            this.comboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStop = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ms = new System.Windows.Forms.Label();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.checkBox_newline = new System.Windows.Forms.CheckBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.TextBoxSend = new System.Windows.Forms.TextBox();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port:";
            // 
            // comboBoxSerialPorts
            // 
            this.comboBoxSerialPorts.FormattingEnabled = true;
            this.comboBoxSerialPorts.Location = new System.Drawing.Point(92, 14);
            this.comboBoxSerialPorts.Name = "comboBoxSerialPorts";
            this.comboBoxSerialPorts.Size = new System.Drawing.Size(84, 20);
            this.comboBoxSerialPorts.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(3, 6);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(74, 30);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(92, 39);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(84, 20);
            this.comboBoxBaudRate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parity:";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.comboBoxParity.Location = new System.Drawing.Point(92, 90);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(84, 20);
            this.comboBoxParity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits:";
            // 
            // comboBoxStop
            // 
            this.comboBoxStop.FormattingEnabled = true;
            this.comboBoxStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxStop.Location = new System.Drawing.Point(92, 115);
            this.comboBoxStop.Name = "comboBoxStop";
            this.comboBoxStop.Size = new System.Drawing.Size(84, 20);
            this.comboBoxStop.TabIndex = 7;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(10, 462);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 30);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(92, 66);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(84, 20);
            this.comboBoxDataBits.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Bits:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ms);
            this.panel1.Controls.Add(this.textBoxTimer);
            this.panel1.Controls.Add(this.checkBoxRepeat);
            this.panel1.Controls.Add(this.checkBox_newline);
            this.panel1.Controls.Add(this.buttonClean);
            this.panel1.Controls.Add(this.comboBoxBaudRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.comboBoxSerialPorts);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxDataBits);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxParity);
            this.panel1.Controls.Add(this.comboBoxStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 504);
            this.panel1.TabIndex = 12;
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.Location = new System.Drawing.Point(159, 434);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(17, 12);
            this.label_ms.TabIndex = 17;
            this.label_ms.Text = "ms";
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(92, 429);
            this.textBoxTimer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(51, 21);
            this.textBoxTimer.TabIndex = 16;
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(12, 434);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(60, 16);
            this.checkBoxRepeat.TabIndex = 15;
            this.checkBoxRepeat.Text = "repeat";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            this.checkBoxRepeat.CheckedChanged += new System.EventHandler(this.checkBoxRepeat_CheckedChanged);
            // 
            // checkBox_newline
            // 
            this.checkBox_newline.AutoSize = true;
            this.checkBox_newline.Location = new System.Drawing.Point(12, 408);
            this.checkBox_newline.Name = "checkBox_newline";
            this.checkBox_newline.Size = new System.Drawing.Size(66, 16);
            this.checkBox_newline.TabIndex = 14;
            this.checkBox_newline.Text = "newline";
            this.checkBox_newline.UseVisualStyleBackColor = true;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(105, 463);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 30);
            this.buttonClean.TabIndex = 13;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.cleanText_Click);
            // 
            // TextBoxSend
            // 
            this.TextBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSend.Location = new System.Drawing.Point(79, 12);
            this.TextBoxSend.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSend.Name = "TextBoxSend";
            this.TextBoxSend.Size = new System.Drawing.Size(400, 21);
            this.TextBoxSend.TabIndex = 12;
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxReceive.Location = new System.Drawing.Point(185, 0);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(476, 450);
            this.richTextBoxReceive.TabIndex = 13;
            this.richTextBoxReceive.Text = "";
            this.richTextBoxReceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxReceive_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonSend);
            this.panel2.Controls.Add(this.TextBoxSend);
            this.panel2.Location = new System.Drawing.Point(182, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 44);
            this.panel2.TabIndex = 14;
            // 
            // SerialPortW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBoxReceive);
            this.Controls.Add(this.panel1);
            this.Name = "SerialPortW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialPort";
            this.Load += new System.EventHandler(this.SerialPortW_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSerialPorts;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStop;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxSend;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
        private System.Windows.Forms.CheckBox checkBox_newline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
    }
}

