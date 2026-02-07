namespace Course19
{
    partial class NewLocalDrivingLicenseApplicationForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPersonalDetails = new System.Windows.Forms.TabPage();
            this.personDetails1 = new Course19.PersonDetails();
            this.btNext = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabApplicationInfo = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lbApp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPersonalDetails.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.tabApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPersonalDetails);
            this.tabControl1.Controls.Add(this.tabApplicationInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 632);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // TabPersonalDetails
            // 
            this.TabPersonalDetails.Controls.Add(this.personDetails1);
            this.TabPersonalDetails.Controls.Add(this.btNext);
            this.TabPersonalDetails.Controls.Add(this.gbFilter);
            this.TabPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPersonalDetails.Location = new System.Drawing.Point(4, 38);
            this.TabPersonalDetails.Name = "TabPersonalDetails";
            this.TabPersonalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabPersonalDetails.Size = new System.Drawing.Size(1161, 590);
            this.TabPersonalDetails.TabIndex = 0;
            this.TabPersonalDetails.Text = "Personal Details";
            this.TabPersonalDetails.UseVisualStyleBackColor = true;
            // 
            // personDetails1
            // 
            this.personDetails1.BackColor = System.Drawing.Color.White;
            this.personDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personDetails1.Location = new System.Drawing.Point(7, 127);
            this.personDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.personID = null;
            this.personDetails1.Size = new System.Drawing.Size(1149, 400);
            this.personDetails1.TabIndex = 8;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.White;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Image = global::Course19.Properties.Resources.Next_32;
            this.btNext.Location = new System.Drawing.Point(991, 535);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(164, 52);
            this.btNext.TabIndex = 7;
            this.btNext.Text = "Next";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btSearch);
            this.gbFilter.Controls.Add(this.textBox1);
            this.gbFilter.Controls.Add(this.comboBox1);
            this.gbFilter.Controls.Add(this.btAddUser);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(15, 30);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1140, 89);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(344, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
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
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btAddUser
            // 
            this.btAddUser.FlatAppearance.BorderSize = 2;
            this.btAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUser.Image = global::Course19.Properties.Resources.AddPerson_32;
            this.btAddUser.Location = new System.Drawing.Point(736, 29);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(59, 52);
            this.btAddUser.TabIndex = 20;
            this.btAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // tabApplicationInfo
            // 
            this.tabApplicationInfo.Controls.Add(this.comboBox2);
            this.tabApplicationInfo.Controls.Add(this.pictureBox14);
            this.tabApplicationInfo.Controls.Add(this.pictureBox13);
            this.tabApplicationInfo.Controls.Add(this.pictureBox12);
            this.tabApplicationInfo.Controls.Add(this.pictureBox11);
            this.tabApplicationInfo.Controls.Add(this.pictureBox10);
            this.tabApplicationInfo.Controls.Add(this.label20);
            this.tabApplicationInfo.Controls.Add(this.lbApp);
            this.tabApplicationInfo.Controls.Add(this.label18);
            this.tabApplicationInfo.Controls.Add(this.label17);
            this.tabApplicationInfo.Controls.Add(this.lbApplicationID);
            this.tabApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tabApplicationInfo.Controls.Add(this.lbUsername);
            this.tabApplicationInfo.Controls.Add(this.lbFees);
            this.tabApplicationInfo.Controls.Add(this.label10);
            this.tabApplicationInfo.Controls.Add(this.btBack);
            this.tabApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabApplicationInfo.Location = new System.Drawing.Point(4, 38);
            this.tabApplicationInfo.Name = "tabApplicationInfo";
            this.tabApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplicationInfo.Size = new System.Drawing.Size(1161, 590);
            this.tabApplicationInfo.TabIndex = 1;
            this.tabApplicationInfo.Text = "Application Info";
            this.tabApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(371, 211);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(369, 33);
            this.comboBox2.TabIndex = 28;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Course19.Properties.Resources.User_32__2;
            this.pictureBox14.Location = new System.Drawing.Point(313, 305);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(32, 32);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Course19.Properties.Resources.money_321;
            this.pictureBox13.Location = new System.Drawing.Point(313, 259);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(32, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Course19.Properties.Resources.Renew_Driving_License_321;
            this.pictureBox12.Location = new System.Drawing.Point(313, 208);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Course19.Properties.Resources.Number_324;
            this.pictureBox11.Location = new System.Drawing.Point(313, 109);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Course19.Properties.Resources.Calendar_322;
            this.pictureBox10.Location = new System.Drawing.Point(313, 156);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(105, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 25);
            this.label20.TabIndex = 9;
            this.label20.Text = "License Class:";
            // 
            // lbApp
            // 
            this.lbApp.AutoSize = true;
            this.lbApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApp.Location = new System.Drawing.Point(105, 160);
            this.lbApp.Name = "lbApp";
            this.lbApp.Size = new System.Drawing.Size(177, 25);
            this.lbApp.TabIndex = 8;
            this.lbApp.Text = "Application Date:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(105, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 25);
            this.label18.TabIndex = 7;
            this.label18.Text = "Application Fees:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(105, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 25);
            this.label17.TabIndex = 6;
            this.label17.Text = "Created By:";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(366, 113);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(48, 25);
            this.lbApplicationID.TabIndex = 5;
            this.lbApplicationID.Text = "???";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(366, 160);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(122, 25);
            this.lbApplicationDate.TabIndex = 4;
            this.lbApplicationDate.Text = "02/07/1996";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(366, 309);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(107, 25);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "username";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(366, 263);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(36, 25);
            this.lbFees.TabIndex = 2;
            this.lbFees.Text = "15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "D.L Application ID:";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Image = global::Course19.Properties.Resources.Prev_32;
            this.btBack.Location = new System.Drawing.Point(3, 535);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(164, 52);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Back";
            this.btBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(235, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(689, 42);
            this.label3.TabIndex = 25;
            this.label3.Text = "New Local Driving License Application";
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Image = global::Course19.Properties.Resources.Save_321;
            this.btSave.Location = new System.Drawing.Point(930, 754);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(179, 55);
            this.btSave.TabIndex = 27;
            this.btSave.Text = "Save";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::Course19.Properties.Resources.Close_322;
            this.btClose.Location = new System.Drawing.Point(732, 754);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(192, 55);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "Close";
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // NewLocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 826);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewLocalDrivingLicenseApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License";
            this.Load += new System.EventHandler(this.NewLocalDrivingLicenseApplicationForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPersonalDetails.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.tabApplicationInfo.ResumeLayout(false);
            this.tabApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPersonalDetails;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabApplicationInfo;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbApp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.ComboBox comboBox2;
        private PersonDetails personDetails1;
    }
}