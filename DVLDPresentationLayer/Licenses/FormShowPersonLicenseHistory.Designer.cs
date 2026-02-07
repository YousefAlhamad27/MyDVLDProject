namespace Course19
{
    partial class FormShowPersonLicenseHistory
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabLocal = new System.Windows.Forms.TabPage();
            this.lbNumRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabInternational = new System.Windows.Forms.TabPage();
            this.lbNumRecords2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.personDetails1 = new Course19.PersonDetails();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btClose = new System.Windows.Forms.Button();
            this.tsShowLocalLicenseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.tsShowInternationalLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btSearch);
            this.gbFilter.Controls.Add(this.textBox1);
            this.gbFilter.Controls.Add(this.comboBox1);
            this.gbFilter.Controls.Add(this.btAddPerson);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Enabled = false;
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(260, 94);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1143, 89);
            this.gbFilter.TabIndex = 7;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(344, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 32);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.comboBox1.Location = new System.Drawing.Point(118, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(469, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 46);
            this.label2.TabIndex = 21;
            this.label2.Text = "License History\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 607);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1391, 432);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabLocal);
            this.tabControl1.Controls.Add(this.TabInternational);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1379, 380);
            this.tabControl1.TabIndex = 25;
            // 
            // TabLocal
            // 
            this.TabLocal.Controls.Add(this.lbNumRecords);
            this.TabLocal.Controls.Add(this.label5);
            this.TabLocal.Controls.Add(this.label3);
            this.TabLocal.Controls.Add(this.dataGridView1);
            this.TabLocal.Controls.Add(this.button2);
            this.TabLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabLocal.Location = new System.Drawing.Point(4, 38);
            this.TabLocal.Name = "TabLocal";
            this.TabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.TabLocal.Size = new System.Drawing.Size(1371, 338);
            this.TabLocal.TabIndex = 0;
            this.TabLocal.Text = "Local";
            this.TabLocal.UseVisualStyleBackColor = true;
            // 
            // lbNumRecords
            // 
            this.lbNumRecords.AutoSize = true;
            this.lbNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRecords.Location = new System.Drawing.Point(144, 277);
            this.lbNumRecords.Name = "lbNumRecords";
            this.lbNumRecords.Size = new System.Drawing.Size(23, 25);
            this.lbNumRecords.TabIndex = 43;
            this.lbNumRecords.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "# Records:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Local Licenses History:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1348, 230);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.TabStop = false;
            // 
            // TabInternational
            // 
            this.TabInternational.Controls.Add(this.lbNumRecords2);
            this.TabInternational.Controls.Add(this.label6);
            this.TabInternational.Controls.Add(this.label7);
            this.TabInternational.Controls.Add(this.dataGridView2);
            this.TabInternational.Controls.Add(this.button4);
            this.TabInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabInternational.Location = new System.Drawing.Point(4, 38);
            this.TabInternational.Name = "TabInternational";
            this.TabInternational.Padding = new System.Windows.Forms.Padding(3);
            this.TabInternational.Size = new System.Drawing.Size(1371, 338);
            this.TabInternational.TabIndex = 1;
            this.TabInternational.Text = "International";
            this.TabInternational.UseVisualStyleBackColor = true;
            // 
            // lbNumRecords2
            // 
            this.lbNumRecords2.AutoSize = true;
            this.lbNumRecords2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRecords2.Location = new System.Drawing.Point(1328, 272);
            this.lbNumRecords2.Name = "lbNumRecords2";
            this.lbNumRecords2.Size = new System.Drawing.Size(26, 29);
            this.lbNumRecords2.TabIndex = 47;
            this.lbNumRecords2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1202, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "# Records:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "International Licenses History:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(15, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1350, 230);
            this.dataGridView2.TabIndex = 44;
            this.dataGridView2.TabStop = false;
            // 
            // personDetails1
            // 
            this.personDetails1.BackColor = System.Drawing.Color.White;
            this.personDetails1.Location = new System.Drawing.Point(260, 200);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.personID = null;
            this.personDetails1.Size = new System.Drawing.Size(1155, 401);
            this.personDetails1.TabIndex = 8;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowLocalLicenseInfo});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(201, 30);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowInternationalLicenseInfoToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(289, 58);
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
            this.btClose.Location = new System.Drawing.Point(1175, 1045);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(228, 58);
            this.btClose.TabIndex = 38;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tsShowLocalLicenseInfo
            // 
            this.tsShowLocalLicenseInfo.Image = global::Course19.Properties.Resources.License_View_324;
            this.tsShowLocalLicenseInfo.Name = "tsShowLocalLicenseInfo";
            this.tsShowLocalLicenseInfo.Size = new System.Drawing.Size(200, 26);
            this.tsShowLocalLicenseInfo.Text = "Show License Info";
            this.tsShowLocalLicenseInfo.Click += new System.EventHandler(this.tsShowLocalLicenseInfo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Course19.Properties.Resources.Next_32;
            this.button2.Location = new System.Drawing.Point(1199, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Next";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Course19.Properties.Resources.Prev_32;
            this.button4.Location = new System.Drawing.Point(15, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Back";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course19.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btSearch
            // 
            this.btSearch.FlatAppearance.BorderSize = 2;
            this.btSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Image = global::Course19.Properties.Resources.SearchPerson;
            this.btSearch.Location = new System.Drawing.Point(671, 29);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(59, 52);
            this.btSearch.TabIndex = 3;
            this.btSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btAddPerson
            // 
            this.btAddPerson.FlatAppearance.BorderSize = 2;
            this.btAddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPerson.Image = global::Course19.Properties.Resources.AddPerson_32;
            this.btAddPerson.Location = new System.Drawing.Point(736, 29);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(59, 52);
            this.btAddPerson.TabIndex = 20;
            this.btAddPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddPerson.UseVisualStyleBackColor = true;
            // 
            // tsShowInternationalLicenseInfoToolStripMenuItem
            // 
            this.tsShowInternationalLicenseInfoToolStripMenuItem.Image = global::Course19.Properties.Resources.License_View_32;
            this.tsShowInternationalLicenseInfoToolStripMenuItem.Name = "tsShowInternationalLicenseInfoToolStripMenuItem";
            this.tsShowInternationalLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.tsShowInternationalLicenseInfoToolStripMenuItem.Text = "Show International License Info";
            this.tsShowInternationalLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.tsShowInternationalLicenseInfoToolStripMenuItem_Click);
            // 
            // FormShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 1117);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personDetails1);
            this.Controls.Add(this.gbFilter);
            this.Name = "FormShowPersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowPersonLicenseHistorycs";
            this.Load += new System.EventHandler(this.FormShowPersonLicenseHistorycs_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabLocal.ResumeLayout(false);
            this.TabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabInternational.ResumeLayout(false);
            this.TabInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.Label label1;
        private PersonDetails personDetails1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabLocal;
        private System.Windows.Forms.Label lbNumRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage TabInternational;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbNumRecords2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsShowLocalLicenseInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsShowInternationalLicenseInfoToolStripMenuItem;
    }
}