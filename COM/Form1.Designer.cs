namespace COM
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comport = new System.IO.Ports.SerialPort(this.components);
            this.textShow = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.ComboBox();
            this.txtParity = new System.Windows.Forms.ComboBox();
            this.txtDatabits = new System.Windows.Forms.ComboBox();
            this.txtStopbits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textReceive = new System.Windows.Forms.TextBox();
            this.buttonRSlinetest = new System.Windows.Forms.Button();
            this.buttonInitialize = new System.Windows.Forms.Button();
            this.buttonOutPutModelInformation = new System.Windows.Forms.Button();
            this.buttonIndicatedValue = new System.Windows.Forms.Button();
            this.buttonTransmissionMode00 = new System.Windows.Forms.Button();
            this.buttonTransmissionMode10 = new System.Windows.Forms.Button();
            this.buttonMinimumSetting = new System.Windows.Forms.Button();
            this.buttonMaximumSetting = new System.Windows.Forms.Button();
            this.textMinimumSetting = new System.Windows.Forms.TextBox();
            this.textMaximumSetting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.FormattingEnabled = true;
            this.txtPort.Location = new System.Drawing.Point(36, 38);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(79, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "null";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(463, 19);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(101, 29);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(463, 52);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(101, 29);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(36, 98);
            this.textSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSend.Multiline = true;
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(461, 86);
            this.textSend.TabIndex = 4;
            this.textSend.TextChanged += new System.EventHandler(this.textSend_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(503, 148);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(71, 36);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Send:";
            // 
            // textShow
            // 
            this.textShow.Location = new System.Drawing.Point(580, 98);
            this.textShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textShow.Multiline = true;
            this.textShow.Name = "textShow";
            this.textShow.Size = new System.Drawing.Size(399, 336);
            this.textShow.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baud Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Databits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stopbits";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.FormattingEnabled = true;
            this.txtBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400"});
            this.txtBaudRate.Location = new System.Drawing.Point(121, 36);
            this.txtBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(79, 23);
            this.txtBaudRate.TabIndex = 16;
            this.txtBaudRate.Text = "9600";
            // 
            // txtParity
            // 
            this.txtParity.FormattingEnabled = true;
            this.txtParity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.txtParity.Location = new System.Drawing.Point(207, 38);
            this.txtParity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(79, 23);
            this.txtParity.TabIndex = 17;
            this.txtParity.Text = "Odd";
            // 
            // txtDatabits
            // 
            this.txtDatabits.FormattingEnabled = true;
            this.txtDatabits.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.txtDatabits.Location = new System.Drawing.Point(292, 38);
            this.txtDatabits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatabits.Name = "txtDatabits";
            this.txtDatabits.Size = new System.Drawing.Size(79, 23);
            this.txtDatabits.TabIndex = 18;
            this.txtDatabits.Text = "7";
            // 
            // txtStopbits
            // 
            this.txtStopbits.FormattingEnabled = true;
            this.txtStopbits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.txtStopbits.Location = new System.Drawing.Point(377, 38);
            this.txtStopbits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStopbits.Name = "txtStopbits";
            this.txtStopbits.Size = new System.Drawing.Size(79, 23);
            this.txtStopbits.TabIndex = 19;
            this.txtStopbits.Text = "One";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(759, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "LOG";
            // 
            // textReceive
            // 
            this.textReceive.Location = new System.Drawing.Point(36, 332);
            this.textReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textReceive.Multiline = true;
            this.textReceive.Name = "textReceive";
            this.textReceive.Size = new System.Drawing.Size(461, 102);
            this.textReceive.TabIndex = 21;
            // 
            // buttonRSlinetest
            // 
            this.buttonRSlinetest.Location = new System.Drawing.Point(143, 190);
            this.buttonRSlinetest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRSlinetest.Name = "buttonRSlinetest";
            this.buttonRSlinetest.Size = new System.Drawing.Size(101, 36);
            this.buttonRSlinetest.TabIndex = 22;
            this.buttonRSlinetest.Text = "連接線路";
            this.buttonRSlinetest.UseVisualStyleBackColor = true;
            this.buttonRSlinetest.Click += new System.EventHandler(this.buttonRSlinetest_Click);
            // 
            // buttonInitialize
            // 
            this.buttonInitialize.Location = new System.Drawing.Point(36, 190);
            this.buttonInitialize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInitialize.Name = "buttonInitialize";
            this.buttonInitialize.Size = new System.Drawing.Size(101, 36);
            this.buttonInitialize.TabIndex = 23;
            this.buttonInitialize.Text = "機器初始化";
            this.buttonInitialize.UseVisualStyleBackColor = true;
            this.buttonInitialize.Click += new System.EventHandler(this.buttonInitialize_Click);
            // 
            // buttonOutPutModelInformation
            // 
            this.buttonOutPutModelInformation.Location = new System.Drawing.Point(250, 190);
            this.buttonOutPutModelInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOutPutModelInformation.Name = "buttonOutPutModelInformation";
            this.buttonOutPutModelInformation.Size = new System.Drawing.Size(101, 36);
            this.buttonOutPutModelInformation.TabIndex = 24;
            this.buttonOutPutModelInformation.Text = "設備資料";
            this.buttonOutPutModelInformation.UseVisualStyleBackColor = true;
            this.buttonOutPutModelInformation.Click += new System.EventHandler(this.buttonOutPutModelInformation_Click);
            // 
            // buttonIndicatedValue
            // 
            this.buttonIndicatedValue.Location = new System.Drawing.Point(104, 242);
            this.buttonIndicatedValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIndicatedValue.Name = "buttonIndicatedValue";
            this.buttonIndicatedValue.Size = new System.Drawing.Size(131, 36);
            this.buttonIndicatedValue.TabIndex = 25;
            this.buttonIndicatedValue.Text = "感測資料(次)";
            this.buttonIndicatedValue.UseVisualStyleBackColor = true;
            this.buttonIndicatedValue.Click += new System.EventHandler(this.buttonIndicatedValue_Click);
            // 
            // buttonTransmissionMode00
            // 
            this.buttonTransmissionMode00.Location = new System.Drawing.Point(36, 282);
            this.buttonTransmissionMode00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransmissionMode00.Name = "buttonTransmissionMode00";
            this.buttonTransmissionMode00.Size = new System.Drawing.Size(131, 36);
            this.buttonTransmissionMode00.TabIndex = 26;
            this.buttonTransmissionMode00.Text = "感測資料(ON)";
            this.buttonTransmissionMode00.UseVisualStyleBackColor = true;
            this.buttonTransmissionMode00.Click += new System.EventHandler(this.buttonTransmissionMode00_Click);
            // 
            // buttonTransmissionMode10
            // 
            this.buttonTransmissionMode10.Location = new System.Drawing.Point(173, 282);
            this.buttonTransmissionMode10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransmissionMode10.Name = "buttonTransmissionMode10";
            this.buttonTransmissionMode10.Size = new System.Drawing.Size(131, 36);
            this.buttonTransmissionMode10.TabIndex = 27;
            this.buttonTransmissionMode10.Text = "感測資料(OFF)";
            this.buttonTransmissionMode10.UseVisualStyleBackColor = true;
            this.buttonTransmissionMode10.Click += new System.EventHandler(this.buttonTransmissionMode10_Click);
            // 
            // buttonMinimumSetting
            // 
            this.buttonMinimumSetting.Location = new System.Drawing.Point(463, 218);
            this.buttonMinimumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimumSetting.Name = "buttonMinimumSetting";
            this.buttonMinimumSetting.Size = new System.Drawing.Size(87, 36);
            this.buttonMinimumSetting.TabIndex = 28;
            this.buttonMinimumSetting.Text = "設定最小";
            this.buttonMinimumSetting.UseVisualStyleBackColor = true;
            this.buttonMinimumSetting.Click += new System.EventHandler(this.buttonMinimumSetting_Click);
            // 
            // buttonMaximumSetting
            // 
            this.buttonMaximumSetting.Location = new System.Drawing.Point(463, 258);
            this.buttonMaximumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMaximumSetting.Name = "buttonMaximumSetting";
            this.buttonMaximumSetting.Size = new System.Drawing.Size(87, 36);
            this.buttonMaximumSetting.TabIndex = 29;
            this.buttonMaximumSetting.Text = "設定最大";
            this.buttonMaximumSetting.UseVisualStyleBackColor = true;
            this.buttonMaximumSetting.Click += new System.EventHandler(this.buttonMaximumSetting_Click);
            // 
            // textMinimumSetting
            // 
            this.textMinimumSetting.Location = new System.Drawing.Point(381, 223);
            this.textMinimumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMinimumSetting.Multiline = true;
            this.textMinimumSetting.Name = "textMinimumSetting";
            this.textMinimumSetting.Size = new System.Drawing.Size(76, 31);
            this.textMinimumSetting.TabIndex = 30;
            this.textMinimumSetting.Text = "0";
            this.textMinimumSetting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMinimumSetting_KeyPress);
            // 
            // textMaximumSetting
            // 
            this.textMaximumSetting.Location = new System.Drawing.Point(381, 258);
            this.textMaximumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMaximumSetting.Multiline = true;
            this.textMaximumSetting.Name = "textMaximumSetting";
            this.textMaximumSetting.Size = new System.Drawing.Size(76, 31);
            this.textMaximumSetting.TabIndex = 31;
            this.textMaximumSetting.Text = "0";
            this.textMaximumSetting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMaximumSetting_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 476);
            this.Controls.Add(this.textMaximumSetting);
            this.Controls.Add(this.textMinimumSetting);
            this.Controls.Add(this.buttonMaximumSetting);
            this.Controls.Add(this.buttonMinimumSetting);
            this.Controls.Add(this.buttonTransmissionMode10);
            this.Controls.Add(this.buttonTransmissionMode00);
            this.Controls.Add(this.buttonIndicatedValue);
            this.Controls.Add(this.buttonOutPutModelInformation);
            this.Controls.Add(this.buttonInitialize);
            this.Controls.Add(this.buttonRSlinetest);
            this.Controls.Add(this.textReceive);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStopbits);
            this.Controls.Add(this.txtDatabits);
            this.Controls.Add(this.txtParity);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textSend);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtPort;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort comport;
        private System.Windows.Forms.TextBox textShow;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtBaudRate;
        private System.Windows.Forms.ComboBox txtParity;
        private System.Windows.Forms.ComboBox txtDatabits;
        private System.Windows.Forms.ComboBox txtStopbits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textReceive;
        private System.Windows.Forms.Button buttonRSlinetest;
        private System.Windows.Forms.Button buttonInitialize;
        private System.Windows.Forms.Button buttonOutPutModelInformation;
        private System.Windows.Forms.Button buttonIndicatedValue;
        private System.Windows.Forms.Button buttonTransmissionMode00;
        private System.Windows.Forms.Button buttonTransmissionMode10;
        private System.Windows.Forms.Button buttonMinimumSetting;
        private System.Windows.Forms.Button buttonMaximumSetting;
        private System.Windows.Forms.TextBox textMinimumSetting;
        private System.Windows.Forms.TextBox textMaximumSetting;
    }
}

