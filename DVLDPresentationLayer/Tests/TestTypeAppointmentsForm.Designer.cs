namespace Course19
{
    partial class TestTypeAppointmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTestAppointmentsType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNumRecords = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btAddNewAppointment = new System.Windows.Forms.Button();
            this.BigPictureBox = new System.Windows.Forms.PictureBox();
            this.applicationLicenseInfoUserControl2 = new Course19.ApplicationLicenseInfoUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTestAppointmentsType
            // 
            this.lbTestAppointmentsType.AutoSize = true;
            this.lbTestAppointmentsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestAppointmentsType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTestAppointmentsType.Location = new System.Drawing.Point(343, 196);
            this.lbTestAppointmentsType.Name = "lbTestAppointmentsType";
            this.lbTestAppointmentsType.Size = new System.Drawing.Size(465, 42);
            this.lbTestAppointmentsType.TabIndex = 33;
            this.lbTestAppointmentsType.Text = "Vision Test Appointments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Appointments:\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 747);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 203);
            this.dataGridView1.TabIndex = 35;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.tsTakeTest});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 84);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Course19.Properties.Resources.edit_324;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // tsTakeTest
            // 
            this.tsTakeTest.Image = global::Course19.Properties.Resources.Test_32;
            this.tsTakeTest.Name = "tsTakeTest";
            this.tsTakeTest.Size = new System.Drawing.Size(214, 26);
            this.tsTakeTest.Text = "Take Test";
            this.tsTakeTest.Click += new System.EventHandler(this.takeTesdtToolStripMenuItem_Click);
            // 
            // lbNumRecords
            // 
            this.lbNumRecords.AutoSize = true;
            this.lbNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRecords.Location = new System.Drawing.Point(-785, 943);
            this.lbNumRecords.Name = "lbNumRecords";
            this.lbNumRecords.Size = new System.Drawing.Size(23, 25);
            this.lbNumRecords.TabIndex = 39;
            this.lbNumRecords.Text = "0";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(-917, 943);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(116, 25);
            this.lbName.TabIndex = 38;
            this.lbName.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 968);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 968);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "# Records:";
            // 
            // btClose
            // 
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::Course19.Properties.Resources.ac5b6539d134b48b1c796bb0cb3f3b5011;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(905, 956);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(233, 68);
            this.btClose.TabIndex = 37;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAddNewAppointment
            // 
            this.btAddNewAppointment.FlatAppearance.BorderSize = 2;
            this.btAddNewAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btAddNewAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNewAppointment.Image = global::Course19.Properties.Resources.AddAppointment_32;
            this.btAddNewAppointment.Location = new System.Drawing.Point(1081, 693);
            this.btAddNewAppointment.Name = "btAddNewAppointment";
            this.btAddNewAppointment.Size = new System.Drawing.Size(57, 48);
            this.btAddNewAppointment.TabIndex = 36;
            this.btAddNewAppointment.UseVisualStyleBackColor = true;
            this.btAddNewAppointment.Click += new System.EventHandler(this.btAddNewAppointment_Click);
            // 
            // BigPictureBox
            // 
            this.BigPictureBox.Image = global::Course19.Properties.Resources.Vision_512;
            this.BigPictureBox.Location = new System.Drawing.Point(400, -1);
            this.BigPictureBox.Name = "BigPictureBox";
            this.BigPictureBox.Size = new System.Drawing.Size(368, 194);
            this.BigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BigPictureBox.TabIndex = 1;
            this.BigPictureBox.TabStop = false;
            // 
            // applicationLicenseInfoUserControl2
            // 
            this.applicationLicenseInfoUserControl2.applicationID = 0;
            this.applicationLicenseInfoUserControl2.BackColor = System.Drawing.Color.White;
            this.applicationLicenseInfoUserControl2.localAppID = 0;
            this.applicationLicenseInfoUserControl2.Location = new System.Drawing.Point(8, 241);
            this.applicationLicenseInfoUserControl2.Name = "applicationLicenseInfoUserControl2";
            this.applicationLicenseInfoUserControl2.Size = new System.Drawing.Size(1130, 446);
            this.applicationLicenseInfoUserControl2.TabIndex = 42;
            // 
            // TestTypeAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 1053);
            this.Controls.Add(this.applicationLicenseInfoUserControl2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNumRecords);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAddNewAppointment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTestAppointmentsType);
            this.Controls.Add(this.BigPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestTypeAppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test Appointments";
            this.Load += new System.EventHandler(this.VisionTestAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BigPictureBox;
        private System.Windows.Forms.Label lbTestAppointmentsType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAddNewAppointment;
        private System.Windows.Forms.Label lbNumRecords;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private ApplicationLicenseInfoUserControl applicationLicenseInfoUserControl2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTakeTest;
    }
}