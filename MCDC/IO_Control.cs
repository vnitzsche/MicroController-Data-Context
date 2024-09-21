using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                SerialPort sp = new SerialPort();
                sp.PortName = port;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One; 
                sp.
                try()
                MessageBox.Show(ports.Length.ToString());
            }

        }
    }
}
