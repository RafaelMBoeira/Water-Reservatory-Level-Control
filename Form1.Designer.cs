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
            this.chNivel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.tbCalculations = new System.Windows.Forms.TextBox();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.opfOpen = new System.Windows.Forms.OpenFileDialog();
            this.tmSample = new System.Windows.Forms.Timer(this.components);
            this.spNivel = new System.IO.Ports.SerialPort(this.components);
            this.sfdChart = new System.Windows.Forms.SaveFileDialog();
            this.cbV1 = new System.Windows.Forms.ComboBox();
            this.cbV2 = new System.Windows.Forms.ComboBox();
            this.cbV3 = new System.Windows.Forms.ComboBox();
            this.cbV4 = new System.Windows.Forms.ComboBox();
            this.cbV5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tmVariaveis = new System.Windows.Forms.Timer(this.components);
            this.btVar = new System.Windows.Forms.Button();
            this.tbExcel1 = new System.Windows.Forms.TextBox();
            this.tbExcel2 = new System.Windows.Forms.TextBox();
            this.tbExcel3 = new System.Windows.Forms.TextBox();
            this.tbExcel4 = new System.Windows.Forms.TextBox();
            this.tbExcel5 = new System.Windows.Forms.TextBox();
            this.btPeriodo = new System.Windows.Forms.Button();
            this.tbMod = new System.Windows.Forms.TextBox();
            this.btMod = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chbVariables = new System.Windows.Forms.CheckedListBox();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Período de Amostragem (ms):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "VARIÁVEIS DISPONÍVEIS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "h: Nível do Tanque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "u: Sinal de controle do sistema (Vazão da bomba centrífuga)";
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(565, 47);
            this.tbPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(115, 22);
            this.tbPeriodo.TabIndex = 14;
            this.tbPeriodo.Text = "100";
            // 
            // menuStrip1
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
            this.navbar.Name = "menuStrip1";
            this.navbar.Size = new System.Drawing.Size(1320, 28);
            this.navbar.TabIndex = 15;
            this.navbar.Text = "menu";
            // 
            // novoToolStripMenuItem
            // 
            this.btNew.Name = "novoToolStripMenuItem";
            this.btNew.Size = new System.Drawing.Size(59, 24);
            this.btNew.Text = "Novo";
            this.btNew.Click += new System.EventHandler(this.newFile);
            // 
            // Abrir
            // 
            this.btOpen.Name = "Abrir";
            this.btOpen.Size = new System.Drawing.Size(65, 24);
            this.btOpen.Text = "Abrir...";
            this.btOpen.Click += new System.EventHandler(this.openFile);
            // 
            // salvarToolStripMenuItem
            // 
            this.btSave.Name = "salvarToolStripMenuItem";
            this.btSave.Size = new System.Drawing.Size(63, 24);
            this.btSave.Text = "Salvar";
            this.btSave.Click += new System.EventHandler(this.saveFile);
            // 
            // compilarToolStripMenuItem
            // 
            this.btCompile.Name = "compilarToolStripMenuItem";
            this.btCompile.Size = new System.Drawing.Size(84, 24);
            this.btCompile.Text = "Compilar";
            this.btCompile.Click += new System.EventHandler(this.compile);
            // 
            // carregarToolStripMenuItem
            // 
            this.btLoad.Name = "carregarToolStripMenuItem";
            this.btLoad.Size = new System.Drawing.Size(80, 24);
            this.btLoad.Text = "Carregar";
            this.btLoad.Click += new System.EventHandler(this.loadProgram);
            // 
            // salvarGráficoToolStripMenuItem
            // 
            this.btSaveChart.Enabled = false;
            this.btSaveChart.Name = "salvarGráficoToolStripMenuItem";
            this.btSaveChart.Size = new System.Drawing.Size(115, 24);
            this.btSaveChart.Text = "Salvar Gráfico";
            this.btSaveChart.Click += new System.EventHandler(this.saveChart);
            // 
            // iniciarToolStripMenuItem
            // 
            this.btRun.Name = "iniciarToolStripMenuItem";
            this.btRun.Size = new System.Drawing.Size(63, 24);
            this.btRun.Text = "Iniciar";
            this.btRun.Click += new System.EventHandler(this.startSimulation);
            // 
            // chNivel
            // 
            this.chNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.AxisY.Maximum = 310D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chNivel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chNivel.Legends.Add(legend1);
            this.chNivel.Location = new System.Drawing.Point(763, 50);
            this.chNivel.Margin = new System.Windows.Forms.Padding(4);
            this.chNivel.Name = "chNivel";
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
            this.chNivel.Series.Add(series1);
            this.chNivel.Series.Add(series2);
            this.chNivel.Series.Add(series3);
            this.chNivel.Series.Add(series4);
            this.chNivel.Series.Add(series5);
            this.chNivel.Size = new System.Drawing.Size(541, 314);
            this.chNivel.TabIndex = 16;
            this.chNivel.Text = "chart1";
            title1.Name = "Nível d\'Água";
            this.chNivel.Titles.Add(title1);
            // 
            // tbVar
            // 
            this.tbVar.Location = new System.Drawing.Point(16, 50);
            this.tbVar.Margin = new System.Windows.Forms.Padding(4);
            this.tbVar.Multiline = true;
            this.tbVar.Name = "tbVar";
            this.tbVar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVar.Size = new System.Drawing.Size(340, 245);
            this.tbVar.TabIndex = 17;
            this.tbVar.Text = "//Declare aqui novas variáveis";
            this.tbVar.TextChanged += new System.EventHandler(this.newVariableAdded);
            // 
            // tbLei
            // 
            this.tbCalculations.Location = new System.Drawing.Point(16, 304);
            this.tbCalculations.Margin = new System.Windows.Forms.Padding(4);
            this.tbCalculations.Multiline = true;
            this.tbCalculations.Name = "tbLei";
            this.tbCalculations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCalculations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCalculations.Size = new System.Drawing.Size(737, 525);
            this.tbCalculations.TabIndex = 18;
            this.tbCalculations.Text = "//Digite aqui sua lei de controle";
            // 
            // opfAbrir
            // 
            this.opfOpen.FileName = "opfAbrir";
            this.opfOpen.InitialDirectory = "C:\\";
            // 
            // tmAmostra
            // 
            this.tmSample.Interval = 1000;
            // 
            // spNivel
            // 
            this.spNivel.PortName = "COM4";
            this.spNivel.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataReceived);
            // 
            // cbV1
            // 
            this.cbV1.FormattingEnabled = true;
            this.cbV1.Location = new System.Drawing.Point(763, 421);
            this.cbV1.Margin = new System.Windows.Forms.Padding(4);
            this.cbV1.Name = "cbV1";
            this.cbV1.Size = new System.Drawing.Size(160, 24);
            this.cbV1.TabIndex = 20;
            // 
            // cbV2
            // 
            this.cbV2.FormattingEnabled = true;
            this.cbV2.Location = new System.Drawing.Point(763, 470);
            this.cbV2.Margin = new System.Windows.Forms.Padding(4);
            this.cbV2.Name = "cbV2";
            this.cbV2.Size = new System.Drawing.Size(160, 24);
            this.cbV2.TabIndex = 21;
            // 
            // cbV3
            // 
            this.cbV3.FormattingEnabled = true;
            this.cbV3.Location = new System.Drawing.Point(763, 519);
            this.cbV3.Margin = new System.Windows.Forms.Padding(4);
            this.cbV3.Name = "cbV3";
            this.cbV3.Size = new System.Drawing.Size(160, 24);
            this.cbV3.TabIndex = 22;
            // 
            // cbV4
            // 
            this.cbV4.FormattingEnabled = true;
            this.cbV4.Location = new System.Drawing.Point(763, 569);
            this.cbV4.Margin = new System.Windows.Forms.Padding(4);
            this.cbV4.Name = "cbV4";
            this.cbV4.Size = new System.Drawing.Size(160, 24);
            this.cbV4.TabIndex = 23;
            // 
            // cbV5
            // 
            this.cbV5.FormattingEnabled = true;
            this.cbV5.Location = new System.Drawing.Point(763, 618);
            this.cbV5.Margin = new System.Windows.Forms.Padding(4);
            this.cbV5.Name = "cbV5";
            this.cbV5.Size = new System.Drawing.Size(160, 24);
            this.cbV5.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 401);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Valor 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 450);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Valor 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(763, 500);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Valor 3:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 549);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Valor 4:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(763, 598);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Valor 5:";
            // 
            // tmVariaveis
            // 
            this.tmVariaveis.Enabled = true;
            // 
            // btVar
            // 
            this.btVar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btVar.Location = new System.Drawing.Point(763, 651);
            this.btVar.Margin = new System.Windows.Forms.Padding(4);
            this.btVar.Name = "btVar";
            this.btVar.Size = new System.Drawing.Size(161, 28);
            this.btVar.TabIndex = 30;
            this.btVar.Text = "Monitorar Variáveis";
            this.btVar.UseVisualStyleBackColor = true;
            this.btVar.Click += new System.EventHandler(this.btVar_Click);
            // 
            // tbExcel1
            // 
            this.tbExcel1.Location = new System.Drawing.Point(904, 372);
            this.tbExcel1.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel1.Multiline = true;
            this.tbExcel1.Name = "tbExcel1";
            this.tbExcel1.Size = new System.Drawing.Size(132, 24);
            this.tbExcel1.TabIndex = 31;
            this.tbExcel1.Visible = false;
            // 
            // tbExcel2
            // 
            this.tbExcel2.Location = new System.Drawing.Point(1045, 372);
            this.tbExcel2.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel2.Multiline = true;
            this.tbExcel2.Name = "tbExcel2";
            this.tbExcel2.Size = new System.Drawing.Size(132, 24);
            this.tbExcel2.TabIndex = 32;
            this.tbExcel2.Visible = false;
            // 
            // tbExcel3
            // 
            this.tbExcel3.Location = new System.Drawing.Point(963, 404);
            this.tbExcel3.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel3.Multiline = true;
            this.tbExcel3.Name = "tbExcel3";
            this.tbExcel3.Size = new System.Drawing.Size(132, 24);
            this.tbExcel3.TabIndex = 33;
            this.tbExcel3.Visible = false;
            // 
            // tbExcel4
            // 
            this.tbExcel4.Location = new System.Drawing.Point(1104, 404);
            this.tbExcel4.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel4.Multiline = true;
            this.tbExcel4.Name = "tbExcel4";
            this.tbExcel4.Size = new System.Drawing.Size(132, 24);
            this.tbExcel4.TabIndex = 34;
            this.tbExcel4.Visible = false;
            // 
            // tbExcel5
            // 
            this.tbExcel5.Location = new System.Drawing.Point(1104, 436);
            this.tbExcel5.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcel5.Multiline = true;
            this.tbExcel5.Name = "tbExcel5";
            this.tbExcel5.Size = new System.Drawing.Size(132, 24);
            this.tbExcel5.TabIndex = 35;
            this.tbExcel5.Visible = false;
            // 
            // btPeriodo
            // 
            this.btPeriodo.Enabled = false;
            this.btPeriodo.Location = new System.Drawing.Point(565, 78);
            this.btPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.btPeriodo.Name = "btPeriodo";
            this.btPeriodo.Size = new System.Drawing.Size(116, 28);
            this.btPeriodo.TabIndex = 36;
            this.btPeriodo.Text = "Mudar Tempo";
            this.btPeriodo.UseVisualStyleBackColor = true;
            this.btPeriodo.Click += new System.EventHandler(this.btPeriodo_Click);
            // 
            // tbMod
            // 
            this.tbMod.Location = new System.Drawing.Point(763, 687);
            this.tbMod.Margin = new System.Windows.Forms.Padding(4);
            this.tbMod.Name = "tbMod";
            this.tbMod.Size = new System.Drawing.Size(160, 22);
            this.tbMod.TabIndex = 37;
            // 
            // btMod
            // 
            this.btMod.Enabled = false;
            this.btMod.Location = new System.Drawing.Point(763, 719);
            this.btMod.Margin = new System.Windows.Forms.Padding(4);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(161, 28);
            this.btMod.TabIndex = 38;
            this.btMod.Text = "Modificar Variável";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 48);
            this.label5.TabIndex = 39;
            this.label5.Text = "Para mudar o tempo de amostragem digite no campo acima \r\ndo botão \"Modificar Vari" +
    "áveis\" a letra \"T\" mais o tempo que \r\ndesejas. Ex.: T100.\r\n";
            // 
            // chbVariables
            // 
            this.chbVariables.FormattingEnabled = true;
            this.chbVariables.Location = new System.Drawing.Point(963, 519);
            this.chbVariables.Name = "chbVariables";
            this.chbVariables.Size = new System.Drawing.Size(181, 191);
            this.chbVariables.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 844);
            this.Controls.Add(this.chbVariables);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.tbMod);
            this.Controls.Add(this.btPeriodo);
            this.Controls.Add(this.tbExcel5);
            this.Controls.Add(this.tbExcel4);
            this.Controls.Add(this.tbExcel3);
            this.Controls.Add(this.tbExcel2);
            this.Controls.Add(this.tbExcel1);
            this.Controls.Add(this.btVar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbV5);
            this.Controls.Add(this.cbV4);
            this.Controls.Add(this.cbV3);
            this.Controls.Add(this.cbV2);
            this.Controls.Add(this.cbV1);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer tmVariaveis;
        private System.Windows.Forms.TextBox tbExcel1;
        private System.Windows.Forms.TextBox tbExcel2;
        private System.Windows.Forms.TextBox tbExcel3;
        private System.Windows.Forms.TextBox tbExcel4;
        private System.Windows.Forms.TextBox tbExcel5;
        public System.Windows.Forms.DataVisualization.Charting.Chart chNivel;
        public System.Windows.Forms.ComboBox cbV1;
        public System.Windows.Forms.ComboBox cbV2;
        public System.Windows.Forms.ComboBox cbV3;
        public System.Windows.Forms.ComboBox cbV4;
        public System.Windows.Forms.ComboBox cbV5;
        private System.Windows.Forms.TextBox tbMod;
        public System.Windows.Forms.Button btPeriodo;
        public System.Windows.Forms.ToolStripMenuItem btSaveChart;
        public System.Windows.Forms.Button btVar;
        public System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.CheckedListBox chbVariables;
    }
}

