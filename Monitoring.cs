using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Monitoring
    {
        public int baudRate { get; set; }
        public string portName { get; set; }
        public int sampleTime { get; set; }

        public Monitoring(int baudRate, string portName, int sampleTime)
        {
            this.baudRate = baudRate;
            this.portName = portName;
            this.sampleTime = sampleTime;
        }   
    }
}
