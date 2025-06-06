﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MonitoringForm : Form
    {
        private LevelControlForm frmMain;
        private Monitoring monitor;
        private ConcurrentQueue<string> receivedDataQueue = new ConcurrentQueue<string>();
        private bool running = false;
        private string inputData;
        private string csvPath;
        private int sampleCount = 0;
        public MonitoringForm(LevelControlForm frmMain, string csvPath, string portName, int baudRate)
        {
            InitializeComponent();

            this.frmMain = frmMain;
            this.frmMain.Hide();
            this.frmMain.Enabled = false;

            this.csvPath = csvPath;

            spMonitor.PortName = portName;
            spMonitor.BaudRate = baudRate;
        }

        private void run(object sender, EventArgs e)
        {
            if (btRun.Text.Equals("Executar"))
            {
                try
                {
                    if (spMonitor.IsOpen == false)
                        spMonitor.Open();
                    spMonitor.Write("I");
                }
                catch
                {
                    MessageBox.Show("Porta não encontrada ou não está disponível.");
                    return;
                }

                monitor = new Monitoring(
                    spMonitor.BaudRate,
                    spMonitor.PortName,
                    Convert.ToInt16(tbSample.Text)
                );
                running = true;

                chMonitor.Series.Clear();
                foreach (string variable in chbVariables.CheckedItems)
                    chMonitor.Series.Add(variable);

                chbVariables.Enabled = false;
                tbSample.Enabled = false;
                btRun.Text = "Parar";
                startThreatingDataReceived();
                return;
            }

            if (btRun.Text.Equals("Parar"))
            {
                spMonitor.Close();
                running = false;
                sampleCount = 0;
                chbVariables.Enabled = true;
                tbSample.Enabled = true;
                btRun.Text = "Iniciar";
                return;
            }
        }
        private void startThreatingDataReceived()
        {
            Task.Run(() =>
            {
                using (StreamWriter writer = new StreamWriter(csvPath, append: true))
                {
                    while (running)
                    {
                        if (receivedDataQueue.IsEmpty)
                            continue;

                        string[] varValues = inputData.Split(';');

                        int i = 0;
                        foreach (string value in varValues)
                            chMonitor.Invoke(new Action(() => 
                                chMonitor.Series[i].Points.AddXY(
                                    monitor.sampleTime * sampleCount, 
                                    Convert.ToDouble(value))
                           ));

                        writer.Write(Convert.ToString(monitor.sampleTime * sampleCount) + ";" + inputData + "\r\n");

                        sampleCount++;
                    }
                    writer.Close();
                }
            });
        }

        private void dataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            inputData = spMonitor.ReadLine();
            receivedDataQueue.Enqueue(inputData);
        }

        private void whenClosed(object sender, FormClosingEventArgs e)
        {
            spMonitor.Close();
            running = false;
            frmMain.Enabled = true;
            frmMain.Show();
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
