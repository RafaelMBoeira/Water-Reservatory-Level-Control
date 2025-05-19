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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.navbar = new System.Windows.Forms.MenuStrip();
            this.btNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btCompile = new System.Windows.Forms.ToolStripMenuItem();
            this.btLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btRun = new System.Windows.Forms.ToolStripMenuItem();
            this.btSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.btMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.btSkeletonPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.btConfigurations = new System.Windows.Forms.ToolStripMenuItem();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.tbCalculations = new System.Windows.Forms.TextBox();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.tmSample = new System.Windows.Forms.Timer(this.components);
            this.spNivel = new System.IO.Ports.SerialPort(this.components);
            this.sfdChart = new System.Windows.Forms.SaveFileDialog();
            this.tmVariaveis = new System.Windows.Forms.Timer(this.components);
            this.chbVariables = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.navbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(476, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "VARIÁVEIS JÁ DEFINIDAS:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(476, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "h: Nível do Tanque";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(476, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "u: Vazão da bomba centrífuga";
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
            this.btRun,
            this.btSkeletonPicker,
            this.btConfigurations});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(782, 28);
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
            // btRun
            // 
            this.btRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSimulation,
            this.btMonitor});
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(63, 24);
            this.btRun.Text = "Iniciar";
            // 
            // btSimulation
            // 
            this.btSimulation.Name = "btSimulation";
            this.btSimulation.Size = new System.Drawing.Size(196, 26);
            this.btSimulation.Text = "Simulação";
            this.btSimulation.Click += new System.EventHandler(this.startSimulation);
            // 
            // btMonitor
            // 
            this.btMonitor.Name = "btMonitor";
            this.btMonitor.Size = new System.Drawing.Size(196, 26);
            this.btMonitor.Text = "Monitoramento";
            this.btMonitor.Click += new System.EventHandler(this.startMonitoring);
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
            // tbVar
            // 
            this.tbVar.Location = new System.Drawing.Point(7, 22);
            this.tbVar.Margin = new System.Windows.Forms.Padding(4);
            this.tbVar.Multiline = true;
            this.tbVar.Name = "tbVar";
            this.tbVar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbVar.Size = new System.Drawing.Size(437, 292);
            this.tbVar.TabIndex = 17;
            this.tbVar.Text = "//Declare aqui novas variáveis";
            this.tbVar.TextChanged += new System.EventHandler(this.newVariableAdded);
            // 
            // tbCalculations
            // 
            this.tbCalculations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCalculations.Location = new System.Drawing.Point(7, 22);
            this.tbCalculations.Margin = new System.Windows.Forms.Padding(4);
            this.tbCalculations.Multiline = true;
            this.tbCalculations.Name = "tbCalculations";
            this.tbCalculations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCalculations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCalculations.Size = new System.Drawing.Size(437, 411);
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
            // chbVariables
            // 
            this.chbVariables.FormattingEnabled = true;
            this.chbVariables.Location = new System.Drawing.Point(6, 21);
            this.chbVariables.Name = "chbVariables";
            this.chbVariables.Size = new System.Drawing.Size(245, 412);
            this.chbVariables.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbVariables);
            this.groupBox1.Location = new System.Drawing.Point(503, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 448);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variáveis para Monitoramento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbVar);
            this.groupBox2.Location = new System.Drawing.Point(16, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 328);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Declaração de Variáveis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCalculations);
            this.groupBox3.Location = new System.Drawing.Point(16, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 448);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lei de Controle";
            // 
            // LevelControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 844);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.navbar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LevelControlForm";
            this.Text = "Water Reservatory Level Control";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem btSkeletonPicker;
        private System.Windows.Forms.ToolStripMenuItem btConfigurations;
        private System.Windows.Forms.ToolStripMenuItem btSimulation;
        private System.Windows.Forms.ToolStripMenuItem btMonitor;
        private System.Windows.Forms.CheckedListBox chbVariables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

