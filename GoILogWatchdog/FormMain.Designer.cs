namespace GoILogWatchdog
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBoxNotifyAutosave = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyStartup = new System.Windows.Forms.CheckBox();
            this.checkBoxStartInTray = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabelGithubRepo = new System.Windows.Forms.LinkLabel();
            this.linkLabelGithubProfile = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Text = "GoI Log Watchdog";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 54);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(284, 261);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.checkBoxNotifyAutosave);
            this.tabPageSettings.Controls.Add(this.checkBoxNotifyStartup);
            this.tabPageSettings.Controls.Add(this.checkBoxStartInTray);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(276, 235);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyAutosave
            // 
            this.checkBoxNotifyAutosave.AutoSize = true;
            this.checkBoxNotifyAutosave.Location = new System.Drawing.Point(8, 52);
            this.checkBoxNotifyAutosave.Name = "checkBoxNotifyAutosave";
            this.checkBoxNotifyAutosave.Size = new System.Drawing.Size(103, 17);
            this.checkBoxNotifyAutosave.TabIndex = 2;
            this.checkBoxNotifyAutosave.Tag = "notify_autosave";
            this.checkBoxNotifyAutosave.Text = "Notify autosave.";
            this.checkBoxNotifyAutosave.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyStartup
            // 
            this.checkBoxNotifyStartup.AutoSize = true;
            this.checkBoxNotifyStartup.Location = new System.Drawing.Point(8, 29);
            this.checkBoxNotifyStartup.Name = "checkBoxNotifyStartup";
            this.checkBoxNotifyStartup.Size = new System.Drawing.Size(91, 17);
            this.checkBoxNotifyStartup.TabIndex = 1;
            this.checkBoxNotifyStartup.Tag = "notify_startup";
            this.checkBoxNotifyStartup.Text = "Notify startup.";
            this.checkBoxNotifyStartup.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartInTray
            // 
            this.checkBoxStartInTray.AutoSize = true;
            this.checkBoxStartInTray.Location = new System.Drawing.Point(8, 6);
            this.checkBoxStartInTray.Name = "checkBoxStartInTray";
            this.checkBoxStartInTray.Size = new System.Drawing.Size(82, 17);
            this.checkBoxStartInTray.TabIndex = 0;
            this.checkBoxStartInTray.Tag = "start_in_tray";
            this.checkBoxStartInTray.Text = "Start in tray.";
            this.checkBoxStartInTray.UseVisualStyleBackColor = true;
            this.checkBoxStartInTray.CheckedChanged += new System.EventHandler(this.checkBoxStartInTray_CheckedChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.linkLabelGithubRepo);
            this.tabPageAbout.Controls.Add(this.linkLabelGithubProfile);
            this.tabPageAbout.Controls.Add(this.label2);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelProductName);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(276, 235);
            this.tabPageAbout.TabIndex = 1;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabelGithubRepo
            // 
            this.linkLabelGithubRepo.AutoSize = true;
            this.linkLabelGithubRepo.Location = new System.Drawing.Point(173, 44);
            this.linkLabelGithubRepo.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabelGithubRepo.Name = "linkLabelGithubRepo";
            this.linkLabelGithubRepo.Size = new System.Drawing.Size(69, 13);
            this.linkLabelGithubRepo.TabIndex = 4;
            this.linkLabelGithubRepo.TabStop = true;
            this.linkLabelGithubRepo.Text = "Project Repo";
            this.linkLabelGithubRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithubRepo_LinkClicked);
            // 
            // linkLabelGithubProfile
            // 
            this.linkLabelGithubProfile.AutoSize = true;
            this.linkLabelGithubProfile.Location = new System.Drawing.Point(127, 44);
            this.linkLabelGithubProfile.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabelGithubProfile.Name = "linkLabelGithubProfile";
            this.linkLabelGithubProfile.Size = new System.Drawing.Size(40, 13);
            this.linkLabelGithubProfile.TabIndex = 3;
            this.linkLabelGithubProfile.TabStop = true;
            this.linkLabelGithubProfile.Text = "GitHub";
            this.linkLabelGithubProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithubProfile_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author: Dr. Pit Lazarus";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(8, 25);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(46, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "v1.0.0.0";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(8, 6);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(3);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(98, 13);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "GoI Log Watchdog";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoI Log Watchdog";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.CheckBox checkBoxNotifyStartup;
        private System.Windows.Forms.CheckBox checkBoxStartInTray;
        private System.Windows.Forms.CheckBox checkBoxNotifyAutosave;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabelGithubRepo;
        private System.Windows.Forms.LinkLabel linkLabelGithubProfile;
        private System.Windows.Forms.Label label2;
    }
}

