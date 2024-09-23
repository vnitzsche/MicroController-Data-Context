using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using MCDC.Microcontroller;
using Microsoft.VisualBasic.ApplicationServices;

namespace MCDC
{
    internal class ConfigFileParser
    {


        public ConfigFileParser() { }   

        public List<Microcontroller.Microcontroller> ParseFile(string filepath)
        {
            var microcontrollers = new List<Microcontroller.Microcontroller>();

            bool parsingMicrocontrollers = true; // We start by parsing microcontroller section

            using (var reader = new StreamReader(filepath))
            {
                // Skip the headers
                string line = reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    // Check for separator line
                    if (line.StartsWith("-;;;"))
                    {
                        parsingMicrocontrollers = false; // Switch to parsing pins section
                        reader.ReadLine(); // Skip the Pin section headers
                        continue;
                    }

                    // Parse microcontroller data
                    if (parsingMicrocontrollers)
                    {
                        var values = line.Split(';');
                        if (values.Length >= 4 && !string.IsNullOrEmpty(values[0])) // Ignore empty lines
                        {
                            
                            EnumConnectionType connectionType;
                            if (values[3] == "WiFi")
                            {
                                connectionType = EnumConnectionType.WiFi;
                            }
                            else
                            {
                                connectionType = EnumConnectionType.USB;
                            }

                            var microcontroller = new Microcontroller.Microcontroller(int.Parse(values[0]), values[1], int.Parse(values[2]), connectionType);

                            microcontrollers.Add(microcontroller);
                        }
                    }
                    // Parse pin data
                    else
                    {
                        var values = line.Split(';');
                        if (values.Length >= 4 && !string.IsNullOrEmpty(values[0])) // Ignore empty lines
                        {
                            //PinType
                            PinType pintype;
                            if (values[3] == "DI") { pintype = PinType.DigitalInput; }
                            else if (values[3] == "DO") { pintype = PinType.DigitalOutput; }
                            else if (values[3] == "AI") { pintype = PinType.AnalogInput; }
                            else if (values[3] == "AO") { pintype = PinType.AnalogOutput; }
                            else
                            {
                                MessageBox.Show("Faulty pintype. Please check .csv File", "Wrong Input", MessageBoxButtons.OK);
                            }

                            //Choosing right microcontroller based on ID
                            int MicrocontrollerFoundID = 0;
                            foreach (var mc in microcontrollers)
                            {
                                if(mc.MicrocontrollerID == int.Parse(values[0]))
                                {
                                    MicrocontrollerFoundID = mc.MicrocontrollerID;
                                    break;
                                }
                            } 
                            

                            var pin = new IO(int.Parse(values[0]), values[2], int.Parse(values[1]), microcontrollers[1], pintype, Hauptbild.FormIOControl);
                            {
                                PinID = int.Parse(values[0]),
                                MicrocontrollerID = int.Parse(values[1]),
                                PinName = values[2],
                                PinType = values[3],
                                Scaling = values.Length > 4 ? values[4] : null
                            };
                            pins.Add(pin);
                        }
                    }
                }
            }

            return microcontrollers;
        }
    }
}
