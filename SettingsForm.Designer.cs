namespace Indicator
{
    partial class SettingsForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lockIndicatorsGroupBox = new System.Windows.Forms.GroupBox();
            this.scrollLockIndicatorCheckBox = new System.Windows.Forms.CheckBox();
            this.numLockIndicatorCheckBox = new System.Windows.Forms.CheckBox();
            this.capsLockIndicatorCheckBox = new System.Windows.Forms.CheckBox();
            this.hardDriveIndicatorGroupBox = new System.Windows.Forms.GroupBox();
            this.totalHddIndicatorCheckBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.customLockIndicatorsGroupBox = new System.Windows.Forms.GroupBox();
            this.customCapsLockIconsPanel = new System.Windows.Forms.Panel();
            this.customCapsLockOffIconBrowseButton = new System.Windows.Forms.Button();
            this.customCapsLockOnIconLabel = new System.Windows.Forms.Label();
            this.customCapsLockOnIconBrowseButton = new System.Windows.Forms.Button();
            this.customCapsLockOffIconLabel = new System.Windows.Forms.Label();
            this.customCapsLockOffIconPathBox = new System.Windows.Forms.TextBox();
            this.customCapsLockOnIconPathBox = new System.Windows.Forms.TextBox();
            this.customNumLockIconsPanel = new System.Windows.Forms.Panel();
            this.customNumLockOffIconBrowseButton = new System.Windows.Forms.Button();
            this.customNumLockOnIconLabel = new System.Windows.Forms.Label();
            this.customNumLockOnIconBrowseButton = new System.Windows.Forms.Button();
            this.customNumLockOffIconLabel = new System.Windows.Forms.Label();
            this.customNumLockOffIconPathBox = new System.Windows.Forms.TextBox();
            this.customNumLockOnIconPathBox = new System.Windows.Forms.TextBox();
            this.customScrollLockIconsPanel = new System.Windows.Forms.Panel();
            this.customScrollLockOffIconBrowseButton = new System.Windows.Forms.Button();
            this.customScrollLockOnIconLabel = new System.Windows.Forms.Label();
            this.customScrollLockOnIconBrowseButton = new System.Windows.Forms.Button();
            this.customScrollLockOffIconLabel = new System.Windows.Forms.Label();
            this.customScrollLockOffIconPathBox = new System.Windows.Forms.TextBox();
            this.customScrollLockOnIconPathBox = new System.Windows.Forms.TextBox();
            this.customScrollLockIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.customNumLockIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.customCapsLockIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.customHardDriveIndicatorGroupBox = new System.Windows.Forms.GroupBox();
            this.customTotalHddIconsPanel = new System.Windows.Forms.Panel();
            this.customTotalHddOffIconBrowseButton = new System.Windows.Forms.Button();
            this.customTotalHddOnIconLabel = new System.Windows.Forms.Label();
            this.customTotalHddOnIconBrowseButton = new System.Windows.Forms.Button();
            this.customTotalHddOffIconLabel = new System.Windows.Forms.Label();
            this.customTotalHddOffIconPathBox = new System.Windows.Forms.TextBox();
            this.customTotalHddOnIconPathBox = new System.Windows.Forms.TextBox();
            this.customTotalHddIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.lockIndicatorRefreshTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.hardDriveIndicatorRefreshTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.capsLockIndicatorRefreshTimeLabel = new System.Windows.Forms.Label();
            this.numLockIndicatorRefreshTimeLabel = new System.Windows.Forms.Label();
            this.scrollLockIndicatorRefreshTimeLabel = new System.Windows.Forms.Label();
            this.totalHddIndicatorRefreshTimeLabel = new System.Windows.Forms.Label();
            this.totalHddRefreshTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalHddMsLabel = new System.Windows.Forms.Label();
            this.scrollLockMsLabel = new System.Windows.Forms.Label();
            this.scrollLockRefreshTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.numLockMsLabel = new System.Windows.Forms.Label();
            this.numLockRefreshTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.capsLockMsLabel = new System.Windows.Forms.Label();
            this.capsLockRefreshTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.lockIndicatorsGroupBox.SuspendLayout();
            this.hardDriveIndicatorGroupBox.SuspendLayout();
            this.customLockIndicatorsGroupBox.SuspendLayout();
            this.customCapsLockIconsPanel.SuspendLayout();
            this.customNumLockIconsPanel.SuspendLayout();
            this.customScrollLockIconsPanel.SuspendLayout();
            this.customHardDriveIndicatorGroupBox.SuspendLayout();
            this.customTotalHddIconsPanel.SuspendLayout();
            this.lockIndicatorRefreshTimeGroupBox.SuspendLayout();
            this.hardDriveIndicatorRefreshTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalHddRefreshTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollLockRefreshTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLockRefreshTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capsLockRefreshTimeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lockIndicatorsGroupBox
            // 
            this.lockIndicatorsGroupBox.Controls.Add(this.scrollLockIndicatorCheckBox);
            this.lockIndicatorsGroupBox.Controls.Add(this.numLockIndicatorCheckBox);
            this.lockIndicatorsGroupBox.Controls.Add(this.capsLockIndicatorCheckBox);
            this.lockIndicatorsGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lockIndicatorsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.lockIndicatorsGroupBox.Name = "lockIndicatorsGroupBox";
            this.lockIndicatorsGroupBox.Size = new System.Drawing.Size(235, 90);
            this.lockIndicatorsGroupBox.TabIndex = 2;
            this.lockIndicatorsGroupBox.TabStop = false;
            this.lockIndicatorsGroupBox.Text = "Lock Indicators";
            // 
            // scrollLockIndicatorCheckBox
            // 
            this.scrollLockIndicatorCheckBox.AutoSize = true;
            this.scrollLockIndicatorCheckBox.Location = new System.Drawing.Point(6, 67);
            this.scrollLockIndicatorCheckBox.Name = "scrollLockIndicatorCheckBox";
            this.scrollLockIndicatorCheckBox.Size = new System.Drawing.Size(158, 17);
            this.scrollLockIndicatorCheckBox.TabIndex = 2;
            this.scrollLockIndicatorCheckBox.Text = "Show scroll lock indicator";
            this.scrollLockIndicatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // numLockIndicatorCheckBox
            // 
            this.numLockIndicatorCheckBox.AutoSize = true;
            this.numLockIndicatorCheckBox.Location = new System.Drawing.Point(6, 44);
            this.numLockIndicatorCheckBox.Name = "numLockIndicatorCheckBox";
            this.numLockIndicatorCheckBox.Size = new System.Drawing.Size(154, 17);
            this.numLockIndicatorCheckBox.TabIndex = 1;
            this.numLockIndicatorCheckBox.Text = "Show num lock indicator";
            this.numLockIndicatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // capsLockIndicatorCheckBox
            // 
            this.capsLockIndicatorCheckBox.AutoSize = true;
            this.capsLockIndicatorCheckBox.Location = new System.Drawing.Point(6, 21);
            this.capsLockIndicatorCheckBox.Name = "capsLockIndicatorCheckBox";
            this.capsLockIndicatorCheckBox.Size = new System.Drawing.Size(154, 17);
            this.capsLockIndicatorCheckBox.TabIndex = 0;
            this.capsLockIndicatorCheckBox.Text = "Show caps lock indicator";
            this.capsLockIndicatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // hardDriveIndicatorGroupBox
            // 
            this.hardDriveIndicatorGroupBox.Controls.Add(this.totalHddIndicatorCheckBox);
            this.hardDriveIndicatorGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.hardDriveIndicatorGroupBox.Location = new System.Drawing.Point(12, 108);
            this.hardDriveIndicatorGroupBox.Name = "hardDriveIndicatorGroupBox";
            this.hardDriveIndicatorGroupBox.Size = new System.Drawing.Size(235, 44);
            this.hardDriveIndicatorGroupBox.TabIndex = 3;
            this.hardDriveIndicatorGroupBox.TabStop = false;
            this.hardDriveIndicatorGroupBox.Text = "Hard Drive Indicator";
            // 
            // totalHddIndicatorCheckBox
            // 
            this.totalHddIndicatorCheckBox.AutoSize = true;
            this.totalHddIndicatorCheckBox.Location = new System.Drawing.Point(6, 21);
            this.totalHddIndicatorCheckBox.Name = "totalHddIndicatorCheckBox";
            this.totalHddIndicatorCheckBox.Size = new System.Drawing.Size(220, 17);
            this.totalHddIndicatorCheckBox.TabIndex = 3;
            this.totalHddIndicatorCheckBox.Text = "Show total hard drive usage indicator";
            this.totalHddIndicatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.applyButton.Location = new System.Drawing.Point(1040, 158);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 30;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cancelButton.Location = new System.Drawing.Point(959, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.okButton.Location = new System.Drawing.Point(878, 158);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 28;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // customLockIndicatorsGroupBox
            // 
            this.customLockIndicatorsGroupBox.Controls.Add(this.customCapsLockIconsPanel);
            this.customLockIndicatorsGroupBox.Controls.Add(this.customNumLockIconsPanel);
            this.customLockIndicatorsGroupBox.Controls.Add(this.customScrollLockIconsPanel);
            this.customLockIndicatorsGroupBox.Controls.Add(this.customScrollLockIconsCheckBox);
            this.customLockIndicatorsGroupBox.Controls.Add(this.customNumLockIconsCheckBox);
            this.customLockIndicatorsGroupBox.Controls.Add(this.customCapsLockIconsCheckBox);
            this.customLockIndicatorsGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.customLockIndicatorsGroupBox.Location = new System.Drawing.Point(253, 12);
            this.customLockIndicatorsGroupBox.Name = "customLockIndicatorsGroupBox";
            this.customLockIndicatorsGroupBox.Size = new System.Drawing.Size(602, 90);
            this.customLockIndicatorsGroupBox.TabIndex = 7;
            this.customLockIndicatorsGroupBox.TabStop = false;
            this.customLockIndicatorsGroupBox.Text = "Lock Indicator Icons";
            // 
            // customCapsLockIconsPanel
            // 
            this.customCapsLockIconsPanel.Controls.Add(this.customCapsLockOffIconBrowseButton);
            this.customCapsLockIconsPanel.Controls.Add(this.customCapsLockOnIconLabel);
            this.customCapsLockIconsPanel.Controls.Add(this.customCapsLockOnIconBrowseButton);
            this.customCapsLockIconsPanel.Controls.Add(this.customCapsLockOffIconLabel);
            this.customCapsLockIconsPanel.Controls.Add(this.customCapsLockOffIconPathBox);
            this.customCapsLockIconsPanel.Controls.Add(this.customCapsLockOnIconPathBox);
            this.customCapsLockIconsPanel.Location = new System.Drawing.Point(216, 13);
            this.customCapsLockIconsPanel.Name = "customCapsLockIconsPanel";
            this.customCapsLockIconsPanel.Size = new System.Drawing.Size(380, 27);
            this.customCapsLockIconsPanel.TabIndex = 10;
            // 
            // customCapsLockOffIconBrowseButton
            // 
            this.customCapsLockOffIconBrowseButton.Location = new System.Drawing.Point(322, 3);
            this.customCapsLockOffIconBrowseButton.Name = "customCapsLockOffIconBrowseButton";
            this.customCapsLockOffIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customCapsLockOffIconBrowseButton.TabIndex = 8;
            this.customCapsLockOffIconBrowseButton.Text = "Browse";
            this.customCapsLockOffIconBrowseButton.UseVisualStyleBackColor = true;
            this.customCapsLockOffIconBrowseButton.Click += new System.EventHandler(this.customCapsLockOffIconBrowseButton_Click);
            // 
            // customCapsLockOnIconLabel
            // 
            this.customCapsLockOnIconLabel.AutoSize = true;
            this.customCapsLockOnIconLabel.Location = new System.Drawing.Point(3, 9);
            this.customCapsLockOnIconLabel.Name = "customCapsLockOnIconLabel";
            this.customCapsLockOnIconLabel.Size = new System.Drawing.Size(51, 13);
            this.customCapsLockOnIconLabel.TabIndex = 18;
            this.customCapsLockOnIconLabel.Text = "On icon:";
            // 
            // customCapsLockOnIconBrowseButton
            // 
            this.customCapsLockOnIconBrowseButton.Location = new System.Drawing.Point(132, 3);
            this.customCapsLockOnIconBrowseButton.Name = "customCapsLockOnIconBrowseButton";
            this.customCapsLockOnIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customCapsLockOnIconBrowseButton.TabIndex = 6;
            this.customCapsLockOnIconBrowseButton.Text = "Browse";
            this.customCapsLockOnIconBrowseButton.UseVisualStyleBackColor = true;
            this.customCapsLockOnIconBrowseButton.Click += new System.EventHandler(this.customCapsLockOnIconBrowseButton_Click);
            // 
            // customCapsLockOffIconLabel
            // 
            this.customCapsLockOffIconLabel.AutoSize = true;
            this.customCapsLockOffIconLabel.Location = new System.Drawing.Point(193, 9);
            this.customCapsLockOffIconLabel.Name = "customCapsLockOffIconLabel";
            this.customCapsLockOffIconLabel.Size = new System.Drawing.Size(52, 13);
            this.customCapsLockOffIconLabel.TabIndex = 21;
            this.customCapsLockOffIconLabel.Text = "Off icon:";
            // 
            // customCapsLockOffIconPathBox
            // 
            this.customCapsLockOffIconPathBox.Location = new System.Drawing.Point(246, 5);
            this.customCapsLockOffIconPathBox.Name = "customCapsLockOffIconPathBox";
            this.customCapsLockOffIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customCapsLockOffIconPathBox.TabIndex = 7;
            // 
            // customCapsLockOnIconPathBox
            // 
            this.customCapsLockOnIconPathBox.Location = new System.Drawing.Point(56, 5);
            this.customCapsLockOnIconPathBox.Name = "customCapsLockOnIconPathBox";
            this.customCapsLockOnIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customCapsLockOnIconPathBox.TabIndex = 5;
            // 
            // customNumLockIconsPanel
            // 
            this.customNumLockIconsPanel.Controls.Add(this.customNumLockOffIconBrowseButton);
            this.customNumLockIconsPanel.Controls.Add(this.customNumLockOnIconLabel);
            this.customNumLockIconsPanel.Controls.Add(this.customNumLockOnIconBrowseButton);
            this.customNumLockIconsPanel.Controls.Add(this.customNumLockOffIconLabel);
            this.customNumLockIconsPanel.Controls.Add(this.customNumLockOffIconPathBox);
            this.customNumLockIconsPanel.Controls.Add(this.customNumLockOnIconPathBox);
            this.customNumLockIconsPanel.Location = new System.Drawing.Point(216, 36);
            this.customNumLockIconsPanel.Name = "customNumLockIconsPanel";
            this.customNumLockIconsPanel.Size = new System.Drawing.Size(380, 27);
            this.customNumLockIconsPanel.TabIndex = 10;
            // 
            // customNumLockOffIconBrowseButton
            // 
            this.customNumLockOffIconBrowseButton.Location = new System.Drawing.Point(322, 3);
            this.customNumLockOffIconBrowseButton.Name = "customNumLockOffIconBrowseButton";
            this.customNumLockOffIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customNumLockOffIconBrowseButton.TabIndex = 13;
            this.customNumLockOffIconBrowseButton.Text = "Browse";
            this.customNumLockOffIconBrowseButton.UseVisualStyleBackColor = true;
            this.customNumLockOffIconBrowseButton.Click += new System.EventHandler(this.customNumLockOffIconBrowseButton_Click);
            // 
            // customNumLockOnIconLabel
            // 
            this.customNumLockOnIconLabel.AutoSize = true;
            this.customNumLockOnIconLabel.Location = new System.Drawing.Point(3, 9);
            this.customNumLockOnIconLabel.Name = "customNumLockOnIconLabel";
            this.customNumLockOnIconLabel.Size = new System.Drawing.Size(51, 13);
            this.customNumLockOnIconLabel.TabIndex = 18;
            this.customNumLockOnIconLabel.Text = "On icon:";
            // 
            // customNumLockOnIconBrowseButton
            // 
            this.customNumLockOnIconBrowseButton.Location = new System.Drawing.Point(132, 3);
            this.customNumLockOnIconBrowseButton.Name = "customNumLockOnIconBrowseButton";
            this.customNumLockOnIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customNumLockOnIconBrowseButton.TabIndex = 11;
            this.customNumLockOnIconBrowseButton.Text = "Browse";
            this.customNumLockOnIconBrowseButton.UseVisualStyleBackColor = true;
            this.customNumLockOnIconBrowseButton.Click += new System.EventHandler(this.customNumLockOnIconBrowseButton_Click);
            // 
            // customNumLockOffIconLabel
            // 
            this.customNumLockOffIconLabel.AutoSize = true;
            this.customNumLockOffIconLabel.Location = new System.Drawing.Point(193, 9);
            this.customNumLockOffIconLabel.Name = "customNumLockOffIconLabel";
            this.customNumLockOffIconLabel.Size = new System.Drawing.Size(52, 13);
            this.customNumLockOffIconLabel.TabIndex = 21;
            this.customNumLockOffIconLabel.Text = "Off icon:";
            // 
            // customNumLockOffIconPathBox
            // 
            this.customNumLockOffIconPathBox.Location = new System.Drawing.Point(246, 5);
            this.customNumLockOffIconPathBox.Name = "customNumLockOffIconPathBox";
            this.customNumLockOffIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customNumLockOffIconPathBox.TabIndex = 12;
            // 
            // customNumLockOnIconPathBox
            // 
            this.customNumLockOnIconPathBox.Location = new System.Drawing.Point(56, 5);
            this.customNumLockOnIconPathBox.Name = "customNumLockOnIconPathBox";
            this.customNumLockOnIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customNumLockOnIconPathBox.TabIndex = 10;
            // 
            // customScrollLockIconsPanel
            // 
            this.customScrollLockIconsPanel.Controls.Add(this.customScrollLockOffIconBrowseButton);
            this.customScrollLockIconsPanel.Controls.Add(this.customScrollLockOnIconLabel);
            this.customScrollLockIconsPanel.Controls.Add(this.customScrollLockOnIconBrowseButton);
            this.customScrollLockIconsPanel.Controls.Add(this.customScrollLockOffIconLabel);
            this.customScrollLockIconsPanel.Controls.Add(this.customScrollLockOffIconPathBox);
            this.customScrollLockIconsPanel.Controls.Add(this.customScrollLockOnIconPathBox);
            this.customScrollLockIconsPanel.Location = new System.Drawing.Point(216, 59);
            this.customScrollLockIconsPanel.Name = "customScrollLockIconsPanel";
            this.customScrollLockIconsPanel.Size = new System.Drawing.Size(380, 27);
            this.customScrollLockIconsPanel.TabIndex = 10;
            // 
            // customScrollLockOffIconBrowseButton
            // 
            this.customScrollLockOffIconBrowseButton.Location = new System.Drawing.Point(322, 3);
            this.customScrollLockOffIconBrowseButton.Name = "customScrollLockOffIconBrowseButton";
            this.customScrollLockOffIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customScrollLockOffIconBrowseButton.TabIndex = 18;
            this.customScrollLockOffIconBrowseButton.Text = "Browse";
            this.customScrollLockOffIconBrowseButton.UseVisualStyleBackColor = true;
            this.customScrollLockOffIconBrowseButton.Click += new System.EventHandler(this.customScrollLockOffIconBrowseButton_Click);
            // 
            // customScrollLockOnIconLabel
            // 
            this.customScrollLockOnIconLabel.AutoSize = true;
            this.customScrollLockOnIconLabel.Location = new System.Drawing.Point(3, 9);
            this.customScrollLockOnIconLabel.Name = "customScrollLockOnIconLabel";
            this.customScrollLockOnIconLabel.Size = new System.Drawing.Size(51, 13);
            this.customScrollLockOnIconLabel.TabIndex = 18;
            this.customScrollLockOnIconLabel.Text = "On icon:";
            // 
            // customScrollLockOnIconBrowseButton
            // 
            this.customScrollLockOnIconBrowseButton.Location = new System.Drawing.Point(132, 3);
            this.customScrollLockOnIconBrowseButton.Name = "customScrollLockOnIconBrowseButton";
            this.customScrollLockOnIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customScrollLockOnIconBrowseButton.TabIndex = 16;
            this.customScrollLockOnIconBrowseButton.Text = "Browse";
            this.customScrollLockOnIconBrowseButton.UseVisualStyleBackColor = true;
            this.customScrollLockOnIconBrowseButton.Click += new System.EventHandler(this.customScrollLockOnIconBrowseButton_Click);
            // 
            // customScrollLockOffIconLabel
            // 
            this.customScrollLockOffIconLabel.AutoSize = true;
            this.customScrollLockOffIconLabel.Location = new System.Drawing.Point(193, 9);
            this.customScrollLockOffIconLabel.Name = "customScrollLockOffIconLabel";
            this.customScrollLockOffIconLabel.Size = new System.Drawing.Size(52, 13);
            this.customScrollLockOffIconLabel.TabIndex = 21;
            this.customScrollLockOffIconLabel.Text = "Off icon:";
            // 
            // customScrollLockOffIconPathBox
            // 
            this.customScrollLockOffIconPathBox.Location = new System.Drawing.Point(246, 5);
            this.customScrollLockOffIconPathBox.Name = "customScrollLockOffIconPathBox";
            this.customScrollLockOffIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customScrollLockOffIconPathBox.TabIndex = 17;
            // 
            // customScrollLockOnIconPathBox
            // 
            this.customScrollLockOnIconPathBox.Location = new System.Drawing.Point(56, 5);
            this.customScrollLockOnIconPathBox.Name = "customScrollLockOnIconPathBox";
            this.customScrollLockOnIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customScrollLockOnIconPathBox.TabIndex = 15;
            // 
            // customScrollLockIconsCheckBox
            // 
            this.customScrollLockIconsCheckBox.AutoSize = true;
            this.customScrollLockIconsCheckBox.Location = new System.Drawing.Point(6, 67);
            this.customScrollLockIconsCheckBox.Name = "customScrollLockIconsCheckBox";
            this.customScrollLockIconsCheckBox.Size = new System.Drawing.Size(169, 17);
            this.customScrollLockIconsCheckBox.TabIndex = 14;
            this.customScrollLockIconsCheckBox.Text = "Use custom scroll lock icons";
            this.customScrollLockIconsCheckBox.UseVisualStyleBackColor = true;
            this.customScrollLockIconsCheckBox.CheckedChanged += new System.EventHandler(this.customScrollLockIconsCheckBox_CheckedChanged);
            // 
            // customNumLockIconsCheckBox
            // 
            this.customNumLockIconsCheckBox.AutoSize = true;
            this.customNumLockIconsCheckBox.Location = new System.Drawing.Point(6, 44);
            this.customNumLockIconsCheckBox.Name = "customNumLockIconsCheckBox";
            this.customNumLockIconsCheckBox.Size = new System.Drawing.Size(165, 17);
            this.customNumLockIconsCheckBox.TabIndex = 9;
            this.customNumLockIconsCheckBox.Text = "Use custom num lock icons";
            this.customNumLockIconsCheckBox.UseVisualStyleBackColor = true;
            this.customNumLockIconsCheckBox.CheckedChanged += new System.EventHandler(this.customNumLockIconsCheckBox_CheckedChanged);
            // 
            // customCapsLockIconsCheckBox
            // 
            this.customCapsLockIconsCheckBox.AutoSize = true;
            this.customCapsLockIconsCheckBox.Location = new System.Drawing.Point(6, 21);
            this.customCapsLockIconsCheckBox.Name = "customCapsLockIconsCheckBox";
            this.customCapsLockIconsCheckBox.Size = new System.Drawing.Size(165, 17);
            this.customCapsLockIconsCheckBox.TabIndex = 4;
            this.customCapsLockIconsCheckBox.Text = "Use custom caps lock icons";
            this.customCapsLockIconsCheckBox.UseVisualStyleBackColor = true;
            this.customCapsLockIconsCheckBox.CheckedChanged += new System.EventHandler(this.customCapsLockIconsCheckBox_CheckedChanged);
            // 
            // customHardDriveIndicatorGroupBox
            // 
            this.customHardDriveIndicatorGroupBox.Controls.Add(this.customTotalHddIconsPanel);
            this.customHardDriveIndicatorGroupBox.Controls.Add(this.customTotalHddIconsCheckBox);
            this.customHardDriveIndicatorGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.customHardDriveIndicatorGroupBox.Location = new System.Drawing.Point(253, 108);
            this.customHardDriveIndicatorGroupBox.Name = "customHardDriveIndicatorGroupBox";
            this.customHardDriveIndicatorGroupBox.Size = new System.Drawing.Size(602, 44);
            this.customHardDriveIndicatorGroupBox.TabIndex = 8;
            this.customHardDriveIndicatorGroupBox.TabStop = false;
            this.customHardDriveIndicatorGroupBox.Text = "Hard Drive Indicator Icons";
            // 
            // customTotalHddIconsPanel
            // 
            this.customTotalHddIconsPanel.Controls.Add(this.customTotalHddOffIconBrowseButton);
            this.customTotalHddIconsPanel.Controls.Add(this.customTotalHddOnIconLabel);
            this.customTotalHddIconsPanel.Controls.Add(this.customTotalHddOnIconBrowseButton);
            this.customTotalHddIconsPanel.Controls.Add(this.customTotalHddOffIconLabel);
            this.customTotalHddIconsPanel.Controls.Add(this.customTotalHddOffIconPathBox);
            this.customTotalHddIconsPanel.Controls.Add(this.customTotalHddOnIconPathBox);
            this.customTotalHddIconsPanel.Location = new System.Drawing.Point(216, 13);
            this.customTotalHddIconsPanel.Name = "customTotalHddIconsPanel";
            this.customTotalHddIconsPanel.Size = new System.Drawing.Size(380, 27);
            this.customTotalHddIconsPanel.TabIndex = 10;
            // 
            // customTotalHddOffIconBrowseButton
            // 
            this.customTotalHddOffIconBrowseButton.Location = new System.Drawing.Point(322, 3);
            this.customTotalHddOffIconBrowseButton.Name = "customTotalHddOffIconBrowseButton";
            this.customTotalHddOffIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customTotalHddOffIconBrowseButton.TabIndex = 23;
            this.customTotalHddOffIconBrowseButton.Text = "Browse";
            this.customTotalHddOffIconBrowseButton.UseVisualStyleBackColor = true;
            this.customTotalHddOffIconBrowseButton.Click += new System.EventHandler(this.customTotalHddOffIconBrowseButton_Click);
            // 
            // customTotalHddOnIconLabel
            // 
            this.customTotalHddOnIconLabel.AutoSize = true;
            this.customTotalHddOnIconLabel.Location = new System.Drawing.Point(3, 9);
            this.customTotalHddOnIconLabel.Name = "customTotalHddOnIconLabel";
            this.customTotalHddOnIconLabel.Size = new System.Drawing.Size(51, 13);
            this.customTotalHddOnIconLabel.TabIndex = 18;
            this.customTotalHddOnIconLabel.Text = "On icon:";
            // 
            // customTotalHddOnIconBrowseButton
            // 
            this.customTotalHddOnIconBrowseButton.Location = new System.Drawing.Point(132, 3);
            this.customTotalHddOnIconBrowseButton.Name = "customTotalHddOnIconBrowseButton";
            this.customTotalHddOnIconBrowseButton.Size = new System.Drawing.Size(55, 23);
            this.customTotalHddOnIconBrowseButton.TabIndex = 21;
            this.customTotalHddOnIconBrowseButton.Text = "Browse";
            this.customTotalHddOnIconBrowseButton.UseVisualStyleBackColor = true;
            this.customTotalHddOnIconBrowseButton.Click += new System.EventHandler(this.customTotalHddOnIconBrowseButton_Click);
            // 
            // customTotalHddOffIconLabel
            // 
            this.customTotalHddOffIconLabel.AutoSize = true;
            this.customTotalHddOffIconLabel.Location = new System.Drawing.Point(193, 9);
            this.customTotalHddOffIconLabel.Name = "customTotalHddOffIconLabel";
            this.customTotalHddOffIconLabel.Size = new System.Drawing.Size(52, 13);
            this.customTotalHddOffIconLabel.TabIndex = 21;
            this.customTotalHddOffIconLabel.Text = "Off icon:";
            // 
            // customTotalHddOffIconPathBox
            // 
            this.customTotalHddOffIconPathBox.Location = new System.Drawing.Point(246, 5);
            this.customTotalHddOffIconPathBox.Name = "customTotalHddOffIconPathBox";
            this.customTotalHddOffIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customTotalHddOffIconPathBox.TabIndex = 22;
            // 
            // customTotalHddOnIconPathBox
            // 
            this.customTotalHddOnIconPathBox.Location = new System.Drawing.Point(56, 5);
            this.customTotalHddOnIconPathBox.Name = "customTotalHddOnIconPathBox";
            this.customTotalHddOnIconPathBox.Size = new System.Drawing.Size(70, 22);
            this.customTotalHddOnIconPathBox.TabIndex = 20;
            // 
            // customTotalHddIconsCheckBox
            // 
            this.customTotalHddIconsCheckBox.AutoSize = true;
            this.customTotalHddIconsCheckBox.Location = new System.Drawing.Point(6, 21);
            this.customTotalHddIconsCheckBox.Name = "customTotalHddIconsCheckBox";
            this.customTotalHddIconsCheckBox.Size = new System.Drawing.Size(204, 17);
            this.customTotalHddIconsCheckBox.TabIndex = 19;
            this.customTotalHddIconsCheckBox.Text = "Use custom hard drive usage icons";
            this.customTotalHddIconsCheckBox.UseVisualStyleBackColor = true;
            this.customTotalHddIconsCheckBox.CheckedChanged += new System.EventHandler(this.customTotalHddIconsCheckBox_CheckedChanged);
            // 
            // lockIndicatorRefreshTimeGroupBox
            // 
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.capsLockMsLabel);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.capsLockRefreshTimeUpDown);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.numLockMsLabel);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.numLockRefreshTimeUpDown);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.scrollLockMsLabel);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.scrollLockIndicatorRefreshTimeLabel);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.scrollLockRefreshTimeUpDown);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.numLockIndicatorRefreshTimeLabel);
            this.lockIndicatorRefreshTimeGroupBox.Controls.Add(this.capsLockIndicatorRefreshTimeLabel);
            this.lockIndicatorRefreshTimeGroupBox.Location = new System.Drawing.Point(861, 12);
            this.lockIndicatorRefreshTimeGroupBox.Name = "lockIndicatorRefreshTimeGroupBox";
            this.lockIndicatorRefreshTimeGroupBox.Size = new System.Drawing.Size(254, 90);
            this.lockIndicatorRefreshTimeGroupBox.TabIndex = 9;
            this.lockIndicatorRefreshTimeGroupBox.TabStop = false;
            this.lockIndicatorRefreshTimeGroupBox.Text = "Lock Indicator Refresh Time";
            // 
            // hardDriveIndicatorRefreshTimeGroupBox
            // 
            this.hardDriveIndicatorRefreshTimeGroupBox.Controls.Add(this.totalHddMsLabel);
            this.hardDriveIndicatorRefreshTimeGroupBox.Controls.Add(this.totalHddRefreshTimeUpDown);
            this.hardDriveIndicatorRefreshTimeGroupBox.Controls.Add(this.totalHddIndicatorRefreshTimeLabel);
            this.hardDriveIndicatorRefreshTimeGroupBox.Location = new System.Drawing.Point(861, 108);
            this.hardDriveIndicatorRefreshTimeGroupBox.Name = "hardDriveIndicatorRefreshTimeGroupBox";
            this.hardDriveIndicatorRefreshTimeGroupBox.Size = new System.Drawing.Size(254, 44);
            this.hardDriveIndicatorRefreshTimeGroupBox.TabIndex = 10;
            this.hardDriveIndicatorRefreshTimeGroupBox.TabStop = false;
            this.hardDriveIndicatorRefreshTimeGroupBox.Text = "Hard Drive Indicator Refresh Time";
            // 
            // capsLockIndicatorRefreshTimeLabel
            // 
            this.capsLockIndicatorRefreshTimeLabel.AutoSize = true;
            this.capsLockIndicatorRefreshTimeLabel.Location = new System.Drawing.Point(6, 22);
            this.capsLockIndicatorRefreshTimeLabel.Name = "capsLockIndicatorRefreshTimeLabel";
            this.capsLockIndicatorRefreshTimeLabel.Size = new System.Drawing.Size(123, 13);
            this.capsLockIndicatorRefreshTimeLabel.TabIndex = 0;
            this.capsLockIndicatorRefreshTimeLabel.Text = "Caps lock refresh time:";
            // 
            // numLockIndicatorRefreshTimeLabel
            // 
            this.numLockIndicatorRefreshTimeLabel.AutoSize = true;
            this.numLockIndicatorRefreshTimeLabel.Location = new System.Drawing.Point(6, 45);
            this.numLockIndicatorRefreshTimeLabel.Name = "numLockIndicatorRefreshTimeLabel";
            this.numLockIndicatorRefreshTimeLabel.Size = new System.Drawing.Size(122, 13);
            this.numLockIndicatorRefreshTimeLabel.TabIndex = 1;
            this.numLockIndicatorRefreshTimeLabel.Text = "Num lock refresh time:";
            // 
            // scrollLockIndicatorRefreshTimeLabel
            // 
            this.scrollLockIndicatorRefreshTimeLabel.AutoSize = true;
            this.scrollLockIndicatorRefreshTimeLabel.Location = new System.Drawing.Point(6, 68);
            this.scrollLockIndicatorRefreshTimeLabel.Name = "scrollLockIndicatorRefreshTimeLabel";
            this.scrollLockIndicatorRefreshTimeLabel.Size = new System.Drawing.Size(126, 13);
            this.scrollLockIndicatorRefreshTimeLabel.TabIndex = 2;
            this.scrollLockIndicatorRefreshTimeLabel.Text = "Scroll lock refresh time:";
            // 
            // totalHddIndicatorRefreshTimeLabel
            // 
            this.totalHddIndicatorRefreshTimeLabel.AutoSize = true;
            this.totalHddIndicatorRefreshTimeLabel.Location = new System.Drawing.Point(6, 22);
            this.totalHddIndicatorRefreshTimeLabel.Name = "totalHddIndicatorRefreshTimeLabel";
            this.totalHddIndicatorRefreshTimeLabel.Size = new System.Drawing.Size(161, 13);
            this.totalHddIndicatorRefreshTimeLabel.TabIndex = 3;
            this.totalHddIndicatorRefreshTimeLabel.Text = "Hard drive usage refresh time:";
            // 
            // totalHddRefreshTimeUpDown
            // 
            this.totalHddRefreshTimeUpDown.Location = new System.Drawing.Point(173, 17);
            this.totalHddRefreshTimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.totalHddRefreshTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalHddRefreshTimeUpDown.Name = "totalHddRefreshTimeUpDown";
            this.totalHddRefreshTimeUpDown.Size = new System.Drawing.Size(53, 22);
            this.totalHddRefreshTimeUpDown.TabIndex = 27;
            this.totalHddRefreshTimeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // totalHddMsLabel
            // 
            this.totalHddMsLabel.AutoSize = true;
            this.totalHddMsLabel.Location = new System.Drawing.Point(227, 22);
            this.totalHddMsLabel.Name = "totalHddMsLabel";
            this.totalHddMsLabel.Size = new System.Drawing.Size(21, 13);
            this.totalHddMsLabel.TabIndex = 11;
            this.totalHddMsLabel.Text = "ms";
            // 
            // scrollLockMsLabel
            // 
            this.scrollLockMsLabel.AutoSize = true;
            this.scrollLockMsLabel.Location = new System.Drawing.Point(227, 68);
            this.scrollLockMsLabel.Name = "scrollLockMsLabel";
            this.scrollLockMsLabel.Size = new System.Drawing.Size(21, 13);
            this.scrollLockMsLabel.TabIndex = 12;
            this.scrollLockMsLabel.Text = "ms";
            // 
            // scrollLockRefreshTimeUpDown
            // 
            this.scrollLockRefreshTimeUpDown.Location = new System.Drawing.Point(173, 63);
            this.scrollLockRefreshTimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.scrollLockRefreshTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scrollLockRefreshTimeUpDown.Name = "scrollLockRefreshTimeUpDown";
            this.scrollLockRefreshTimeUpDown.Size = new System.Drawing.Size(53, 22);
            this.scrollLockRefreshTimeUpDown.TabIndex = 26;
            this.scrollLockRefreshTimeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numLockMsLabel
            // 
            this.numLockMsLabel.AutoSize = true;
            this.numLockMsLabel.Location = new System.Drawing.Point(227, 45);
            this.numLockMsLabel.Name = "numLockMsLabel";
            this.numLockMsLabel.Size = new System.Drawing.Size(21, 13);
            this.numLockMsLabel.TabIndex = 12;
            this.numLockMsLabel.Text = "ms";
            // 
            // numLockRefreshTimeUpDown
            // 
            this.numLockRefreshTimeUpDown.Location = new System.Drawing.Point(173, 40);
            this.numLockRefreshTimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLockRefreshTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLockRefreshTimeUpDown.Name = "numLockRefreshTimeUpDown";
            this.numLockRefreshTimeUpDown.Size = new System.Drawing.Size(53, 22);
            this.numLockRefreshTimeUpDown.TabIndex = 25;
            this.numLockRefreshTimeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // capsLockMsLabel
            // 
            this.capsLockMsLabel.AutoSize = true;
            this.capsLockMsLabel.Location = new System.Drawing.Point(227, 22);
            this.capsLockMsLabel.Name = "capsLockMsLabel";
            this.capsLockMsLabel.Size = new System.Drawing.Size(21, 13);
            this.capsLockMsLabel.TabIndex = 14;
            this.capsLockMsLabel.Text = "ms";
            // 
            // capsLockRefreshTimeUpDown
            // 
            this.capsLockRefreshTimeUpDown.Location = new System.Drawing.Point(173, 17);
            this.capsLockRefreshTimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.capsLockRefreshTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.capsLockRefreshTimeUpDown.Name = "capsLockRefreshTimeUpDown";
            this.capsLockRefreshTimeUpDown.Size = new System.Drawing.Size(53, 22);
            this.capsLockRefreshTimeUpDown.TabIndex = 24;
            this.capsLockRefreshTimeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 193);
            this.Controls.Add(this.hardDriveIndicatorRefreshTimeGroupBox);
            this.Controls.Add(this.lockIndicatorRefreshTimeGroupBox);
            this.Controls.Add(this.customHardDriveIndicatorGroupBox);
            this.Controls.Add(this.customLockIndicatorsGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.hardDriveIndicatorGroupBox);
            this.Controls.Add(this.lockIndicatorsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Indicator - Settings";
            this.lockIndicatorsGroupBox.ResumeLayout(false);
            this.lockIndicatorsGroupBox.PerformLayout();
            this.hardDriveIndicatorGroupBox.ResumeLayout(false);
            this.hardDriveIndicatorGroupBox.PerformLayout();
            this.customLockIndicatorsGroupBox.ResumeLayout(false);
            this.customLockIndicatorsGroupBox.PerformLayout();
            this.customCapsLockIconsPanel.ResumeLayout(false);
            this.customCapsLockIconsPanel.PerformLayout();
            this.customNumLockIconsPanel.ResumeLayout(false);
            this.customNumLockIconsPanel.PerformLayout();
            this.customScrollLockIconsPanel.ResumeLayout(false);
            this.customScrollLockIconsPanel.PerformLayout();
            this.customHardDriveIndicatorGroupBox.ResumeLayout(false);
            this.customHardDriveIndicatorGroupBox.PerformLayout();
            this.customTotalHddIconsPanel.ResumeLayout(false);
            this.customTotalHddIconsPanel.PerformLayout();
            this.lockIndicatorRefreshTimeGroupBox.ResumeLayout(false);
            this.lockIndicatorRefreshTimeGroupBox.PerformLayout();
            this.hardDriveIndicatorRefreshTimeGroupBox.ResumeLayout(false);
            this.hardDriveIndicatorRefreshTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalHddRefreshTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrollLockRefreshTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLockRefreshTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capsLockRefreshTimeUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lockIndicatorsGroupBox;
        private System.Windows.Forms.CheckBox numLockIndicatorCheckBox;
        private System.Windows.Forms.CheckBox capsLockIndicatorCheckBox;
        private System.Windows.Forms.CheckBox scrollLockIndicatorCheckBox;
        private System.Windows.Forms.GroupBox hardDriveIndicatorGroupBox;
        private System.Windows.Forms.CheckBox totalHddIndicatorCheckBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox customLockIndicatorsGroupBox;
        private System.Windows.Forms.GroupBox customHardDriveIndicatorGroupBox;
        private System.Windows.Forms.CheckBox customCapsLockIconsCheckBox;
        private System.Windows.Forms.CheckBox customScrollLockIconsCheckBox;
        private System.Windows.Forms.CheckBox customNumLockIconsCheckBox;
        private System.Windows.Forms.CheckBox customTotalHddIconsCheckBox;
        private System.Windows.Forms.Panel customCapsLockIconsPanel;
        private System.Windows.Forms.Button customCapsLockOffIconBrowseButton;
        private System.Windows.Forms.Label customCapsLockOnIconLabel;
        private System.Windows.Forms.Button customCapsLockOnIconBrowseButton;
        private System.Windows.Forms.Label customCapsLockOffIconLabel;
        private System.Windows.Forms.TextBox customCapsLockOffIconPathBox;
        private System.Windows.Forms.TextBox customCapsLockOnIconPathBox;
        private System.Windows.Forms.Panel customNumLockIconsPanel;
        private System.Windows.Forms.Button customNumLockOffIconBrowseButton;
        private System.Windows.Forms.Label customNumLockOnIconLabel;
        private System.Windows.Forms.Button customNumLockOnIconBrowseButton;
        private System.Windows.Forms.Label customNumLockOffIconLabel;
        private System.Windows.Forms.TextBox customNumLockOffIconPathBox;
        private System.Windows.Forms.TextBox customNumLockOnIconPathBox;
        private System.Windows.Forms.Panel customScrollLockIconsPanel;
        private System.Windows.Forms.Button customScrollLockOffIconBrowseButton;
        private System.Windows.Forms.Label customScrollLockOnIconLabel;
        private System.Windows.Forms.Button customScrollLockOnIconBrowseButton;
        private System.Windows.Forms.Label customScrollLockOffIconLabel;
        private System.Windows.Forms.TextBox customScrollLockOffIconPathBox;
        private System.Windows.Forms.TextBox customScrollLockOnIconPathBox;
        private System.Windows.Forms.Panel customTotalHddIconsPanel;
        private System.Windows.Forms.Button customTotalHddOffIconBrowseButton;
        private System.Windows.Forms.Label customTotalHddOnIconLabel;
        private System.Windows.Forms.Button customTotalHddOnIconBrowseButton;
        private System.Windows.Forms.Label customTotalHddOffIconLabel;
        private System.Windows.Forms.TextBox customTotalHddOffIconPathBox;
        private System.Windows.Forms.TextBox customTotalHddOnIconPathBox;
        private System.Windows.Forms.GroupBox lockIndicatorRefreshTimeGroupBox;
        private System.Windows.Forms.GroupBox hardDriveIndicatorRefreshTimeGroupBox;
        private System.Windows.Forms.Label scrollLockIndicatorRefreshTimeLabel;
        private System.Windows.Forms.Label numLockIndicatorRefreshTimeLabel;
        private System.Windows.Forms.Label capsLockIndicatorRefreshTimeLabel;
        private System.Windows.Forms.Label totalHddIndicatorRefreshTimeLabel;
        private System.Windows.Forms.NumericUpDown totalHddRefreshTimeUpDown;
        private System.Windows.Forms.Label totalHddMsLabel;
        private System.Windows.Forms.Label capsLockMsLabel;
        private System.Windows.Forms.NumericUpDown capsLockRefreshTimeUpDown;
        private System.Windows.Forms.Label numLockMsLabel;
        private System.Windows.Forms.NumericUpDown numLockRefreshTimeUpDown;
        private System.Windows.Forms.Label scrollLockMsLabel;
        private System.Windows.Forms.NumericUpDown scrollLockRefreshTimeUpDown;
    }
}