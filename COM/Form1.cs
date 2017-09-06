using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 1.委派
 * 2.Open的條件判斷
 * 3.Button處理(Enable、集合、相互關係)
 * 4.test
 * 
 */

namespace COM
{
    public partial class Form1 : Form
    {
        //機器安全壓力限制
        private int MachineSafePressure = 150;
        //在Bin資料夾裡
        StreamWriter sw = new StreamWriter(@"Log.txt");

        private Thread mThread;
        static Queue<long> mQueue;
        // TODO: I/O 

        //按鈕狀態
        private enum queueType
        {
            EVENT_SEND_CMD_INITIALIZE,//RES
            EVENT_RECEIVE_CMD_DATA,//輸出資料
            EVENT_SEND_CMD_RSLINETEST,//RS-
            EVENT_SEND_CMD_MODELINFORMATION,//SYS
            EVENT_SEND_CMD_INDICATEDVALUE,//GDT1
            EVENT_SEND_CMD_TRANSMISSIONMODE00,//MOD00
            EVENT_SEND_CMD_TRANSMISSIONMODE10,//MOD10
            EVENT_RECEIVE_CMD_TRANSMISSIONMODE,//接收MOD重複回傳的資料
            EVENT_SEND_CMD_TXTUSING,//手動輸入指令區域
            EVENT_SEND_CMD_MINIMUMLIMIT,//設定最小限制
            EVENT_SEND_CMD_MAXIMUMLIMIT,//設定最大限制
        };

