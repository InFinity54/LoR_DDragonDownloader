using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LoR_DDragonDownloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainForm_Settings_DownloadFolder_TextBox.Text = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString(); ;
        }

        private void MainForm_Button_Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr(e) de vouloir quitter le programme ?" + Environment.NewLine + "Tout téléchargement en cours sera annulé.", "Legends of Runeterra - Data Dragon Downloader", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
