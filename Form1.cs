using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int contvar = 0;
        private string currentProjectPath = @"C:\";
        private string skeletonsPath = @"E:\\Programa Nivel-CS\\Nova pasta\\Water-Reservatory-Level-Control\\skeletons\\";
        private string selectedSkeletonPath;
        private string inoFilePath;
        Dictionary<int, string> variables = new Dictionary<int, string>();
        string inputData;
        int comp_s = 1;
        int save_s = 1;
        int graf_s = 1;
        int cExcel = 0;

        public string salvando, compilando, graphic;
        public Form1()
        {
            InitializeComponent();

            foreach (string path in System.IO.Directory.GetFiles(skeletonsPath))
            {
                ToolStripItem skeleton = new ToolStripMenuItem();
                skeleton.Text = System.IO.Path.GetFileNameWithoutExtension(path);
                skeleton.Click += skeletonSelected;
                btSkeletonPicker.DropDownItems.Add(skeleton);
            }
        }

        private void skeletonSelected(object sender, EventArgs e)
        {
            selectedSkeletonPath = skeletonsPath + ((ToolStripItem) sender).Text + ".txt";
        }

        private void newFile(object sender, EventArgs e)
        {
            tbVar.Focus();
            currentProjectPath = @"C:\";
            tbExcel1.Text = "";
            tbExcel2.Text = "";
            tbExcel3.Text = "";
            tbExcel4.Text = "";
            tbExcel5.Text = "";
            chNivel.Series.Clear();
            tbVar.Text = " ";
            tbCalculations.Text = " ";
            tbPeriodo.Text = "100";
            btSampleSizeChanger.Enabled = false;
            btSaveChart.Enabled = false;
            tmSample.Enabled = false;
            spNivel.Close();
            cExcel = 0;
            comp_s = 1;
        }
        
        private void openFile(object sender, EventArgs e)
        {
            string line;
            bool isVariableField = true;
            bool isControlLawField = false;
            OpenFileDialog opfAbrir = new OpenFileDialog();
            if (opfAbrir.ShowDialog() == DialogResult.OK)
            {
                tbVar.Text = "";
                tbCalculations.Text = "";
                System.IO.StreamReader file = new System.IO.StreamReader(opfAbrir.FileName);
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
            //verifica se existe algo digitado na caixa de texto
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
            
            //verifica se existe algo digitado na caixa de texto
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

            currentProjectPath = saveCompilationFile();
            inoFilePath = currentProjectPath;
            if (!string.IsNullOrEmpty(currentProjectPath))
                currentProjectPath = saveChartFile();

            if (!string.IsNullOrEmpty(currentProjectPath))
                currentProjectPath = saveCommandFile();

            //if (!string.IsNullOrEmpty(currentProjectPath))
            //    System.Diagnostics.Process.Start(compilando);
        }

        private void loadProgram(object sender, EventArgs e)
        {
            frmPort frmPort = new frmPort(inoFilePath);
            frmPort.StartPosition = FormStartPosition.CenterParent;
            frmPort.Show();
        }

        private void saveChart(object sender, EventArgs e)
        {
            //define o titulo
            sfdChart.Title = "Salvar Arquivo do Excel";
            //Define as extensões permitidas
            sfdChart.Filter = "CSV|.csv";
            //define o indice do filtro
            sfdChart.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            sfdChart.FileName = "Tabela";
            //Define a extensão padrão como .csv
            sfdChart.DefaultExt = ".csv";
            //define o diretório padrão
            sfdChart.InitialDirectory = @"C:\";
            //restaura o diretorio atual antes de fechar a janela
            sfdChart.RestoreDirectory = true;
            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = sfdChart.ShowDialog();
            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                //pega o diretório onde o arquivo .ino foi salvo
                //salvando = sfdSalvar.FileName;
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(sfdChart.FileName, FileMode.Create);
                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.Write(tbExcel1.Text + "\r\n");
                writer.Write(tbExcel2.Text + "\r\n");
                writer.Write(tbExcel3.Text + "\r\n");
                writer.Write(tbExcel4.Text + "\r\n");
                writer.Write(tbExcel5.Text + "\r\n");
                //fecha o escrito e o stream
                writer.Close();
            }
            else
            {
                //exibe mensagem informando que a operação foi cancelada
                MessageBox.Show("Operação cancelada");
            }
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

        private void startSimulation(object sender, EventArgs e)
        {
            if (btRun.Text.Equals("Iniciar"))
            {
                if (spNivel.IsOpen == false)
                    spNivel.Open();
                spNivel.Write("I");
                btRun.Text = "Parar";
                btSaveChart.Enabled = true;
                return;
            }

            if (btRun.Text.Equals("Parar"))
            {
                spNivel.Open();
                spNivel.Write("F");
                spNivel.Close();
                cExcel = 0;
                btRun.Text = "Iniciar";
                btSaveChart.Enabled = false;
                return;
            }

        }
        private void threatDataReceived()
        {
            string[] varValues = inputData.Split(';');

            int i = 0;
            foreach (string value in varValues)
            {
                chNivel.Series[i].Points.AddXY(Convert.ToInt64(tbPeriodo.Text) * cExcel, Convert.ToDouble(value));
            }

            if (chNivel.Series.Count > 100)
                chNivel.Series.RemoveAt(0);

            using (StreamWriter writer = new StreamWriter(graphic, true))
            {
                writer.Write(inputData + ";" + Convert.ToString(Convert.ToInt32(tbPeriodo.Text) * cExcel) + ";" + "\r\n");
                writer.Close();
            }
            cExcel++;
            spNivel.Open();
        }

        private void dataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            inputData = spNivel.ReadLine();
            spNivel.Close();
            threatDataReceived();
        }

        private void btPeriodo_Click(object sender, EventArgs e)
        {
            tmSample.Interval = Convert.ToInt32(tbPeriodo.Text);
            if (spNivel.IsOpen == false)
                spNivel.Open();
            spNivel.Write("T"+tbPeriodo.Text);
        }

        private string saveCompilationFile()
        {
            if (string.IsNullOrEmpty(selectedSkeletonPath))
            {
                MessageBox.Show("Selecione um Esqueleto!");
                return "";
            }

            string code = createCode(selectedSkeletonPath);
            return save(
                "Salvar Arquivo do Compilador",
                "Compilador|.ino",
                "Programa",
                ".ino",
                currentProjectPath,
                code
            );
        }

        private string saveChartFile()
        {
            return save(
                "Salvar Arquivo do Gráfico",
                "Gráfico|.csv",
                "Gráfico",
                ".csv",
                currentProjectPath,
                tbExcel1.Text
            );
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
                    {
                        Console.WriteLine("asdadasda");
                        fullCode = string.Concat(fullCode, "float " + chbVariables.Items[ind] + " = 0;" + "\r\n");
                    }
                    continue;
                }
                if (line.Trim().ToString().Equals("//law"))
                {
                    Console.WriteLine(tbCalculations.Lines.Length);
                    Console.WriteLine(chbVariables.CheckedItems.Count);
                    for (int ind = 0; ind < tbCalculations.Lines.Length; ind++)
                        fullCode = string.Concat(fullCode, tbCalculations.Lines[ind] + ";" + "\r\n");

                    for (int ind = 0; ind < chbVariables.CheckedItems.Count; ind++)
                        fullCode = string.Concat(
                            fullCode, 
                            "Serial.print(" + chbVariables.CheckedItems[ind] + ");" + "\r\n",
                            "Serial.print(\";\");" + "\r\n"
                        );
                    continue;
                }

                fullCode = string.Concat(fullCode, line + "\r\n");
            }
            return fullCode;
        }

        private string save(
            string title,
            string filter,
            string filename,
            string defaultExt,
            string initialDirectory,
            string content
        )
        {
            sfdSave.Title = title;
            //Define as extensões permitidas
            sfdSave.Filter = filter;
            //define o indice do filtro
            sfdSave.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            sfdSave.FileName = filename;
            //Define a extensão padrão como .h
            sfdSave.DefaultExt = defaultExt;
            //define o diretório padrão
            sfdSave.InitialDirectory = initialDirectory;
            //restaura o diretorio atual antes de fechar a janela
            sfdSave.RestoreDirectory = true;
            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult result = sfdSave.ShowDialog();
            //Se o ousuário pressionar o botão Salvar
            if (result == DialogResult.OK)
            {
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(sfdSave.FileName, FileMode.Create);
                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.Write(content);
                //fecha o escrito e o stream
                writer.Close();

                return sfdSave.FileName;
            }
            return "";
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
    }
}
