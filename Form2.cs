using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class frmPort : Form
    {
        int load_s = 1;
        public frmPort(string carregar)
        {
            InitializeComponent();
            var form1 = new Form1();
            textBox1.Text = carregar;
        }
        private void AtualizaListaCOMs()
        {
            int i;
            bool quantDiferente;
            i = 0;
            quantDiferente = false;
            if (cbPorta.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbPorta.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            if (quantDiferente == false)
            {
                return;
            }

            cbPorta.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                cbPorta.Items.Add(s);
            }
            cbPorta.SelectedIndex = 0;
        }


        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaListaCOMs();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            string carregando;
            
            if (cbPorta.SelectedItem != "")
            {
                //define o titulo
                sfdCarregar.Title = "Salvar Comando de Carregamento do Arduino";
                //Define as extensões permitidas
                sfdCarregar.Filter = "Arquivo de Carregamento|.BAT";
                //define o indice do filtro
                sfdCarregar.FilterIndex = 0;
                //Atribui um valor vazio ao nome do arquivo
                sfdCarregar.FileName = "Carregar";
                //Define a extensão padrão como .h
                sfdCarregar.DefaultExt = ".BAT";
                //define o diretório padrão
                sfdCarregar.InitialDirectory = textBox1.Text;
                //restaura o diretorio atual antes de fechar a janela
                sfdCarregar.RestoreDirectory = true;
                //Abre a caixa de dialogo e determina qual botão foi pressionado
                DialogResult bat = sfdCarregar.ShowDialog();
                //Se o ousuário pressionar o botão Salvar
                if (bat == DialogResult.OK)
                {
                    //Cria um stream usando o nome do arquivo
                    FileStream fs = new FileStream(sfdCarregar.FileName, FileMode.Create);
                    //Cria um escrito que irá escrever no stream
                    StreamWriter writer = new StreamWriter(fs);
                    //escreve o conteúdo da caixa de texto no stream
                    writer.Write("\"C:\\Program Files (x86)\\Arduino\\arduino_debug.exe\"" + " --port " + "\"" + cbPorta.Text + "\"" + " --upload " + "\"" + textBox1.Text + "\"" + "\r\n" + " pause");
                    //fecha o escrito e o stream
                    writer.Close();
                }
                else
                {
                    if (bat == DialogResult.Cancel)
                    {
                        //exibe mensagem informando que a operação foi cancelada
                        load_s = 0;
                        MessageBox.Show("Operação cancelada");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma Porta");
            }

            if (load_s == 1)
            {
                ardPort.PortName = cbPorta.Text;
                carregando = sfdCarregar.FileName;
                if (ardPort.IsOpen == true)
                    ardPort.Close();
                System.Diagnostics.Process.Start(carregando);
                var form1 = new Form1();           
                if (ardPort.IsOpen==false)
                {
                    ardPort.Open();
                    ardPort.Write("I;");
                }
                form1.btVar.Enabled = false;
                form1.btPeriodo.Enabled = true;
                form1.btMod.Enabled = true;
                form1.spNivel.PortName = cbPorta.Text;
            }
            load_s = 1;
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPort_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ardPort.IsOpen == true) 
                ardPort.Close();
        }
    }
}
