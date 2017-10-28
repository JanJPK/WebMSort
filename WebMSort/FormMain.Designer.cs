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
            this.buttonOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowse.Location = new System.Drawing.Point(12, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(160, 40);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWork.Location = new System.Drawing.Point(12, 163);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(160, 40);
            this.buttonWork.TabIndex = 1;
            this.buttonWork.Text = "Work";
            this.buttonWork.UseVisualStyleBackColor = true;
            // 
            // radioButtonRenaming
            // 
            this.radioButtonRenaming.AutoSize = true;
            this.radioButtonRenaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonRenaming.Location = new System.Drawing.Point(14, 58);
            this.radioButtonRenaming.Name = "radioButtonRenaming";
            this.radioButtonRenaming.Size = new System.Drawing.Size(127, 29);
            this.radioButtonRenaming.TabIndex = 2;
            this.radioButtonRenaming.TabStop = true;
            this.radioButtonRenaming.Text = "Renaming";
            this.radioButtonRenaming.UseVisualStyleBackColor = true;
            // 
            // radioButtonSorting
            // 
            this.radioButtonSorting.AutoSize = true;
            this.radioButtonSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSorting.Location = new System.Drawing.Point(14, 93);
            this.radioButtonSorting.Name = "radioButtonSorting";
            this.radioButtonSorting.Size = new System.Drawing.Size(98, 29);
            this.radioButtonSorting.TabIndex = 3;
            this.radioButtonSorting.TabStop = true;
            this.radioButtonSorting.Text = "Sorting";
            this.radioButtonSorting.UseVisualStyleBackColor = true;
            // 
            // buttonOptions
            // 
            this.buttonOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOptions.Location = new System.Drawing.Point(12, 209);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(160, 40);
            this.buttonOptions.TabIndex = 4;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.radioButtonSorting);
            this.Controls.Add(this.radioButtonRenaming);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.RadioButton radioButtonRenaming;
        private System.Windows.Forms.RadioButton radioButtonSorting;
        private System.Windows.Forms.Button buttonOptions;
    }
}

