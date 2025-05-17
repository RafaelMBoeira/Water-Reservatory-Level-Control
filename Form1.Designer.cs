namespace WindowsFormsApp2
{
    partial class LevelControlForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.navbar = new System.Windows.Forms.MenuStrip();
            this.btNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.btLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btSaveChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btRun = new System.Windows.Forms.ToolStripMenuItem();
            this.btSkeletonPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.btConfigurations = new System.Windows.Forms.ToolStripMenuItem();
            this.chMonitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.tbCalculations = new System.Windows.Forms.TextBox();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.tmSample = new System.Windows.Forms.Timer(this.components);
            this.spNivel = new System.IO.Ports.SerialPort(this.components);
            this.sfdChart = new System.Windows.Forms.SaveFileDialog();
            this.tmVariaveis = new System.Windows.Forms.Timer(this.components);
            this.tbExcel1 = new System.Windows.Forms.TextBox();
            this.tbExcel2 = new System.Windows.Forms.TextBox();
            this.tbExcel3 = new System.Windows.Forms.TextBox();
            this.tbExcel4 = new System.Windows.Forms.TextBox();
            this.tbExcel5 = new System.Windows.Forms.TextBox();
            this.btSampleSizeChanger = new System.Windows.Forms.Button();
            this.chbVariables = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Período de Amostragem (ms):";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(371, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "VARIÁVEIS JÁ DEFINIDAS:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(371, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "h: Nível do Tanque";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(371, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "u: Vazão da bomba centrífuga";
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(993, 382);
            this.tbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(115, 22);
            this.tbPeriodo.TabIndex = 14;
            this.tbPeriodo.Text = "100";
            // 
            // navbar
            // 
            this.navbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNew,
            this.btOpen,
            this.btSave,
            this.btCompile,
            this.btLoad,
            this.btSaveChart,
            this.btRun,
            this.btSkeletonPicker,
            this.btConfigurations});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1165, 28);
            this.navbar.TabIndex = 15;
            this.navbar.Text = "menu";
            // 
            // btNew
            // 
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(59, 24);
            this.btNew.Text = "Novo";
            this.btNew.Click += new System.EventHandler(this.newFile);
            // 
            // btOpen
            // 
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(65, 24);
            this.btOpen.Text = "Abrir...";
            this.btOpen.Click += new System.EventHandler(this.openFile);
            // 
            // btSave
            // 
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(63, 24);
            this.btSave.Text = "Salvar";
            this.btSave.Click += new System.EventHandler(this.saveFile);
            // 
            // btCompile
            // 
            this.btCompile.Name = "btCompile";
            this.btCompile.Size = new System.Drawing.Size(84, 24);
            this.btCompile.Text = "Compilar";
            this.btCompile.Click += new System.EventHandler(this.compile);
            // 
            // btLoad
            // 
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(80, 24);
            this.btLoad.Text = "Carregar";
            this.btLoad.Click += new System.EventHandler(this.loadProgram);
            // 
            // btSaveChart
            // 
            this.btSaveChart.Enabled = false;
            this.btSaveChart.Name = "btSaveChart";
            this.btSaveChart.Size = new System.Drawing.Size(115, 24);
            this.btSaveChart.Text = "Salvar Gráfico";
            this.btSaveChart.Click += new System.EventHandler(this.saveChart);
            // 
            // btRun
            // 
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(63, 24);
            this.btRun.Text = "Iniciar";
            this.btRun.Click += new System.EventHandler(this.startSimulation);
            // 
            // btSkeletonPicker
            // 
            this.btSkeletonPicker.Name = "btSkeletonPicker";
            this.btSkeletonPicker.Size = new System.Drawing.Size(161, 24);
            this.btSkeletonPicker.Text = "Selecionar Esqueleto";
            // 
            // btConfigurations
            // 
            this.btConfigurations.Name = "btConfigurations";
            this.btConfigurations.Size = new System.Drawing.Size(118, 24);
            this.btConfigurations.Text = "Configurações";
            this.btConfigurations.Click += new System.EventHandler(this.openConfigurations);
            // 
            // chMonitor
            // 
            this.chMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.AxisY.Maximum = 310D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chMonitor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chMonitor.Legends.Add(legend1);
            this.chMonitor.Location = new System.Drawing.Point(552, 50);
            this.chMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.chMonitor.Name = "chMonitor";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series5";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chMonitor.Series.Add(series1);
            this.chMonitor.Series.Add(series2);
            this.chMonitor.Series.Add(series3);
            this.chMonitor.Series.Add(series4);
            this.chMonitor.Series.Add(series5);
            this.chMonitor.Size = new System.Drawing.Size(600, 314);
            this.chMonitor.TabIndex = 16;
            this.chMonitor.Text = "chart1";
            title1.Name = "Nível d\'Água";
            this.chMonitor.Titles.Add(title1);
            // 
            // tbVar
            // 
            this.tbVar.Location = new System.Drawing.Point(16, 50);
            this.tbVar.Margin = new System.Windows.Forms.Padding(4);
            this.tbVar.Multiline = true;
            this.tbVar.Name = "tbVar";
            this.tbVar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVar.Size = new System.Drawing.Size(340, 314);
            this.tbVar.TabIndex = 17;
            this.tbVar.Text = "//Declare aqui novas variáveis";
            this.tbVar.TextChanged += new System.EventHandler(this.newVariableAdded);
            // 
            // tbCalculations
            // 
            this.tbCalculations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCalculations.Location = new System.Drawing.Point(16, 385);
            this.tbCalculations.Margin = new System.Windows.Forms.Padding(4);
            this.tbCalculations.Multiline = true;
            this.tbCalculations.Name = "tbCalculations";
            this.tbCalculations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCalculations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCalculations.Size = new System.Drawing.Size(513, 445);
            this.tbCalculations.TabIndex = 18;
            this.tbCalculations.Text = "//Digite aqui sua lei de controle";
            // 
            // tmSample
            // 
            this.tmSample.Interval = 1000;
            // 
            // spNivel
            // 
            this.spNivel.PortName = "COM4";
            this.spNivel.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataReceived);
            // 
            // tmVariaveis
            // 
            this.tmVariaveis.Enabled = true;
            // 
            // tbExcel1
            // 
            this.tbExcel1.Location = new System.Drawing.Point(761, 676);
            this.tbExcel1.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel1.Multiline = true;
            this.tbExcel1.Name = "tbExcel1";
            this.tbExcel1.Size = new System.Drawing.Size(132, 24);
            this.tbExcel1.TabIndex = 31;
            this.tbExcel1.Visible = false;
            // 
            // tbExcel2
            // 
            this.tbExcel2.Location = new System.Drawing.Point(902, 676);
            this.tbExcel2.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel2.Multiline = true;
            this.tbExcel2.Name = "tbExcel2";
            this.tbExcel2.Size = new System.Drawing.Size(132, 24);
            this.tbExcel2.TabIndex = 32;
            this.tbExcel2.Visible = false;
            // 
            // tbExcel3
            // 
            this.tbExcel3.Location = new System.Drawing.Point(761, 740);
            this.tbExcel3.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel3.Multiline = true;
            this.tbExcel3.Name = "tbExcel3";
            this.tbExcel3.Size = new System.Drawing.Size(132, 24);
            this.tbExcel3.TabIndex = 33;
            this.tbExcel3.Visible = false;
            // 
            // tbExcel4
            // 
            this.tbExcel4.Location = new System.Drawing.Point(961, 708);
            this.tbExcel4.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel4.Multiline = true;
            this.tbExcel4.Name = "tbExcel4";
            this.tbExcel4.Size = new System.Drawing.Size(132, 24);
            this.tbExcel4.TabIndex = 34;
            this.tbExcel4.Visible = false;
            // 
            // tbExcel5
            // 
            this.tbExcel5.Location = new System.Drawing.Point(961, 740);
            this.tbExcel5.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel5.Multiline = true;
            this.tbExcel5.Name = "tbExcel5";
            this.tbExcel5.Size = new System.Drawing.Size(132, 24);
            this.tbExcel5.TabIndex = 35;
            this.tbExcel5.Visible = false;
            // 
            // btSampleSizeChanger
            // 
            this.btSampleSizeChanger.Enabled = false;
            this.btSampleSizeChanger.Location = new System.Drawing.Point(902, 412);
            this.btSampleSizeChanger.Margin = new System.Windows.Forms.Padding(4);
            this.btSampleSizeChanger.Name = "btSampleSizeChanger";
            this.btSampleSizeChanger.Size = new System.Drawing.Size(116, 28);
            this.btSampleSizeChanger.TabIndex = 36;
            this.btSampleSizeChanger.Text = "Mudar Tempo";
            this.btSampleSizeChanger.UseVisualStyleBackColor = true;
            this.btSampleSizeChanger.Click += new System.EventHandler(this.btPeriodo_Click);
            // 
            // chbVariables
            // 
            this.chbVariables.FormattingEnabled = true;
            this.chbVariables.Location = new System.Drawing.Point(552, 435);
            this.chbVariables.Name = "chbVariables";
            this.chbVariables.Size = new System.Drawing.Size(185, 395);
            this.chbVariables.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(549, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 47);
            this.label6.TabIndex = 41;
            this.label6.Text = "Selecione Variáveis para Monitoramento:";
            // 
            // LevelControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 844);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chbVariables);
            this.Controls.Add(this.btSampleSizeChanger);
            this.Controls.Add(this.tbExcel5);
            this.Controls.Add(this.tbExcel4);
            this.Controls.Add(this.tbExcel3);
            this.Controls.Add(this.tbExcel2);
            this.Controls.Add(this.tbExcel1);
            this.Controls.Add(this.tbCalculations);
            this.Controls.Add(this.tbVar);
            this.Controls.Add(this.chMonitor);
            this.Controls.Add(this.tbPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navbar);
            this.MainMenuStrip = this.navbar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LevelControlForm";
            this.Text = "Water Reservatory Level Control";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip navbar;
        private System.Windows.Forms.ToolStripMenuItem btNew;
        private System.Windows.Forms.ToolStripMenuItem btOpen;
        private System.Windows.Forms.ToolStripMenuItem btSave;
        private System.Windows.Forms.ToolStripMenuItem btCompile;
        private System.Windows.Forms.ToolStripMenuItem btLoad;
        private System.Windows.Forms.TextBox tbVar;
        private System.Windows.Forms.TextBox tbCalculations;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.SaveFileDialog sfdChart;
        public System.Windows.Forms.Timer tmSample;
        private System.Windows.Forms.ToolStripMenuItem btRun;
        public System.IO.Ports.SerialPort spNivel;
        private System.Windows.Forms.Timer tmVariaveis;
        private System.Windows.Forms.TextBox tbExcel1;
        private System.Windows.Forms.TextBox tbExcel2;
        private System.Windows.Forms.TextBox tbExcel3;
        private System.Windows.Forms.TextBox tbExcel4;
        private System.Windows.Forms.TextBox tbExcel5;
        public System.Windows.Forms.DataVisualization.Charting.Chart chMonitor;
        public System.Windows.Forms.Button btSampleSizeChanger;
        public System.Windows.Forms.ToolStripMenuItem btSaveChart;
        public System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.CheckedListBox chbVariables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem btSkeletonPicker;
        private System.Windows.Forms.ToolStripMenuItem btConfigurations;
    }
}

