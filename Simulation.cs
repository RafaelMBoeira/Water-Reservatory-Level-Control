using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Simulation
    {
        public int sampleTime { get; set; }
        public string controlType { get; set; }
        public double targetValue { get; set; }
        public double currentValue { get; set; }
        public double gain { get; set; }
        public double maxPower { get; set; }
        public double currentError { get; set; } = 0;
        public double currentPower { get; set; } = 0;
        public double decay { get; set; } = 0.1;
        public int sampleCount { get; set; } = 0;

        public Simulation(int sampleTime, string controlType, double targetValue, double currentValue, double gain, double maxPower, double decay, int sampleCount)
        {
            this.sampleTime = sampleTime;
            this.controlType = controlType;
            this.targetValue = targetValue;
            this.currentValue = currentValue;
            this.gain = gain;
            this.maxPower = maxPower;
            this.decay = decay; 
            this.sampleCount = sampleCount;
        }
    }
}
