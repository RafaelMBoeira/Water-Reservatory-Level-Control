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
                //define o titulo
                sfdSave.Title = "Salvar Arquivo Texto";
                //Define as extensões permitidas
                sfdSave.Filter = "Arquivo de Texto|.txt";
                //define o indice do filtro
                sfdSave.FilterIndex = 0;
                //Atribui um valor vazio ao nome do arquivo
                sfdSave.FileName = "";
                //Define a extensão padrão como .txt
                sfdSave.DefaultExt = ".txt";
                //define o diretório padrão
                sfdSave.InitialDirectory = @"c:\";
                //restaura o diretorio atual antes de fechar a janela
                sfdSave.RestoreDirectory = true;
                //Abre a caixa de dialogo e determina qual botão foi pressionado
                DialogResult resultado = sfdSave.ShowDialog();
                //Se o ousuário pressionar o botão Salvar
                if (resultado == DialogResult.OK)
                {
                    //Cria um stream usando o nome do arquivo
                    FileStream fs = new FileStream(sfdSave.FileName, FileMode.Create);
                    //Cria um escrito que irá escrever no stream
                    StreamWriter writer = new StreamWriter(fs);
                    //escreve o conteúdo da caixa de texto no stream
                    writer.Write(tbVar.Text);
                    writer.Write("\r\n" + "//Lei" + "\r\n");
                    writer.Write(tbCalculations.Text);
                    writer.Write("\r\n" + "//fim");
                    //fecha o escrito e o stream
                    writer.Close();
                }        
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
            if (!string.IsNullOrEmpty(currentProjectPath))
                currentProjectPath = saveChartFile();

            if (!string.IsNullOrEmpty(currentProjectPath))
                currentProjectPath = saveCommandFile();

            //if (!string.IsNullOrEmpty(currentProjectPath))
            //    System.Diagnostics.Process.Start(compilando);
        }

        private void loadProgram(object sender, EventArgs e)
        {
            frmPort frmPort = new frmPort(salvando);
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
            //define o titulo
            sfdSave.Title = "Salvar Arquivo do Compilador";
            //Define as extensões permitidas
            sfdSave.Filter = "Compilador|.ino";
            //define o indice do filtro
            sfdSave.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            sfdSave.FileName = "Programa";
            //Define a extensão padrão como .h
            sfdSave.DefaultExt = ".ino";
            //define o diretório padrão
            sfdSave.InitialDirectory = currentProjectPath;
            //restaura o diretorio atual antes de fechar a janela
            sfdSave.RestoreDirectory = true;
            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult result = sfdSave.ShowDialog();

            if (result == DialogResult.OK)
            {
                //pega o diretório onde o arquivo .ino foi salvo
                //salvando = sfdSalvar.FileName;
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(sfdSave.FileName, FileMode.Create);
                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.Write("#define TRIGGER_PIN 8" + "\r\n");
                writer.Write("#define ECHO_PIN 7" + "\r\n");
                writer.Write("#define SAIDA 9" + "\r\n");
                writer.Write("#define USONIC_DIV 58.0" + "\r\n");
                writer.Write("#define MEASURE_SAMPLE_DELAY 5" + "\r\n");
                writer.Write("#define MEASURE_SAMPLES 25" + "\r\n");
                writer.Write("#define MEASURE_DELAY 100" + "\r\n");
                writer.Write("bool stringComplete = false;" + "\r\n");
                writer.Write("int nivel,startFlag;" + "\r\n");
                writer.Write("String string;" + "\r\n");
                writer.Write("float sp;" + "\r\n");
                //declara as variaveis
                for (int ind = 0; ind < chbVariables.Items.Count; ind++)
                {
                    writer.Write("float " + chbVariables.Items[ind] + " = 0;" + "\r\n");
                }

                writer.Write("void setup()" + "\r\n" + "{" + "\r\n");
                writer.Write("Serial.begin(9600);" + "\r\n");
                writer.Write("pinMode(SAIDA,OUTPUT);" + "\r\n");
                writer.Write("pinMode(TRIGGER_PIN, OUTPUT);" + "\r\n");
                writer.Write("pinMode(ECHO_PIN, INPUT);" + "\r\n");
                writer.Write("digitalWrite(TRIGGER_PIN, LOW);" + "\r\n");
                writer.Write("delayMicroseconds(500);" + "\r\n");
                writer.Write("TCCR1B = TCCR1B & 0b11111000 | 0X01;" + "\r\n");
                writer.Write("startFlag = 0;" + "\r\n" + "}" + "\r\n");

                writer.Write("void loop()" + "\r\n" + "{" + "\r\n");
                writer.Write("if (stringComplete)" + "\r\n" + "{" + "\r\n");
                writer.Write("if (string[0] == 'I') startFlag = 1;" + "\r\n");
                writer.Write("if (string[0] == 'F') startFlag = 0;" + "\r\n");
                writer.Write("if (string[0] == 'S') sp = ((string[1]-48) * 100) + ((string[2]-48) * 10) + (string[3]-48);" + "\r\n");
                writer.Write("string = \"\";" + "\r\n");
                writer.Write("stringComplete = false;" + "\r\n" + "}" + "\r\n");

                writer.Write("if (startFlag == 1)" + "\r\n" + "{" + "\r\n");
                writer.Write("delay(MEASURE_DELAY);" + "\r\n");
                writer.Write("h = measure();" + "\r\n");
                //realiza os calculos
                for (int ind = 0; ind < tbCalculations.Lines.Length; ind++)
                {
                    writer.Write(tbCalculations.Lines[ind] + ";" + "\r\n");
                }
                //envia valores das variaveis para monitoraçao

                for (int ind = 0; ind < chbVariables.CheckedItems.Count; ind++)
                {
                    writer.Write("Serial.print(" + chbVariables.CheckedItems[ind].ToString() + ");" + "\r\n");
                    writer.Write("Serial.print(\";\");" + "\r\n");
                }

                writer.Write("analogWrite(SAIDA,u);" + "\r\n" + "}" + "\r\n" + "}" + "\r\n");

                writer.Write("void serialEvent()" + "\r\n" + "{" + "\r\n");
                writer.Write("while (Serial.available())" + "\r\n" + "{" + "\r\n");
                writer.Write("char inChar = (char)Serial.read();" + "\r\n");
                writer.Write("string += inChar;" + "\r\n");
                writer.Write("if (inChar == 'I')" + "\r\n" + "{" + "\r\n");
                writer.Write("stringComplete = true;" + "\r\n" + "}" + "\r\n" + "}" + "\r\n" + "}" + "\r\n");

                writer.Write("float measure()" + "\r\n" + "{" + "\r\n");
                writer.Write("float measureSum = 0;" + "\r\n");
                writer.Write("for (int i = 0; i < MEASURE_SAMPLES; i++)" + "\r\n" + "{" + "\r\n");
                writer.Write("delay(MEASURE_SAMPLE_DELAY);" + "\r\n");
                writer.Write("measureSum += singleMeasurement();" + "\r\n" + "}" + "\r\n");
                writer.Write("return measureSum / MEASURE_SAMPLES;" + "\r\n" + "}" + "\r\n");

                writer.Write("long singleMeasurement()" + "\r\n" + "{" + "\r\n");
                writer.Write("long duration = 0;" + "\r\n");
                writer.Write("digitalWrite(TRIGGER_PIN, HIGH);" + "\r\n");
                writer.Write("delayMicroseconds(11);" + "\r\n");
                writer.Write("digitalWrite(TRIGGER_PIN, LOW);" + "\r\n");
                writer.Write("duration = pulseIn(ECHO_PIN, HIGH);" + "\r\n");
                writer.Write("return (long) (((float) duration / USONIC_DIV) * 10.0);" + "\r\n" + "}");
                writer.Close();
                Console.WriteLine(sfdSave.FileName);
                return sfdSave.FileName;
            }
            return "";
        }

        private string saveChartFile()
        {
            //define o titulo
            sfdSave.Title = "Salvar Arquivo do Gráfico";
            //Define as extensões permitidas
            sfdSave.Filter = "Gráfico|.csv";
            //define o indice do filtro
            sfdSave.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            sfdSave.FileName = "Gráfico";
            //Define a extensão padrão como .h
            sfdSave.DefaultExt = ".csv";
            //define o diretório padrão
            sfdSave.InitialDirectory = currentProjectPath;
            //restaura o diretorio atual antes de fechar a janela
            sfdSave.RestoreDirectory = true;
            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult result = sfdSave.ShowDialog();
            //Se o ousuário pressionar o botão Salvar
            if (result == DialogResult.OK)
            {
                //pega o diretório onde o arquivo .ino foi salvo
                //salvando = sfdSalvar.FileName;
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(sfdSave.FileName, FileMode.Create);
                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.Write(tbExcel1.Text);
                writer.Close();

                Console.WriteLine(sfdSave.FileName);
                return sfdSave.FileName;
            }
            return "";
        }

        private string saveCommandFile()
        {
            //define o titulo
            sfdSave.Title = "Salvar Comando de Compilação";
            //Define as extensões permitidas
            sfdSave.Filter = "Prompt|.BAT";
            //define o indice do filtro
            sfdSave.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            sfdSave.FileName = "Compilar";
            //Define a extensão padrão como .h
            sfdSave.DefaultExt = ".BAT";
            //define o diretório padrão
            sfdSave.InitialDirectory = currentProjectPath;
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
                writer.Write("\"C:\\Program Files (x86)\\Arduino\\arduino_debug.exe\"" + " --pref " + "\"build.path=C:\\Users\\Public\\Documents\\Arduino\\plantadenivel\\builder\"" + " --verify " + "\"" + salvando + "\"" + "\r\n" + " pause");
                //fecha o escrito e o stream
                writer.Close();

                Console.WriteLine(sfdSave.FileName);
                return sfdSave.FileName;
            }
            return "";
        }
    }
}
