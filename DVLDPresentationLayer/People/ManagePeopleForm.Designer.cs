namespace Course19
{
    partial class ManagePeopleForm
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
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumRecords = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddPeople = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeople.Location = new System.Drawing.Point(2, 9);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(117, 16);
            this.lbManagePeople.TabIndex = 13;
            this.lbManagePeople.Text = "Manage People";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1606, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 27);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1628, 413);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowDetails,
            this.tsAddNewPerson,
            this.tsEdit,
            this.tsDeletePerson,
            this.tsEmail,
            this.tsPhone});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 160);
            // 
            // tsShowDetails
            // 
            this.tsShowDetails.Image = global::Course19.Properties.Resources.PersonDetails_32;
            this.tsShowDetails.Name = "tsShowDetails";
            this.tsShowDetails.Size = new System.Drawing.Size(191, 26);
            this.tsShowDetails.Text = "Show Details";
            this.tsShowDetails.Click += new System.EventHandler(this.tsShowDetails_Click);
            // 
            // tsAddNewPerson
            // 
            this.tsAddNewPerson.Image = global::Course19.Properties.Resources.person_with_plus_icon_representing_adding_user_creating_a_new_account_or_adding_a_contact_vector1;
            this.tsAddNewPerson.Name = "tsAddNewPerson";
            this.tsAddNewPerson.Size = new System.Drawing.Size(191, 26);
            this.tsAddNewPerson.Text = "Add New Person";
            this.tsAddNewPerson.Click += new System.EventHandler(this.tsAddNewPerson_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = global::Course19.Properties.Resources.png_transparent_computer_icons_editing_others;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(191, 26);
            this.tsEdit.Text = "Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDeletePerson
            // 
            this.tsDeletePerson.Image = global::Course19.Properties.Resources.DeleteRed;
            this.tsDeletePerson.Name = "tsDeletePerson";
            this.tsDeletePerson.Size = new System.Drawing.Size(191, 26);
            this.tsDeletePerson.Text = "Delete";
            this.tsDeletePerson.Click += new System.EventHandler(this.tsDeletePerson_Click);
            // 
            // tsEmail
            // 
            this.tsEmail.Image = global::Course19.Properties.Resources.email_computer_icons_icon_design_message_png_favpng_fJdYjvbftz3UA0nfMyFpYYj0Y;
            this.tsEmail.Name = "tsEmail";
            this.tsEmail.Size = new System.Drawing.Size(191, 26);
            this.tsEmail.Text = "Email";
            // 
            // tsPhone
            // 
            this.tsPhone.Image = global::Course19.Properties.Resources.telephone_call_symbol_iphone_png_favpng_1hrqZMxPXfd2gLPqhzGU1qmNQ;
            this.tsPhone.Name = "tsPhone";
            this.tsPhone.Size = new System.Drawing.Size(191, 26);
            this.tsPhone.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(685, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manage People";
            // 
            // lbNumRecords
            // 
            this.lbNumRecords.AutoSize = true;
            this.lbNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRecords.Location = new System.Drawing.Point(134, 789);
            this.lbNumRecords.Name = "lbNumRecords";
            this.lbNumRecords.Size = new System.Drawing.Size(23, 25);
            this.lbNumRecords.TabIndex = 24;
            this.lbNumRecords.Text = "0";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 789);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(116, 25);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "# Records:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(330, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 30);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality ",
            "Gender",
            "Phone",
            "Email"});
            this.comboBox1.Location = new System.Drawing.Point(130, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 33);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course19.Properties.Resources.group_of_people_icon_a_group_of_three_persons_made_of_a_simple__262;
            this.pictureBox1.Location = new System.Drawing.Point(475, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btAddPeople
            // 
            this.btAddPeople.BackgroundImage = global::Course19.Properties.Resources.person_with_plus_icon_representing_adding_user_creating_a_new_account_or_adding_a_contact_vector;
            this.btAddPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddPeople.FlatAppearance.BorderSize = 2;
            this.btAddPeople.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAddPeople.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPeople.Location = new System.Drawing.Point(1561, 283);
            this.btAddPeople.Name = "btAddPeople";
            this.btAddPeople.Size = new System.Drawing.Size(79, 61);
            this.btAddPeople.TabIndex = 21;
            this.btAddPeople.UseVisualStyleBackColor = true;
            this.btAddPeople.Click += new System.EventHandler(this.btAddPeople_Click);
            // 
            // btClose
            // 
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::Course19.Properties.Resources.ac5b6539d134b48b1c796bb0cb3f3b5011;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(1407, 769);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(233, 68);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1649, 877);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNumRecords);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btAddPeople);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePeopleForm";
            this.Load += new System.EventHandler(this.ManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNumRecords;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btAddPeople;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsDeletePerson;
        private System.Windows.Forms.ToolStripMenuItem tsEmail;
        private System.Windows.Forms.ToolStripMenuItem tsPhone;
    }
}