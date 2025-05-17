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
    public partial class PortSelectionForm : Form
    {
        private LevelControlForm frmMain;
        private string inoFilePath;
        public PortSelectionForm(LevelControlForm frmMain, string inoFilePath)
        {
            InitializeComponent();
            
            this.frmMain = frmMain;
            this.frmMain.Enabled = false;

            this.inoFilePath = inoFilePath;
        }
        private void updateCOMList()
        {
            cbPort.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
                cbPort.Items.Add(s);

            if (cbPort.Items.Count > 0)
                cbPort.SelectedIndex = 0;
            else
            {
                lbMessage.Text = "Nenhuma Porta Serial Encontrada.";
                lbMessage.Visible = true;
            }
        }

        private void updatePorts(object sender, EventArgs e)
        {
            updateCOMList();
            lbMessage.Visible = false;
        }

        private void loadToBoard(object sender, EventArgs e)
        {
            string loadFile = "";
            
            if (cbPort.Text != "")
            {
                loadFile = frmMain.save(
                    "Salvar Comando de Carregamento do Arduino",
                    "Arquivo de Carregamento|.BAT",
                    "Carregar",
                    ".BAT",
                    inoFilePath,
                    "\"C:\\Program Files (x86)\\Arduino\\arduino_debug.exe\"" + " --port " + "\"" + cbPort.Text + "\"" + " --upload " + "\"" + inoFilePath + "\"" + "\r\n" + " pause"
                );
            } 
            else
            {
                lbMessage.Text = "Nenhuma porta foi selecionada.";
                lbMessage.Visible = true;
                return;
            }


            if (!string.IsNullOrEmpty(loadFile))
            {
                ardPort.PortName = cbPort.Text;
                if (ardPort.IsOpen == true)
                    ardPort.Close();
                System.Diagnostics.Process.Start(loadFile);
                if (ardPort.IsOpen == false)
                {
                    ardPort.Open();
                    ardPort.Write("I;");
                }
                frmMain.spNivel.PortName = cbPort.Text;
            }
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
            frmMain.Enabled = true;
        }
    }
}
