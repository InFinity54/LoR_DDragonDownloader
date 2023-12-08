
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainForm_Title = new System.Windows.Forms.Label();
            MainForm_Group_DownloadMode = new System.Windows.Forms.GroupBox();
            MainForm_DownloadModeGenerateLinksOnly = new System.Windows.Forms.RadioButton();
            MainForm_DownloadModeExtractOnly = new System.Windows.Forms.RadioButton();
            MainForm_DownloadModeFull = new System.Windows.Forms.RadioButton();
            MainForm_DownloadModeLight = new System.Windows.Forms.RadioButton();
            MainForm_Description = new System.Windows.Forms.Label();
            MainForm_Group_DownloadProgress = new System.Windows.Forms.GroupBox();
            MainForm_CurrentTaskProgressLabel = new System.Windows.Forms.Label();
            MainForm_CurrentTaskProgressBar = new System.Windows.Forms.ProgressBar();
            MainForm_GlobalProgressLabel = new System.Windows.Forms.Label();
            MainForm_CurrentVersionProgressLabel = new System.Windows.Forms.Label();
            MainForm_CurrentVersionProgressBar = new System.Windows.Forms.ProgressBar();
            MainForm_GlobalProgressBar = new System.Windows.Forms.ProgressBar();
            MainForm_Group_Settings = new System.Windows.Forms.GroupBox();
            MainForm_Settings_DownloadFolder_Browse = new System.Windows.Forms.Button();
            MainForm_Settings_DownloadFolder_TextBox = new System.Windows.Forms.TextBox();
            MainForm_Settings_DownloadFolder_Label = new System.Windows.Forms.Label();
            MainForm_Button_StartDownload = new System.Windows.Forms.Button();
            MainForm_Button_Quit = new System.Windows.Forms.Button();
            DataDragonWorker = new System.ComponentModel.BackgroundWorker();
            AutoRefreshForm = new System.Windows.Forms.Timer(components);
            DownloadFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            MainForm_Group_SortType = new System.Windows.Forms.GroupBox();
            MainForm_SortBySet = new System.Windows.Forms.RadioButton();
            MainForm_SortInOneFolder = new System.Windows.Forms.RadioButton();
            App_Version = new System.Windows.Forms.Label();
            MainForm_Group_Language = new System.Windows.Forms.GroupBox();
            MainForm_LanguageSelector = new System.Windows.Forms.ComboBox();
            MainForm_Group_DownloadMode.SuspendLayout();
            MainForm_Group_DownloadProgress.SuspendLayout();
            MainForm_Group_Settings.SuspendLayout();
            MainForm_Group_SortType.SuspendLayout();
            MainForm_Group_Language.SuspendLayout();
            SuspendLayout();
            // 
            // MainForm_Title
            // 
            MainForm_Title.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MainForm_Title.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            MainForm_Title.Location = new System.Drawing.Point(12, 9);
            MainForm_Title.Name = "MainForm_Title";
            MainForm_Title.Size = new System.Drawing.Size(655, 49);
            MainForm_Title.TabIndex = 0;
            MainForm_Title.Text = "Legends of Runeterra's Data Dragon Downloader";
            MainForm_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm_Group_DownloadMode
            // 
            MainForm_Group_DownloadMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MainForm_Group_DownloadMode.Controls.Add(MainForm_DownloadModeGenerateLinksOnly);
            MainForm_Group_DownloadMode.Controls.Add(MainForm_DownloadModeExtractOnly);
            MainForm_Group_DownloadMode.Controls.Add(MainForm_DownloadModeFull);
            MainForm_Group_DownloadMode.Controls.Add(MainForm_DownloadModeLight);
            MainForm_Group_DownloadMode.Location = new System.Drawing.Point(12, 119);
            MainForm_Group_DownloadMode.Name = "MainForm_Group_DownloadMode";
            MainForm_Group_DownloadMode.Size = new System.Drawing.Size(860, 77);
            MainForm_Group_DownloadMode.TabIndex = 1;
            MainForm_Group_DownloadMode.TabStop = false;
            MainForm_Group_DownloadMode.Text = "%downloadModeAreaTitle%";
            // 
            // MainForm_DownloadModeGenerateLinksOnly
            // 
            MainForm_DownloadModeGenerateLinksOnly.AutoSize = true;
            MainForm_DownloadModeGenerateLinksOnly.Location = new System.Drawing.Point(385, 47);
            MainForm_DownloadModeGenerateLinksOnly.Name = "MainForm_DownloadModeGenerateLinksOnly";
            MainForm_DownloadModeGenerateLinksOnly.Size = new System.Drawing.Size(213, 19);
            MainForm_DownloadModeGenerateLinksOnly.TabIndex = 3;
            MainForm_DownloadModeGenerateLinksOnly.Text = "%lastVersionLinksDownloadMode%";
            MainForm_DownloadModeGenerateLinksOnly.UseVisualStyleBackColor = true;
            MainForm_DownloadModeGenerateLinksOnly.CheckedChanged += MainForm_DownloadModeGenerateLinksOnly_CheckedChanged;
            // 
            // MainForm_DownloadModeExtractOnly
            // 
            MainForm_DownloadModeExtractOnly.AutoSize = true;
            MainForm_DownloadModeExtractOnly.Location = new System.Drawing.Point(7, 47);
            MainForm_DownloadModeExtractOnly.Name = "MainForm_DownloadModeExtractOnly";
            MainForm_DownloadModeExtractOnly.Size = new System.Drawing.Size(247, 19);
            MainForm_DownloadModeExtractOnly.TabIndex = 2;
            MainForm_DownloadModeExtractOnly.Text = "%lastVersionExtractOnlyDownloadMode%";
            MainForm_DownloadModeExtractOnly.UseVisualStyleBackColor = true;
            // 
            // MainForm_DownloadModeFull
            // 
            MainForm_DownloadModeFull.AutoSize = true;
            MainForm_DownloadModeFull.Location = new System.Drawing.Point(385, 22);
            MainForm_DownloadModeFull.Name = "MainForm_DownloadModeFull";
            MainForm_DownloadModeFull.Size = new System.Drawing.Size(185, 19);
            MainForm_DownloadModeFull.TabIndex = 1;
            MainForm_DownloadModeFull.Text = "%allVersionsDownloadMode%";
            MainForm_DownloadModeFull.UseVisualStyleBackColor = true;
            // 
            // MainForm_DownloadModeLight
            // 
            MainForm_DownloadModeLight.AutoSize = true;
            MainForm_DownloadModeLight.Location = new System.Drawing.Point(7, 22);
            MainForm_DownloadModeLight.Name = "MainForm_DownloadModeLight";
            MainForm_DownloadModeLight.Size = new System.Drawing.Size(186, 19);
            MainForm_DownloadModeLight.TabIndex = 0;
            MainForm_DownloadModeLight.Text = "%lastVersionDownloadMode%";
            MainForm_DownloadModeLight.UseVisualStyleBackColor = true;
            // 
            // MainForm_Description
            // 
            MainForm_Description.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MainForm_Description.Location = new System.Drawing.Point(12, 58);
            MainForm_Description.Name = "MainForm_Description";
            MainForm_Description.Size = new System.Drawing.Size(860, 58);
            MainForm_Description.TabIndex = 2;
            MainForm_Description.Text = "%formDescription%";
            MainForm_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm_Group_DownloadProgress
            // 
            MainForm_Group_DownloadProgress.Controls.Add(MainForm_CurrentTaskProgressLabel);
            MainForm_Group_DownloadProgress.Controls.Add(MainForm_CurrentTaskProgressBar);
            MainForm_Group_DownloadProgress.Controls.Add(MainForm_GlobalProgressLabel);
            MainForm_Group_DownloadProgress.Controls.Add(MainForm_CurrentVersionProgressLabel);
            MainForm_Group_DownloadProgress.Controls.Add(MainForm_CurrentVersionProgressBar);
            MainForm_Group_DownloadProgress.Controls.Add(MainForm_GlobalProgressBar);
            MainForm_Group_DownloadProgress.Location = new System.Drawing.Point(12, 258);
            MainForm_Group_DownloadProgress.Name = "MainForm_Group_DownloadProgress";
            MainForm_Group_DownloadProgress.Size = new System.Drawing.Size(860, 196);
            MainForm_Group_DownloadProgress.TabIndex = 3;
            MainForm_Group_DownloadProgress.TabStop = false;
            MainForm_Group_DownloadProgress.Text = "%progressAreaTitle%";
            // 
            // MainForm_CurrentTaskProgressLabel
            // 
            MainForm_CurrentTaskProgressLabel.Location = new System.Drawing.Point(7, 19);
            MainForm_CurrentTaskProgressLabel.Name = "MainForm_CurrentTaskProgressLabel";
            MainForm_CurrentTaskProgressLabel.Size = new System.Drawing.Size(847, 17);
            MainForm_CurrentTaskProgressLabel.TabIndex = 5;
            MainForm_CurrentTaskProgressLabel.Text = "%waitingDownloadStart%";
            MainForm_CurrentTaskProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm_CurrentTaskProgressBar
            // 
            MainForm_CurrentTaskProgressBar.Location = new System.Drawing.Point(7, 39);
            MainForm_CurrentTaskProgressBar.Name = "MainForm_CurrentTaskProgressBar";
            MainForm_CurrentTaskProgressBar.Size = new System.Drawing.Size(847, 23);
            MainForm_CurrentTaskProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            MainForm_CurrentTaskProgressBar.TabIndex = 4;
            // 
            // MainForm_GlobalProgressLabel
            // 
            MainForm_GlobalProgressLabel.Location = new System.Drawing.Point(7, 147);
            MainForm_GlobalProgressLabel.Name = "MainForm_GlobalProgressLabel";
            MainForm_GlobalProgressLabel.Size = new System.Drawing.Size(847, 17);
            MainForm_GlobalProgressLabel.TabIndex = 3;
            MainForm_GlobalProgressLabel.Text = "%waitingDownloadStart%";
            MainForm_GlobalProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm_CurrentVersionProgressLabel
            // 
            MainForm_CurrentVersionProgressLabel.Location = new System.Drawing.Point(7, 82);
            MainForm_CurrentVersionProgressLabel.Name = "MainForm_CurrentVersionProgressLabel";
            MainForm_CurrentVersionProgressLabel.Size = new System.Drawing.Size(847, 17);
            MainForm_CurrentVersionProgressLabel.TabIndex = 2;
            MainForm_CurrentVersionProgressLabel.Text = "%waitingDownloadStart%";
            MainForm_CurrentVersionProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm_CurrentVersionProgressBar
            // 
            MainForm_CurrentVersionProgressBar.Location = new System.Drawing.Point(7, 102);
            MainForm_CurrentVersionProgressBar.Name = "MainForm_CurrentVersionProgressBar";
            MainForm_CurrentVersionProgressBar.Size = new System.Drawing.Size(847, 23);
            MainForm_CurrentVersionProgressBar.Step = 1;
            MainForm_CurrentVersionProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            MainForm_CurrentVersionProgressBar.TabIndex = 1;
            // 
            // MainForm_GlobalProgressBar
            // 
            MainForm_GlobalProgressBar.Location = new System.Drawing.Point(7, 167);
            MainForm_GlobalProgressBar.Name = "MainForm_GlobalProgressBar";
            MainForm_GlobalProgressBar.Size = new System.Drawing.Size(847, 23);
            MainForm_GlobalProgressBar.Step = 1;
            MainForm_GlobalProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            MainForm_GlobalProgressBar.TabIndex = 0;
            // 
            // MainForm_Group_Settings
            // 
            MainForm_Group_Settings.Controls.Add(MainForm_Settings_DownloadFolder_Browse);
            MainForm_Group_Settings.Controls.Add(MainForm_Settings_DownloadFolder_TextBox);
            MainForm_Group_Settings.Controls.Add(MainForm_Settings_DownloadFolder_Label);
            MainForm_Group_Settings.Location = new System.Drawing.Point(12, 460);
            MainForm_Group_Settings.Name = "MainForm_Group_Settings";
            MainForm_Group_Settings.Size = new System.Drawing.Size(558, 72);
            MainForm_Group_Settings.TabIndex = 4;
            MainForm_Group_Settings.TabStop = false;
            MainForm_Group_Settings.Text = "%downloadSettingsAreaTitle%";
            // 
            // MainForm_Settings_DownloadFolder_Browse
            // 
            MainForm_Settings_DownloadFolder_Browse.ForeColor = System.Drawing.Color.Black;
            MainForm_Settings_DownloadFolder_Browse.Location = new System.Drawing.Point(477, 14);
            MainForm_Settings_DownloadFolder_Browse.Name = "MainForm_Settings_DownloadFolder_Browse";
            MainForm_Settings_DownloadFolder_Browse.Size = new System.Drawing.Size(75, 23);
            MainForm_Settings_DownloadFolder_Browse.TabIndex = 2;
            MainForm_Settings_DownloadFolder_Browse.Text = "%downloadFolderSelection%";
            MainForm_Settings_DownloadFolder_Browse.UseVisualStyleBackColor = true;
            MainForm_Settings_DownloadFolder_Browse.Click += MainForm_Settings_DownloadFolder_Browse_Click;
            // 
            // MainForm_Settings_DownloadFolder_TextBox
            // 
            MainForm_Settings_DownloadFolder_TextBox.Location = new System.Drawing.Point(7, 40);
            MainForm_Settings_DownloadFolder_TextBox.Name = "MainForm_Settings_DownloadFolder_TextBox";
            MainForm_Settings_DownloadFolder_TextBox.Size = new System.Drawing.Size(545, 23);
            MainForm_Settings_DownloadFolder_TextBox.TabIndex = 1;
            // 
            // MainForm_Settings_DownloadFolder_Label
            // 
            MainForm_Settings_DownloadFolder_Label.AutoSize = true;
            MainForm_Settings_DownloadFolder_Label.Location = new System.Drawing.Point(6, 22);
            MainForm_Settings_DownloadFolder_Label.Name = "MainForm_Settings_DownloadFolder_Label";
            MainForm_Settings_DownloadFolder_Label.Size = new System.Drawing.Size(184, 15);
            MainForm_Settings_DownloadFolder_Label.TabIndex = 0;
            MainForm_Settings_DownloadFolder_Label.Text = "%downloadFolderSelectionHint%";
            // 
            // MainForm_Button_StartDownload
            // 
            MainForm_Button_StartDownload.ForeColor = System.Drawing.Color.Black;
            MainForm_Button_StartDownload.Location = new System.Drawing.Point(598, 487);
            MainForm_Button_StartDownload.Name = "MainForm_Button_StartDownload";
            MainForm_Button_StartDownload.Size = new System.Drawing.Size(193, 23);
            MainForm_Button_StartDownload.TabIndex = 5;
            MainForm_Button_StartDownload.Text = "%downloadStartButton%";
            MainForm_Button_StartDownload.UseVisualStyleBackColor = true;
            MainForm_Button_StartDownload.Click += MainForm_Button_StartDownload_Click;
            // 
            // MainForm_Button_Quit
            // 
            MainForm_Button_Quit.ForeColor = System.Drawing.Color.Black;
            MainForm_Button_Quit.Location = new System.Drawing.Point(797, 487);
            MainForm_Button_Quit.Name = "MainForm_Button_Quit";
            MainForm_Button_Quit.Size = new System.Drawing.Size(75, 23);
            MainForm_Button_Quit.TabIndex = 6;
            MainForm_Button_Quit.Text = "%exitButton%";
            MainForm_Button_Quit.UseVisualStyleBackColor = true;
            MainForm_Button_Quit.Click += MainForm_Button_Quit_Click;
            // 
            // DataDragonWorker
            // 
            DataDragonWorker.DoWork += DataDragonWorker_DoWork;
            // 
            // AutoRefreshForm
            // 
            AutoRefreshForm.Enabled = true;
            AutoRefreshForm.Interval = 150;
            AutoRefreshForm.Tick += AutoRefreshForm_Tick;
            // 
            // MainForm_Group_SortType
            // 
            MainForm_Group_SortType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MainForm_Group_SortType.Controls.Add(MainForm_SortBySet);
            MainForm_Group_SortType.Controls.Add(MainForm_SortInOneFolder);
            MainForm_Group_SortType.Location = new System.Drawing.Point(12, 202);
            MainForm_Group_SortType.Name = "MainForm_Group_SortType";
            MainForm_Group_SortType.Size = new System.Drawing.Size(860, 50);
            MainForm_Group_SortType.TabIndex = 2;
            MainForm_Group_SortType.TabStop = false;
            MainForm_Group_SortType.Text = "%sortModeAreaTitle%";
            // 
            // MainForm_SortBySet
            // 
            MainForm_SortBySet.AutoSize = true;
            MainForm_SortBySet.Location = new System.Drawing.Point(385, 22);
            MainForm_SortBySet.Name = "MainForm_SortBySet";
            MainForm_SortBySet.Size = new System.Drawing.Size(81, 19);
            MainForm_SortBySet.TabIndex = 1;
            MainForm_SortBySet.Text = "%setSort%";
            MainForm_SortBySet.UseVisualStyleBackColor = true;
            // 
            // MainForm_SortInOneFolder
            // 
            MainForm_SortInOneFolder.AutoSize = true;
            MainForm_SortInOneFolder.Location = new System.Drawing.Point(7, 22);
            MainForm_SortInOneFolder.Name = "MainForm_SortInOneFolder";
            MainForm_SortInOneFolder.Size = new System.Drawing.Size(119, 19);
            MainForm_SortInOneFolder.TabIndex = 0;
            MainForm_SortInOneFolder.Text = "%oneFolderSort%";
            MainForm_SortInOneFolder.UseVisualStyleBackColor = true;
            // 
            // App_Version
            // 
            App_Version.ForeColor = System.Drawing.Color.DarkGray;
            App_Version.Location = new System.Drawing.Point(598, 513);
            App_Version.Name = "App_Version";
            App_Version.Size = new System.Drawing.Size(274, 19);
            App_Version.TabIndex = 7;
            App_Version.Text = "Version %version%";
            App_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm_Group_Language
            // 
            MainForm_Group_Language.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MainForm_Group_Language.Controls.Add(MainForm_LanguageSelector);
            MainForm_Group_Language.Location = new System.Drawing.Point(673, 12);
            MainForm_Group_Language.Name = "MainForm_Group_Language";
            MainForm_Group_Language.Size = new System.Drawing.Size(199, 46);
            MainForm_Group_Language.TabIndex = 8;
            MainForm_Group_Language.TabStop = false;
            MainForm_Group_Language.Text = "%appLanguageAreaTitle%";
            // 
            // MainForm_LanguageSelector
            // 
            MainForm_LanguageSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            MainForm_LanguageSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            MainForm_LanguageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MainForm_LanguageSelector.FormattingEnabled = true;
            MainForm_LanguageSelector.Items.AddRange(new object[] { "Français", "English" });
            MainForm_LanguageSelector.Location = new System.Drawing.Point(6, 17);
            MainForm_LanguageSelector.MaxDropDownItems = 2;
            MainForm_LanguageSelector.Name = "MainForm_LanguageSelector";
            MainForm_LanguageSelector.Size = new System.Drawing.Size(187, 23);
            MainForm_LanguageSelector.TabIndex = 0;
            MainForm_LanguageSelector.SelectionChangeCommitted += MainForm_LanguageSelector_SelectionChangeCommitted;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(95, 95, 95);
            ClientSize = new System.Drawing.Size(884, 541);
            ControlBox = false;
            Controls.Add(MainForm_Group_Language);
            Controls.Add(App_Version);
            Controls.Add(MainForm_Group_SortType);
            Controls.Add(MainForm_Button_Quit);
            Controls.Add(MainForm_Button_StartDownload);
            Controls.Add(MainForm_Group_Settings);
            Controls.Add(MainForm_Group_DownloadProgress);
            Controls.Add(MainForm_Description);
            Controls.Add(MainForm_Group_DownloadMode);
            Controls.Add(MainForm_Title);
            ForeColor = System.Drawing.SystemColors.ScrollBar;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Legends of Runeterra's Data Dragon Downloader";
            MainForm_Group_DownloadMode.ResumeLayout(false);
            MainForm_Group_DownloadMode.PerformLayout();
            MainForm_Group_DownloadProgress.ResumeLayout(false);
            MainForm_Group_Settings.ResumeLayout(false);
            MainForm_Group_Settings.PerformLayout();
            MainForm_Group_SortType.ResumeLayout(false);
            MainForm_Group_SortType.PerformLayout();
            MainForm_Group_Language.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox MainForm_Group_SortType;
        private System.Windows.Forms.RadioButton MainForm_SortBySet;
        private System.Windows.Forms.RadioButton MainForm_SortInOneFolder;
        private System.Windows.Forms.Label App_Version;
        private System.Windows.Forms.GroupBox MainForm_Group_Language;
        private System.Windows.Forms.ComboBox MainForm_LanguageSelector;
        private System.Windows.Forms.RadioButton MainForm_DownloadModeExtractOnly;
        private System.Windows.Forms.RadioButton MainForm_DownloadModeGenerateLinksOnly;
    }
}

