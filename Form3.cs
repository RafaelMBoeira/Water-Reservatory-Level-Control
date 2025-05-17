using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ConfigurationForm : Form
    {
        private LevelControlForm frmMain;
        public ConfigurationForm(LevelControlForm frmMain)
        {
            InitializeComponent();

            this.frmMain = frmMain;
            this.frmMain.Enabled = false;

            tbDefaultPath.Text = Properties.Settings.Default.DefaultSavePath;
            tbSkeleton.Text = Properties.Settings.Default.DefaultSkeletonPath;
        }

        private void selectSkeletonsFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdOpen = new FolderBrowserDialog();
            if (fbdOpen.ShowDialog() == DialogResult.OK)
                tbSkeleton.Text = fbdOpen.SelectedPath;
        }

        private void selectDefaultPath(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdOpen = new FolderBrowserDialog();
            if (fbdOpen.ShowDialog() == DialogResult.OK)
                tbDefaultPath.Text = fbdOpen.SelectedPath;
        }

        private void saveConfiguration(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultSavePath = tbDefaultPath.Text;
            Properties.Settings.Default.DefaultSkeletonPath = tbSkeleton.Text;
            Properties.Settings.Default.Save();
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void whenClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Enabled = true;
        }
    }
}
