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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbControlTypes = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nmTarget = new System.Windows.Forms.NumericUpDown();
            this.nmCurrent = new System.Windows.Forms.NumericUpDown();
            this.nmHigh = new System.Windows.Forms.NumericUpDown();
            this.gbxVariables = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btApply = new System.Windows.Forms.Button();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmPower = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHigh)).BeginInit();
            this.gbxVariables.SuspendLayout();
            this.gbxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPower)).BeginInit();
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
            this.cbControlTypes.SelectionChangeCommitted += new System.EventHandler(this.changeControlType);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 45);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simularToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.simularToolStripMenuItem.Text = "Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simulate);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.exit);
            // 
            // nmTarget
            // 
            this.nmTarget.Location = new System.Drawing.Point(122, 28);
            this.nmTarget.Name = "nmTarget";
            this.nmTarget.Size = new System.Drawing.Size(120, 22);
            this.nmTarget.TabIndex = 3;
            // 
            // nmCurrent
            // 
            this.nmCurrent.Location = new System.Drawing.Point(122, 56);
            this.nmCurrent.Name = "nmCurrent";
            this.nmCurrent.Size = new System.Drawing.Size(120, 22);
            this.nmCurrent.TabIndex = 4;
            // 
            // nmHigh
            // 
            this.nmHigh.Location = new System.Drawing.Point(122, 84);
            this.nmHigh.Name = "nmHigh";
            this.nmHigh.Size = new System.Drawing.Size(120, 22);
            this.nmHigh.TabIndex = 5;
            // 
            // gbxVariables
            // 
            this.gbxVariables.Controls.Add(this.nmPower);
            this.gbxVariables.Controls.Add(this.label4);
            this.gbxVariables.Controls.Add(this.btApply);
            this.gbxVariables.Controls.Add(this.label3);
            this.gbxVariables.Controls.Add(this.label2);
            this.gbxVariables.Controls.Add(this.label1);
            this.gbxVariables.Controls.Add(this.nmTarget);
            this.gbxVariables.Controls.Add(this.nmCurrent);
            this.gbxVariables.Controls.Add(this.nmHigh);
            this.gbxVariables.Location = new System.Drawing.Point(414, 362);
            this.gbxVariables.Name = "gbxVariables";
            this.gbxVariables.Size = new System.Drawing.Size(248, 199);
            this.gbxVariables.TabIndex = 7;
            this.gbxVariables.TabStop = false;
            this.gbxVariables.Text = "Variáveis";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor Atual";
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
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(9, 170);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(233, 23);
            this.btApply.TabIndex = 10;
            this.btApply.Text = "Aplicar Valores";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.applyValues);
            // 
            // gbxControl
            // 
            this.gbxControl.Controls.Add(this.cbControlTypes);
            this.gbxControl.Location = new System.Drawing.Point(128, 362);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(200, 199);
            this.gbxControl.TabIndex = 8;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Tipos de Controle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Potência";
            // 
            // nmPower
            // 
            this.nmPower.Location = new System.Drawing.Point(122, 112);
            this.nmPower.Name = "nmPower";
            this.nmPower.Size = new System.Drawing.Size(120, 22);
            this.nmPower.TabIndex = 12;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.gbxVariables);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SimulationForm";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHigh)).EndInit();
            this.gbxVariables.ResumeLayout(false);
            this.gbxVariables.PerformLayout();
            this.gbxControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbControlTypes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nmTarget;
        private System.Windows.Forms.NumericUpDown nmCurrent;
        private System.Windows.Forms.NumericUpDown nmHigh;
        private System.Windows.Forms.GroupBox gbxVariables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.NumericUpDown nmPower;
        private System.Windows.Forms.Label label4;
    }
}