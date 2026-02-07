namespace Course19
{
    partial class FormIssueDriverLicenseFirstTime
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
            this.txtBoxNotes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.applicationLicenseInfoUserControl1 = new Course19.ApplicationLicenseInfoUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes:";
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Location = new System.Drawing.Point(159, 510);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(977, 154);
            this.txtBoxNotes.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Course19.Properties.Resources.IssueDrivingLicense_321;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(971, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 52);
            this.button1.TabIndex = 37;
            this.button1.Text = "Issue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClose
            // 
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::Course19.Properties.Resources.ac5b6539d134b48b1c796bb0cb3f3b5011;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(760, 670);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(202, 52);
            this.btClose.TabIndex = 36;
            this.btClose.Text = "Close";
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Course19.Properties.Resources.Notes_32;
            this.pictureBox9.Location = new System.Drawing.Point(110, 508);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // applicationLicenseInfoUserControl1
            // 
            this.applicationLicenseInfoUserControl1.applicationID = 0;
            this.applicationLicenseInfoUserControl1.BackColor = System.Drawing.Color.White;
            this.applicationLicenseInfoUserControl1.localAppID = 0;
            this.applicationLicenseInfoUserControl1.Location = new System.Drawing.Point(12, 55);
            this.applicationLicenseInfoUserControl1.Name = "applicationLicenseInfoUserControl1";
            this.applicationLicenseInfoUserControl1.Size = new System.Drawing.Size(1137, 450);
            this.applicationLicenseInfoUserControl1.TabIndex = 0;
            // 
            // FormIssueDriverLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txtBoxNotes);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applicationLicenseInfoUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormIssueDriverLicenseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driver License First Time";
            this.Load += new System.EventHandler(this.FormIssueDriverLicenseFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplicationLicenseInfoUserControl applicationLicenseInfoUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNotes;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button button1;
    }
}