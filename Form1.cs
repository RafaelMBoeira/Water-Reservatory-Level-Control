using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LevelControlForm : Form
    {
        private string currentProjectPath;
        private string skeletonsPath;
        private string selectedSkeletonPath;
        private string inoFilePath;
        private string csvPath = "";
        private string compilerPath = "";
        private string inputData;
        private int sampleCount = 0;
        private bool running = false;
        private ConcurrentQueue<string> receivedDataQueue = new ConcurrentQueue<string>();
        Dictionary<int, string> variables = new Dictionary<int, string>();
        public LevelControlForm()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(Properties.Settings.Default.DefaultSkeletonPath))
                skeletonsPath = Properties.Settings.Default.DefaultSkeletonPath;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.DefaultSavePath))
                currentProjectPath = Properties.Settings.Default.DefaultSavePath;

            if (!string.IsNullOrEmpty(skeletonsPath))
                foreach (string path in System.IO.Directory.GetFiles(skeletonsPath))
                {
                    ToolStripItem skeleton = new ToolStripMenuItem();

                    skeleton.Text = System.IO.Path.GetFileNameWithoutExtension(path);
                    skeleton.Click += skeletonSelected;
                    btSkeletonPicker.DropDownItems.Add(skeleton);
                
                    selectedSkeletonPath = path;
                }
        }

        private void skeletonSelected(object sender, EventArgs e)
        {
            selectedSkeletonPath = System.IO.Path.Combine(skeletonsPath, ((ToolStripItem) sender).Text + ".txt");
        }
        private void newVariableAdded(object sender, EventArgs e)
        {
            int i = 0;
            chbVariables.Items.Clear();
            chbVariables.Items.Add("h");
            chbVariables.Items.Add("u");
            variables.Clear();

            foreach (string s in tbVar.Lines)
            {
                string validVariable = Regex.Replace(s, "[^a-zA-Z]", "").Trim();

                if (string.IsNullOrEmpty(validVariable))
                    continue;

                chbVariables.Items.Add(validVariable);
                variables.Add(i, validVariable);
                i++;
            }
        }
        private void newFile(object sender, EventArgs e)
        {
            tbVar.Focus();
            currentProjectPath = Properties.Settings.Default.DefaultSavePath;
            tbVar.Text = "";
            tbCalculations.Text = "";
            tmSample.Enabled = false;
            spNivel.Close();
            sampleCount = 0;
        }
        private void openFile(object sender, EventArgs e)
        {
            string line;
            bool isVariableField = true;
            bool isControlLawField = false;
            OpenFileDialog opfOpen = new OpenFileDialog();
            if (opfOpen.ShowDialog() == DialogResult.OK)
            {
                tbVar.Text = "";
                tbCalculations.Text = "";
                System.IO.StreamReader file = new System.IO.StreamReader(opfOpen.FileName);
                while ((line = file.ReadLine()) != "//fim")
                {

                    if (line == "//Lei")
                    {
                        isVariableField = false;
                        isControlLawField = true;
                        continue;
                    }

                    if (isVariableField)
                    {
                        tbVar.Text += line;
                        tbVar.Text += "\r\n";
                    }

                    if (isControlLawField)
                    {
                        tbCalculations.Text += line;
                        tbCalculations.Text += "\r\n";
                    }
                }
            }
        }
        private void saveFile(object sender, EventArgs e)
        {
            string variables = tbVar.Text.Trim();
            string controlLaw = tbCalculations.Text.Trim();

            if (string.IsNullOrEmpty(variables))
            {
                MessageBox.Show("Informe algo na caixa de texto das Variáveis");
                return;
            }
            if (variables == "//Declare aqui novas variáveis")
            {
                MessageBox.Show("Informe novas variáveis");
                return;
            }
            if (string.IsNullOrEmpty(controlLaw))
            {
                MessageBox.Show("Informe algo na caixa de texto da lei de controle");
                return;
            }
            if (controlLaw == "//Digite aqui sua lei de controle")
            {
                MessageBox.Show("Informe sua lei de controle");
                return;
            }

            save(
                "Salvar Arquivo Texto",
                "Arquivo de Texto|.txt",
                "Arquivo",
                ".txt",
                currentProjectPath,
                tbVar.Text + "\r\n" + "//Lei" + "\r\n" + tbCalculations.Text + "\r\n" + "//fim"
            );

            return;
        }
        private void compile(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(tbVar.Text))
            {
                MessageBox.Show("Informe algo na caixa de texto das Variáveis");
                return;
            }
            if (tbVar.Text == "//Declare aqui novas variáveis")
            {
                MessageBox.Show("Informe novas variáveis");
                return;
            }
            if (string.IsNullOrEmpty(tbCalculations.Text))
            {
                MessageBox.Show("Informe algo na caixa de texto da lei de controle");
                return;
            }
            if (tbCalculations.Text == "//Digite aqui sua lei de controle")
            {
                MessageBox.Show("Informe sua lei de controle");
                return;
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.DefaultSkeletonPath))
            {
                MessageBox.Show("O caminho padrão para escolha de esqueletos não está configurado, altere nas configurações.");
                return;
            }

            if (string.IsNullOrEmpty(selectedSkeletonPath))
            {
                MessageBox.Show("Selecione um Esqueleto!");
                return;
            }

            inoFilePath = saveCompilationFile();
            currentProjectPath = System.IO.Path.GetFullPath(inoFilePath);

            if (!string.IsNullOrEmpty(inoFilePath))
                csvPath = saveChartFile();

            if (!string.IsNullOrEmpty(csvPath))
                compilerPath = saveCommandFile();

            if (!string.IsNullOrEmpty(compilerPath))
                System.Diagnostics.Process.Start(compilerPath);
        }
        private string createCode(string skeletonPath)
        {
            string fullCode = "";
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(skeletonPath);
            while ((line = file.ReadLine()) != "//fim")
            {
                if (line.Trim().ToString().Equals("//var"))
                {
                    for (int ind = 0; ind < chbVariables.Items.Count; ind++)
                        fullCode = string.Concat(fullCode, "float " + chbVariables.Items[ind] + " = 0;" + "\r\n");

                    continue;
                }
                if (line.Trim().ToString().Equals("//law"))
                {
                    for (int ind = 0; ind < tbCalculations.Lines.Length; ind++)
                        fullCode = string.Concat(fullCode, tbCalculations.Lines[ind] + ";" + "\r\n");

                    foreach (string variable in chbVariables.CheckedItems)
                        fullCode = string.Concat(
                            fullCode,
                            "Serial.print(" + variable + ");" + "\r\n",
                            "Serial.print(\";\");" + "\r\n"
                        );
                    continue;
                }

                fullCode = string.Concat(fullCode, line + "\r\n");
            }
            return fullCode;
        }
        private void loadProgram(object sender, EventArgs e)
        {
            PortSelectionForm frmPort = new PortSelectionForm(this, inoFilePath);
            frmPort.StartPosition = FormStartPosition.CenterParent;
            frmPort.Show();
        }
        private void saveChart(object sender, EventArgs e)
        {
            sfdChart.Title = "Salvar Arquivo do Excel";
            sfdChart.Filter = "CSV|.csv";
            sfdChart.FilterIndex = 0;
            sfdChart.FileName = "Tabela";
            sfdChart.DefaultExt = ".csv";
            sfdChart.InitialDirectory = currentProjectPath;
            sfdChart.RestoreDirectory = true;
            DialogResult resultado = sfdChart.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfdChart.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Close();
            }
        }
        private void startMonitoring(object sender, EventArgs e)
        {
            MonitoringForm frmMonitor = new MonitoringForm(this, csvPath);
            frmMonitor.StartPosition = FormStartPosition.CenterParent;
            frmMonitor.Show();
        }
        private void dataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            inputData = spNivel.ReadLine();
            spNivel.Close();
            receivedDataQueue.Enqueue(inputData);
        }
        public string save(
            string title,
            string filter,
            string filename,
            string defaultExt,
            string initialDirectory,
            string content
        )
        {
            sfdSave.Title = title;
            sfdSave.Filter = filter;
            sfdSave.FilterIndex = 0;
            sfdSave.FileName = filename;
            sfdSave.DefaultExt = defaultExt;
            sfdSave.InitialDirectory = initialDirectory;
            sfdSave.RestoreDirectory = true;
            DialogResult result = sfdSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfdSave.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(content);
                writer.Close();

                return sfdSave.FileName;
            }
            return "";
        }
        private string saveCompilationFile()
        {
            string code = createCode(selectedSkeletonPath);
            return save(
                "Salvar Arquivo do Compilador",
                "Compilador|.ino",
                "Programa",
                ".ino",
                inoFilePath,
                code
            );
        }
        private string saveChartFile()
        {
            string header = "time;";
            foreach (string variable in chbVariables.CheckedItems)
                header = string.Concat(header, variable,";");

            return save(
                "Salvar Arquivo do Gráfico",
                "Gráfico|.csv",
                "Gráfico",
                ".csv",
                csvPath,
                header+"\r\n"
            );
        }
        private string saveCommandFile()
        {
            return save(
                "Salvar Comando de Compilação",
                "Prompt|.BAT",
                "Compilar",
                ".BAT",
                currentProjectPath,
                "\"C:\\Program Files (x86)\\Arduino\\arduino_debug.exe\"" + " --pref " + "\"build.path=C:\\Users\\Public\\Documents\\Arduino\\plantadenivel\\builder\"" + " --verify " + "\"" + inoFilePath + "\"" + "\r\n" + " pause"
            );
        }
        private void openConfigurations(object sender, EventArgs e)
        {
            ConfigurationForm frmConfig = new ConfigurationForm(this);
            frmConfig.StartPosition = FormStartPosition.CenterParent;
            frmConfig.Show();
        }

        private void startSimulation(object sender, EventArgs e)
        {
        }
    }
}
