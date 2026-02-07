namespace Course19
{
    partial class ManageUsersForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.lbNumRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowDetails,
            this.toolStripSeparator2,
            this.tsAddNewUser,
            this.tsEdit,
            this.tsDeleteUser,
            this.tsChangePassword,
            this.toolStripSeparator1,
            this.tsEmail,
            this.tsPhoneCall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 198);
            // 
            // tsShowDetails
            // 
            this.tsShowDetails.Image = global::Course19.Properties.Resources.PersonDetails_32;
            this.tsShowDetails.Name = "tsShowDetails";
            this.tsShowDetails.Size = new System.Drawing.Size(197, 26);
            this.tsShowDetails.Text = "Show Details";
            this.tsShowDetails.Click += new System.EventHandler(this.tsShowDetails_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // tsAddNewUser
            // 
            this.tsAddNewUser.Image = global::Course19.Properties.Resources.Edit_User_32;
            this.tsAddNewUser.Name = "tsAddNewUser";
            this.tsAddNewUser.Size = new System.Drawing.Size(197, 26);
            this.tsAddNewUser.Text = "Add New User";
            this.tsAddNewUser.Click += new System.EventHandler(this.tsAddNewUser_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Image = global::Course19.Properties.Resources.edit_32;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(197, 26);
            this.tsEdit.Text = "Edit";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.Image = global::Course19.Properties.Resources.DeleteRed;
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Size = new System.Drawing.Size(197, 26);
            this.tsDeleteUser.Text = "Delete";
            this.tsDeleteUser.Click += new System.EventHandler(this.tsDeleteUser_Click);
            // 
            // tsChangePassword
            // 
            this.tsChangePassword.Image = global::Course19.Properties.Resources.Password_322;
            this.tsChangePassword.Name = "tsChangePassword";
            this.tsChangePassword.Size = new System.Drawing.Size(197, 26);
            this.tsChangePassword.Text = "Change Password";
            this.tsChangePassword.Click += new System.EventHandler(this.tsChangePassword_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // tsEmail
            // 
            this.tsEmail.Image = global::Course19.Properties.Resources.send_email_32;
            this.tsEmail.Name = "tsEmail";
            this.tsEmail.Size = new System.Drawing.Size(197, 26);
            this.tsEmail.Text = "Send Email";
            // 
            // tsPhoneCall
            // 
            this.tsPhoneCall.Image = global::Course19.Properties.Resources.call_321;
            this.tsPhoneCall.Name = "tsPhoneCall";
            this.tsPhoneCall.Size = new System.Drawing.Size(197, 26);
            this.tsPhoneCall.Text = "Phone Call";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter By:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "Username",
            "Is Active"});
            this.comboBox1.Location = new System.Drawing.Point(165, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(384, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(28, 875);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(116, 25);
            this.lbRecords.TabIndex = 10;
            this.lbRecords.Text = "# Records:";
            this.lbRecords.Click += new System.EventHandler(this.lbRecords_Click);
            // 
            // lbNumRecords
            // 
            this.lbNumRecords.AutoSize = true;
            this.lbNumRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRecords.Location = new System.Drawing.Point(146, 875);
            this.lbNumRecords.Name = "lbNumRecords";
            this.lbNumRecords.Size = new System.Drawing.Size(23, 25);
            this.lbNumRecords.TabIndex = 11;
            this.lbNumRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(741, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Manage Users";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(384, 385);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 33);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course19.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(704, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btAddUser
            // 
            this.btAddUser.BackColor = System.Drawing.Color.White;
            this.btAddUser.FlatAppearance.BorderSize = 2;
            this.btAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUser.Image = global::Course19.Properties.Resources.Add_New_User_72;
            this.btAddUser.Location = new System.Drawing.Point(1553, 354);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(90, 78);
            this.btAddUser.TabIndex = 12;
            this.btAddUser.UseVisualStyleBackColor = false;
            this.btAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClose
            // 
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::Course19.Properties.Resources.ac5b6539d134b48b1c796bb0cb3f3b5011;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(1410, 875);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(233, 68);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(33, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1610, 419);
            this.dataGridView1.TabIndex = 16;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1703, 965);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.lbNumRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label lbNumRecords;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem tsChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsEmail;
        private System.Windows.Forms.ToolStripMenuItem tsPhoneCall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}