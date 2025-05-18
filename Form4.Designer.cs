namespace WindowsFormsApp2
{
    partial class MonitoringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.navbar = new System.Windows.Forms.MenuStrip();
            this.btRun = new System.Windows.Forms.ToolStripMenuItem();
            this.btExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chMonitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chbVariables = new System.Windows.Forms.CheckedListBox();
            this.gbxPanel = new System.Windows.Forms.GroupBox();
            this.spMonitor = new System.IO.Ports.SerialPort(this.components);
            this.gbxSample = new System.Windows.Forms.GroupBox();
            this.tbSample = new System.Windows.Forms.TextBox();
            this.gpxBaudRate = new System.Windows.Forms.GroupBox();
            this.tbBaudRate = new System.Windows.Forms.TextBox();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMonitor)).BeginInit();
            this.gbxPanel.SuspendLayout();
            this.gbxSample.SuspendLayout();
            this.gpxBaudRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btRun,
            this.btExit});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1214, 28);
            this.navbar.TabIndex = 0;
            this.navbar.Text = "menuStrip1";
            // 
            // btRun
            // 
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(79, 24);
            this.btRun.Text = "Executar";
            this.btRun.Click += new System.EventHandler(this.run);
            // 
            // btExit
            // 
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(48, 24);
            this.btExit.Text = "Sair";
            this.btExit.Click += new System.EventHandler(this.exit);
            // 
            // chMonitor
            // 
            chartArea2.Name = "ChartArea1";
            this.chMonitor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chMonitor.Legends.Add(legend2);
            this.chMonitor.Location = new System.Drawing.Point(12, 49);
            this.chMonitor.Name = "chMonitor";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chMonitor.Series.Add(series2);
            this.chMonitor.Size = new System.Drawing.Size(776, 357);
            this.chMonitor.TabIndex = 1;
            this.chMonitor.Text = "chart1";
            // 
            // chbVariables
            // 
            this.chbVariables.FormattingEnabled = true;
            this.chbVariables.Location = new System.Drawing.Point(6, 30);
            this.chbVariables.Name = "chbVariables";
            this.chbVariables.Size = new System.Drawing.Size(205, 310);
            this.chbVariables.TabIndex = 2;
            // 
            // gbxPanel
            // 
            this.gbxPanel.Controls.Add(this.chbVariables);
            this.gbxPanel.Location = new System.Drawing.Point(983, 49);
            this.gbxPanel.Name = "gbxPanel";
            this.gbxPanel.Size = new System.Drawing.Size(217, 357);
            this.gbxPanel.TabIndex = 3;
            this.gbxPanel.TabStop = false;
            this.gbxPanel.Text = "Selecione Variáveis";
            // 
            // spMonitor
            // 
            this.spMonitor.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataReceived);
            // 
            // gbxSample
            // 
            this.gbxSample.Controls.Add(this.tbSample);
            this.gbxSample.Location = new System.Drawing.Point(811, 49);
            this.gbxSample.Name = "gbxSample";
            this.gbxSample.Size = new System.Drawing.Size(166, 60);
            this.gbxSample.TabIndex = 4;
            this.gbxSample.TabStop = false;
            this.gbxSample.Text = "Tempo de Amostragem";
            // 
            // tbSample
            // 
            this.tbSample.Location = new System.Drawing.Point(6, 30);
            this.tbSample.Name = "tbSample";
            this.tbSample.Size = new System.Drawing.Size(154, 22);
            this.tbSample.TabIndex = 0;
            // 
            // gpxBaudRate
            // 
            this.gpxBaudRate.Controls.Add(this.tbBaudRate);
            this.gpxBaudRate.Location = new System.Drawing.Point(811, 115);
            this.gpxBaudRate.Name = "gpxBaudRate";
            this.gpxBaudRate.Size = new System.Drawing.Size(166, 60);
            this.gpxBaudRate.TabIndex = 5;
            this.gpxBaudRate.TabStop = false;
            this.gpxBaudRate.Text = "BaudRate";
            // 
            // tbBaudRate
            // 
            this.tbBaudRate.Location = new System.Drawing.Point(6, 30);
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(154, 22);
            this.tbBaudRate.TabIndex = 0;
            // 
            // MonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 418);
            this.Controls.Add(this.gpxBaudRate);
            this.Controls.Add(this.gbxSample);
            this.Controls.Add(this.gbxPanel);
            this.Controls.Add(this.chMonitor);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.navbar;
            this.MaximizeBox = false;
            this.Name = "MonitoringForm";
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.whenClosed);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMonitor)).EndInit();
            this.gbxPanel.ResumeLayout(false);
            this.gbxSample.ResumeLayout(false);
            this.gbxSample.PerformLayout();
            this.gpxBaudRate.ResumeLayout(false);
            this.gpxBaudRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navbar;
        private System.Windows.Forms.ToolStripMenuItem btRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMonitor;
        private System.Windows.Forms.CheckedListBox chbVariables;
        private System.Windows.Forms.GroupBox gbxPanel;
        private System.Windows.Forms.ToolStripMenuItem btExit;
        private System.IO.Ports.SerialPort spMonitor;
        private System.Windows.Forms.GroupBox gbxSample;
        private System.Windows.Forms.TextBox tbSample;
        private System.Windows.Forms.GroupBox gpxBaudRate;
        private System.Windows.Forms.TextBox tbBaudRate;
    }
}