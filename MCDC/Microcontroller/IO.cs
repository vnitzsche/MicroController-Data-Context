using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MCDC.Microcontroller
{
    public enum PinType
    {
        DigitalInput, 
        DigitalOutput,
        AnalogInput, 
        AnalogOutput
    }
    internal class IO
    {
        public int MicrocontrollerID {  get; set; }
        public int PinID { get; set; }
        public int PinSortingNum { get; set; }
        public string PinName { get; set; }
        public bool OverwriteIsActive { get; set; }
        public bool OverwriteValue { get; set; }
        public bool fromControllerValue { get; set; }
        public bool toControllerValue { get; set; }
        public PinType prop_pinType { get; set; }

        private IO_Control IO_ControlForm = null;
        private Guna2CustomRadioButton RadioButtonActiveValue = new Guna2CustomRadioButton();
        private Guna2ToggleSwitch SwitchOverwriteActive = new Guna2ToggleSwitch();
        private Guna2ToggleSwitch SwitchOverwriteValue = new Guna2ToggleSwitch();
        private Label IO_PinIDLabel = new Label();
        private Label IO_PinNameLabel = new Label();

        public IO(int pinID, string pinName, int microcontrollerID, int pinSortingNum, PinType pinType, IO_Control iO_ControlForm)
        {
            PinID = pinID;
            PinName = pinName;
            MicrocontrollerID = microcontrollerID;
            IO_ControlForm = iO_ControlForm;
            PinSortingNum = pinSortingNum;
            prop_pinType = pinType;

            AddToTablePanel();
        }

        private void AddToTablePanel()
        {
            //Selecting table for IO type
            TableLayoutPanel TablePanel = null;
            if (prop_pinType == PinType.DigitalInput) { TablePanel = IO_ControlForm.TableLayoutPanelDI; }
            else if(prop_pinType == PinType.DigitalOutput) { TablePanel = IO_ControlForm.TableLayoutPanelDO; }
            else if(prop_pinType == PinType.AnalogInput) { TablePanel = IO_ControlForm.TableLayoutPanelAI; }
            else if(prop_pinType == PinType.AnalogOutput) { TablePanel = IO_ControlForm.TableLayoutPanelAO; }

            //Adding new Row for Control
            TablePanel.AutoSize = true;
            TablePanel.Dock = DockStyle.Top;
            TablePanel.RowCount += 0;
            TablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));

            //Adding and configuring State Indicator
            TablePanel.Controls.Add(RadioButtonActiveValue, 0, PinSortingNum);
            RadioButtonActiveValue.Dock = DockStyle.Fill;
            RadioButtonActiveValue.UncheckedState.FillColor = System.Drawing.Color.Silver;
            RadioButtonActiveValue.Enabled = false;
            RadioButtonActiveValue.CheckedState.InnerColor = System.Drawing.Color.GreenYellow;

            //Adding and configuring SwitchOverwriteActive
            TablePanel.Controls.Add(SwitchOverwriteActive, 1, PinSortingNum);
            SwitchOverwriteActive.Dock = DockStyle.Fill;    

            //Adding and configuring SwitchOverwriteValue
            TablePanel.Controls.Add(SwitchOverwriteValue, 2, PinSortingNum);
            SwitchOverwriteValue.Dock = DockStyle.Fill;

            //Adding PinID (corresponding GPIO Number of the Board)
            TablePanel.Controls.Add(IO_PinIDLabel, 3, PinSortingNum);
            IO_PinIDLabel.Dock = DockStyle.Fill;
            IO_PinIDLabel.Text = PinID.ToString();

            //Adding PinName
            TablePanel.Controls.Add(IO_PinNameLabel, 4, PinSortingNum);  
            IO_PinNameLabel.Dock = DockStyle.Fill;
            IO_PinNameLabel.Text = PinName.ToString();

        }

    }
}