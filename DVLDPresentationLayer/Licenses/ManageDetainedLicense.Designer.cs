namespace Course19
{
    partial class ManageDetainedLicense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumRecords = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.comboBoxIsReleased = new System.Windows.Forms.ComboBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btReleaseLicense = new System.Windows.Forms.Button();
            this.btDetainLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1692, 459);
            this.dataGridView1.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowPersonDetails,
            this.tsShowLicenseHistory,
            this.tsShowPersonLicenseHistory,
            this.toolStripSeparator1,
            this.tsReleaseDetainedLicense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(269, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsShowPersonDetails
            // 
            this.tsShowPersonDetails.Image = global::Course19.Properties.Resources.PersonDetails_323;
            this.tsShowPersonDetails.Name = "tsShowPersonDetails";
            this.tsShowPersonDetails.Size = new System.Drawing.Size(268, 26);
            this.tsShowPersonDetails.Text = "Show Person Details";
            this.tsShowPersonDetails.Click += new System.EventHandler(this.tsShowPersonDetails_Click);
            // 
            // tsShowLicenseHistory
            // 
            this.tsShowLicenseHistory.Image = global::Course19.Properties.Resources.License_View_323;
            this.tsShowLicenseHistory.Name = "tsShowLicenseHistory";
            this.tsShowLicenseHistory.Size = new System.Drawing.Size(268, 26);
            this.tsShowLicenseHistory.Text = "Show License Details";
            this.tsShowLicenseHistory.Click += new System.EventHandler(this.tsShowLicenseHistory_Click);
            // 
            // tsShowPersonLicenseHistory
            // 
            this.tsShowPersonLicenseHistory.Image = global::Course19.Properties.Resources.PersonLicenseHistory_321;
            this.tsShowPersonLicenseHistory.Name = "tsShowPersonLicenseHistory";
            this.tsShowPersonLicenseHistory.Size = new System.Drawing.Size(268, 26);
            this.tsShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsShowPersonLicenseHistory.Click += new System.EventHandler(this.tsShowPersonLicenseHistory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // tsReleaseDetainedLicense
            // 
            this.tsReleaseDetainedLicense.Image = global::Course19.Properties.Resources.Release_Detained_License_323;
            this.tsReleaseDetainedLicense.Name = "tsReleaseDetainedLicense";
            this.tsReleaseDetainedLicense.Size = new System.Drawing.Size(268, 26);
            this.tsReleaseDetainedLicense.Text = "Release Detained License";
            this.tsReleaseDetainedLicense.Click += new System.EventHandler(this.tsReleaseDetainedLicense_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(682, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 42);
            this.label3.TabIndex = 29;
            this.label3.Text = "Detained Licenses List";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(334, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 30);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.comboBox1.Location = new System.Drawing.Point(134, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 33);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filter By:";
            // 
            // lbNumRecords
            // 
            this.lbNumRecords.AutoSize = true;
            this.lbNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRecords.Location = new System.Drawing.Point(129, 827);
            this.lbNumRecords.Name = "lbNumRecords";
            this.lbNumRecords.Size = new System.Drawing.Size(23, 25);
            this.lbNumRecords.TabIndex = 39;
            this.lbNumRecords.Text = "0";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(7, 827);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(116, 25);
            this.lbName.TabIndex = 38;
            this.lbName.Text = "# Records:";
            // 
            // comboBoxIsReleased
            // 
            this.comboBoxIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIsReleased.FormattingEnabled = true;
            this.comboBoxIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboBoxIsReleased.Location = new System.Drawing.Point(334, 314);
            this.comboBoxIsReleased.Name = "comboBoxIsReleased";
            this.comboBoxIsReleased.Size = new System.Drawing.Size(162, 33);
            this.comboBoxIsReleased.TabIndex = 40;
            this.comboBoxIsReleased.Visible = false;
            this.comboBoxIsReleased.SelectedIndexChanged += new System.EventHandler(this.comboBoxIsReleased_SelectedIndexChanged);
            // 
            // btClose
            // 
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::Course19.Properties.Resources.ac5b6539d134b48b1c796bb0cb3f3b5011;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(1471, 818);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(233, 68);
            this.btClose.TabIndex = 37;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btReleaseLicense
            // 
            this.btReleaseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReleaseLicense.Image = global::Course19.Properties.Resources.Release_Detained_License_64;
            this.btReleaseLicense.Location = new System.Drawing.Point(1540, 286);
            this.btReleaseLicense.Name = "btReleaseLicense";
            this.btReleaseLicense.Size = new System.Drawing.Size(79, 61);
            this.btReleaseLicense.TabIndex = 33;
            this.btReleaseLicense.UseVisualStyleBackColor = true;
            this.btReleaseLicense.Click += new System.EventHandler(this.btReleaseLicense_Click);
            // 
            // btDetainLicense
            // 
            this.btDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetainLicense.Image = global::Course19.Properties.Resources.Detain_642;
            this.btDetainLicense.Location = new System.Drawing.Point(1625, 286);
            this.btDetainLicense.Name = "btDetainLicense";
            this.btDetainLicense.Size = new System.Drawing.Size(79, 61);
            this.btDetainLicense.TabIndex = 32;
            this.btDetainLicense.UseVisualStyleBackColor = true;
            this.btDetainLicense.Click += new System.EventHandler(this.btDetainLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course19.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(514, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ManageDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1712, 904);
            this.Controls.Add(this.comboBoxIsReleased);
            this.Controls.Add(this.lbNumRecords);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReleaseLicense);
            this.Controls.Add(this.btDetainLicense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained License";
            this.Load += new System.EventHandler(this.ManageDetainedLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btDetainLicense;
        private System.Windows.Forms.Button btReleaseLicense;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumRecords;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox comboBoxIsReleased;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsShowLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsReleaseDetainedLicense;
    }
}