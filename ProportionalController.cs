using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class ProportionalController
    {
        public double kp;  // Proportional gain

        public ProportionalController(double kp)
        {
            this.kp = kp;
        }

        public double Compute(double currentError)
        {
            return kp * currentError;
        }
    }
}
