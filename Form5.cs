using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SimulationForm : Form
    {
        private bool running = false;
        private string selectedControlType;
        public SimulationForm()
        {
            InitializeComponent();
        }

        private void applyValues(object sender, EventArgs e)
        {

        }

        private void changeControlType(object sender, EventArgs e)
        {

        }

        private void simulate(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                while (running)
                {

                }
            });
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
