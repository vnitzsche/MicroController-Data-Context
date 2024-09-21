using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MCDC.Microcontroller
{
    internal class DI
    {
        public int MicrocontrollerID {  get; set; }
        public int PinID { get; set; }
        public int PinSortingNum { get; set; }
        public string PinName { get; set; }
        public bool OverwriteIsActive { get; set; }
        public bool OverwriteValue { get; set; }
        public bool fromControllerValue { get; set; }
        public bool toControllerValue { get; set; } 

        public DI(int pinID, string pinName, int microcontrollerID) 
        {
            PinID = pinID;
            PinName = pinName;
            MicrocontrollerID = microcontrollerID;  
        }

    }
}
