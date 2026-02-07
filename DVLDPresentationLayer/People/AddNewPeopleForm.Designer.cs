namespace Course19
{
    partial class AddNewPeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPeopleForm));
            this.button1 = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbToChange = new System.Windows.Forms.Label();
            this.addNewPerson1 = new Course19.AddNewPerson();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1332, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 27);
            this.button1.TabIndex = 20;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(673, 752);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(203, 65);
            this.btClose.TabIndex = 15;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbToChange
            // 
            this.lbToChange.AutoSize = true;
            this.lbToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToChange.Location = new System.Drawing.Point(12, 9);
            this.lbToChange.Name = "lbToChange";
            this.lbToChange.Size = new System.Drawing.Size(119, 18);
            this.lbToChange.TabIndex = 21;
            this.lbToChange.Text = "Add New Person";
            // 
            // addNewPerson1
            // 
            this.addNewPerson1.BackColor = System.Drawing.Color.White;
            this.addNewPerson1.Location = new System.Drawing.Point(62, 60);
            this.addNewPerson1.Name = "addNewPerson1";
            this.addNewPerson1.personID = null;
            this.addNewPerson1.Size = new System.Drawing.Size(1295, 783);
            this.addNewPerson1.TabIndex = 22;
            this.addNewPerson1.Load += new System.EventHandler(this.addNewPerson1_Load);
            // 
            // AddNewPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1375, 865);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.addNewPerson1);
            this.Controls.Add(this.lbToChange);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewPeopleForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewPeopleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbToChange;
        private AddNewPerson addNewPerson1;
    }
}