namespace Course19
{
    partial class FilterLicenseDriverInfo
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
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.driverLicenseInfo1 = new Course19.DriverLicenseInfo();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.btSearch);
            this.groupBoxFilter.Controls.Add(this.textBox1);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(750, 126);
            this.groupBoxFilter.TabIndex = 2;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // btSearch
            // 
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Image = global::Course19.Properties.Resources.License_View_322;
            this.btSearch.Location = new System.Drawing.Point(641, 43);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(82, 61);
            this.btSearch.TabIndex = 2;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 59);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LicenseID:";
            // 
            // driverLicenseInfo1
            // 
            this.driverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.driverLicenseInfo1.licenseID = null;
            this.driverLicenseInfo1.Location = new System.Drawing.Point(3, 135);
            this.driverLicenseInfo1.Name = "driverLicenseInfo1";
            this.driverLicenseInfo1.Size = new System.Drawing.Size(1030, 457);
            this.driverLicenseInfo1.TabIndex = 0;
            // 
            // FilterLicenseDriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.driverLicenseInfo1);
            this.Name = "FilterLicenseDriverInfo";
            this.Size = new System.Drawing.Size(1032, 588);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private DriverLicenseInfo driverLicenseInfo1;
    }
}
