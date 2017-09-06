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
<<<<<<< HEAD
            this.textBoxsamplerate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.samplestart = new System.Windows.Forms.Button();
            this.samplestop = new System.Windows.Forms.Button();
            this.setparameter = new System.Windows.Forms.Button();
=======
            this.lowLight = new System.Windows.Forms.Label();
            this.OKlight = new System.Windows.Forms.Label();
            this.highLight = new System.Windows.Forms.Label();
            this.statusHighLight = new System.Windows.Forms.Label();
            this.statusLowLight = new System.Windows.Forms.Label();
            this.statusOKLight = new System.Windows.Forms.Label();
            this.statusDuringMeasurement = new System.Windows.Forms.Label();
            this.statusDetectingPeak = new System.Windows.Forms.Label();
            this.statusDuringHold = new System.Windows.Forms.Label();
>>>>>>> Test01
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
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(519, 148);
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
<<<<<<< HEAD
            this.textShow.Location = new System.Drawing.Point(596, 98);
=======
            this.textShow.Location = new System.Drawing.Point(714, 52);
>>>>>>> Test01
            this.textShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textShow.Multiline = true;
            this.textShow.Name = "textShow";
            this.textShow.Size = new System.Drawing.Size(265, 382);
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
<<<<<<< HEAD
            this.label8.Location = new System.Drawing.Point(773, 66);
=======
            this.label8.Location = new System.Drawing.Point(825, 20);
>>>>>>> Test01
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "LOG";
            // 
            // textReceive
            // 
            this.textReceive.Location = new System.Drawing.Point(36, 354);
            this.textReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textReceive.Multiline = true;
            this.textReceive.Name = "textReceive";
            this.textReceive.Size = new System.Drawing.Size(461, 102);
            this.textReceive.TabIndex = 21;
            // 
            // buttonRSlinetest
            // 
            this.buttonRSlinetest.Location = new System.Drawing.Point(162, 190);
            this.buttonRSlinetest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRSlinetest.Name = "buttonRSlinetest";
            this.buttonRSlinetest.Size = new System.Drawing.Size(120, 36);
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
            this.buttonInitialize.Size = new System.Drawing.Size(120, 36);
            this.buttonInitialize.TabIndex = 23;
            this.buttonInitialize.Text = "機器初始化";
            this.buttonInitialize.UseVisualStyleBackColor = true;
            this.buttonInitialize.Click += new System.EventHandler(this.buttonInitialize_Click);
            // 
            // buttonOutPutModelInformation
            // 
            this.buttonOutPutModelInformation.Location = new System.Drawing.Point(288, 190);
            this.buttonOutPutModelInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOutPutModelInformation.Name = "buttonOutPutModelInformation";
            this.buttonOutPutModelInformation.Size = new System.Drawing.Size(120, 36);
            this.buttonOutPutModelInformation.TabIndex = 24;
            this.buttonOutPutModelInformation.Text = "設備資料";
            this.buttonOutPutModelInformation.UseVisualStyleBackColor = true;
            this.buttonOutPutModelInformation.Click += new System.EventHandler(this.buttonOutPutModelInformation_Click);
            // 
            // buttonIndicatedValue
            // 
<<<<<<< HEAD
            this.buttonIndicatedValue.Location = new System.Drawing.Point(36, 230);
=======
            this.buttonIndicatedValue.Location = new System.Drawing.Point(102, 274);
>>>>>>> Test01
            this.buttonIndicatedValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIndicatedValue.Name = "buttonIndicatedValue";
            this.buttonIndicatedValue.Size = new System.Drawing.Size(120, 36);
            this.buttonIndicatedValue.TabIndex = 25;
            this.buttonIndicatedValue.Text = "感測資料(次)";
            this.buttonIndicatedValue.UseVisualStyleBackColor = true;
            this.buttonIndicatedValue.Click += new System.EventHandler(this.buttonIndicatedValue_Click);
            // 
            // buttonTransmissionMode00
            // 
<<<<<<< HEAD
            this.buttonTransmissionMode00.Location = new System.Drawing.Point(162, 230);
=======
            this.buttonTransmissionMode00.Location = new System.Drawing.Point(36, 314);
>>>>>>> Test01
            this.buttonTransmissionMode00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransmissionMode00.Name = "buttonTransmissionMode00";
            this.buttonTransmissionMode00.Size = new System.Drawing.Size(120, 36);
            this.buttonTransmissionMode00.TabIndex = 26;
            this.buttonTransmissionMode00.Text = "感測資料(ON)\r\n";
            this.buttonTransmissionMode00.UseVisualStyleBackColor = true;
            this.buttonTransmissionMode00.Click += new System.EventHandler(this.buttonTransmissionMode00_Click);
            // 
            // buttonTransmissionMode10
            // 
