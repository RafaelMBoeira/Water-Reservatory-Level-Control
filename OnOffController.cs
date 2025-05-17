using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class OnOffController
    {
        private int isOn = 0;
        public double lowerLimit;
        public double upperLimit;

        public OnOffController(double lowerLimit, double upperLimit)
        {
            if (lowerLimit >= upperLimit)
                throw new ArgumentException("Lower limit must be less than upper limit.");

            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;
        }

        public int Compute(double measuredValue)
        {
            if (measuredValue <= lowerLimit)
                isOn = 1;
            
            if (measuredValue >= upperLimit)
                isOn = 0;

            return isOn;
        }
    }
}
