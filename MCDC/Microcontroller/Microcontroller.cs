using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;

namespace MCDC.Microcontroller
{

    public enum EnumConnectionType
    {
        USB, 
        WiFi
    }
    internal class Microcontroller
    {
        
        public int MicrocontrollerID;
        public string MicrocontrollerName;
        public string SerialPortName;
        public string PathConfigFile;
        public int SendInterval;
        public EnumConnectionType ConnectionType;

        private Timer UpdateIOLoop;

        public List<IO> GPIOs = new List<IO>();
        public Microcontroller(int microcontrollerID, string microcontrollerName, int sendInterval, EnumConnectionType connectionType)
        {  
            MicrocontrollerID = microcontrollerID;
            MicrocontrollerName = microcontrollerName;
            SendInterval = sendInterval;
            ConnectionType = connectionType;

            UpdateIOLoop = new Timer();
            UpdateIOLoop.Interval = SendInterval;
            UpdateIOLoop.Tick += new EventHandler(UpdateIO);
            UpdateIOLoop.Start();
        }

        private void UpdateIO(object sender, EventArgs e)
        {

        }
    }
}
