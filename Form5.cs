using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class SimulationForm : Form
    {
        private bool running = false;
        private Simulation currentSimulation;
        private string selectedControlType;
        private int sampleCount = 0;
        private LevelControlForm frmMain;
        public SimulationForm(LevelControlForm frmMain)
        {
            InitializeComponent();
            
            this.frmMain = frmMain;
            this.frmMain.Enabled = false;
            this.frmMain.Hide();

            initializeChart();
        }
        private void simulate(object sender, EventArgs e)
        {
            if (btSim.Text == "Simular")
            {
                try
                {
                    currentSimulation = new Simulation(
                        Convert.ToInt16(tbSampleTime.Text),
                        cbControlTypes.Text,
                        Convert.ToDouble(tbTarget.Text),
                        Convert.ToDouble(tbCurrent.Text),
                        Convert.ToDouble(tbGain.Text),
                        Convert.ToDouble(tbPower.Text),
                        Convert.ToDouble(tbDecay.Text)/100,
                        Convert.ToInt16(tbSimTime.Text)
                    );
                }
                catch
                {
                    MessageBox.Show("Todas as entradas devem ser numéricas.");
                    return;
                }
                chSim.Series.Clear();
                sampleCount = 0;
                initializeChart();
                btSim.Text = "Parar";
                running = true;
                gbxControl.Enabled = false;
                gbxVariables.Enabled = false;
                gbxSample.Enabled = false;
                gbxSimTime.Enabled = false;
                simulationTask();
            }
            else
            {
                btSim.Text = "Simular";
                running = false;
                gbxControl.Enabled = true;
                gbxVariables.Enabled = true;
                gbxSample.Enabled = true;
                gbxSimTime.Enabled = true;
            }
        }
        private void simulationTask()
        {
            Task.Run(() =>
            {
                for (int i = 0; running && i < currentSimulation.sampleCount; i++)
                    compute();
            });
            
        }
        private void initializeChart()
        {
            chSim.Series.Clear();
            chSim.Series.Add("Potência");
            chSim.Series["Potência"].ChartType = SeriesChartType.Line;
            chSim.Series.Add("Erro");
            chSim.Series["Erro"].ChartType = SeriesChartType.Line;
            chSim.Series.Add("Medida Atual");
            chSim.Series["Medida Atual"].ChartType = SeriesChartType.Line;
        }

        private void compute()
        {
            double output = 0.0;
            double error = 0.0;

            if (currentSimulation.controlType == "Proporcional")
            {
                ProportionalController controller = new ProportionalController(currentSimulation.gain);
                error = currentSimulation.targetValue - currentSimulation.currentValue;
                output = controller.Compute(error) - (currentSimulation.decay * currentSimulation.currentValue);
            }

            if (currentSimulation.controlType == "Integrativo")
            {
                IntegrativeController controller = new IntegrativeController(currentSimulation.gain);
                error = currentSimulation.targetValue - currentSimulation.currentValue;
                output = controller.Compute(error, sampleCount * currentSimulation.sampleTime) - (currentSimulation.decay * currentSimulation.currentValue);
            }

            if (currentSimulation.controlType == "Derivativo")
            {
                DerivativeController controller = new DerivativeController(currentSimulation.gain);
                error = currentSimulation.targetValue - currentSimulation.currentValue;
                output = controller.Compute(error, sampleCount * currentSimulation.sampleTime) - (currentSimulation.decay * currentSimulation.currentValue);
            }
            currentSimulation.currentPower = output;
            if (output > currentSimulation.maxPower)
                output = currentSimulation.maxPower;

            currentSimulation.currentValue += output * currentSimulation.sampleTime / 1000;
            
            currentSimulation.currentError = error;

            updateChart();
        }
        private void updateChart()
        {
            sampleCount++;
            try
            {
                chSim.Invoke(new Action(() => chSim.Series["Potência"].Points.AddXY(sampleCount * currentSimulation.sampleTime, currentSimulation.currentPower)));
                chSim.Invoke(new Action(() => chSim.Series["Erro"].Points.AddXY(sampleCount * currentSimulation.sampleTime, currentSimulation.currentError)));
                chSim.Invoke(new Action(() => chSim.Series["Medida Atual"].Points.AddXY(sampleCount * currentSimulation.sampleTime, currentSimulation.currentValue)));
            }
            catch(Exception e)
            {
                return;
            }
        }
        private void exit(object sender, EventArgs e)
        {
            Close();
        }
        private void whenClosed(object sender, FormClosingEventArgs e)
        {
            running = false;
            chSim.Series.Clear();
            frmMain.Enabled = true;
            frmMain.Show();
        }
    }
}
