namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.chNivel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.tbCalculations = new System.Windows.Forms.TextBox();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.opfOpen = new System.Windows.Forms.OpenFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.chNivel)).BeginInit();
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
            this.btRun});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1165, 28);
            this.navbar.TabIndex = 15;
            this.navbar.Text = "menu";
            // 
            // btNew
            // 
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(59, 26);
            this.btNew.Text = "Novo";
            this.btNew.Click += new System.EventHandler(this.newFile);
            // 
            // btOpen
            // 
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(65, 26);
            this.btOpen.Text = "Abrir...";
            this.btOpen.Click += new System.EventHandler(this.openFile);
            // 
            // btSave
            // 
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(63, 26);
            this.btSave.Text = "Salvar";
            this.btSave.Click += new System.EventHandler(this.saveFile);
            // 
            // btCompile
            // 
            this.btCompile.Name = "btCompile";
            this.btCompile.Size = new System.Drawing.Size(84, 26);
            this.btCompile.Text = "Compilar";
            this.btCompile.Click += new System.EventHandler(this.compile);
            // 
            // btLoad
            // 
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(80, 26);
            this.btLoad.Text = "Carregar";
            this.btLoad.Click += new System.EventHandler(this.loadProgram);
            // 
            // btSaveChart
            // 
            this.btSaveChart.Enabled = false;
            this.btSaveChart.Name = "btSaveChart";
            this.btSaveChart.Size = new System.Drawing.Size(115, 26);
            this.btSaveChart.Text = "Salvar Gráfico";
            this.btSaveChart.Click += new System.EventHandler(this.saveChart);
            // 
            // btRun
            // 
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(63, 26);
            this.btRun.Text = "Iniciar";
            this.btRun.Click += new System.EventHandler(this.startSimulation);
            // 
            // chNivel
            // 
            this.chNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea6.AxisY.Maximum = 310D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.Name = "ChartArea1";
            this.chNivel.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chNivel.Legends.Add(legend6);
            this.chNivel.Location = new System.Drawing.Point(552, 50);
            this.chNivel.Margin = new System.Windows.Forms.Padding(4);
            this.chNivel.Name = "chNivel";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Legend = "Legend1";
            series26.Name = "Series1";
            series26.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series26.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Legend = "Legend1";
            series27.Name = "Series2";
            series27.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series27.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Legend = "Legend1";
            series28.Name = "Series3";
            series28.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series28.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Legend = "Legend1";
            series29.Name = "Series4";
            series29.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series29.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Legend = "Legend1";
            series30.Name = "Series5";
            series30.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series30.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chNivel.Series.Add(series26);
            this.chNivel.Series.Add(series27);
            this.chNivel.Series.Add(series28);
            this.chNivel.Series.Add(series29);
            this.chNivel.Series.Add(series30);
            this.chNivel.Size = new System.Drawing.Size(600, 314);
            this.chNivel.TabIndex = 16;
            this.chNivel.Text = "chart1";
            title6.Name = "Nível d\'Água";
            this.chNivel.Titles.Add(title6);
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
            // opfOpen
            // 
            this.opfOpen.FileName = "opfAbrir";
            this.opfOpen.InitialDirectory = "C:\\";
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
            // Form1
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
            this.Controls.Add(this.chNivel);
            this.Controls.Add(this.tbPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navbar);
            this.MainMenuStrip = this.navbar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chNivel)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog opfOpen;
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
        public System.Windows.Forms.DataVisualization.Charting.Chart chNivel;
        public System.Windows.Forms.Button btSampleSizeChanger;
        public System.Windows.Forms.ToolStripMenuItem btSaveChart;
        public System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.CheckedListBox chbVariables;
        private System.Windows.Forms.Label label6;
    }
}

