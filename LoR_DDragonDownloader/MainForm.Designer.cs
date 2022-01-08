
namespace LoR_DDragonDownloader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainForm_Title = new System.Windows.Forms.Label();
            this.MainForm_Group_DownloadMode = new System.Windows.Forms.GroupBox();
            this.MainForm_DownloadModeFull = new System.Windows.Forms.RadioButton();
            this.MainForm_DownloadModeLight = new System.Windows.Forms.RadioButton();
            this.MainForm_Description = new System.Windows.Forms.Label();
            this.MainForm_Group_DownloadProgress = new System.Windows.Forms.GroupBox();
            this.MainForm_CurrentTaskProgressLabel = new System.Windows.Forms.Label();
            this.MainForm_CurrentTaskProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainForm_GlobalProgressLabel = new System.Windows.Forms.Label();
            this.MainForm_CurrentVersionProgressLabel = new System.Windows.Forms.Label();
            this.MainForm_CurrentVersionProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainForm_GlobalProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainForm_Group_Settings = new System.Windows.Forms.GroupBox();
            this.MainForm_Settings_DownloadFolder_TextBox = new System.Windows.Forms.TextBox();
            this.MainForm_Settings_DownloadFolder_Label = new System.Windows.Forms.Label();
            this.MainForm_Button_StartDownload = new System.Windows.Forms.Button();
            this.MainForm_Button_Quit = new System.Windows.Forms.Button();
            this.DataDragonWorker = new System.ComponentModel.BackgroundWorker();
            this.AutoRefreshForm = new System.Windows.Forms.Timer(this.components);
            this.DownloadFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.MainForm_Settings_DownloadFolder_Browse = new System.Windows.Forms.Button();
            this.MainForm_Group_DownloadMode.SuspendLayout();
            this.MainForm_Group_DownloadProgress.SuspendLayout();
            this.MainForm_Group_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm_Title
            // 
            this.MainForm_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainForm_Title.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MainForm_Title.Location = new System.Drawing.Point(12, 9);
            this.MainForm_Title.Name = "MainForm_Title";
            this.MainForm_Title.Size = new System.Drawing.Size(860, 49);
            this.MainForm_Title.TabIndex = 0;
            this.MainForm_Title.Text = "Legends of Runeterra - Data Dragon Downloader";
            this.MainForm_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm_Group_DownloadMode
            // 
            this.MainForm_Group_DownloadMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainForm_Group_DownloadMode.Controls.Add(this.MainForm_DownloadModeFull);
            this.MainForm_Group_DownloadMode.Controls.Add(this.MainForm_DownloadModeLight);
            this.MainForm_Group_DownloadMode.Location = new System.Drawing.Point(12, 119);
            this.MainForm_Group_DownloadMode.Name = "MainForm_Group_DownloadMode";
            this.MainForm_Group_DownloadMode.Size = new System.Drawing.Size(860, 50);
            this.MainForm_Group_DownloadMode.TabIndex = 1;
            this.MainForm_Group_DownloadMode.TabStop = false;
            this.MainForm_Group_DownloadMode.Text = "Mode de téléchargement";
            // 
            // MainForm_DownloadModeFull
            // 
            this.MainForm_DownloadModeFull.AutoSize = true;
            this.MainForm_DownloadModeFull.Location = new System.Drawing.Point(385, 22);
            this.MainForm_DownloadModeFull.Name = "MainForm_DownloadModeFull";
            this.MainForm_DownloadModeFull.Size = new System.Drawing.Size(382, 19);
            this.MainForm_DownloadModeFull.TabIndex = 1;
            this.MainForm_DownloadModeFull.Text = "Téléchargement de toutes les versions depuis la version 1.0.0 incluse";
            this.MainForm_DownloadModeFull.UseVisualStyleBackColor = true;
            // 
            // MainForm_DownloadModeLight
            // 
            this.MainForm_DownloadModeLight.AutoSize = true;
            this.MainForm_DownloadModeLight.Location = new System.Drawing.Point(7, 22);
            this.MainForm_DownloadModeLight.Name = "MainForm_DownloadModeLight";
            this.MainForm_DownloadModeLight.Size = new System.Drawing.Size(292, 19);
            this.MainForm_DownloadModeLight.TabIndex = 0;
            this.MainForm_DownloadModeLight.Text = "Téléchargement de la dernière version uniquement";
            this.MainForm_DownloadModeLight.UseVisualStyleBackColor = true;
            // 
            // MainForm_Description
            // 
            this.MainForm_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainForm_Description.Location = new System.Drawing.Point(12, 58);
            this.MainForm_Description.Name = "MainForm_Description";
            this.MainForm_Description.Size = new System.Drawing.Size(860, 58);
            this.MainForm_Description.TabIndex = 2;
            this.MainForm_Description.Text = resources.GetString("MainForm_Description.Text");
            this.MainForm_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm_Group_DownloadProgress
            // 
            this.MainForm_Group_DownloadProgress.Controls.Add(this.MainForm_CurrentTaskProgressLabel);
            this.MainForm_Group_DownloadProgress.Controls.Add(this.MainForm_CurrentTaskProgressBar);
            this.MainForm_Group_DownloadProgress.Controls.Add(this.MainForm_GlobalProgressLabel);
            this.MainForm_Group_DownloadProgress.Controls.Add(this.MainForm_CurrentVersionProgressLabel);
            this.MainForm_Group_DownloadProgress.Controls.Add(this.MainForm_CurrentVersionProgressBar);
            this.MainForm_Group_DownloadProgress.Controls.Add(this.MainForm_GlobalProgressBar);
            this.MainForm_Group_DownloadProgress.Location = new System.Drawing.Point(12, 175);
            this.MainForm_Group_DownloadProgress.Name = "MainForm_Group_DownloadProgress";
            this.MainForm_Group_DownloadProgress.Size = new System.Drawing.Size(860, 196);
            this.MainForm_Group_DownloadProgress.TabIndex = 3;
            this.MainForm_Group_DownloadProgress.TabStop = false;
            this.MainForm_Group_DownloadProgress.Text = "Progression";
            // 
            // MainForm_CurrentTaskProgressLabel
            // 
            this.MainForm_CurrentTaskProgressLabel.Location = new System.Drawing.Point(7, 19);
            this.MainForm_CurrentTaskProgressLabel.Name = "MainForm_CurrentTaskProgressLabel";
            this.MainForm_CurrentTaskProgressLabel.Size = new System.Drawing.Size(847, 17);
            this.MainForm_CurrentTaskProgressLabel.TabIndex = 5;
            this.MainForm_CurrentTaskProgressLabel.Text = "En attente du début du téléchargement...";
            this.MainForm_CurrentTaskProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm_CurrentTaskProgressBar
            // 
            this.MainForm_CurrentTaskProgressBar.Location = new System.Drawing.Point(7, 39);
            this.MainForm_CurrentTaskProgressBar.Name = "MainForm_CurrentTaskProgressBar";
            this.MainForm_CurrentTaskProgressBar.Size = new System.Drawing.Size(847, 23);
            this.MainForm_CurrentTaskProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.MainForm_CurrentTaskProgressBar.TabIndex = 4;
            // 
            // MainForm_GlobalProgressLabel
            // 
            this.MainForm_GlobalProgressLabel.Location = new System.Drawing.Point(7, 147);
            this.MainForm_GlobalProgressLabel.Name = "MainForm_GlobalProgressLabel";
            this.MainForm_GlobalProgressLabel.Size = new System.Drawing.Size(847, 17);
            this.MainForm_GlobalProgressLabel.TabIndex = 3;
            this.MainForm_GlobalProgressLabel.Text = "En attente du début du téléchargement...";
            this.MainForm_GlobalProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm_CurrentVersionProgressLabel
            // 
            this.MainForm_CurrentVersionProgressLabel.Location = new System.Drawing.Point(7, 82);
            this.MainForm_CurrentVersionProgressLabel.Name = "MainForm_CurrentVersionProgressLabel";
            this.MainForm_CurrentVersionProgressLabel.Size = new System.Drawing.Size(847, 17);
            this.MainForm_CurrentVersionProgressLabel.TabIndex = 2;
            this.MainForm_CurrentVersionProgressLabel.Text = "En attente du début du téléchargement...";
            this.MainForm_CurrentVersionProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm_CurrentVersionProgressBar
            // 
            this.MainForm_CurrentVersionProgressBar.Location = new System.Drawing.Point(7, 102);
            this.MainForm_CurrentVersionProgressBar.Name = "MainForm_CurrentVersionProgressBar";
            this.MainForm_CurrentVersionProgressBar.Size = new System.Drawing.Size(847, 23);
            this.MainForm_CurrentVersionProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.MainForm_CurrentVersionProgressBar.TabIndex = 1;
            // 
            // MainForm_GlobalProgressBar
            // 
            this.MainForm_GlobalProgressBar.Location = new System.Drawing.Point(7, 167);
            this.MainForm_GlobalProgressBar.Name = "MainForm_GlobalProgressBar";
            this.MainForm_GlobalProgressBar.Size = new System.Drawing.Size(847, 23);
            this.MainForm_GlobalProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.MainForm_GlobalProgressBar.TabIndex = 0;
            // 
            // MainForm_Group_Settings
            // 
            this.MainForm_Group_Settings.Controls.Add(this.MainForm_Settings_DownloadFolder_Browse);
            this.MainForm_Group_Settings.Controls.Add(this.MainForm_Settings_DownloadFolder_TextBox);
            this.MainForm_Group_Settings.Controls.Add(this.MainForm_Settings_DownloadFolder_Label);
            this.MainForm_Group_Settings.Location = new System.Drawing.Point(12, 377);
            this.MainForm_Group_Settings.Name = "MainForm_Group_Settings";
            this.MainForm_Group_Settings.Size = new System.Drawing.Size(558, 72);
            this.MainForm_Group_Settings.TabIndex = 4;
            this.MainForm_Group_Settings.TabStop = false;
            this.MainForm_Group_Settings.Text = "Paramètres de l\'application";
            // 
            // MainForm_Settings_DownloadFolder_TextBox
            // 
            this.MainForm_Settings_DownloadFolder_TextBox.Location = new System.Drawing.Point(7, 40);
            this.MainForm_Settings_DownloadFolder_TextBox.Name = "MainForm_Settings_DownloadFolder_TextBox";
            this.MainForm_Settings_DownloadFolder_TextBox.Size = new System.Drawing.Size(545, 23);
            this.MainForm_Settings_DownloadFolder_TextBox.TabIndex = 1;
            // 
            // MainForm_Settings_DownloadFolder_Label
            // 
            this.MainForm_Settings_DownloadFolder_Label.AutoSize = true;
            this.MainForm_Settings_DownloadFolder_Label.Location = new System.Drawing.Point(6, 22);
            this.MainForm_Settings_DownloadFolder_Label.Name = "MainForm_Settings_DownloadFolder_Label";
            this.MainForm_Settings_DownloadFolder_Label.Size = new System.Drawing.Size(233, 15);
            this.MainForm_Settings_DownloadFolder_Label.TabIndex = 0;
            this.MainForm_Settings_DownloadFolder_Label.Text = "Chemin vers le dossier de téléchargement :";
            // 
            // MainForm_Button_StartDownload
            // 
            this.MainForm_Button_StartDownload.ForeColor = System.Drawing.Color.Black;
            this.MainForm_Button_StartDownload.Location = new System.Drawing.Point(598, 404);
            this.MainForm_Button_StartDownload.Name = "MainForm_Button_StartDownload";
            this.MainForm_Button_StartDownload.Size = new System.Drawing.Size(193, 23);
            this.MainForm_Button_StartDownload.TabIndex = 5;
            this.MainForm_Button_StartDownload.Text = "Démarrer le téléchargement";
            this.MainForm_Button_StartDownload.UseVisualStyleBackColor = true;
            this.MainForm_Button_StartDownload.Click += new System.EventHandler(this.MainForm_Button_StartDownload_Click);
            // 
            // MainForm_Button_Quit
            // 
            this.MainForm_Button_Quit.ForeColor = System.Drawing.Color.Black;
            this.MainForm_Button_Quit.Location = new System.Drawing.Point(797, 404);
            this.MainForm_Button_Quit.Name = "MainForm_Button_Quit";
            this.MainForm_Button_Quit.Size = new System.Drawing.Size(75, 23);
            this.MainForm_Button_Quit.TabIndex = 6;
            this.MainForm_Button_Quit.Text = "Quitter";
            this.MainForm_Button_Quit.UseVisualStyleBackColor = true;
            this.MainForm_Button_Quit.Click += new System.EventHandler(this.MainForm_Button_Quit_Click);
            // 
            // DataDragonWorker
            // 
            this.DataDragonWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DataDragonWorker_DoWork);
            // 
            // AutoRefreshForm
            // 
            this.AutoRefreshForm.Enabled = true;
            this.AutoRefreshForm.Interval = 150;
            this.AutoRefreshForm.Tick += new System.EventHandler(this.AutoRefreshForm_Tick);
            // 
            // MainForm_Settings_DownloadFolder_Browse
            // 
            this.MainForm_Settings_DownloadFolder_Browse.ForeColor = System.Drawing.Color.Black;
            this.MainForm_Settings_DownloadFolder_Browse.Location = new System.Drawing.Point(477, 14);
            this.MainForm_Settings_DownloadFolder_Browse.Name = "MainForm_Settings_DownloadFolder_Browse";
            this.MainForm_Settings_DownloadFolder_Browse.Size = new System.Drawing.Size(75, 23);
            this.MainForm_Settings_DownloadFolder_Browse.TabIndex = 2;
            this.MainForm_Settings_DownloadFolder_Browse.Text = "Parcourir";
            this.MainForm_Settings_DownloadFolder_Browse.UseVisualStyleBackColor = true;
            this.MainForm_Settings_DownloadFolder_Browse.Click += new System.EventHandler(this.MainForm_Settings_DownloadFolder_Browse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.ControlBox = false;
            this.Controls.Add(this.MainForm_Button_Quit);
            this.Controls.Add(this.MainForm_Button_StartDownload);
            this.Controls.Add(this.MainForm_Group_Settings);
            this.Controls.Add(this.MainForm_Group_DownloadProgress);
            this.Controls.Add(this.MainForm_Description);
            this.Controls.Add(this.MainForm_Group_DownloadMode);
            this.Controls.Add(this.MainForm_Title);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legends of Runeterra - Data Dragon Downloader";
            this.MainForm_Group_DownloadMode.ResumeLayout(false);
            this.MainForm_Group_DownloadMode.PerformLayout();
            this.MainForm_Group_DownloadProgress.ResumeLayout(false);
            this.MainForm_Group_Settings.ResumeLayout(false);
            this.MainForm_Group_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainForm_Title;
        private System.Windows.Forms.GroupBox MainForm_Group_DownloadMode;
        private System.Windows.Forms.RadioButton MainForm_DownloadModeFull;
        private System.Windows.Forms.RadioButton MainForm_DownloadModeLight;
        private System.Windows.Forms.Label MainForm_Description;
        private System.Windows.Forms.GroupBox MainForm_Group_DownloadProgress;
        private System.Windows.Forms.GroupBox MainForm_Group_Settings;
        private System.Windows.Forms.Button MainForm_Button_StartDownload;
        private System.Windows.Forms.Button MainForm_Button_Quit;
        private System.Windows.Forms.Label MainForm_GlobalProgressLabel;
        private System.Windows.Forms.Label MainForm_CurrentVersionProgressLabel;
        private System.Windows.Forms.ProgressBar MainForm_CurrentVersionProgressBar;
        private System.Windows.Forms.ProgressBar MainForm_GlobalProgressBar;
        private System.Windows.Forms.TextBox MainForm_Settings_DownloadFolder_TextBox;
        private System.Windows.Forms.Label MainForm_Settings_DownloadFolder_Label;
        private System.Windows.Forms.Label MainForm_CurrentTaskProgressLabel;
        private System.Windows.Forms.ProgressBar MainForm_CurrentTaskProgressBar;
        private System.ComponentModel.BackgroundWorker DataDragonWorker;
        private System.Windows.Forms.Timer AutoRefreshForm;
        private System.Windows.Forms.Button MainForm_Settings_DownloadFolder_Browse;
        private System.Windows.Forms.FolderBrowserDialog DownloadFolderSelect;
    }
}

