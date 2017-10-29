namespace WebMSort
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.radioButtonRenaming = new System.Windows.Forms.RadioButton();
            this.radioButtonSorting = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.checkBoxSubdirectory = new System.Windows.Forms.CheckBox();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.buttonConfirmChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFFmpegDirectory = new System.Windows.Forms.Button();
            this.textBoxNoSoundFilename = new System.Windows.Forms.TextBox();
            this.textBoxSoundFilename = new System.Windows.Forms.TextBox();
            this.textBoxNoSoundFolderName = new System.Windows.Forms.TextBox();
            this.textBoxSoundFolderName = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowse.Location = new System.Drawing.Point(6, 6);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(190, 40);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWork.Location = new System.Drawing.Point(6, 165);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(190, 40);
            this.buttonWork.TabIndex = 1;
            this.buttonWork.Text = "Work";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // radioButtonRenaming
            // 
            this.radioButtonRenaming.AutoSize = true;
            this.radioButtonRenaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonRenaming.Location = new System.Drawing.Point(6, 52);
            this.radioButtonRenaming.Name = "radioButtonRenaming";
            this.radioButtonRenaming.Size = new System.Drawing.Size(127, 29);
            this.radioButtonRenaming.TabIndex = 2;
            this.radioButtonRenaming.TabStop = true;
            this.radioButtonRenaming.Text = "Renaming";
            this.radioButtonRenaming.UseVisualStyleBackColor = true;
            this.radioButtonRenaming.CheckedChanged += new System.EventHandler(this.radioButtonRenaming_CheckedChanged);
            // 
            // radioButtonSorting
            // 
            this.radioButtonSorting.AutoSize = true;
            this.radioButtonSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSorting.Location = new System.Drawing.Point(6, 87);
            this.radioButtonSorting.Name = "radioButtonSorting";
            this.radioButtonSorting.Size = new System.Drawing.Size(98, 29);
            this.radioButtonSorting.TabIndex = 3;
            this.radioButtonSorting.TabStop = true;
            this.radioButtonSorting.Text = "Sorting";
            this.radioButtonSorting.UseVisualStyleBackColor = true;
            this.radioButtonSorting.CheckedChanged += new System.EventHandler(this.radioButtonSorting_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageOptions);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(210, 237);
            this.tabControl.TabIndex = 5;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.checkBoxSubdirectory);
            this.tabPageMain.Controls.Add(this.buttonWork);
            this.tabPageMain.Controls.Add(this.radioButtonSorting);
            this.tabPageMain.Controls.Add(this.radioButtonRenaming);
            this.tabPageMain.Controls.Add(this.buttonBrowse);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(202, 211);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubdirectory
            // 
            this.checkBoxSubdirectory.AutoSize = true;
            this.checkBoxSubdirectory.Enabled = false;
            this.checkBoxSubdirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBoxSubdirectory.Location = new System.Drawing.Point(6, 129);
            this.checkBoxSubdirectory.Name = "checkBoxSubdirectory";
            this.checkBoxSubdirectory.Size = new System.Drawing.Size(170, 30);
            this.checkBoxSubdirectory.TabIndex = 4;
            this.checkBoxSubdirectory.Text = "Subdirectories";
            this.checkBoxSubdirectory.UseVisualStyleBackColor = true;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.buttonConfirmChanges);
            this.tabPageOptions.Controls.Add(this.label4);
            this.tabPageOptions.Controls.Add(this.label3);
            this.tabPageOptions.Controls.Add(this.label2);
            this.tabPageOptions.Controls.Add(this.label1);
            this.tabPageOptions.Controls.Add(this.buttonFFmpegDirectory);
            this.tabPageOptions.Controls.Add(this.textBoxNoSoundFilename);
            this.tabPageOptions.Controls.Add(this.textBoxSoundFilename);
            this.tabPageOptions.Controls.Add(this.textBoxNoSoundFolderName);
            this.tabPageOptions.Controls.Add(this.textBoxSoundFolderName);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(202, 211);
            this.tabPageOptions.TabIndex = 1;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmChanges
            // 
            this.buttonConfirmChanges.Location = new System.Drawing.Point(96, 139);
            this.buttonConfirmChanges.Name = "buttonConfirmChanges";
            this.buttonConfirmChanges.Size = new System.Drawing.Size(100, 23);
            this.buttonConfirmChanges.TabIndex = 9;
            this.buttonConfirmChanges.Text = "Confirm changes";
            this.buttonConfirmChanges.UseVisualStyleBackColor = true;
            this.buttonConfirmChanges.Click += new System.EventHandler(this.buttonConfirmChanges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NS/Filename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "S/Filename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NS/Folder name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "S/Folder name";
            // 
            // buttonFFmpegDirectory
            // 
            this.buttonFFmpegDirectory.Location = new System.Drawing.Point(6, 6);
            this.buttonFFmpegDirectory.Name = "buttonFFmpegDirectory";
            this.buttonFFmpegDirectory.Size = new System.Drawing.Size(190, 23);
            this.buttonFFmpegDirectory.TabIndex = 4;
            this.buttonFFmpegDirectory.Text = "FFmpeg Directory";
            this.buttonFFmpegDirectory.UseVisualStyleBackColor = true;
            this.buttonFFmpegDirectory.Click += new System.EventHandler(this.buttonFFmpegDirectory_Click);
            // 
            // textBoxNoSoundFilename
            // 
            this.textBoxNoSoundFilename.Location = new System.Drawing.Point(96, 113);
            this.textBoxNoSoundFilename.Name = "textBoxNoSoundFilename";
            this.textBoxNoSoundFilename.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoSoundFilename.TabIndex = 3;
            // 
            // textBoxSoundFilename
            // 
            this.textBoxSoundFilename.Location = new System.Drawing.Point(96, 87);
            this.textBoxSoundFilename.Name = "textBoxSoundFilename";
            this.textBoxSoundFilename.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoundFilename.TabIndex = 2;
            // 
            // textBoxNoSoundFolderName
            // 
            this.textBoxNoSoundFolderName.Location = new System.Drawing.Point(96, 61);
            this.textBoxNoSoundFolderName.Name = "textBoxNoSoundFolderName";
            this.textBoxNoSoundFolderName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoSoundFolderName.TabIndex = 1;
            // 
            // textBoxSoundFolderName
            // 
            this.textBoxSoundFolderName.Location = new System.Drawing.Point(96, 35);
            this.textBoxSoundFolderName.Name = "textBoxSoundFolderName";
            this.textBoxSoundFolderName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoundFolderName.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.Text = "WebM Sort";
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.RadioButton radioButtonRenaming;
        private System.Windows.Forms.RadioButton radioButtonSorting;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.CheckBox checkBoxSubdirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFFmpegDirectory;
        private System.Windows.Forms.TextBox textBoxNoSoundFilename;
        private System.Windows.Forms.TextBox textBoxSoundFilename;
        private System.Windows.Forms.TextBox textBoxNoSoundFolderName;
        private System.Windows.Forms.TextBox textBoxSoundFolderName;
        private System.Windows.Forms.Button buttonConfirmChanges;
    }
}

