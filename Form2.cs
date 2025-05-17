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
        private void updateCOMList()
        {
            cbPort.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
                cbPort.Items.Add(s);

            cbPort.SelectedIndex = 0;
        }

        private void updatePorts(object sender, EventArgs e)
        {
            updateCOMList();
            lbMessage.Visible = false;
        }

        private void loadToBoard(object sender, EventArgs e)
        {
            string carregando;
            
            if (cbPort.SelectedItem != "")
            {
                //define o titulo
                sfdLoad.Title = "Salvar Comando de Carregamento do Arduino";
                //Define as extensões permitidas
                sfdLoad.Filter = "Arquivo de Carregamento|.BAT";
                //define o indice do filtro
                sfdLoad.FilterIndex = 0;
                //Atribui um valor vazio ao nome do arquivo
                sfdLoad.FileName = "Carregar";
                //Define a extensão padrão como .h
                sfdLoad.DefaultExt = ".BAT";
                //define o diretório padrão
                sfdLoad.InitialDirectory = textBox1.Text;
                //restaura o diretorio atual antes de fechar a janela
                sfdLoad.RestoreDirectory = true;
                //Abre a caixa de dialogo e determina qual botão foi pressionado
                DialogResult bat = sfdLoad.ShowDialog();
                //Se o ousuário pressionar o botão Salvar
                if (bat == DialogResult.OK)
                {
                    //Cria um stream usando o nome do arquivo
                    FileStream fs = new FileStream(sfdLoad.FileName, FileMode.Create);
                    //Cria um escrito que irá escrever no stream
                    StreamWriter writer = new StreamWriter(fs);
                    //escreve o conteúdo da caixa de texto no stream
                    writer.Write("\"C:\\Program Files (x86)\\Arduino\\arduino_debug.exe\"" + " --port " + "\"" + cbPort.Text + "\"" + " --upload " + "\"" + textBox1.Text + "\"" + "\r\n" + " pause");
                    //fecha o escrito e o stream
                    writer.Close();
                }
            } 
            else
            {
                lbMessage.Visible = true;
            }


            if (load_s == 1)
            {
                ardPort.PortName = cbPort.Text;
                carregando = sfdLoad.FileName;
                if (ardPort.IsOpen == true)
                    ardPort.Close();
                System.Diagnostics.Process.Start(carregando);
                var form1 = new Form1();
                if (ardPort.IsOpen == false)
                {
                    ardPort.Open();
                    ardPort.Write("I;");
                }
                form1.btSampleSizeChanger.Enabled = true;
                form1.spNivel.PortName = cbPort.Text;
            }
            load_s = 1;
            Close();
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void whenClosed(object sender, FormClosedEventArgs e)
        {
            lbMessage.Visible = false;
            if (ardPort.IsOpen == true) 
                ardPort.Close();
        }
    }
}
