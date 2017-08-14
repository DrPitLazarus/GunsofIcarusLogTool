namespace GunsofIcarusLogTool
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonAutosavePrompt = new System.Windows.Forms.RadioButton();
            this.radioButtonAutosaveAutomatic = new System.Windows.Forms.RadioButton();
            this.radioButtonAutosaveDisabled = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpenLogFolderAutosave = new System.Windows.Forms.Button();
            this.buttonOpenLogFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSaveMSInfo = new System.Windows.Forms.Button();
            this.buttonSaveDxDiag = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(434, 411);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonOpenLogFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSaveLog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonOpenLog);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonAutosavePrompt);
            this.groupBox3.Controls.Add(this.radioButtonAutosaveAutomatic);
            this.groupBox3.Controls.Add(this.radioButtonAutosaveDisabled);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.buttonOpenLogFolderAutosave);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 270);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autosave";
            // 
            // radioButtonAutosavePrompt
            // 
            this.radioButtonAutosavePrompt.AutoSize = true;
            this.radioButtonAutosavePrompt.Location = new System.Drawing.Point(6, 104);
            this.radioButtonAutosavePrompt.Name = "radioButtonAutosavePrompt";
            this.radioButtonAutosavePrompt.Size = new System.Drawing.Size(58, 17);
            this.radioButtonAutosavePrompt.TabIndex = 18;
            this.radioButtonAutosavePrompt.TabStop = true;
            this.radioButtonAutosavePrompt.Tag = "prompt";
            this.radioButtonAutosavePrompt.Text = "Prompt";
            this.radioButtonAutosavePrompt.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutosaveAutomatic
            // 
            this.radioButtonAutosaveAutomatic.AutoSize = true;
            this.radioButtonAutosaveAutomatic.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonAutosaveAutomatic.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAutosaveAutomatic.Name = "radioButtonAutosaveAutomatic";
            this.radioButtonAutosaveAutomatic.Size = new System.Drawing.Size(72, 17);
            this.radioButtonAutosaveAutomatic.TabIndex = 17;
            this.radioButtonAutosaveAutomatic.TabStop = true;
            this.radioButtonAutosaveAutomatic.Tag = "automatic";
            this.radioButtonAutosaveAutomatic.Text = "Automatic";
            this.radioButtonAutosaveAutomatic.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutosaveDisabled
            // 
            this.radioButtonAutosaveDisabled.AutoSize = true;
            this.radioButtonAutosaveDisabled.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAutosaveDisabled.Name = "radioButtonAutosaveDisabled";
            this.radioButtonAutosaveDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAutosaveDisabled.TabIndex = 16;
            this.radioButtonAutosaveDisabled.TabStop = true;
            this.radioButtonAutosaveDisabled.Tag = "disabled";
            this.radioButtonAutosaveDisabled.Text = "Disabled";
            this.radioButtonAutosaveDisabled.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(32, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Whenever the game is closed, open the Save Log dialog.\r\nYou can customize the fil" +
    "ename and append timestamp or choose not to save.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(32, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Saves the log everytime the game is closed. \r\nFilenames have timestamps appended." +
    "\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Opens the folder where autosaved logs are saved.";
            // 
            // buttonOpenLogFolderAutosave
            // 
            this.buttonOpenLogFolderAutosave.AutoSize = true;
            this.buttonOpenLogFolderAutosave.Location = new System.Drawing.Point(6, 193);
            this.buttonOpenLogFolderAutosave.Name = "buttonOpenLogFolderAutosave";
            this.buttonOpenLogFolderAutosave.Size = new System.Drawing.Size(123, 23);
            this.buttonOpenLogFolderAutosave.TabIndex = 8;
            this.buttonOpenLogFolderAutosave.Text = "Open Autosave Folder";
            this.buttonOpenLogFolderAutosave.UseVisualStyleBackColor = true;
            this.buttonOpenLogFolderAutosave.Click += new System.EventHandler(this.buttonOpenLogFolderAutosave_Click);
            // 
            // buttonOpenLogFolder
            // 
            this.buttonOpenLogFolder.AutoSize = true;
            this.buttonOpenLogFolder.Location = new System.Drawing.Point(6, 48);
            this.buttonOpenLogFolder.Name = "buttonOpenLogFolder";
            this.buttonOpenLogFolder.Size = new System.Drawing.Size(96, 23);
            this.buttonOpenLogFolder.TabIndex = 7;
            this.buttonOpenLogFolder.Text = "Open Log Folder";
            this.buttonOpenLogFolder.UseVisualStyleBackColor = true;
            this.buttonOpenLogFolder.Click += new System.EventHandler(this.buttonOpenLogFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saves the current log. Opens dialog where you can customize \r\nthe name or append " +
    "a timestamp.";
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Location = new System.Drawing.Point(6, 77);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(96, 23);
            this.buttonSaveLog.TabIndex = 1;
            this.buttonSaveLog.Text = "Save Log...";
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opens the current log in default text viewer.";
            // 
            // buttonOpenLog
            // 
            this.buttonOpenLog.Location = new System.Drawing.Point(6, 19);
            this.buttonOpenLog.Name = "buttonOpenLog";
            this.buttonOpenLog.Size = new System.Drawing.Size(96, 23);
            this.buttonOpenLog.TabIndex = 0;
            this.buttonOpenLog.Text = "Open Log";
            this.buttonOpenLog.UseVisualStyleBackColor = true;
            this.buttonOpenLog.Click += new System.EventHandler(this.buttonOpenLog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Opens the folder where the logs are saved.";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(426, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "System";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonSaveMSInfo);
            this.groupBox6.Controls.Add(this.buttonSaveDxDiag);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(420, 379);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DxDiag and MSInfo";
            // 
            // buttonSaveMSInfo
            // 
            this.buttonSaveMSInfo.AutoSize = true;
            this.buttonSaveMSInfo.Location = new System.Drawing.Point(6, 48);
            this.buttonSaveMSInfo.Name = "buttonSaveMSInfo";
            this.buttonSaveMSInfo.Size = new System.Drawing.Size(106, 23);
            this.buttonSaveMSInfo.TabIndex = 3;
            this.buttonSaveMSInfo.Text = "Save MSInfo Data";
            this.buttonSaveMSInfo.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDxDiag
            // 
            this.buttonSaveDxDiag.AutoSize = true;
            this.buttonSaveDxDiag.Location = new System.Drawing.Point(6, 19);
            this.buttonSaveDxDiag.Name = "buttonSaveDxDiag";
            this.buttonSaveDxDiag.Size = new System.Drawing.Size(106, 23);
            this.buttonSaveDxDiag.TabIndex = 2;
            this.buttonSaveDxDiag.Text = "Save DxDiag Data";
            this.buttonSaveDxDiag.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Network";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Config & About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 279);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "About";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxMinimizeToTray);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Config";
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(6, 19);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(98, 17);
            this.checkBoxMinimizeToTray.TabIndex = 0;
            this.checkBoxMinimizeToTray.Text = "Minimize to tray";
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "GoI Log Tool";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Guns of Icarus Log Tool";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.Button buttonOpenLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonOpenLogFolderAutosave;
        private System.Windows.Forms.Button buttonOpenLogFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonSaveMSInfo;
        private System.Windows.Forms.Button buttonSaveDxDiag;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
        private System.Windows.Forms.RadioButton radioButtonAutosavePrompt;
        private System.Windows.Forms.RadioButton radioButtonAutosaveAutomatic;
        private System.Windows.Forms.RadioButton radioButtonAutosaveDisabled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

