namespace UpperQuest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.devicesTabPage = new System.Windows.Forms.TabPage();
            this.GetLogs = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTextureHeightValue = new System.Windows.Forms.Label();
            this.devicebitratelabel = new System.Windows.Forms.Label();
            this.devicecaptureheightlabel = new System.Windows.Forms.Label();
            this.devicecapturewidthlabel = new System.Windows.Forms.Label();
            this.devicefullratecapturelabel = new System.Windows.Forms.Label();
            this.labelTextureHeight = new System.Windows.Forms.Label();
            this.labelTextureWidth = new System.Windows.Forms.Label();
            this.labelGpuLevel = new System.Windows.Forms.Label();
            this.labelCpuLevel = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.devicesListBox = new System.Windows.Forms.ListBox();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.captureh = new System.Windows.Forms.RadioButton();
            this.bitrate = new System.Windows.Forms.RadioButton();
            this.capturew = new System.Windows.Forms.RadioButton();
            this.fullRateCapture = new System.Windows.Forms.RadioButton();
            this.DownloadProcessLabel = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelProperty = new System.Windows.Forms.Label();
            this.textBoxPropertyValue = new System.Windows.Forms.TextBox();
            this.radioButtonGPU = new System.Windows.Forms.RadioButton();
            this.radioButtonCPU = new System.Windows.Forms.RadioButton();
            this.radioButtonTexture = new System.Windows.Forms.RadioButton();
            this.textBoxApkFilePath = new System.Windows.Forms.TextBox();
            this.labelApkFilePath = new System.Windows.Forms.Label();
            this.buttonBrowseApk = new System.Windows.Forms.Button();
            this.gamesTabPage = new System.Windows.Forms.TabPage();
            this.DiscordDownloadButton = new System.Windows.Forms.Button();
            this.listViewGames = new System.Windows.Forms.ListView();
            this.imageListGames = new System.Windows.Forms.ImageList(this.components);
            this.labelGames = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.devicesTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.gamesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.devicesTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Controls.Add(this.gamesTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(400, 300);
            this.tabControl.TabIndex = 0;
            // 
            // devicesTabPage
            // 
            this.devicesTabPage.Controls.Add(this.GetLogs);
            this.devicesTabPage.Controls.Add(this.buttonRefresh);
            this.devicesTabPage.Controls.Add(this.labelTextureHeightValue);
            this.devicesTabPage.Controls.Add(this.devicebitratelabel);
            this.devicesTabPage.Controls.Add(this.devicecaptureheightlabel);
            this.devicesTabPage.Controls.Add(this.devicecapturewidthlabel);
            this.devicesTabPage.Controls.Add(this.devicefullratecapturelabel);
            this.devicesTabPage.Controls.Add(this.labelTextureHeight);
            this.devicesTabPage.Controls.Add(this.labelTextureWidth);
            this.devicesTabPage.Controls.Add(this.labelGpuLevel);
            this.devicesTabPage.Controls.Add(this.labelCpuLevel);
            this.devicesTabPage.Controls.Add(this.labelDeviceName);
            this.devicesTabPage.Controls.Add(this.devicesListBox);
            this.devicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.devicesTabPage.Name = "devicesTabPage";
            this.devicesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.devicesTabPage.Size = new System.Drawing.Size(392, 274);
            this.devicesTabPage.TabIndex = 0;
            this.devicesTabPage.Text = "Devices";
            this.devicesTabPage.UseVisualStyleBackColor = true;
            // 
            // GetLogs
            // 
            this.GetLogs.Location = new System.Drawing.Point(135, 245);
            this.GetLogs.Name = "GetLogs";
            this.GetLogs.Size = new System.Drawing.Size(75, 23);
            this.GetLogs.TabIndex = 13;
            this.GetLogs.Text = "Get Logs";
            this.GetLogs.UseVisualStyleBackColor = true;
            this.GetLogs.Click += new System.EventHandler(this.GetLogs_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(295, 245);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelTextureHeightValue
            // 
            this.labelTextureHeightValue.AutoSize = true;
            this.labelTextureHeightValue.Location = new System.Drawing.Point(232, 121);
            this.labelTextureHeightValue.Name = "labelTextureHeightValue";
            this.labelTextureHeightValue.Size = new System.Drawing.Size(35, 13);
            this.labelTextureHeightValue.TabIndex = 10;
            this.labelTextureHeightValue.Text = "label5";
            // 
            // devicebitratelabel
            // 
            this.devicebitratelabel.AutoSize = true;
            this.devicebitratelabel.Location = new System.Drawing.Point(232, 94);
            this.devicebitratelabel.Name = "devicebitratelabel";
            this.devicebitratelabel.Size = new System.Drawing.Size(42, 13);
            this.devicebitratelabel.TabIndex = 9;
            this.devicebitratelabel.Text = "BitRate";
            // 
            // devicecaptureheightlabel
            // 
            this.devicecaptureheightlabel.AutoSize = true;
            this.devicecaptureheightlabel.Location = new System.Drawing.Point(232, 67);
            this.devicecaptureheightlabel.Name = "devicecaptureheightlabel";
            this.devicecaptureheightlabel.Size = new System.Drawing.Size(81, 13);
            this.devicecaptureheightlabel.TabIndex = 8;
            this.devicecaptureheightlabel.Text = "Capture Height:";
            // 
            // devicecapturewidthlabel
            // 
            this.devicecapturewidthlabel.AutoSize = true;
            this.devicecapturewidthlabel.Location = new System.Drawing.Point(232, 40);
            this.devicecapturewidthlabel.Name = "devicecapturewidthlabel";
            this.devicecapturewidthlabel.Size = new System.Drawing.Size(78, 13);
            this.devicecapturewidthlabel.TabIndex = 7;
            this.devicecapturewidthlabel.Text = "Capture Width:";
            // 
            // devicefullratecapturelabel
            // 
            this.devicefullratecapturelabel.AutoSize = true;
            this.devicefullratecapturelabel.Location = new System.Drawing.Point(232, 13);
            this.devicefullratecapturelabel.Name = "devicefullratecapturelabel";
            this.devicefullratecapturelabel.Size = new System.Drawing.Size(89, 13);
            this.devicefullratecapturelabel.TabIndex = 6;
            this.devicefullratecapturelabel.Text = "FullRateCapture: ";
            // 
            // labelTextureHeight
            // 
            this.labelTextureHeight.AutoSize = true;
            this.labelTextureHeight.Location = new System.Drawing.Point(148, 121);
            this.labelTextureHeight.Name = "labelTextureHeight";
            this.labelTextureHeight.Size = new System.Drawing.Size(80, 13);
            this.labelTextureHeight.TabIndex = 5;
            this.labelTextureHeight.Text = "Texture Height:";
            // 
            // labelTextureWidth
            // 
            this.labelTextureWidth.AutoSize = true;
            this.labelTextureWidth.Location = new System.Drawing.Point(148, 94);
            this.labelTextureWidth.Name = "labelTextureWidth";
            this.labelTextureWidth.Size = new System.Drawing.Size(77, 13);
            this.labelTextureWidth.TabIndex = 4;
            this.labelTextureWidth.Text = "Texture Width:";
            // 
            // labelGpuLevel
            // 
            this.labelGpuLevel.AutoSize = true;
            this.labelGpuLevel.Location = new System.Drawing.Point(148, 67);
            this.labelGpuLevel.Name = "labelGpuLevel";
            this.labelGpuLevel.Size = new System.Drawing.Size(62, 13);
            this.labelGpuLevel.TabIndex = 3;
            this.labelGpuLevel.Text = "GPU Level:";
            // 
            // labelCpuLevel
            // 
            this.labelCpuLevel.AutoSize = true;
            this.labelCpuLevel.Location = new System.Drawing.Point(148, 40);
            this.labelCpuLevel.Name = "labelCpuLevel";
            this.labelCpuLevel.Size = new System.Drawing.Size(61, 13);
            this.labelCpuLevel.TabIndex = 2;
            this.labelCpuLevel.Text = "CPU Level:";
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(148, 13);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(75, 13);
            this.labelDeviceName.TabIndex = 1;
            this.labelDeviceName.Text = "Device Name:";
            // 
            // devicesListBox
            // 
            this.devicesListBox.FormattingEnabled = true;
            this.devicesListBox.Location = new System.Drawing.Point(6, 6);
            this.devicesListBox.Name = "devicesListBox";
            this.devicesListBox.Size = new System.Drawing.Size(120, 251);
            this.devicesListBox.TabIndex = 0;
            this.devicesListBox.SelectedIndexChanged += new System.EventHandler(this.devicesListBox_SelectedIndexChanged);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.captureh);
            this.settingsTabPage.Controls.Add(this.bitrate);
            this.settingsTabPage.Controls.Add(this.capturew);
            this.settingsTabPage.Controls.Add(this.fullRateCapture);
            this.settingsTabPage.Controls.Add(this.DownloadProcessLabel);
            this.settingsTabPage.Controls.Add(this.buttonDownload);
            this.settingsTabPage.Controls.Add(this.buttonChange);
            this.settingsTabPage.Controls.Add(this.labelProperty);
            this.settingsTabPage.Controls.Add(this.textBoxPropertyValue);
            this.settingsTabPage.Controls.Add(this.radioButtonGPU);
            this.settingsTabPage.Controls.Add(this.radioButtonCPU);
            this.settingsTabPage.Controls.Add(this.radioButtonTexture);
            this.settingsTabPage.Controls.Add(this.textBoxApkFilePath);
            this.settingsTabPage.Controls.Add(this.labelApkFilePath);
            this.settingsTabPage.Controls.Add(this.buttonBrowseApk);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(392, 274);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // captureh
            // 
            this.captureh.AutoSize = true;
            this.captureh.Location = new System.Drawing.Point(86, 69);
            this.captureh.Name = "captureh";
            this.captureh.Size = new System.Drawing.Size(94, 17);
            this.captureh.TabIndex = 15;
            this.captureh.TabStop = true;
            this.captureh.Text = "Capture height";
            this.captureh.UseVisualStyleBackColor = true;
            // 
            // bitrate
            // 
            this.bitrate.AutoSize = true;
            this.bitrate.Location = new System.Drawing.Point(194, 23);
            this.bitrate.Name = "bitrate";
            this.bitrate.Size = new System.Drawing.Size(55, 17);
            this.bitrate.TabIndex = 14;
            this.bitrate.TabStop = true;
            this.bitrate.Text = "Bitrate";
            this.bitrate.UseVisualStyleBackColor = true;
            // 
            // capturew
            // 
            this.capturew.AutoSize = true;
            this.capturew.Location = new System.Drawing.Point(86, 46);
            this.capturew.Name = "capturew";
            this.capturew.Size = new System.Drawing.Size(90, 17);
            this.capturew.TabIndex = 13;
            this.capturew.TabStop = true;
            this.capturew.Text = "Capture width";
            this.capturew.UseVisualStyleBackColor = true;
            // 
            // fullRateCapture
            // 
            this.fullRateCapture.AutoSize = true;
            this.fullRateCapture.Location = new System.Drawing.Point(86, 23);
            this.fullRateCapture.Name = "fullRateCapture";
            this.fullRateCapture.Size = new System.Drawing.Size(101, 17);
            this.fullRateCapture.TabIndex = 12;
            this.fullRateCapture.TabStop = true;
            this.fullRateCapture.Text = "FullRateCapture";
            this.fullRateCapture.UseVisualStyleBackColor = true;
            // 
            // DownloadProcessLabel
            // 
            this.DownloadProcessLabel.AutoSize = true;
            this.DownloadProcessLabel.Location = new System.Drawing.Point(91, 165);
            this.DownloadProcessLabel.Name = "DownloadProcessLabel";
            this.DownloadProcessLabel.Size = new System.Drawing.Size(0, 13);
            this.DownloadProcessLabel.TabIndex = 10;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(19, 207);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 9;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(19, 129);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 5;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(16, 87);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(49, 13);
            this.labelProperty.TabIndex = 4;
            this.labelProperty.Text = "Property:";
            // 
            // textBoxPropertyValue
            // 
            this.textBoxPropertyValue.Location = new System.Drawing.Point(19, 103);
            this.textBoxPropertyValue.Name = "textBoxPropertyValue";
            this.textBoxPropertyValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropertyValue.TabIndex = 3;
            // 
            // radioButtonGPU
            // 
            this.radioButtonGPU.AutoSize = true;
            this.radioButtonGPU.Location = new System.Drawing.Point(19, 69);
            this.radioButtonGPU.Name = "radioButtonGPU";
            this.radioButtonGPU.Size = new System.Drawing.Size(48, 17);
            this.radioButtonGPU.TabIndex = 2;
            this.radioButtonGPU.TabStop = true;
            this.radioButtonGPU.Text = "GPU";
            this.radioButtonGPU.UseVisualStyleBackColor = true;
            // 
            // radioButtonCPU
            // 
            this.radioButtonCPU.AutoSize = true;
            this.radioButtonCPU.Location = new System.Drawing.Point(19, 46);
            this.radioButtonCPU.Name = "radioButtonCPU";
            this.radioButtonCPU.Size = new System.Drawing.Size(47, 17);
            this.radioButtonCPU.TabIndex = 1;
            this.radioButtonCPU.TabStop = true;
            this.radioButtonCPU.Text = "CPU";
            this.radioButtonCPU.UseVisualStyleBackColor = true;
            // 
            // radioButtonTexture
            // 
            this.radioButtonTexture.AutoSize = true;
            this.radioButtonTexture.Location = new System.Drawing.Point(19, 23);
            this.radioButtonTexture.Name = "radioButtonTexture";
            this.radioButtonTexture.Size = new System.Drawing.Size(61, 17);
            this.radioButtonTexture.TabIndex = 0;
            this.radioButtonTexture.TabStop = true;
            this.radioButtonTexture.Text = "Texture";
            this.radioButtonTexture.UseVisualStyleBackColor = true;
            // 
            // textBoxApkFilePath
            // 
            this.textBoxApkFilePath.Location = new System.Drawing.Point(19, 181);
            this.textBoxApkFilePath.Name = "textBoxApkFilePath";
            this.textBoxApkFilePath.ReadOnly = true;
            this.textBoxApkFilePath.Size = new System.Drawing.Size(200, 20);
            this.textBoxApkFilePath.TabIndex = 7;
            // 
            // labelApkFilePath
            // 
            this.labelApkFilePath.AutoSize = true;
            this.labelApkFilePath.Location = new System.Drawing.Point(16, 165);
            this.labelApkFilePath.Name = "labelApkFilePath";
            this.labelApkFilePath.Size = new System.Drawing.Size(75, 13);
            this.labelApkFilePath.TabIndex = 6;
            this.labelApkFilePath.Text = "APK File Path:";
            // 
            // buttonBrowseApk
            // 
            this.buttonBrowseApk.Location = new System.Drawing.Point(221, 179);
            this.buttonBrowseApk.Name = "buttonBrowseApk";
            this.buttonBrowseApk.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseApk.TabIndex = 8;
            this.buttonBrowseApk.Text = "Browse";
            this.buttonBrowseApk.UseVisualStyleBackColor = true;
            this.buttonBrowseApk.Click += new System.EventHandler(this.buttonBrowseApk_Click);
            // 
            // gamesTabPage
            // 
            this.gamesTabPage.Controls.Add(this.DiscordDownloadButton);
            this.gamesTabPage.Controls.Add(this.listViewGames);
            this.gamesTabPage.Controls.Add(this.labelGames);
            this.gamesTabPage.Location = new System.Drawing.Point(4, 22);
            this.gamesTabPage.Name = "gamesTabPage";
            this.gamesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gamesTabPage.Size = new System.Drawing.Size(392, 274);
            this.gamesTabPage.TabIndex = 2;
            this.gamesTabPage.Text = "Games";
            this.gamesTabPage.UseVisualStyleBackColor = true;
            // 
            // DiscordDownloadButton
            // 
            this.DiscordDownloadButton.Location = new System.Drawing.Point(20, 33);
            this.DiscordDownloadButton.Name = "DiscordDownloadButton";
            this.DiscordDownloadButton.Size = new System.Drawing.Size(166, 23);
            this.DiscordDownloadButton.TabIndex = 2;
            this.DiscordDownloadButton.Text = "Download Discord";
            this.DiscordDownloadButton.UseVisualStyleBackColor = true;
            this.DiscordDownloadButton.Click += new System.EventHandler(this.DiscordDownloadButton_Click);
            // 
            // listViewGames
            // 
            this.listViewGames.HideSelection = false;
            this.listViewGames.LargeImageList = this.imageListGames;
            this.listViewGames.Location = new System.Drawing.Point(9, 22);
            this.listViewGames.Name = "listViewGames";
            this.listViewGames.Size = new System.Drawing.Size(387, 256);
            this.listViewGames.TabIndex = 1;
            this.listViewGames.UseCompatibleStateImageBehavior = false;
            this.listViewGames.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageListGames
            // 
            this.imageListGames.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGames.ImageStream")));
            this.imageListGames.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGames.Images.SetKeyName(0, "OIP.jpg");
            // 
            // labelGames
            // 
            this.labelGames.AutoSize = true;
            this.labelGames.Location = new System.Drawing.Point(6, 6);
            this.labelGames.Name = "labelGames";
            this.labelGames.Size = new System.Drawing.Size(43, 13);
            this.labelGames.TabIndex = 0;
            this.labelGames.Text = "Games:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 321);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Oculus Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.devicesTabPage.ResumeLayout(false);
            this.devicesTabPage.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            this.gamesTabPage.ResumeLayout(false);
            this.gamesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage devicesTabPage;
        private System.Windows.Forms.ListBox devicesListBox;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TabPage gamesTabPage;
        private System.Windows.Forms.Label labelTextureHeightValue;
        private System.Windows.Forms.Label devicebitratelabel;
        private System.Windows.Forms.Label devicecaptureheightlabel;
        private System.Windows.Forms.Label devicecapturewidthlabel;
        private System.Windows.Forms.Label devicefullratecapturelabel;
        private System.Windows.Forms.Label labelTextureHeight;
        private System.Windows.Forms.Label labelTextureWidth;
        private System.Windows.Forms.Label labelGpuLevel;
        private System.Windows.Forms.Label labelCpuLevel;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.TextBox textBoxPropertyValue;
        private System.Windows.Forms.RadioButton radioButtonGPU;
        private System.Windows.Forms.RadioButton radioButtonCPU;
        private System.Windows.Forms.RadioButton radioButtonTexture;
        private System.Windows.Forms.TextBox textBoxApkFilePath;
        private System.Windows.Forms.Label labelApkFilePath;
        private System.Windows.Forms.Button buttonBrowseApk;
        private System.Windows.Forms.ListView listViewGames;
        private System.Windows.Forms.ImageList imageListGames;
        private System.Windows.Forms.Label labelGames;
        private System.Windows.Forms.Label DownloadProcessLabel;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.RadioButton bitrate;
        private System.Windows.Forms.RadioButton capturew;
        private System.Windows.Forms.RadioButton fullRateCapture;
        private System.Windows.Forms.RadioButton captureh;
        private System.Windows.Forms.Button GetLogs;
        private System.Windows.Forms.Button DiscordDownloadButton;
    }
}
