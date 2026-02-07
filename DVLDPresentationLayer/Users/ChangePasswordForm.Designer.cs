namespace Course19
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBoxCurrent = new System.Windows.Forms.TextBox();
            this.txtBoxConfirm = new System.Windows.Forms.TextBox();
            this.txtBoxNew = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userInformationCardcs1 = new Course19.UserInformationCardcs();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.Location = new System.Drawing.Point(68, 564);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(191, 25);
            this.lbCurrentPassword.TabIndex = 1;
            this.lbCurrentPassword.Text = "Current Password:";
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPass.Location = new System.Drawing.Point(17, 651);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(242, 25);
            this.lbConfirmPass.TabIndex = 2;
            this.lbConfirmPass.Text = "Confirm New Password:";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.Location = new System.Drawing.Point(98, 607);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(161, 25);
            this.lbNewPass.TabIndex = 3;
            this.lbNewPass.Text = "New Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course19.Properties.Resources.Password_323;
            this.pictureBox1.Location = new System.Drawing.Point(278, 564);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Course19.Properties.Resources.Password_323;
            this.pictureBox2.Location = new System.Drawing.Point(278, 651);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Course19.Properties.Resources.Password_323;
            this.pictureBox3.Location = new System.Drawing.Point(278, 607);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // txtBoxCurrent
            // 
            this.txtBoxCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCurrent.Location = new System.Drawing.Point(336, 566);
            this.txtBoxCurrent.Name = "txtBoxCurrent";
            this.txtBoxCurrent.PasswordChar = '*';
            this.txtBoxCurrent.Size = new System.Drawing.Size(173, 30);
            this.txtBoxCurrent.TabIndex = 7;
            this.txtBoxCurrent.UseSystemPasswordChar = true;
            // 
            // txtBoxConfirm
            // 
            this.txtBoxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirm.Location = new System.Drawing.Point(336, 653);
            this.txtBoxConfirm.Name = "txtBoxConfirm";
            this.txtBoxConfirm.PasswordChar = '*';
            this.txtBoxConfirm.Size = new System.Drawing.Size(173, 30);
            this.txtBoxConfirm.TabIndex = 8;
            this.txtBoxConfirm.UseSystemPasswordChar = true;
            this.txtBoxConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxConfirm_Validating);
            // 
            // txtBoxNew
            // 
            this.txtBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNew.Location = new System.Drawing.Point(336, 609);
            this.txtBoxNew.Name = "txtBoxNew";
            this.txtBoxNew.PasswordChar = '*';
            this.txtBoxNew.Size = new System.Drawing.Size(173, 30);
            this.txtBoxNew.TabIndex = 9;
            this.txtBoxNew.UseSystemPasswordChar = true;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(734, 717);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(203, 65);
            this.btClose.TabIndex = 16;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(943, 717);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(203, 65);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userInformationCardcs1
            // 
            this.userInformationCardcs1.BackColor = System.Drawing.Color.White;
            this.userInformationCardcs1.Location = new System.Drawing.Point(31, 24);
            this.userInformationCardcs1.Name = "userInformationCardcs1";
            this.userInformationCardcs1.Size = new System.Drawing.Size(1226, 522);
            this.userInformationCardcs1.TabIndex = 0;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 809);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txtBoxNew);
            this.Controls.Add(this.txtBoxConfirm);
            this.Controls.Add(this.txtBoxCurrent);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.lbConfirmPass);
            this.Controls.Add(this.lbCurrentPassword);
            this.Controls.Add(this.userInformationCardcs1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBoxCurrent;
        private System.Windows.Forms.TextBox txtBoxConfirm;
        private System.Windows.Forms.TextBox txtBoxNew;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserInformationCardcs userInformationCardcs1;
    }
}