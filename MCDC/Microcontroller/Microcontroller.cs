using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace MCDC.Microcontroller
{
    internal class Microcontroller
    {
        public int MicrocontrollerID;
        public string MicrocontrollerName;
        public string SerialPortName;

        private IO[] GPIOs;
        public Microcontroller(int microcontrollerID, string microcontrollerName)
        {  
            MicrocontrollerID = microcontrollerID;
            MicrocontrollerName = microcontrollerName;
        }
    }
}
