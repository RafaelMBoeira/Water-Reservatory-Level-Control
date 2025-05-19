namespace WindowsFormsApp2
{
    partial class SimulationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbControlTypes = new System.Windows.Forms.ComboBox();
            this.chSim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btSim = new System.Windows.Forms.ToolStripMenuItem();
            this.btExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxVariables = new System.Windows.Forms.GroupBox();
            this.tbDecay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGain = new System.Windows.Forms.TextBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.gbxSample = new System.Windows.Forms.GroupBox();
            this.tbSampleTime = new System.Windows.Forms.TextBox();
            this.gbxSimTime = new System.Windows.Forms.GroupBox();
            this.tbSimTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chSim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbxVariables.SuspendLayout();
            this.gbxControl.SuspendLayout();
            this.gbxSample.SuspendLayout();
            this.gbxSimTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbControlTypes
            // 
            this.cbControlTypes.FormattingEnabled = true;
            this.cbControlTypes.Items.AddRange(new object[] {
            "ON/OFF",
            "Proporcional",
            "Integrativo",
            "Derivativo"});
            this.cbControlTypes.Location = new System.Drawing.Point(6, 24);
            this.cbControlTypes.Name = "cbControlTypes";
            this.cbControlTypes.Size = new System.Drawing.Size(188, 24);
            this.cbControlTypes.TabIndex = 0;
            // 
            // chSim
            // 
            chartArea6.Name = "ChartArea1";
            this.chSim.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chSim.Legends.Add(legend6);
            this.chSim.Location = new System.Drawing.Point(12, 45);
            this.chSim.Name = "chSim";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chSim.Series.Add(series6);
            this.chSim.Size = new System.Drawing.Size(776, 300);
            this.chSim.TabIndex = 1;
            this.chSim.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSim,
            this.btExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btSim
            // 
            this.btSim.Name = "btSim";
            this.btSim.Size = new System.Drawing.Size(73, 24);
            this.btSim.Text = "Simular";
            this.btSim.Click += new System.EventHandler(this.simulate);
            // 
            // btExit
            // 
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(48, 24);
            this.btExit.Text = "Sair";
            this.btExit.Click += new System.EventHandler(this.exit);
            // 
            // gbxVariables
            // 
            this.gbxVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxVariables.Controls.Add(this.tbDecay);
            this.gbxVariables.Controls.Add(this.label5);
            this.gbxVariables.Controls.Add(this.tbPower);
            this.gbxVariables.Controls.Add(this.label4);
            this.gbxVariables.Controls.Add(this.tbGain);
            this.gbxVariables.Controls.Add(this.tbCurrent);
            this.gbxVariables.Controls.Add(this.label3);
            this.gbxVariables.Controls.Add(this.tbTarget);
            this.gbxVariables.Controls.Add(this.label2);
            this.gbxVariables.Controls.Add(this.label1);
            this.gbxVariables.Location = new System.Drawing.Point(375, 390);
            this.gbxVariables.Name = "gbxVariables";
            this.gbxVariables.Size = new System.Drawing.Size(248, 226);
            this.gbxVariables.TabIndex = 7;
            this.gbxVariables.TabStop = false;
            this.gbxVariables.Text = "Variáveis";
            // 
            // tbDecay
            // 
            this.tbDecay.Location = new System.Drawing.Point(130, 141);
            this.tbDecay.Name = "tbDecay";
            this.tbDecay.Size = new System.Drawing.Size(112, 22);
            this.tbDecay.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Decaimento (%)";
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(130, 113);
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(112, 22);
            this.tbPower.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Potência Máxima";
            // 
            // tbGain
            // 
            this.tbGain.Location = new System.Drawing.Point(130, 85);
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(112, 22);
            this.tbGain.TabIndex = 12;
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(130, 57);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(112, 22);
            this.tbCurrent.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ganho";
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(130, 27);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(112, 22);
            this.tbTarget.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor Atual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor Desejado";
            // 
            // gbxControl
            // 
            this.gbxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxControl.Controls.Add(this.cbControlTypes);
            this.gbxControl.Location = new System.Drawing.Point(169, 390);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(200, 78);
            this.gbxControl.TabIndex = 8;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Tipos de Controle";
            // 
            // gbxSample
            // 
            this.gbxSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSample.Controls.Add(this.tbSampleTime);
            this.gbxSample.Location = new System.Drawing.Point(169, 474);
            this.gbxSample.Name = "gbxSample";
            this.gbxSample.Size = new System.Drawing.Size(200, 68);
            this.gbxSample.TabIndex = 9;
            this.gbxSample.TabStop = false;
            this.gbxSample.Text = "Período da Amostragem";
            // 
            // tbSampleTime
            // 
            this.tbSampleTime.Location = new System.Drawing.Point(6, 29);
            this.tbSampleTime.Name = "tbSampleTime";
            this.tbSampleTime.Size = new System.Drawing.Size(188, 22);
            this.tbSampleTime.TabIndex = 11;
            // 
            // gbxSimTime
            // 
            this.gbxSimTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSimTime.Controls.Add(this.tbSimTime);
            this.gbxSimTime.Location = new System.Drawing.Point(169, 548);
            this.gbxSimTime.Name = "gbxSimTime";
            this.gbxSimTime.Size = new System.Drawing.Size(200, 68);
            this.gbxSimTime.TabIndex = 10;
            this.gbxSimTime.TabStop = false;
            this.gbxSimTime.Text = "Número de Amostras";
            // 
            // tbSimTime
            // 
            this.tbSimTime.Location = new System.Drawing.Point(6, 33);
            this.tbSimTime.Name = "tbSimTime";
            this.tbSimTime.Size = new System.Drawing.Size(188, 22);
            this.tbSimTime.TabIndex = 11;
            // 
            // SimulationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.gbxSimTime);
            this.Controls.Add(this.gbxSample);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.gbxVariables);
            this.Controls.Add(this.chSim);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SimulationForm";
            this.Text = "Simulação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.whenClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chSim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxVariables.ResumeLayout(false);
            this.gbxVariables.PerformLayout();
            this.gbxControl.ResumeLayout(false);
            this.gbxSample.ResumeLayout(false);
            this.gbxSample.PerformLayout();
            this.gbxSimTime.ResumeLayout(false);
            this.gbxSimTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbControlTypes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btSim;
        private System.Windows.Forms.ToolStripMenuItem btExit;
        private System.Windows.Forms.GroupBox gbxVariables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.GroupBox gbxSample;
        private System.Windows.Forms.TextBox tbGain;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.TextBox tbDecay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxSimTime;
        private System.Windows.Forms.TextBox tbSampleTime;
        private System.Windows.Forms.TextBox tbSimTime;
    }
}