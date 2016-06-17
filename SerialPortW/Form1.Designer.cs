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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port:";
            // 
            // serialPorts
            // 
            this.serialPorts.FormattingEnabled = true;
            this.serialPorts.Location = new System.Drawing.Point(94, 12);
            this.serialPorts.Name = "serialPorts";
            this.serialPorts.Size = new System.Drawing.Size(69, 20);
            this.serialPorts.TabIndex = 1;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(220, 10);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(42, 23);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // receive
            // 
            this.receive.Location = new System.Drawing.Point(12, 45);
            this.receive.Multiline = true;
            this.receive.Name = "receive";
            this.receive.Size = new System.Drawing.Size(250, 99);
            this.receive.TabIndex = 3;
            // 
            // SerialPortW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 155);
            this.Controls.Add(this.receive);
            this.Controls.Add(this.send);
            this.Controls.Add(this.serialPorts);
            this.Controls.Add(this.label1);
            this.Name = "SerialPortW";
            this.Text = "SerialPortW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialPorts;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox receive;

    }
}

