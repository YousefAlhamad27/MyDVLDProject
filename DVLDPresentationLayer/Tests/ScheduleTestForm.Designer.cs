namespace Course19
{
    partial class ScheduleTestForm
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
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BigPictureBox = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTrial = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.bigLabel = new System.Windows.Forms.Label();
            this.groupBoxRetake = new System.Windows.Forms.GroupBox();
            this.lbRetakeTestID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbRetakeFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBoxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).BeginInit();
            this.groupBoxRetake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTest.Controls.Add(this.btSave);
            this.groupBoxTest.Controls.Add(this.dateTimePicker1);
            this.groupBoxTest.Controls.Add(this.pictureBox7);
            this.groupBoxTest.Controls.Add(this.pictureBox6);
            this.groupBoxTest.Controls.Add(this.pictureBox5);
            this.groupBoxTest.Controls.Add(this.pictureBox4);
            this.groupBoxTest.Controls.Add(this.pictureBox3);
            this.groupBoxTest.Controls.Add(this.pictureBox2);
            this.groupBoxTest.Controls.Add(this.label12);
            this.groupBoxTest.Controls.Add(this.BigPictureBox);
            this.groupBoxTest.Controls.Add(this.lbID);
            this.groupBoxTest.Controls.Add(this.lbClass);
            this.groupBoxTest.Controls.Add(this.label9);
            this.groupBoxTest.Controls.Add(this.label8);
            this.groupBoxTest.Controls.Add(this.label7);
            this.groupBoxTest.Controls.Add(this.label6);
            this.groupBoxTest.Controls.Add(this.label5);
            this.groupBoxTest.Controls.Add(this.lbName);
            this.groupBoxTest.Controls.Add(this.lbTrial);
            this.groupBoxTest.Controls.Add(this.lbFees);
            this.groupBoxTest.Controls.Add(this.bigLabel);
            this.groupBoxTest.Controls.Add(this.groupBoxRetake);
            this.groupBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTest.Location = new System.Drawing.Point(12, 28);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(646, 745);
            this.groupBoxTest.TabIndex = 0;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Vision Test";
            // 
            // btSave
            // 
            this.btSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::Course19.Properties.Resources.Save_323;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(437, 686);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(203, 51);
            this.btSave.TabIndex = 24;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 423);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 28);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Course19.Properties.Resources.Number_326;
            this.pictureBox7.Location = new System.Drawing.Point(160, 239);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Course19.Properties.Resources.License_Type_321;
            this.pictureBox6.Location = new System.Drawing.Point(160, 289);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Course19.Properties.Resources.Person_325;
            this.pictureBox5.Location = new System.Drawing.Point(160, 332);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Course19.Properties.Resources.Count_32;
            this.pictureBox4.Location = new System.Drawing.Point(160, 373);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Course19.Properties.Resources.Calendar_325;
            this.pictureBox3.Location = new System.Drawing.Point(160, 420);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Course19.Properties.Resources.money_323;
            this.pictureBox2.Location = new System.Drawing.Point(160, 464);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 22);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fees:";
            // 
            // BigPictureBox
            // 
            this.BigPictureBox.Image = global::Course19.Properties.Resources.driving_test_512;
            this.BigPictureBox.Location = new System.Drawing.Point(149, 11);
            this.BigPictureBox.Name = "BigPictureBox";
            this.BigPictureBox.Size = new System.Drawing.Size(350, 168);
            this.BigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BigPictureBox.TabIndex = 12;
            this.BigPictureBox.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(215, 239);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(43, 22);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "???";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(214, 289);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(60, 22);
            this.lbClass.TabIndex = 10;
            this.lbClass.Text = "Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "D.L App.ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "D.Class:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(214, 332);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 22);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // lbTrial
            // 
            this.lbTrial.AutoSize = true;
            this.lbTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrial.Location = new System.Drawing.Point(214, 373);
            this.lbTrial.Name = "lbTrial";
            this.lbTrial.Size = new System.Drawing.Size(21, 22);
            this.lbTrial.TabIndex = 3;
            this.lbTrial.Text = "0";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(214, 464);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(77, 22);
            this.lbFees.TabIndex = 2;
            this.lbFees.Text = "Amount";
            // 
            // bigLabel
            // 
            this.bigLabel.AutoSize = true;
            this.bigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel.Location = new System.Drawing.Point(148, 182);
            this.bigLabel.Name = "bigLabel";
            this.bigLabel.Size = new System.Drawing.Size(239, 38);
            this.bigLabel.TabIndex = 1;
            this.bigLabel.Text = "Schedule Test";
            // 
            // groupBoxRetake
            // 
            this.groupBoxRetake.Controls.Add(this.lbRetakeTestID);
            this.groupBoxRetake.Controls.Add(this.label11);
            this.groupBoxRetake.Controls.Add(this.lbTotalFees);
            this.groupBoxRetake.Controls.Add(this.lbRetakeFees);
            this.groupBoxRetake.Controls.Add(this.label3);
            this.groupBoxRetake.Controls.Add(this.label4);
            this.groupBoxRetake.Controls.Add(this.pictureBox9);
            this.groupBoxRetake.Controls.Add(this.pictureBox10);
            this.groupBoxRetake.Controls.Add(this.pictureBox8);
            this.groupBoxRetake.Enabled = false;
            this.groupBoxRetake.Location = new System.Drawing.Point(6, 513);
            this.groupBoxRetake.Name = "groupBoxRetake";
            this.groupBoxRetake.Size = new System.Drawing.Size(632, 167);
            this.groupBoxRetake.TabIndex = 0;
            this.groupBoxRetake.TabStop = false;
            this.groupBoxRetake.Text = "Retake Test Info";
            // 
            // lbRetakeTestID
            // 
            this.lbRetakeTestID.AutoSize = true;
            this.lbRetakeTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetakeTestID.Location = new System.Drawing.Point(208, 116);
            this.lbRetakeTestID.Name = "lbRetakeTestID";
            this.lbRetakeTestID.Size = new System.Drawing.Size(43, 22);
            this.lbRetakeTestID.TabIndex = 29;
            this.lbRetakeTestID.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total Fees:";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(493, 50);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(77, 22);
            this.lbTotalFees.TabIndex = 27;
            this.lbTotalFees.Text = "Amount";
            // 
            // lbRetakeFees
            // 
            this.lbRetakeFees.AutoSize = true;
            this.lbRetakeFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetakeFees.Location = new System.Drawing.Point(208, 50);
            this.lbRetakeFees.Name = "lbRetakeFees";
            this.lbRetakeFees.Size = new System.Drawing.Size(21, 22);
            this.lbRetakeFees.TabIndex = 24;
            this.lbRetakeFees.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "D.L App.ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "R.App.Fees:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Course19.Properties.Resources.Number_327;
            this.pictureBox9.Location = new System.Drawing.Point(154, 106);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Course19.Properties.Resources.money_323;
            this.pictureBox10.Location = new System.Drawing.Point(443, 50);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Course19.Properties.Resources.money_323;
            this.pictureBox8.Location = new System.Drawing.Point(154, 50);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
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
            this.btClose.Location = new System.Drawing.Point(218, 779);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(228, 68);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ScheduleTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 855);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.groupBoxTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).EndInit();
            this.groupBoxRetake.ResumeLayout(false);
            this.groupBoxRetake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox BigPictureBox;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTrial;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label bigLabel;
        private System.Windows.Forms.GroupBox groupBoxRetake;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbRetakeTestID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label lbRetakeFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
    }
}