<<<<<<< HEAD
            this.buttonTransmissionMode10.Location = new System.Drawing.Point(288, 230);
=======
            this.buttonTransmissionMode10.Location = new System.Drawing.Point(173, 314);
>>>>>>> Test01
            this.buttonTransmissionMode10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransmissionMode10.Name = "buttonTransmissionMode10";
            this.buttonTransmissionMode10.Size = new System.Drawing.Size(120, 36);
            this.buttonTransmissionMode10.TabIndex = 27;
            this.buttonTransmissionMode10.Text = "感測資料(OFF)";
            this.buttonTransmissionMode10.UseVisualStyleBackColor = true;
            this.buttonTransmissionMode10.Click += new System.EventHandler(this.buttonTransmissionMode10_Click);
            // 
            // buttonMinimumSetting
            // 
            this.buttonMinimumSetting.Location = new System.Drawing.Point(503, 190);
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
            this.buttonMaximumSetting.Location = new System.Drawing.Point(503, 230);
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
            this.textMinimumSetting.Location = new System.Drawing.Point(421, 190);
            this.textMinimumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMinimumSetting.Multiline = true;
            this.textMinimumSetting.Name = "textMinimumSetting";
            this.textMinimumSetting.Size = new System.Drawing.Size(76, 36);
            this.textMinimumSetting.TabIndex = 30;
            this.textMinimumSetting.Text = "0";
            this.textMinimumSetting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMinimumSetting_KeyPress);
            // 
            // textMaximumSetting
            // 
            this.textMaximumSetting.Location = new System.Drawing.Point(421, 230);
            this.textMaximumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMaximumSetting.Multiline = true;
            this.textMaximumSetting.Name = "textMaximumSetting";
            this.textMaximumSetting.Size = new System.Drawing.Size(76, 36);
            this.textMaximumSetting.TabIndex = 31;
            this.textMaximumSetting.Text = "0";
            this.textMaximumSetting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMaximumSetting_KeyPress);
            // 
<<<<<<< HEAD
            // textBoxsamplerate
            // 
            this.textBoxsamplerate.Location = new System.Drawing.Point(36, 291);
            this.textBoxsamplerate.Multiline = true;
            this.textBoxsamplerate.Name = "textBoxsamplerate";
            this.textBoxsamplerate.Size = new System.Drawing.Size(111, 36);
            this.textBoxsamplerate.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Set Sample Rate:(ms)";
            // 
            // samplestart
            // 
            this.samplestart.Location = new System.Drawing.Point(153, 291);
            this.samplestart.Name = "samplestart";
            this.samplestart.Size = new System.Drawing.Size(111, 36);
            this.samplestart.TabIndex = 34;
            this.samplestart.Text = "開始";
            this.samplestart.UseVisualStyleBackColor = true;
            this.samplestart.Click += new System.EventHandler(this.Samplestart_Click);
            // 
            // samplestop
            // 
            this.samplestop.Location = new System.Drawing.Point(270, 291);
            this.samplestop.Name = "samplestop";
            this.samplestop.Size = new System.Drawing.Size(111, 36);
            this.samplestop.TabIndex = 35;
            this.samplestop.Text = "結束";
            this.samplestop.UseVisualStyleBackColor = true;
            this.samplestop.Click += new System.EventHandler(this.Samplestop_Click);
            // 
            // setparameter
            // 
            this.setparameter.Location = new System.Drawing.Point(570, 19);
            this.setparameter.Name = "setparameter";
            this.setparameter.Size = new System.Drawing.Size(101, 29);
            this.setparameter.TabIndex = 36;
            this.setparameter.Text = "Set Parameter";
            this.setparameter.UseVisualStyleBackColor = true;
            this.setparameter.Click += new System.EventHandler(this.Setparameter_Click);
