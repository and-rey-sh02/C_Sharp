using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace ComportsTest
{
    public partial class Form1 : Form
    {
        static SerialPort ComPort;
      
        string[] portsName;

        string[] portsNames = new string[5] { "COM1", "CNCA0", "CNCB0", "CNCA1", "CNCB1" };

        int[] portsBaudrate = new int[7] { 115200, 19200, 230400, 57600, 38400, 9600, 4800 };

        int[] portsDataBits = new int[4] { 5, 6, 7, 8 };

        double[] portsStopBits = new double[3] { 1, 2, 1.5 };

        string[] Parity = new string[5] { "None", "Odd", "Even", "Mark", "Space" };
       
        byte[] bufferStack = new byte[255+3];
        int index = 0;

        public void Config()
        {
            StopBits varStopBits;
            Parity varParity;

            if (ComPort != null && ComPort.IsOpen)
            {
                ComPort.Close();
            }

            ComPort = new SerialPort();

            ComPort.PortName = comboBoxPort.Text;

            int varBaundRate = Int32.Parse(comboBoxBaudrate.Text);
            ComPort.BaudRate = varBaundRate;

            int varDataBits = Int32.Parse(comboBoxDataBits.Text);
            ComPort.DataBits = varDataBits;

            if (comboBoxStopBits.Text == "1")
            {
                varStopBits = StopBits.One;
                ComPort.StopBits = varStopBits;
            }

            else if (comboBoxStopBits.Text == "2")
            {
                varStopBits = StopBits.Two;
                ComPort.StopBits = varStopBits;
            }

            else
            {
                varStopBits = StopBits.OnePointFive;
                ComPort.StopBits = varStopBits;
            }

            string parity = comboBoxParity.Text;

            if (comboBoxParity.Text == "None")
            {
                varParity = (Parity)Enum.Parse(typeof(Parity), parity, true);
                ComPort.Parity = varParity;
            }

            else if (comboBoxParity.Text == "Odd")
            {
                varParity = (Parity)Enum.Parse(typeof(Parity), parity, true);
                ComPort.Parity = varParity;
            }

            else if (comboBoxParity.Text == "Even")
            {
                varParity = (Parity)Enum.Parse(typeof(Parity), parity, true);
                ComPort.Parity = varParity;
            }

            else if (comboBoxParity.Text == "Mark")
            {
                varParity = (Parity)Enum.Parse(typeof(Parity), parity, true);
                ComPort.Parity = varParity;
            }

            else
            {
                varParity = (Parity)Enum.Parse(typeof(Parity), parity, true);
                ComPort.Parity = varParity;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var itemsBaudrate in portsBaudrate)
            {
                comboBoxBaudrate.Items.Add(itemsBaudrate);
            }

            comboBoxBaudrate.SelectedIndex = 5;
            comboBoxBaudrate.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var itemsDataBits in portsDataBits)
            {
                comboBoxDataBits.Items.Add(itemsDataBits);
            }

            comboBoxDataBits.SelectedIndex = 3;
            comboBoxDataBits.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var itemsStopBits in portsStopBits)
            {
                comboBoxStopBits.Items.Add(itemsStopBits);
            }

            comboBoxStopBits.SelectedIndex = 0;
            comboBoxStopBits.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var itemsParity in Parity)
            {
                comboBoxParity.Items.Add(itemsParity);
            }

            comboBoxParity.SelectedIndex = 0;
            comboBoxParity.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void WriteRichTBStr(string byteStr)
        {
            richTextBox1.Invoke(new Action
                           (() =>
                           {
                               byteStr = byteStr.Substring(2, byteStr.Length - 3);
                               richTextBox1.SuspendLayout();
                               richTextBox1.AppendText("-> ");
                               richTextBox1.AppendText(byteStr);
                               richTextBox1.AppendText("\n");
                               richTextBox1.ResumeLayout();
                           }
                           ));
        }       

        public void WriteRichTBHex(byte[] strByte, int numEror)
        {          
           richTextBox1.Invoke(new Action
                            (() =>
                            {
                                switch (numEror)
                                {
                                    case 0: 
                                        richTextBox1.SuspendLayout();
                                        var data = BitConverter.ToString(strByte);
                                        richTextBox1.AppendText("-> ");
                                        richTextBox1.AppendText(data);
                                        richTextBox1.AppendText("\n");
                                        richTextBox1.ResumeLayout();
                                        break;
                                    case 1:
                                        richTextBox1.SuspendLayout();
                                        data = BitConverter.ToString(strByte);
                                        richTextBox1.AppendText("-> ");
                                        richTextBox1.AppendText(data);
                                        richTextBox1.AppendText("\n");
                                        richTextBox1.AppendText("The trailing bit is missing");
                                        richTextBox1.AppendText("\n");
                                        richTextBox1.ResumeLayout();
                                        break;
                                    case 2:
                                        richTextBox1.SuspendLayout();
                                        data = BitConverter.ToString(strByte);
                                        richTextBox1.AppendText("-> ");
                                        richTextBox1.AppendText(data);
                                        richTextBox1.AppendText("\n");
                                        richTextBox1.AppendText("The message has no end");
                                        richTextBox1.AppendText("\n");
                                        richTextBox1.ResumeLayout();
                                        break;
                                }                                
                            }
                            ));
        }

        private void cp_Received(object sender, SerialDataReceivedEventArgs e)
        {           
            if (ComPort.IsOpen)
            {
                try
                {
                    int lenDataCP = ComPort.BytesToRead;
                    byte[] buf_Pmessage = new byte[lenDataCP];
                    int nBytes = ComPort.Read(buf_Pmessage, 0, lenDataCP);                

                    for (int i = 0; i < buf_Pmessage.Length; i++)
                    {
                        if (index == 0)
                        {
                            if (buf_Pmessage[i] == 152)
                            {
                                bufferStack[index] = buf_Pmessage[i];
                                index++;
                            }
                        }
                        else
                        {
                            if (index == 1)
                            {
                                bufferStack[index] = buf_Pmessage[i];
                                index++;
                            }
                            else
                            {
                                if (buf_Pmessage[i] != 152)
                                {
                                    if (index < bufferStack[1] + 2)
                                    {
                                        bufferStack[index] = buf_Pmessage[i];
                                        index++;
                                    }
                                    else
                                    {                                      
                                        if (buf_Pmessage[i] == 31)
                                        {

                                            bufferStack[index] = buf_Pmessage[i];
                                            index = 0;                                             

                                            if (checkBoxHEXRd.Checked)
                                            {
                                                WriteRichTBHex(bufferStack.Skip(2).Take(bufferStack[1]).ToArray(), 0);
                                            }
                                            else
                                            {
                                                string getStrBytes = Encoding.GetEncoding(1251).GetString(bufferStack, 0, bufferStack.Length);
                                                WriteRichTBStr(getStrBytes);
                                            }
                                        }
                                        else
                                        {
                                            WriteRichTBHex(bufferStack.Take(index).ToArray(), 1);
                                            
                                        }
                                    }
                                }
                                else
                                {
                                    WriteRichTBHex(bufferStack.Take(index).ToArray(), 2);
                                    bufferStack[0] = buf_Pmessage[i];
                                    index = 1;
                                }
                            }
                        }
                    }                                                   
                }
                catch (Exception)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBoxPort.Text != ""))
            {
                Config();
                buttonConnected.Enabled = false;
                buttonDisconnected.Enabled = true;
            }

            else
            {
                MessageBox.Show("Such a COM port does not exist");
                buttonConnected.Enabled = true;
                return;
            }

            if (!ComPort.IsOpen)
            {
                try
                {
                    ComPort.Open();
                    ComPort.DataReceived += cp_Received;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();

            portsName = SerialPort.GetPortNames();

            foreach (var itemsName in portsName)
            {
                comboBoxPort.Items.Add(itemsName);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] buf_message;
            Random rnd = new Random();         
            if (ComPort.IsOpen)
            {
                try
                {
                    string str = textBox1.Text;                 
                    byte[] prom_buff;

                    if (checkBoxHEXWr.Checked)
                    {
                        string patern = "[^ A-F a-f 0-9]";
                        str = Regex.Replace(str, patern, String.Empty);
                        if (str.Length % 2 != 0)
                        {
                            str = str.Insert(0, "0");
                        }

                        prom_buff = new byte[str.Length / 2];

                        for (int i = 0; i < str.Length / 2; i++)
                        {
                            prom_buff[i] = (byte)Convert.ToInt32(str.Substring(i * 2, 2), 16);
                        }                        
                    }
                    else
                    {
                        prom_buff = Encoding.GetEncoding(1251).GetBytes(str);                        
                    }

                    buf_message = new byte[prom_buff.Length + 3];
                    buf_message[0] = 0x98;
                    buf_message[1] = (byte)prom_buff.Length;
                    buf_message[buf_message.Length - 1] = 0x1f;                             

                    for (int i = 0; i < prom_buff.Length; i++)
                    {
                        buf_message[2 + i] = prom_buff[i];
                    }
           
                    for (int i = 0; i < buf_message.Length; i++)
                    {
                        var rndI = rnd;
                        ComPort.Write(buf_message, i, 1);
                        Thread.Sleep(rndI.Next(1, 15));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonDisconnected_Click(object sender, EventArgs e)
        {
            buttonDisconnected.Enabled = false;
            buttonConnected.Enabled = true;

            if (ComPort.IsOpen)
            {
                try
                {
                    ComPort.Close();
                }
                catch (Exception)
                {

                }
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

    }
}
