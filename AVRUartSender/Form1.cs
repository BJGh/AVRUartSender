using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AVRUartSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SerialPort ComPort = new SerialPort();
        private void updatePorts()
        {
            string[] port_names = SerialPort.GetPortNames();
            foreach (string port_n in port_names)
            {
                cb_Port_Select.Items.Add(port_n);
            }
        }
        private void connect()
        {
            bool errorHandle = false;
            //setup port connection settings
            if (cb_Port_Select.SelectedIndex != -1 & cb_Databit.SelectedIndex != -1 & cb_BaudRate.SelectedIndex != -1 & cb_Parity.SelectedIndex != -1 & cb_Stopbit.SelectedIndex != -1)
            {
                ComPort.PortName = cb_Port_Select.Text;
                ComPort.BaudRate = int.Parse(cb_BaudRate.Text);
                ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cb_Parity.Text);
                ComPort.DataBits = int.Parse(cb_Databit.Text);
                ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cb_Stopbit.Text);
                try
                {
                    ComPort.Open();
                }
                catch (UnauthorizedAccessException) { errorHandle = true; }
                catch (System.IO.IOException) { errorHandle = true; }
                catch (ArgumentException) { errorHandle = true; }
                if (errorHandle) { MessageBox.Show("Selected COM Port is busy", "Could not open COM Port", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                MessageBox.Show("Select all COM ports!", "COM Port selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ComPort.IsOpen)
            {
                port_connect_btn.Text = "Disconnect";
            }
        }
        private void disconnect()
        {
            ComPort.Close();
            port_connect_btn.Text = "Connect";
        }
        private void port_connect_btn_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                disconnect();
            }
            else { connect(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePorts();
        }

        private void input_textbox_TextChanged(object sender, EventArgs e)
        {
            if (to_led_textbox.TextLength < 1)
            {
                to_led_textbox.Text = input_textbox.Text;

            }
            string str = to_led_textbox.Text;

            for (int i = 0; i < str.Length; i++)
            {
                asc = (byte)str[i];
                asc_textbox.Text += asc.ToString("###");


            }



        }

        private void clear_inptextbox_btn_Click(object sender, EventArgs e)
        {
            to_led_textbox.Clear();
        }
        private void clr_asc_btn_Click(object sender, EventArgs e)
        {
            asc_textbox.Clear();
            asc = 0;
        }

        private void send_text_led_btn_Click(object sender, EventArgs e)
        {

        }
        private byte asc;
        private byte[] received_ascii;
        private char[] buff = new char[1];
        private void char_sender()
        {
            if (!(String.IsNullOrEmpty(to_led_textbox.Text) || (String.IsNullOrWhiteSpace(to_led_textbox.Text))))
            {
                received_ascii = Encoding.ASCII.GetBytes(to_led_textbox.Text);

                if (received_ascii.Length < 1 || received_ascii == null)
                {
                    MessageBox.Show("Byte array is empty or not initialized!", "Empty ascii byte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ComPort.IsOpen)
                    {

                        ComPort.Write(received_ascii, 0, received_ascii.Length);

                    }
                    else { MessageBox.Show("COM Port isn't connected or busy!", "COM Port error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                MessageBox.Show("Your input Textbox cannot be empty!", "Empty textbox error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void send_asc_btn_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                if (buff[0] != '\0')
                {
                    ComPort.Write(buff, 0, 1);
                    char_sender();
                }
                else
                {
                    MessageBox.Show("Operation number is incorrect or not selected yet", "Empty textbox error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void op1_btn_Click(object sender, EventArgs e)
        {
            buff[0] = '1';
          
        }

        private void op2_btn_Click(object sender, EventArgs e)
        {
            buff[0] = '2';
        }

        private void cb_Port_Select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Stopbit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

