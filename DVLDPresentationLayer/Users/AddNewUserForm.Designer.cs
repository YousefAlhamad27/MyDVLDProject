namespace Course19
{
    partial class AddNewUserForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPersonalDetails = new System.Windows.Forms.TabPage();
            this.personDetails1 = new Course19.PersonDetails();
            this.btNext = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabLoginInfo = new System.Windows.Forms.TabPage();
            this.btBack = new System.Windows.Forms.Button();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPersonalDetails.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.TabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(449, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 42);
            this.label3.TabIndex = 22;
            this.label3.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPersonalDetails);
            this.tabControl1.Controls.Add(this.TabLoginInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 646);
            this.tabControl1.TabIndex = 23;
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
            this.TabPersonalDetails.Size = new System.Drawing.Size(1166, 604);
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
            this.personDetails1.Size = new System.Drawing.Size(1155, 401);
            this.personDetails1.TabIndex = 24;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.White;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Image = global::Course19.Properties.Resources.Next_32;
            this.btNext.Location = new System.Drawing.Point(987, 546);
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
            this.gbFilter.Controls.Add(this.btAddPerson);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(7, 30);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1144, 89);
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
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(344, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 32);
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
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
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
            // TabLoginInfo
            // 
            this.TabLoginInfo.Controls.Add(this.btBack);
            this.TabLoginInfo.Controls.Add(this.checkBoxIsActive);
            this.TabLoginInfo.Controls.Add(this.txtBoxPassword);
            this.TabLoginInfo.Controls.Add(this.txtBoxConfirmPassword);
            this.TabLoginInfo.Controls.Add(this.txtBoxUsername);
            this.TabLoginInfo.Controls.Add(this.label15);
            this.TabLoginInfo.Controls.Add(this.lbUserID);
            this.TabLoginInfo.Controls.Add(this.label13);
            this.TabLoginInfo.Controls.Add(this.label10);
            this.TabLoginInfo.Controls.Add(this.label14);
            this.TabLoginInfo.Controls.Add(this.pictureBox13);
            this.TabLoginInfo.Controls.Add(this.pictureBox12);
            this.TabLoginInfo.Controls.Add(this.pictureBox10);
            this.TabLoginInfo.Controls.Add(this.pictureBox11);
            this.TabLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabLoginInfo.Location = new System.Drawing.Point(4, 38);
            this.TabLoginInfo.Name = "TabLoginInfo";
            this.TabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabLoginInfo.Size = new System.Drawing.Size(1166, 604);
            this.TabLoginInfo.TabIndex = 1;
            this.TabLoginInfo.Text = "Login Info";
            this.TabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Image = global::Course19.Properties.Resources.Prev_32;
            this.btBack.Location = new System.Drawing.Point(3, 546);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(164, 52);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Back";
            this.btBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(285, 284);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(102, 29);
            this.checkBoxIsActive.TabIndex = 4;
            this.checkBoxIsActive.Text = "isActive";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(322, 169);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(239, 32);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPassword_Validating);
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(322, 222);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(239, 32);
            this.txtBoxConfirmPassword.TabIndex = 3;
            this.txtBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.Location = new System.Drawing.Point(322, 118);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(239, 32);
            this.txtBoxUsername.TabIndex = 1;
            this.txtBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxUsername_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 26);
            this.label15.TabIndex = 4;
            this.label15.Text = "Confirm Password:";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(329, 67);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(38, 26);
            this.lbUserID.TabIndex = 3;
            this.lbUserID.Text = "??";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(109, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Username:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(137, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "User ID:";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Course19.Properties.Resources.Person_323;
            this.pictureBox13.Location = new System.Drawing.Point(267, 118);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(32, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 7;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Course19.Properties.Resources.Number_322;
            this.pictureBox12.Location = new System.Drawing.Point(267, 169);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 6;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Course19.Properties.Resources.Number_322;
            this.pictureBox10.Location = new System.Drawing.Point(267, 219);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Course19.Properties.Resources.Number_322;
            this.pictureBox11.Location = new System.Drawing.Point(267, 67);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Image = global::Course19.Properties.Resources.Save_321;
            this.btSave.Location = new System.Drawing.Point(1007, 778);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(179, 55);
            this.btSave.TabIndex = 2;
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
            this.btClose.Location = new System.Drawing.Point(809, 778);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(192, 55);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 844);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPersonalDetails.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.TabLoginInfo.ResumeLayout(false);
            this.TabLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPersonalDetails;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TabLoginInfo;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PersonDetails personDetails1;
    }
}