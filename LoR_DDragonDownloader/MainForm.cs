using Ionic.Zip;
using LoR_DataDragonDownloader;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace LoR_DDragonDownloader
{
    public partial class MainForm : Form
    {
        static public string baseUrl = "https://dd.b.pvp.net/";
        static public List<string> versions = new List<string>();
        static public List<string> langs = new List<string>();
        static public List<string> sets = new List<string>();

        static public string currentTask = "En attente du début du téléchargement...";
        static public string currentVersion = "En attente du début du téléchargement...";
        static public string globalTask = "En attente du début du téléchargement...";

        static public int currentTaskProgress = 0;
        static public int currentVersionProgress = 0;
        static public int globalTaskProgress = 0;

        public MainForm()
        {
            InitializeComponent();

            GetVersionsList();
            GetLangsList();
            GetSetsList();
        }

        /**
         * Récupération de la liste des versions.
         */
        static void GetVersionsList()
        {
            string jsonString = new WebClient().DownloadString("https://private.infinity54.fr/runeterra_versions.json");
            JArray json = JArray.Parse(jsonString);

            foreach (string version in json)
            {
                versions.Add(version);
            }
        }

        /**
         * Récupération de la liste des langues.
         */
        static void GetLangsList()
        {
            string jsonString = new WebClient().DownloadString("https://private.infinity54.fr/runeterra_langs.json");
            JArray json = JArray.Parse(jsonString);

            foreach (string version in json)
            {
                langs.Add(version);
            }
        }

        /**
         * Récupération de la liste des contenus possibles.
         */
        static void GetSetsList()
        {
            string jsonString = new WebClient().DownloadString("https://private.infinity54.fr/runeterra_sets.json");
            JArray json = JArray.Parse(jsonString);

            foreach (string version in json)
            {
                sets.Add(version);
            }
        }

        private void MainForm_Button_Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr(e) de vouloir quitter le programme ?" + Environment.NewLine + "Tout téléchargement en cours sera annulé.", "Legends of Runeterra - Data Dragon Downloader", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Button_StartDownload_Click(object sender, EventArgs e)
        {
            if (!MainForm_DownloadModeLight.Checked == true && !MainForm_DownloadModeFull.Checked == true)
            {
                MessageBox.Show("Vous devez sélectionner un mode de téléchargement pour continuer.", "Legends of Runeterra - Data Dragon Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MainForm_Settings_DownloadFolder_TextBox.Text.Length == 0)
            {
                MessageBox.Show("Vous devez spécifier un chemin vers un dossier de votre ordinateur où sera téléchargé le Data Dragon.", "Legends of Runeterra - Data Dragon Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(MainForm_Settings_DownloadFolder_TextBox.Text))
            {
                Directory.CreateDirectory(MainForm_Settings_DownloadFolder_TextBox.Text);
            }

            if (Directory.GetDirectories(MainForm_Settings_DownloadFolder_TextBox.Text).Length > 0 || Directory.GetFiles(MainForm_Settings_DownloadFolder_TextBox.Text).Length > 0)
            {
                if (MessageBox.Show("Le dossier de téléchargement spécifié n'est pas vide. Si vous continuez, le programme videra le contenu du dossier choisi, et ce dernier sera définitivement perdu." + Environment.NewLine + "Voulez-vous continuer ?", "Legends of Runeterra - Data Dragon Downloader", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    StartingDownload();
                }
            }
            else
            {
                StartingDownload();
            }
        }

        private void StartingDownload()
        {
            // On modifie l'apparence des barres de progression
            MainForm_CurrentTaskProgressBar.Style = ProgressBarStyle.Blocks;
            MainForm_CurrentVersionProgressBar.Style = ProgressBarStyle.Blocks;
            MainForm_GlobalProgressBar.Style = ProgressBarStyle.Blocks;

            // On empêche la modification du dossier de destination
            MainForm_Settings_DownloadFolder_TextBox.ReadOnly = true;

            // On empêche le changement de mode de téléchargement
            MainForm_DownloadModeLight.Enabled = false;
            MainForm_DownloadModeFull.Enabled = false;

            // On désactive le bouton de démarrage de la procédure de téléchargement
            MainForm_Button_StartDownload.Enabled = false;

            // On désactive le bouton pour choisir un dossier
            MainForm_Settings_DownloadFolder_Browse.Enabled = false;

            Refresh();

            DataDragonWorker.RunWorkerAsync();
        }

        private void DataDragonWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // On définit le message global
            if (MainForm_DownloadModeLight.Checked)
            {
                globalTask = "Installation de la dernière version du Data Dragon...";
            }
            else
            {
                globalTask = "Installation de l'intégralité du Data Dragon...";
            }

            // On prépare les versions à traiter
            List<string> versionsToDownload = new List<string>();

            if (MainForm_DownloadModeLight.Checked)
            {
                versionsToDownload.Add(versions[versions.Count - 1]);
            }
            else
            {
                versionsToDownload = versions;
            }

            int globalElementsFinished = 0;

            // Pour chaque version...
            foreach (string version in versionsToDownload)
            {
                // On réinitialise la progression de la version
                currentVersionProgress = 0;
                int totalVersionsElementsFinished = 0;

                // On définit le message de l'étape
                currentVersion = "Récupération et extraction de la version " + version + "...";

                // ..., pour chaque contenu...
                foreach (string set in sets)
                {
                    // ...et pour chaque langage...
                    foreach (string lang in langs)
                    {
                        string fileName = set + "-" + lang + ".zip";
                        string fileURL = baseUrl + version.Replace(".", "_") + "/" + fileName;

                        // ..., on commence par vérifier si le fichier correspondant existe ou non.
                        if (IsFileAvailable(fileURL))
                        {
                            string downloadPath = MainForm_Settings_DownloadFolder_TextBox.Text + "\\" + version;

                            // On vérifie si le dossier de la version existe ou non.
                            if (!Directory.Exists(downloadPath))
                            {
                                // Si ce n'est pas le cas, on le crée.
                                Directory.CreateDirectory(downloadPath);
                            }

                            currentTask = "Téléchargement du fichier \"" + fileName + "\"...";

                            // Si le fichier existe, on le télécharge
                            bool downloadFinished = false;
                            WebClient client = new WebClient();
                            client.DownloadProgressChanged += (sender, e) => DataDragonFileDownloading(sender, e, fileName);
                            client.DownloadFileCompleted += (s, e) =>
                            {
                                currentTask = "Finalisation du téléchargement du fichier \"" + fileName + "\"...";
                                currentTaskProgress = 0;
                                downloadFinished = true;
                            };
                            client.DownloadFileAsync(new Uri(fileURL), downloadPath + "\\" + fileName);

                            while (!downloadFinished) { }

                            // Une fois le fichier téléchargé, on l'extrait
                            string fileToExtract = Path.Combine(MainForm_Settings_DownloadFolder_TextBox.Text, version, fileName);
                            string extractDirectory = Path.Combine(MainForm_Settings_DownloadFolder_TextBox.Text, version, set);
                            int totalFilesToExtract = 0;
                            int filesExtracted = 0;

                            currentTask = "Extraction du fichier \"" + fileName + "\"...";

                            using (ZipFile zip = ZipFile.Read(fileToExtract))
                            {
                                totalFilesToExtract = zip.Count;
                                zip.ExtractProgress += (sender, e) =>
                                {
                                    if (e.EventType != ZipProgressEventType.Extracting_BeforeExtractEntry)
                                        return;
                                    filesExtracted++;
                                    currentTaskProgress = 100 * filesExtracted / totalFilesToExtract;
                                };
                                zip.ExtractAll(extractDirectory, ExtractExistingFileAction.OverwriteSilently);
                            }

                            // Une fois le fichier extrait, on réorganise le dossier
                            string versionRootFolder = Path.Combine(MainForm_Settings_DownloadFolder_TextBox.Text, version, set);

                            // Si le set actuel est différent du core, il faut traiter les images des cartes en premier
                            if (set != "core")
                            {
                                currentTask = "Déplacement des images des cartes...";
                                List<String> cardsToMove = Directory.GetFiles(Path.Combine(extractDirectory, lang, "img", "cards"), "*.*").ToList();
                                int totalCardsToMove = cardsToMove.Count;
                                int cardsMoved = 0;

                                foreach (string card in cardsToMove)
                                {
                                    string newCard = Path.Combine(Path.GetDirectoryName(card), lang, Path.GetFileName(card));

                                    if (!Directory.Exists(Path.GetDirectoryName(newCard)))
                                    {
                                        Directory.CreateDirectory(Path.GetDirectoryName(newCard));
                                    }

                                    File.Move(card, newCard, true);
                                    cardsMoved++;
                                    currentTaskProgress = (int)Math.Round((Convert.ToDecimal(cardsMoved) / totalCardsToMove), 0);
                                }
                            }

                            currentTask = "Déplacement des fichiers...";
                            List<string> filesToMove = Directory.GetFiles(Path.Combine(versionRootFolder, lang, "data"), "*.*", SearchOption.AllDirectories).ToList();
                            int totalFilesToMove = filesToMove.Count;
                            int filesMoved = 0;

                            foreach (string file in filesToMove)
                            {
                                string newFile = file.Replace(Path.Combine(versionRootFolder, lang, "data"), Path.Combine(versionRootFolder, "..", "data"));

                                if (!Directory.Exists(Path.GetDirectoryName(newFile)))
                                {
                                    Directory.CreateDirectory(Path.GetDirectoryName(newFile));
                                }

                                File.Move(file, newFile, true);
                                filesMoved++;
                                currentTaskProgress = (int)Math.Round((Convert.ToDecimal(filesMoved) / totalFilesToMove) / 2, 0);
                            }

                            filesToMove = Directory.GetFiles(Path.Combine(versionRootFolder, lang, "img"), "*.*", SearchOption.AllDirectories).ToList();
                            totalFilesToMove = filesToMove.Count;
                            filesMoved = 0;

                            foreach (string file in filesToMove)
                            {
                                string newFile = file.Replace(Path.Combine(versionRootFolder, lang, "img"), Path.Combine(versionRootFolder, "..", "img"));

                                if (!Directory.Exists(Path.GetDirectoryName(newFile)))
                                {
                                    Directory.CreateDirectory(Path.GetDirectoryName(newFile));
                                }

                                File.Move(file, newFile, true);
                                filesMoved++;
                                currentTaskProgress = (int)Math.Round((Convert.ToDecimal(filesMoved) / totalFilesToMove) / 2, 0);
                            }

                            Directory.Delete(Path.Combine(versionRootFolder, lang), true);

                            // Une fois le dossier réorganisé, on supprime les fichiers inutiles
                            currentTask = "Nettoyage du dossier...";
                            currentTaskProgress = 0;
                            File.Delete(Path.Combine(extractDirectory, "COPYRIGHT"));
                            currentTaskProgress = 20;
                            File.Delete(Path.Combine(extractDirectory, "metadata.json"));
                            currentTaskProgress = 40;
                            File.Delete(Path.Combine(extractDirectory, "README.md"));
                            currentTaskProgress = 60;
                            File.Delete(Path.Combine(downloadPath, fileName));
                            currentTaskProgress = 80;
                            Directory.Delete(extractDirectory, true);
                            currentTaskProgress = 100;

                            totalVersionsElementsFinished++;
                            currentVersionProgress += (int)Math.Round(Convert.ToDecimal(totalVersionsElementsFinished) / (sets.Count * langs.Count), 0);
                        }
                        else
                        {
                            totalVersionsElementsFinished++;
                            currentVersionProgress += (int)Math.Round(Convert.ToDecimal(totalVersionsElementsFinished) / (sets.Count * langs.Count), 0);
                        }
                    }
                }

                // On génère le Metadata
                currentTask = "Terminé";
                currentVersion = "Génération du fichier \"metadata.json\"...";
                string metadataSavePath = Path.Combine(MainForm_Settings_DownloadFolder_TextBox.Text, version);
                string cardsFolder = Path.Combine(metadataSavePath, "img", "cards");
                Metadata metadata = new Metadata();

                foreach (string folder in Directory.GetDirectories(cardsFolder))
                {
                    metadata.locales.Add(folder.Replace(cardsFolder, "").Replace("\\", ""));
                }

                File.WriteAllText(Path.Combine(metadataSavePath, "metadata.json"), JsonConvert.SerializeObject(metadata, Formatting.Indented));

                // Une fois le traitement terminé pour cette version, on passe à la version suivante
                globalElementsFinished++;
                globalTaskProgress = (int)Math.Round(Convert.ToDecimal(globalElementsFinished) / versions.Count, 0);
            }

            currentVersion = "Terminé";
            globalTask = "Terminé";

            // On réactive la modification du dossier de destination
            MainForm_Settings_DownloadFolder_TextBox.ReadOnly = false;

            // On réactive le changement de mode de téléchargement
            MainForm_DownloadModeLight.Enabled = true;
            MainForm_DownloadModeFull.Enabled = true;

            // On réactive le bouton de démarrage de la procédure de téléchargement
            MainForm_Button_StartDownload.Enabled = true;

            // On réactive le bouton pour choisir un dossier
            MainForm_Settings_DownloadFolder_Browse.Enabled = true;
            MainForm_Settings_DownloadFolder_TextBox.ReadOnly = false;

            // On réactive le changement de mode de téléchargement
            MainForm_DownloadModeLight.Enabled = true;
            MainForm_DownloadModeFull.Enabled = true;

            // On réactive le bouton de démarrage de la procédure de téléchargement
            MainForm_Button_StartDownload.Enabled = true;

            // On réactive le bouton pour choisir un dossier
            MainForm_Settings_DownloadFolder_Browse.Enabled = true;

            MessageBox.Show("Le Data Dragon a été installé avec succès dans le dossier \"" + MainForm_Settings_DownloadFolder_TextBox.Text + "\".");
        }

        private bool IsFileAvailable(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return true;
                    }

                    return false;
                }
            }
            catch (System.Net.WebException)
            {
                return false;
            }
        }

        private void DataDragonFileDownloading(object sender, DownloadProgressChangedEventArgs e, string fileName)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            currentTask = "Téléchargement du fichier \"" + fileName + "\"... | " + Math.Round((e.BytesReceived / 1024f) / 1024f, 2) + " sur " + Math.Round((e.TotalBytesToReceive / 1024f) / 1024f, 2) + " Mo téléchargé(s).";
            currentTaskProgress = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void AutoRefreshForm_Tick(object sender, EventArgs e)
        {
            MainForm_CurrentTaskProgressLabel.Text = currentTask;
            MainForm_CurrentTaskProgressBar.Value = currentTaskProgress;

            MainForm_CurrentVersionProgressLabel.Text = currentVersion;
            MainForm_CurrentVersionProgressBar.Value = currentVersionProgress;

            MainForm_GlobalProgressLabel.Text = globalTask;
            MainForm_GlobalProgressBar.Value = globalTaskProgress;

            MainForm_CurrentTaskProgressLabel.Refresh();
            MainForm_CurrentTaskProgressBar.Refresh();
            MainForm_CurrentVersionProgressLabel.Refresh();
            MainForm_CurrentVersionProgressBar.Refresh();
            MainForm_GlobalProgressLabel.Refresh();
            MainForm_GlobalProgressBar.Refresh();
        }

        private void MainForm_Settings_DownloadFolder_Browse_Click(object sender, EventArgs e)
        {
            DownloadFolderSelect.ShowDialog();
            MainForm_Settings_DownloadFolder_TextBox.Text = DownloadFolderSelect.SelectedPath;
        }
    }
}
