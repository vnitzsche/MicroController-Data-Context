using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCDC.Microcontroller;

namespace MCDC
{
    public partial class IO_Control : Form
    {
        public IO_Control()
        {
            InitializeComponent(); 
        }

        private void IO_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ButtonScanController_Click(object sender, EventArgs e)
        {
            ScanUSBforController();
        }

        private void ScanUSBforController()
        {
            ComboBoxAvailablePorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ComboBoxAvailablePorts.Items.Add(port); 
            }

        }

        private void IO_Control_Load(object sender, EventArgs e)
        {
            ScanUSBforController();
        }

        private void ButtonConnectMicrocontroller_Click(object sender, EventArgs e)
        {
            int baudrate;
            Int32.TryParse(ComboBoxBaudRate.SelectedItem.ToString(), out baudrate);
            Console.WriteLine(ComboBoxAvailablePorts.SelectedIndex.ToString());
            SerialPort sp = new SerialPort(ComboBoxAvailablePorts.SelectedItem.ToString(), baudrate);
            if (!sp.IsOpen)
            {
                sp.Open();
            }
            Console.WriteLine("SerialPort opened");
            if (sp.IsOpen)
            {
                sp.WriteLine("Connecting MCDC");
            }
            sp.Close();

            IO test = new IO(1, "Name", 1, 1, PinType.DigitalInput, Hauptbild.FormIOControl);
        }
    }
}
