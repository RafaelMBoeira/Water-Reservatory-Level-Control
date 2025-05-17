using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class DerivativeController
    {
        private double previousError = 0.0;
        private double previousTime = 0.0;
        public double kd;  // Derivative gain

        public DerivativeController(double kd)
        {
            this.kd = kd;
        }

        public double Compute(double currentError, double currentTime)
        {
            double dt = currentTime - previousTime;
            double derivative = 0;

            if (dt > 0)
            {
                derivative = (currentError - previousError) / dt;
            }

            previousError = currentError;
            previousTime = currentTime;

            return kd * derivative;
        }
    }
}
