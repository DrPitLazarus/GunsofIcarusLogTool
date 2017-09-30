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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCrash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBoxStartOnLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyAutosave = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyStartup = new System.Windows.Forms.CheckBox();
            this.checkBoxStartInTray = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabelGithubRepo = new System.Windows.Forms.LinkLabel();
            this.linkLabelGithubProfile = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.tabPageStatus = new System.Windows.Forms.TabPage();
            this.labelGameState = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonOpenWatchdogFolder = new System.Windows.Forms.Button();
            this.groupBoxAbout = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tabPageStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Text = "GoI Log Watchdog";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemBug,
            this.toolStripMenuItemCrash,
            this.toolStripSeparator1,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 120);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "Mark Last Log As";
            // 
            // toolStripMenuItemBug
            // 
            this.toolStripMenuItemBug.Name = "toolStripMenuItemBug";
            this.toolStripMenuItemBug.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemBug.Text = "Bug";
            this.toolStripMenuItemBug.Click += new System.EventHandler(this.toolStripMenuItemBug_Click);
            // 
            // toolStripMenuItemCrash
            // 
            this.toolStripMenuItemCrash.Name = "toolStripMenuItemCrash";
            this.toolStripMenuItemCrash.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemCrash.Text = "Crash";
            this.toolStripMenuItemCrash.Click += new System.EventHandler(this.toolStripMenuItemCrash_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStatus);
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
            this.tabPageSettings.Controls.Add(this.groupBoxSettings);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(276, 235);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartOnLogin
            // 
            this.checkBoxStartOnLogin.AutoSize = true;
            this.checkBoxStartOnLogin.Location = new System.Drawing.Point(6, 178);
            this.checkBoxStartOnLogin.Name = "checkBoxStartOnLogin";
            this.checkBoxStartOnLogin.Size = new System.Drawing.Size(91, 17);
            this.checkBoxStartOnLogin.TabIndex = 3;
            this.checkBoxStartOnLogin.Text = "Start on login.";
            this.checkBoxStartOnLogin.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyAutosave
            // 
            this.checkBoxNotifyAutosave.AutoSize = true;
            this.checkBoxNotifyAutosave.Location = new System.Drawing.Point(6, 130);
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
            this.checkBoxNotifyStartup.Location = new System.Drawing.Point(6, 73);
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
            this.checkBoxStartInTray.Location = new System.Drawing.Point(6, 16);
            this.checkBoxStartInTray.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.checkBoxStartInTray.Name = "checkBoxStartInTray";
            this.checkBoxStartInTray.Size = new System.Drawing.Size(82, 17);
            this.checkBoxStartInTray.TabIndex = 0;
            this.checkBoxStartInTray.Tag = "start_in_tray";
            this.checkBoxStartInTray.Text = "Start in tray.";
            this.checkBoxStartInTray.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.groupBoxAbout);
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
            this.linkLabelGithubRepo.Location = new System.Drawing.Point(84, 57);
            this.linkLabelGithubRepo.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabelGithubRepo.Name = "linkLabelGithubRepo";
            this.linkLabelGithubRepo.Size = new System.Drawing.Size(69, 13);
            this.linkLabelGithubRepo.TabIndex = 4;
            this.linkLabelGithubRepo.TabStop = true;
            this.linkLabelGithubRepo.Text = "GitHub Repo";
            this.linkLabelGithubRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithubRepo_LinkClicked);
            // 
            // linkLabelGithubProfile
            // 
            this.linkLabelGithubProfile.AutoSize = true;
            this.linkLabelGithubProfile.Location = new System.Drawing.Point(6, 57);
            this.linkLabelGithubProfile.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabelGithubProfile.Name = "linkLabelGithubProfile";
            this.linkLabelGithubProfile.Size = new System.Drawing.Size(72, 13);
            this.linkLabelGithubProfile.TabIndex = 3;
            this.linkLabelGithubProfile.TabStop = true;
            this.linkLabelGithubProfile.Text = "GitHub Profile";
            this.linkLabelGithubProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithubProfile_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author: Dr. Pit Lazarus";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(6, 19);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(46, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "v1.0.0.0";
            // 
            // tabPageStatus
            // 
            this.tabPageStatus.Controls.Add(this.buttonOpenWatchdogFolder);
            this.tabPageStatus.Controls.Add(this.labelGameState);
            this.tabPageStatus.Controls.Add(this.groupBox2);
            this.tabPageStatus.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatus.Name = "tabPageStatus";
            this.tabPageStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatus.Size = new System.Drawing.Size(276, 235);
            this.tabPageStatus.TabIndex = 2;
            this.tabPageStatus.Text = "Status";
            this.tabPageStatus.UseVisualStyleBackColor = true;
            // 
            // labelGameState
            // 
            this.labelGameState.Location = new System.Drawing.Point(8, 6);
            this.labelGameState.Margin = new System.Windows.Forms.Padding(3);
            this.labelGameState.Name = "labelGameState";
            this.labelGameState.Size = new System.Drawing.Size(126, 13);
            this.labelGameState.TabIndex = 0;
            this.labelGameState.Text = "Game is not running.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxActivity);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity";
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxActivity.Location = new System.Drawing.Point(3, 16);
            this.textBoxActivity.Multiline = true;
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.ReadOnly = true;
            this.textBoxActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxActivity.Size = new System.Drawing.Size(264, 150);
            this.textBoxActivity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start the program in the background. Can be opened from system tray.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(19, 0, 6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "When \"start in tray\" is ticked, show a notification that the program is running i" +
    "n the background.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(19, 0, 6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shows a notification when a log is autosaved.";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(19, 0, 6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Automatically start the program when you login.";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.label5);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Controls.Add(this.label4);
            this.groupBoxSettings.Controls.Add(this.checkBoxStartInTray);
            this.groupBoxSettings.Controls.Add(this.label3);
            this.groupBoxSettings.Controls.Add(this.checkBoxNotifyStartup);
            this.groupBoxSettings.Controls.Add(this.checkBoxNotifyAutosave);
            this.groupBoxSettings.Controls.Add(this.checkBoxStartOnLogin);
            this.groupBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSettings.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(270, 229);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // buttonOpenWatchdogFolder
            // 
            this.buttonOpenWatchdogFolder.AutoSize = true;
            this.buttonOpenWatchdogFolder.Location = new System.Drawing.Point(140, 6);
            this.buttonOpenWatchdogFolder.Name = "buttonOpenWatchdogFolder";
            this.buttonOpenWatchdogFolder.Size = new System.Drawing.Size(128, 23);
            this.buttonOpenWatchdogFolder.TabIndex = 3;
            this.buttonOpenWatchdogFolder.Text = "Open Watchdog Folder";
            this.buttonOpenWatchdogFolder.UseVisualStyleBackColor = true;
            this.buttonOpenWatchdogFolder.Click += new System.EventHandler(this.buttonOpenWatchdogFolder_Click);
            // 
            // groupBoxAbout
            // 
            this.groupBoxAbout.Controls.Add(this.linkLabelGithubProfile);
            this.groupBoxAbout.Controls.Add(this.linkLabelGithubRepo);
            this.groupBoxAbout.Controls.Add(this.labelVersion);
            this.groupBoxAbout.Controls.Add(this.label2);
            this.groupBoxAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAbout.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAbout.Name = "groupBoxAbout";
            this.groupBoxAbout.Size = new System.Drawing.Size(270, 229);
            this.groupBoxAbout.TabIndex = 5;
            this.groupBoxAbout.TabStop = false;
            this.groupBoxAbout.Text = "GoI Log Watchdog";
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
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageStatus.ResumeLayout(false);
            this.tabPageStatus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxAbout.ResumeLayout(false);
            this.groupBoxAbout.PerformLayout();
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
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabelGithubRepo;
        private System.Windows.Forms.LinkLabel linkLabelGithubProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBug;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCrash;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBoxStartOnLogin;
        private System.Windows.Forms.TabPage tabPageStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelGameState;
        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonOpenWatchdogFolder;
        private System.Windows.Forms.GroupBox groupBoxAbout;
    }
}