        private void threadProcess()
        {
            while (true)
            {
                if (mQueue.Count > 0)
                {
                    long item = mQueue.Dequeue();
                    switch ((queueType)item)
                    {
                        case queueType.EVENT_SEND_CMD_INITIALIZE:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "RES";

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + "\n");
                                //設備回傳時間(millisecond)
                                //目前先假設為100(尚未參考Spec)
                                Thread.Sleep(100);

                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                        case queueType.EVENT_RECEIVE_CMD_DATA:
                            if (comport.IsOpen)
                            { 
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                string indata = comport.ReadExisting();

                                textShow.AppendText("[" + dateTimeNow + "]" + "Received: " + indata + "\n");
                                textReceive.AppendText(indata + "\n");
                                //寫入檔案
                                sw.Write(textShow.Text);
                                
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_RSLINETEST:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "RS-";

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + "\n");
                                //設備回傳時間(millisecond)
                                //目前先假設為100(尚未參考Spec)
                                Thread.Sleep(100);
                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_MODELINFORMATION:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "SYS";

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + "\n");

                                //設備回傳時間(millisecond)
                                //目前先假設為100(尚未參考Spec)
                                Thread.Sleep(100);
                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_INDICATEDVALUE:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "GDT1";

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + "\n");

                                //設備回傳時間(millisecond)
                                //目前先假設為100(尚未參考Spec)
                                Thread.Sleep(100);
                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_TRANSMISSIONMODE00:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "MOD00";

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + "\n");

                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_TRANSMISSIONMODE);
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_TRANSMISSIONMODE10:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "MOD10";

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + "\n");
                                comport.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);

                                //設備回傳時間(millisecond)
                                //目前先假設為100(尚未參考Spec)
                                Thread.Sleep(100);
                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                        case queueType.EVENT_RECEIVE_CMD_TRANSMISSIONMODE:
                            if (comport.IsOpen)
                            {
                                comport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_TXTUSING:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = textSend.Text;

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + "\r\n");
                                textSend.Clear();
                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + "\n");

                                Thread.Sleep(100);
                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_MINIMUMLIMIT:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "SCV2,+";
                                String commandValue = textMinimumSetting.Text.PadLeft(5, '0');

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + commandValue + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + commandValue + "\n");
                                //設備回傳時間(millisecond)
                                //目前先假設為100(尚未參考Spec)
                                Thread.Sleep(100);
                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                        case queueType.EVENT_SEND_CMD_MAXIMUMLIMIT:
                            if (comport.IsOpen)
                            {
                                DateTime dateTime = DateTime.Now;
                                String dateTimeNow = dateTime.ToShortTimeString();
                                String commandData = "SCV1,+";
                                String commandValue = textMaximumSetting.Text.PadLeft(5, '0');

                                // "\r\n"為Windows換行(<CR>)
                                comport.Write(commandData + commandValue + "\r\n");

                                textShow.AppendText("[" + dateTimeNow + "]" + "Sent:" + commandData + commandValue + "\n");
                                //設備回傳時間(millisecond)
                                //目前先假設為100(尚未參考Spec)
                                Thread.Sleep(100);
                                mQueue.Enqueue((long)queueType.EVENT_RECEIVE_CMD_DATA);
                            }
                            break;
                    }
                }
            }
        }

        //需要更改
        public Form1()
        {
            //需要更改為利用委派的方式
            Form1.CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            buttonClose.Enabled = false;
            foreach (String ports in SerialPort.GetPortNames())
            {
                txtPort.Items.Add(ports);
            }
        }

        public void serialPortConnect(String port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dateTime = DateTime.Now;
            String dateTimeNow = dateTime.ToShortTimeString();

            comport = new SerialPort(port,
                                     baudrate,
                                     parity,
                                     databits,
                                     stopbits);
            try
            {
                comport.Open();
                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                textShow.AppendText("[" + dateTimeNow + "]" + port + " Connected\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.ToString(), "Error");
            }
        }

        //EventHandler for MOD00(字串分析在這)
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            DateTime dateTime = DateTime.Now;
            String dateTimeNow = dateTime.ToShortTimeString();

            string indata = sp.ReadExisting();
            string MachineStatus = indata.Substring(11, 8);

            //切割所需字串
            textShow.AppendText("[" + dateTimeNow + "]" + "Received: " + indata.Substring(2, 6) + "\n");

            //判斷重量是否超出標準
            if (Convert.ToInt32(indata.Substring(3, 5)) > MachineSafePressure)
            {
                MessageBox.Show("ERROR");
            }

            textReceive.AppendText(indata + "\n");
        }

        //需要更改
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //判斷式寫法???
            if(txtPort.Text != "null")
            {
                String port = txtPort.Text;
                int baudrate = Convert.ToInt32(txtBaudRate.Text);
                Parity parity = (Parity)Enum.Parse(typeof(Parity), txtParity.Text);
                int databits = Convert.ToInt32(txtDatabits.Text);
                StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), txtStopbits.Text);

                serialPortConnect(port, baudrate, parity, databits, stopbits);

                mQueue = new Queue<long>();
                mThread = new Thread(threadProcess);
                mThread.Start();
                
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            String dateTimeNow = dateTime.ToShortTimeString();

            try
            {
                if (comport.IsOpen)
                {
                    sw.Close();
                    if (mThread.IsAlive)
                    {
                        mThread.Abort();
                    }
                    comport.Close();
                    buttonClose.Enabled = false;
                    buttonOpen.Enabled = true;
                    textShow.AppendText("[" + dateTimeNow + "]" + "Disconnected\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region 已完成按鈕區

        //手動輸入指令區域
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_TXTUSING);
        }

        //機器初始化按鈕
        private void buttonInitialize_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_INITIALIZE);
        }

        //連接線路按鈕
        private void buttonRSlinetest_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_RSLINETEST);
        }

        //設備資料按鈕
        private void buttonOutPutModelInformation_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_MODELINFORMATION);
        }

        //感測資料按鈕
        private void buttonIndicatedValue_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_INDICATEDVALUE);
        }

        #endregion

        //MOD00
        private void buttonTransmissionMode00_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
            {
                buttonTransmissionMode00.Enabled = false;
                buttonTransmissionMode10.Enabled = true;
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_TRANSMISSIONMODE00);
            }
        }

        //MOD10
        private void buttonTransmissionMode10_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
            {
                buttonTransmissionMode00.Enabled = true;
                buttonTransmissionMode10.Enabled = false;
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_TRANSMISSIONMODE10);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mThread != null)
            {
                if (mThread.IsAlive)
                {

                    mThread.Abort();
                }
            }
            if (comport.IsOpen)
            {
                sw.Close();
                comport.Close();
            }
        }

        #region 最大最小按鈕
        //設定最小限制
        private void buttonMinimumSetting_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
            {
                if (textMinimumSetting.Text != "")
                    mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_MINIMUMLIMIT);
            }
        }

        //限制只能輸入數字
        private void textMinimumSetting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //設定最大限制
        private void buttonMaximumSetting_Click(object sender, EventArgs e)
        {
            if (comport.IsOpen)
            {
                if(textMaximumSetting.Text != "")
                mQueue.Enqueue((long)queueType.EVENT_SEND_CMD_MAXIMUMLIMIT);
            }
        }

        //限制只能輸入數字
        private void textMaximumSetting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 不需要用到的function
        private void textSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        
    }
}
