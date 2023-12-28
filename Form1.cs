using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialPortTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForExistingInstance();

            InitializeComponent();
            InitializeForm();
        }

        private void CheckForExistingInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();

            var existingProcess = (from proc in Process.GetProcesses()
                                   where proc.Id != currentProcess.Id && proc.ProcessName == currentProcess.ProcessName
                                   select proc).FirstOrDefault();

            if (existingProcess != null)
            {
                MessageBox.Show("Já está em execução!");
                Environment.Exit(0);
            }
        }

        private void InitializeForm()
        {
            timerPort.Enabled = true;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            SerialPort1.DataReceived += serialPort1_DataReceived;
        }

        private void UpdateAvailablePorts()
        {
            string[] availablePorts = SerialPort.GetPortNames();

            if (comboBox1.Items.Count != availablePorts.Length || !comboBox1.Items.Cast<string>().SequenceEqual(availablePorts))
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(availablePorts);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void timerPort_Tick(object sender, EventArgs e)
        {
            UpdateAvailablePorts();
        }

        private void btPort_Click(object sender, EventArgs e)
        {
            if (!SerialPort1.IsOpen)
            {
                try
                {
                    SerialPort1.PortName = comboBox1.SelectedItem.ToString();
                    SerialPort1.Open();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error opening serial port: {ex.Message}");
                }

                if (SerialPort1.IsOpen)
                {
                    btPort.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    SerialPort1.Close();
                    comboBox1.Enabled = true;
                    btPort.Text = "Conectar";
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error closing serial port: {ex.Message}");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[SerialPort1.BytesToRead];
                SerialPort1.Read(buffer, 0, buffer.Length);

                string receivedData = Encoding.UTF8.GetString(buffer);

                Debug.WriteLine($"Received: {receivedData}");

                this.BeginInvoke(new Action(() =>
                {
                    Debug.WriteLine("Atualizando interface do usuário...");
                    string info = receivedData.Substring(0);
                    DataReceive(info);
                }));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error processing received data: {ex.Message}");
            }
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                SerialPort1.WriteLine(textBoxEnvia.Text);
            }
        }

        private void DataReceive(string data)
        {
            textBoxRecebe.AppendText(data + Environment.NewLine);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBoxRecebe.Clear();
        }
    }
}
