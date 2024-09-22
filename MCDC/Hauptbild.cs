using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCDC
{
    public partial class Hauptbild : Form
    {
        public static IO_Control FormIOControl = null;
        public Hauptbild()
        {
            InitializeComponent();
            FormIOControl = new IO_Control();
            Console.WriteLine("hauptbild init done");
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {

        }

        private void ButtonIOcontrol_Click(object sender, EventArgs e)
        {
            if(FormIOControl != null)
            {
                FormIOControl.Show();
                if(FormIOControl.Focused == false)
                {
                    FormIOControl.Activate();
                }
            }
        }

    }
}
