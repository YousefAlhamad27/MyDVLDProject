namespace Course19
{
    partial class UserInfoForm
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
            this.btClose = new System.Windows.Forms.Button();
            this.userInformationCardcs1 = new Course19.UserInformationCardcs();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = global::Course19.Properties.Resources.ac5b6539d134b48b1c796bb0cb3f3b5011;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(939, 557);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(233, 68);
            this.btClose.TabIndex = 32;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // userInformationCardcs1
            // 
            this.userInformationCardcs1.BackColor = System.Drawing.Color.White;
            this.userInformationCardcs1.Location = new System.Drawing.Point(12, 21);
            this.userInformationCardcs1.Name = "userInformationCardcs1";
            this.userInformationCardcs1.Size = new System.Drawing.Size(1160, 530);
            this.userInformationCardcs1.TabIndex = 33;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 638);
            this.Controls.Add(this.userInformationCardcs1);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btClose;
        private UserInformationCardcs userInformationCardcs1;
    }
}