=======
            // lowLight
            // 
            this.lowLight.AutoSize = true;
            this.lowLight.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lowLight.Location = new System.Drawing.Point(631, 248);
            this.lowLight.Name = "lowLight";
            this.lowLight.Size = new System.Drawing.Size(49, 34);
            this.lowLight.TabIndex = 33;
            this.lowLight.Text = "●";
            // 
            // OKlight
            // 
            this.OKlight.AutoSize = true;
            this.OKlight.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OKlight.Location = new System.Drawing.Point(631, 160);
            this.OKlight.Name = "OKlight";
            this.OKlight.Size = new System.Drawing.Size(49, 34);
            this.OKlight.TabIndex = 34;
            this.OKlight.Text = "●";
            // 
            // highLight
            // 
            this.highLight.AutoSize = true;
            this.highLight.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.highLight.Location = new System.Drawing.Point(631, 78);
            this.highLight.Name = "highLight";
            this.highLight.Size = new System.Drawing.Size(49, 34);
            this.highLight.TabIndex = 35;
            this.highLight.Text = "●";
            // 
            // statusHighLight
            // 
            this.statusHighLight.AutoSize = true;
            this.statusHighLight.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusHighLight.Location = new System.Drawing.Point(576, 78);
            this.statusHighLight.Name = "statusHighLight";
            this.statusHighLight.Size = new System.Drawing.Size(49, 34);
            this.statusHighLight.TabIndex = 36;
            this.statusHighLight.Text = "●";
            // 
            // statusLowLight
            // 
            this.statusLowLight.AutoSize = true;
            this.statusLowLight.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusLowLight.Location = new System.Drawing.Point(576, 112);
            this.statusLowLight.Name = "statusLowLight";
            this.statusLowLight.Size = new System.Drawing.Size(49, 34);
            this.statusLowLight.TabIndex = 37;
            this.statusLowLight.Text = "●";
            // 
            // statusOKLight
            // 
            this.statusOKLight.AutoSize = true;
            this.statusOKLight.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusOKLight.Location = new System.Drawing.Point(576, 146);
            this.statusOKLight.Name = "statusOKLight";
            this.statusOKLight.Size = new System.Drawing.Size(49, 34);
            this.statusOKLight.TabIndex = 38;
            this.statusOKLight.Text = "●";
            // 
            // statusDuringMeasurement
            // 
            this.statusDuringMeasurement.AutoSize = true;
            this.statusDuringMeasurement.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusDuringMeasurement.Location = new System.Drawing.Point(576, 180);
            this.statusDuringMeasurement.Name = "statusDuringMeasurement";
            this.statusDuringMeasurement.Size = new System.Drawing.Size(49, 34);
            this.statusDuringMeasurement.TabIndex = 39;
            this.statusDuringMeasurement.Text = "●";
            // 
            // statusDetectingPeak
            // 
            this.statusDetectingPeak.AutoSize = true;
            this.statusDetectingPeak.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusDetectingPeak.Location = new System.Drawing.Point(576, 214);
            this.statusDetectingPeak.Name = "statusDetectingPeak";
            this.statusDetectingPeak.Size = new System.Drawing.Size(49, 34);
            this.statusDetectingPeak.TabIndex = 40;
            this.statusDetectingPeak.Text = "●";
            // 
            // statusDuringHold
            // 
            this.statusDuringHold.AutoSize = true;
            this.statusDuringHold.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusDuringHold.Location = new System.Drawing.Point(576, 248);
            this.statusDuringHold.Name = "statusDuringHold";
            this.statusDuringHold.Size = new System.Drawing.Size(49, 34);
            this.statusDuringHold.TabIndex = 41;
            this.statusDuringHold.Text = "●";
>>>>>>> Test01
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1081, 476);
            this.Controls.Add(this.setparameter);
            this.Controls.Add(this.samplestop);
            this.Controls.Add(this.samplestart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxsamplerate);
=======
            this.ClientSize = new System.Drawing.Size(995, 476);
            this.Controls.Add(this.statusDuringHold);
            this.Controls.Add(this.statusDetectingPeak);
            this.Controls.Add(this.statusDuringMeasurement);
            this.Controls.Add(this.statusOKLight);
            this.Controls.Add(this.statusLowLight);
            this.Controls.Add(this.statusHighLight);
            this.Controls.Add(this.highLight);
            this.Controls.Add(this.OKlight);
            this.Controls.Add(this.lowLight);
>>>>>>> Test01
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
<<<<<<< HEAD
        private System.Windows.Forms.TextBox textBoxsamplerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button samplestart;
        private System.Windows.Forms.Button samplestop;
        private System.Windows.Forms.Button setparameter;
=======
        private System.Windows.Forms.Label lowLight;
        private System.Windows.Forms.Label OKlight;
        private System.Windows.Forms.Label highLight;
        private System.Windows.Forms.Label statusHighLight;
        private System.Windows.Forms.Label statusLowLight;
        private System.Windows.Forms.Label statusOKLight;
        private System.Windows.Forms.Label statusDuringMeasurement;
        private System.Windows.Forms.Label statusDetectingPeak;
        private System.Windows.Forms.Label statusDuringHold;
>>>>>>> Test01
    }
}

