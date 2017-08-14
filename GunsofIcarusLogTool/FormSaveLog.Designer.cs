namespace GunsofIcarusLogTool
{
    partial class FormSaveLog
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelLastWriteDate = new System.Windows.Forms.Label();
            this.buttonAppendTimestamp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxShowInExplorer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "output_log";
            // 
            // textBoxRename
            // 
            this.textBoxRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRename.Location = new System.Drawing.Point(66, 24);
            this.textBoxRename.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRename.Name = "textBoxRename";
            this.textBoxRename.Size = new System.Drawing.Size(232, 20);
            this.textBoxRename.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ".txt";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(247, 72);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelLastWriteDate
            // 
            this.labelLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastWriteDate.AutoSize = true;
            this.labelLastWriteDate.Location = new System.Drawing.Point(6, 56);
            this.labelLastWriteDate.Name = "labelLastWriteDate";
            this.labelLastWriteDate.Size = new System.Drawing.Size(115, 13);
            this.labelLastWriteDate.TabIndex = 5;
            this.labelLastWriteDate.Text = "Last Write Timestamp: ";
            // 
            // buttonAppendTimestamp
            // 
            this.buttonAppendTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAppendTimestamp.AutoSize = true;
            this.buttonAppendTimestamp.Location = new System.Drawing.Point(9, 72);
            this.buttonAppendTimestamp.Name = "buttonAppendTimestamp";
            this.buttonAppendTimestamp.Size = new System.Drawing.Size(108, 23);
            this.buttonAppendTimestamp.TabIndex = 1;
            this.buttonAppendTimestamp.Text = "Append Timestamp";
            this.buttonAppendTimestamp.UseVisualStyleBackColor = true;
            this.buttonAppendTimestamp.Click += new System.EventHandler(this.buttonAppendTimestamp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter custom name or leave blank to use output_log.txt.";
            // 
            // checkBoxShowInExplorer
            // 
            this.checkBoxShowInExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowInExplorer.AutoSize = true;
            this.checkBoxShowInExplorer.Location = new System.Drawing.Point(137, 76);
            this.checkBoxShowInExplorer.Name = "checkBoxShowInExplorer";
            this.checkBoxShowInExplorer.Size = new System.Drawing.Size(104, 17);
            this.checkBoxShowInExplorer.TabIndex = 2;
            this.checkBoxShowInExplorer.Text = "Show in explorer";
            this.checkBoxShowInExplorer.UseVisualStyleBackColor = true;
            // 
            // FormSaveLog
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 101);
            this.Controls.Add(this.checkBoxShowInExplorer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAppendTimestamp);
            this.Controls.Add(this.labelLastWriteDate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRename);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaveLog";
            this.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Log";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelLastWriteDate;
        private System.Windows.Forms.Button buttonAppendTimestamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxShowInExplorer;
    }
}