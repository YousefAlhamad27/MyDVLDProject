namespace Course19
{
    partial class UserInformationCardcs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.personDetails1 = new Course19.PersonDetails();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbIsActive);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbUsername);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbUserID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1140, 118);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Information";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(833, 50);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(37, 25);
            this.lbIsActive.TabIndex = 5;
            this.lbIsActive.Text = "No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Is Active:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(550, 50);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(34, 25);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "??";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Username:";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(239, 50);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(34, 25);
            this.lbUserID.TabIndex = 1;
            this.lbUserID.Text = "??";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "User ID:";
            // 
            // personDetails1
            // 
            this.personDetails1.BackColor = System.Drawing.Color.White;
            this.personDetails1.Location = new System.Drawing.Point(3, 3);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.personID = null;
            this.personDetails1.Size = new System.Drawing.Size(1153, 408);
            this.personDetails1.TabIndex = 29;
            this.personDetails1.Load += new System.EventHandler(this.personDetails1_Load);
            // 
            // UserInformationCardcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.personDetails1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserInformationCardcs";
            this.Size = new System.Drawing.Size(1161, 531);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label10;
        private PersonDetails personDetails1;
    }
}
