using System;

namespace LoR_DDragonDownloader
{
    public class TranslationSystem
    {
        // Window UI
        public static string LanguageAreaTitle()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Langue de l'application",
                _ => "App language"
            };
        }

        public static string DownloaderWelcomeMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Choisissez un mode de téléchargement, puis cliquez sur \"Démarrer le téléchargement\" pour commencer la création du Data Dragon local pour Legends of Runeterra. Une connexion Internet en fibre optique est très fortement recommandée, en raison du grand nombre de fichiers à télécharger et de leur taille. Un troisième mode de téléchargement est en préparation afin de télécharger une version spécifique.",
                _ => "Choose a download mode, then click \"Start download\" to begin creating the local Data Dragon for Legends of Runeterra. A fiber optic Internet connection is highly recommended, due to the large number of files to download and their size. A third download mode is in preparation in order to download a specific version."
            };
        }

        public static string DownloadModeAreaTitle()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Mode de téléchargement",
                _ => "Download mode"
            };
        }

        public static string DownloadModeLastVersionOnly()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Téléchargement de la dernière version uniquement",
                _ => "Download latest version only"
            };
        }

        public static string DownloadModeAllVersions()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Téléchargement de toutes les versions disponibles",
                _ => "Download all available versions"
            };
        }

        public static string DownloadSortAreaTitle()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Mode de rangement",
                _ => "Download sort"
            };
        }

        public static string DownloadSortInOneFolder()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Tri dans un seul dossier",
                _ => "Sort in one folder"
            };
        }

        public static string DownloadSortBySet()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Tri des différents sets dans des dossiers séparés",
                _ => "Sort each set in his own folder"
            };
        }

        public static string ProgressAreaTitle()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Progression du téléchargement du Data Dragon",
                _ => "Data Dragon downloading progress"
            };
        }

        public static string DownloadSettingsAreaTitle()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Paramètres du téléchargement",
                _ => "Download settings"
            };
        }

        public static string DownloadFolderSelectionHint()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Chemin vers le dossier de téléchargement :",
                _ => "Path to download folder:"
            };
        }

        public static string DownloadFolderSelectionButton()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Parcourir",
                _ => "Browse"
            };
        }

        public static string DownloadStartButton()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Démarrer le téléchargement",
                _ => "Start download"
            };
        }

        public static string AppExitButton()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Quitter",
                _ => "Exit"
            };
        }

        // Code strings

        public static string ExitModalConfirmMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Êtes-vous sûr(e) de vouloir quitter le Data Dragon Downloader pour Legends of Runeterra ?" + Environment.NewLine + "Tout téléchargement en cours sera annulé, et tous les fichiers téléchargés resteront dans leur état actuel. Certains fichiers peuvent être corrompus.",
                _ => "Are you sure you want to quit the Legends of Runeterra's Data Dragon Downloader ?" + Environment.NewLine + "Any downloads in progress will be cancelled, and all downloaded files will remain in their current state. Some files may be corrupted."
            };
        }

        public static string DownloadStartUnknownDownloadModeError()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Vous devez sélectionner un mode de téléchargement pour continuer.",
                _ => "You must select a download mode to proceed."
            };
        }

        public static string DownloadStartUnknownSortModeError()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Vous devez sélectionner un mode de tri pour continuer.",
                _ => "You must select a sort mode to proceed."
            };
        }

        public static string DownloadStartUnknownDownloadFolderError()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Vous devez spécifier le chemin vers un dossier de votre ordinateur où les fichiers du Data Dragon seront téléchargés.",
                _ => "You must specify the path to a folder on your computer where the Data Dragon files will be downloaded."
            };
        }

        public static string DownloadFolderIsNotEmptyMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Le dossier de téléchargement spécifié n'est pas vide." + Environment.NewLine + "Si vous continuez, le programme videra le contenu du dossier choisi, et ce dernier sera définitivement perdu." + Environment.NewLine + "Voulez-vous continuer ?",
                _ => "The specified download folder is not empty." + Environment.NewLine + "If you continue, the program will empty the contents of the chosen folder, and the latter will be permanently lost." + Environment.NewLine + "Do you want to continue?"
            };
        }

        public static string WaitingDDragonDownloadStart()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "En attente du début du téléchargement...",
                _ => "Waiting for download to start..."
            };
        }

        public static string DownloadOfLatestVersionIsRunning()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Installation de la dernière version du Data Dragon...",
                _ => "Installing Data Dragon's latest version..."
            };
        }

        public static string DownloadOfAllVersionsIsRunning()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Installation de l'intégralité du Data Dragon...",
                _ => "Installing Data Dragon..."
            };
        }

        public static string DownloadingVersionMessage(string version)
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Téléchargement et installation de la version " + version + "...",
                _ => "Downloading and installation version " + version + "..."
            };
        }

        public static string DownloadingFileMessage(string fileName)
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Téléchargement du fichier \"" + fileName + "\"...",
                _ => "Downloading file \"" + fileName + "\"..."
            };
        }

        public static string DownloadingFileMessageWithProgress(string fileName, double current, double total)
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Téléchargement du fichier \"" + fileName + "\"... | " + current + " sur " + total + " Mo téléchargé(s).",
                _ => "Downloading file \"" + fileName + "\"... | " + current + " of " + total + " Mo downloaded."
            };
        }

        public static string ExtractingFileMessage(string fileName)
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Extraction du fichier \"" + fileName + "\"...",
                _ => "Extracting file \"" + fileName + "\"..."
            };
        }

        public static string PreparingFolderMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Préparation des fichiers pour la réorganisation des dossiers...",
                _ => "Preparing files for folders refactoring..."
            };
        }

        public static string MovingCardsPicturesMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Déplacement des images des cartes...",
                _ => "Moving cards pictures..."
            };
        }

        public static string MovingFilesMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Déplacement des fichiers...",
                _ => "Moving files..."
            };
        }

        public static string CleaningMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Nettoyage...",
                _ => "Cleaning..."
            };
        }

        public static string MetadataJsonFileGeneratingMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Génération du fichier \"metadata.json\"...",
                _ => "Generating file \"metadata.json\"..."
            };
        }

        public static string FinishedMessage()
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Terminé",
                _ => "Finished"
            };
        }

        public static string FinishedAlertMessage(string folder)
        {
            return MainForm.appLanguage switch
            {
                "fr" => "Le Data Dragon a été installé avec succès dans le dossier \"" + folder + "\".",
                _ => "Data Dragon is now installed in \"" + folder + "\"."
            };
        }
    }
}
