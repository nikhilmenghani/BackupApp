namespace BackupApp
{
    partial class MyForm
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
            this.startBackup = new System.Windows.Forms.Button();
            this.btnBrowseInputDirectory = new System.Windows.Forms.Button();
            this.txtDirectoryFromBackup = new System.Windows.Forms.TextBox();
            this.lblBackupFrom = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbTimeUnit = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnLoadExtension = new System.Windows.Forms.Button();
            this.lblBackupTo = new System.Windows.Forms.Label();
            this.txtDirectoryToBackup = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputDirectory = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.richTxtBoxHeader = new System.Windows.Forms.RichTextBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBackup
            // 
            this.startBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBackup.Location = new System.Drawing.Point(338, 242);
            this.startBackup.Name = "startBackup";
            this.startBackup.Size = new System.Drawing.Size(121, 35);
            this.startBackup.TabIndex = 0;
            this.startBackup.Text = "Start Backup";
            this.startBackup.UseVisualStyleBackColor = true;
            this.startBackup.Click += new System.EventHandler(this.startBackup_Click);
            // 
            // btnBrowseInputDirectory
            // 
            this.btnBrowseInputDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseInputDirectory.Location = new System.Drawing.Point(384, 81);
            this.btnBrowseInputDirectory.Name = "btnBrowseInputDirectory";
            this.btnBrowseInputDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInputDirectory.TabIndex = 1;
            this.btnBrowseInputDirectory.Text = "Browse";
            this.btnBrowseInputDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseInputDirectory.Click += new System.EventHandler(this.browseInputDirectory_Click);
            // 
            // txtDirectoryFromBackup
            // 
            this.txtDirectoryFromBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectoryFromBackup.Location = new System.Drawing.Point(109, 81);
            this.txtDirectoryFromBackup.Name = "txtDirectoryFromBackup";
            this.txtDirectoryFromBackup.Size = new System.Drawing.Size(268, 23);
            this.txtDirectoryFromBackup.TabIndex = 2;
            // 
            // lblBackupFrom
            // 
            this.lblBackupFrom.AutoSize = true;
            this.lblBackupFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupFrom.Location = new System.Drawing.Point(12, 82);
            this.lblBackupFrom.Name = "lblBackupFrom";
            this.lblBackupFrom.Size = new System.Drawing.Size(91, 17);
            this.lblBackupFrom.TabIndex = 3;
            this.lblBackupFrom.Text = "Backup From";
            // 
            // txtExtensions
            // 
            this.txtExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtensions.Location = new System.Drawing.Point(109, 115);
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(268, 23);
            this.txtExtensions.TabIndex = 4;
            // 
            // lblExtensions
            // 
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtensions.Location = new System.Drawing.Point(12, 117);
            this.lblExtensions.Name = "lblExtensions";
            this.lblExtensions.Size = new System.Drawing.Size(76, 17);
            this.lblExtensions.TabIndex = 5;
            this.lblExtensions.Text = "Extensions";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 159);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 17);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time Span";
            // 
            // cbTimeUnit
            // 
            this.cbTimeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeUnit.FormattingEnabled = true;
            this.cbTimeUnit.Items.AddRange(new object[] {
            "Day(s)",
            "Hour(s)",
            "Minute(s)",
            "Second(s)"});
            this.cbTimeUnit.Location = new System.Drawing.Point(173, 156);
            this.cbTimeUnit.Name = "cbTimeUnit";
            this.cbTimeUnit.Size = new System.Drawing.Size(92, 24);
            this.cbTimeUnit.TabIndex = 10;
            this.cbTimeUnit.Text = "Day(s)";
            this.cbTimeUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(109, 156);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(51, 23);
            this.txtTime.TabIndex = 11;
            this.txtTime.Text = "1";
            // 
            // btnLoadExtension
            // 
            this.btnLoadExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadExtension.Location = new System.Drawing.Point(384, 115);
            this.btnLoadExtension.Name = "btnLoadExtension";
            this.btnLoadExtension.Size = new System.Drawing.Size(75, 24);
            this.btnLoadExtension.TabIndex = 12;
            this.btnLoadExtension.Text = "Load Again";
            this.btnLoadExtension.UseVisualStyleBackColor = true;
            this.btnLoadExtension.Click += new System.EventHandler(this.loadExtension_Click);
            // 
            // lblBackupTo
            // 
            this.lblBackupTo.AutoSize = true;
            this.lblBackupTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupTo.Location = new System.Drawing.Point(12, 206);
            this.lblBackupTo.Name = "lblBackupTo";
            this.lblBackupTo.Size = new System.Drawing.Size(76, 17);
            this.lblBackupTo.TabIndex = 15;
            this.lblBackupTo.Text = "Backup To";
            // 
            // txtDirectoryToBackup
            // 
            this.txtDirectoryToBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectoryToBackup.Location = new System.Drawing.Point(109, 203);
            this.txtDirectoryToBackup.Name = "txtDirectoryToBackup";
            this.txtDirectoryToBackup.Size = new System.Drawing.Size(268, 23);
            this.txtDirectoryToBackup.TabIndex = 14;
            // 
            // btnBrowseOutputDirectory
            // 
            this.btnBrowseOutputDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOutputDirectory.Location = new System.Drawing.Point(384, 200);
            this.btnBrowseOutputDirectory.Name = "btnBrowseOutputDirectory";
            this.btnBrowseOutputDirectory.Size = new System.Drawing.Size(75, 26);
            this.btnBrowseOutputDirectory.TabIndex = 13;
            this.btnBrowseOutputDirectory.Text = "Browse";
            this.btnBrowseOutputDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseOutputDirectory.Click += new System.EventHandler(this.btnBrowseOutputDirectory_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Peru;
            this.panelHeader.Controls.Add(this.richTxtBoxHeader);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(469, 62);
            this.panelHeader.TabIndex = 16;
            // 
            // richTxtBoxHeader
            // 
            this.richTxtBoxHeader.BackColor = System.Drawing.Color.Peru;
            this.richTxtBoxHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtBoxHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxHeader.Location = new System.Drawing.Point(46, 12);
            this.richTxtBoxHeader.Name = "richTxtBoxHeader";
            this.richTxtBoxHeader.Size = new System.Drawing.Size(380, 37);
            this.richTxtBoxHeader.TabIndex = 0;
            this.richTxtBoxHeader.Text = "            Backup Application";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(469, 291);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblBackupTo);
            this.Controls.Add(this.txtDirectoryToBackup);
            this.Controls.Add(this.btnBrowseOutputDirectory);
            this.Controls.Add(this.btnLoadExtension);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.cbTimeUnit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblExtensions);
            this.Controls.Add(this.txtExtensions);
            this.Controls.Add(this.lblBackupFrom);
            this.Controls.Add(this.txtDirectoryFromBackup);
            this.Controls.Add(this.btnBrowseInputDirectory);
            this.Controls.Add(this.startBackup);
            this.Name = "MyForm";
            this.Text = "Backup App";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBackup;
        private System.Windows.Forms.Button btnBrowseInputDirectory;
        private System.Windows.Forms.TextBox txtDirectoryFromBackup;
        private System.Windows.Forms.Label lblBackupFrom;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtExtensions;
        private System.Windows.Forms.Label lblExtensions;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbTimeUnit;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnLoadExtension;
        private System.Windows.Forms.Label lblBackupTo;
        private System.Windows.Forms.TextBox txtDirectoryToBackup;
        private System.Windows.Forms.Button btnBrowseOutputDirectory;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.RichTextBox richTxtBoxHeader;
    }
}

