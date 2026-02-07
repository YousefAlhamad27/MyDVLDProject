namespace Course19
{
    partial class QuestionRetakeTestTypeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioVision = new System.Windows.Forms.RadioButton();
            this.radioWritten = new System.Windows.Forms.RadioButton();
            this.radioStreet = new System.Windows.Forms.RadioButton();
            this.btSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioStreet);
            this.panel1.Controls.Add(this.radioWritten);
            this.panel1.Controls.Add(this.radioVision);
            this.panel1.Location = new System.Drawing.Point(8, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Test Type:";
            // 
            // radioVision
            // 
            this.radioVision.AutoSize = true;
            this.radioVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVision.Location = new System.Drawing.Point(119, 14);
            this.radioVision.Name = "radioVision";
            this.radioVision.Size = new System.Drawing.Size(121, 26);
            this.radioVision.TabIndex = 0;
            this.radioVision.TabStop = true;
            this.radioVision.Text = "Vision Test";
            this.radioVision.UseVisualStyleBackColor = true;
            // 
            // radioWritten
            // 
            this.radioWritten.AutoSize = true;
            this.radioWritten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWritten.Location = new System.Drawing.Point(229, 75);
            this.radioWritten.Name = "radioWritten";
            this.radioWritten.Size = new System.Drawing.Size(129, 26);
            this.radioWritten.TabIndex = 1;
            this.radioWritten.TabStop = true;
            this.radioWritten.Text = "Written Test";
            this.radioWritten.UseVisualStyleBackColor = true;
            // 
            // radioStreet
            // 
            this.radioStreet.AutoSize = true;
            this.radioStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStreet.Location = new System.Drawing.Point(32, 75);
            this.radioStreet.Name = "radioStreet";
            this.radioStreet.Size = new System.Drawing.Size(120, 26);
            this.radioStreet.TabIndex = 2;
            this.radioStreet.TabStop = true;
            this.radioStreet.Text = "Street Test";
            this.radioStreet.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::Course19.Properties.Resources.Save_324;
            this.btSave.Location = new System.Drawing.Point(192, 254);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(152, 48);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Course19.Properties.Resources.Close_327;
            this.button1.Location = new System.Drawing.Point(12, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(338, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 27);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuestionRetakeTestTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionRetakeTestTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionRetakeTestTypeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionRetakeTestTypeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioStreet;
        private System.Windows.Forms.RadioButton radioWritten;
        private System.Windows.Forms.RadioButton radioVision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button button2;
    }
}