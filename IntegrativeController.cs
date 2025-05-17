using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class IntegrativeController
    {
        private double integralSum = 0.0;
        private double previousTime = 0.0;
        public double ki;  // Integral gain

        public IntegrativeController(double ki)
        {
            this.ki = ki;
        }

        public double Compute(double currentError, double currentTime)
        {
            double dt = currentTime - previousTime;

            if (dt > 0)
            {
                integralSum += currentError * dt;
            }

            previousTime = currentTime;

            return ki * integralSum;
        }
    }
}
