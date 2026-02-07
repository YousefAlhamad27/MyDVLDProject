namespace Course19
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btApplications = new System.Windows.Forms.Button();
            this.ctMenuApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReplacementLostDamaged = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLocalLicenseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInternationalLicenseApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDetainLicenseDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReleaseDetainedLicenseDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.btPeople = new System.Windows.Forms.Button();
            this.btDrivers = new System.Windows.Forms.Button();
            this.btUsers = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ctMenuAccountSet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSignOut = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.ctMenuApplications.SuspendLayout();
            this.ctMenuAccountSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "HAHAHAHA.png");
            this.imageList1.Images.SetKeyName(1, "PSSamurai.jpg");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btApplications);
            this.flowLayoutPanel1.Controls.Add(this.btPeople);
            this.flowLayoutPanel1.Controls.Add(this.btDrivers);
            this.flowLayoutPanel1.Controls.Add(this.btUsers);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1489, 149);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btApplications
            // 
            this.btApplications.ContextMenuStrip = this.ctMenuApplications;
            this.btApplications.FlatAppearance.BorderSize = 0;
            this.btApplications.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btApplications.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApplications.Image = global::Course19.Properties.Resources.Applications_641;
            this.btApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btApplications.Location = new System.Drawing.Point(3, 3);
            this.btApplications.Name = "btApplications";
            this.btApplications.Size = new System.Drawing.Size(264, 136);
            this.btApplications.TabIndex = 1;
            this.btApplications.Text = "Applications";
            this.btApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btApplications.UseVisualStyleBackColor = true;
            this.btApplications.Click += new System.EventHandler(this.btApplications_Click);
            // 
            // ctMenuApplications
            // 
            this.ctMenuApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctMenuApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLicenseServices,
            this.toolStripSeparator1,
            this.tsManageApplications,
            this.toolStripSeparator2,
            this.tsDetainLicense,
            this.tsManageApplicationTypes,
            this.tsManageTestTypes});
            this.ctMenuApplications.Name = "ctMenuApplications";
            this.ctMenuApplications.Size = new System.Drawing.Size(259, 174);
            // 
            // tsLicenseServices
            // 
            this.tsLicenseServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewDrivingLicense,
            this.tsRenewDrivingLicense,
            this.toolStripSeparator3,
            this.tsReplacementLostDamaged,
            this.toolStripSeparator4,
            this.tsReleaseDetainedLicense,
            this.tsRetakeTest});
            this.tsLicenseServices.Image = global::Course19.Properties.Resources.LocalDriving_License;
            this.tsLicenseServices.Name = "tsLicenseServices";
            this.tsLicenseServices.Size = new System.Drawing.Size(258, 26);
            this.tsLicenseServices.Text = "Driving License Services";
            // 
            // tsNewDrivingLicense
            // 
            this.tsNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLocalLicense,
            this.tsInternationalLicense});
            this.tsNewDrivingLicense.Image = global::Course19.Properties.Resources.New_Driving_License_32;
            this.tsNewDrivingLicense.Name = "tsNewDrivingLicense";
            this.tsNewDrivingLicense.Size = new System.Drawing.Size(370, 26);
            this.tsNewDrivingLicense.Text = "New Driving License";
            // 
            // tsLocalLicense
            // 
            this.tsLocalLicense.Image = global::Course19.Properties.Resources.Local_32;
            this.tsLocalLicense.Name = "tsLocalLicense";
            this.tsLocalLicense.Size = new System.Drawing.Size(228, 26);
            this.tsLocalLicense.Text = "Local License";
            this.tsLocalLicense.Click += new System.EventHandler(this.tsLocalLicense_Click);
            // 
            // tsInternationalLicense
            // 
            this.tsInternationalLicense.Image = global::Course19.Properties.Resources.International_32;
            this.tsInternationalLicense.Name = "tsInternationalLicense";
            this.tsInternationalLicense.Size = new System.Drawing.Size(228, 26);
            this.tsInternationalLicense.Text = "International License";
            this.tsInternationalLicense.Click += new System.EventHandler(this.tsInternationalLicense_Click);
            // 
            // tsRenewDrivingLicense
            // 
            this.tsRenewDrivingLicense.Image = global::Course19.Properties.Resources.Renew_Driving_License_32;
            this.tsRenewDrivingLicense.Name = "tsRenewDrivingLicense";
            this.tsRenewDrivingLicense.Size = new System.Drawing.Size(370, 26);
            this.tsRenewDrivingLicense.Text = "Renew Driving License";
            this.tsRenewDrivingLicense.Click += new System.EventHandler(this.tsRenewDrivingLicense_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(367, 6);
            // 
            // tsReplacementLostDamaged
            // 
            this.tsReplacementLostDamaged.Image = global::Course19.Properties.Resources.Damaged_Driving_License_32;
            this.tsReplacementLostDamaged.Name = "tsReplacementLostDamaged";
            this.tsReplacementLostDamaged.Size = new System.Drawing.Size(370, 26);
            this.tsReplacementLostDamaged.Text = "Replacement for lost or Damaged License";
            this.tsReplacementLostDamaged.Click += new System.EventHandler(this.tsReplacementLostDamaged_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(367, 6);
            // 
            // tsReleaseDetainedLicense
            // 
            this.tsReleaseDetainedLicense.Image = global::Course19.Properties.Resources.Release_Detained_License_32;
            this.tsReleaseDetainedLicense.Name = "tsReleaseDetainedLicense";
            this.tsReleaseDetainedLicense.Size = new System.Drawing.Size(370, 26);
            this.tsReleaseDetainedLicense.Text = "Release Detained Driving License";
            this.tsReleaseDetainedLicense.Click += new System.EventHandler(this.tsReleaseDetainedLicense_Click);
            // 
            // tsRetakeTest
            // 
            this.tsRetakeTest.Image = global::Course19.Properties.Resources.Retake_Test_32;
            this.tsRetakeTest.Name = "tsRetakeTest";
            this.tsRetakeTest.Size = new System.Drawing.Size(370, 26);
            this.tsRetakeTest.Text = "Retake Test";
            this.tsRetakeTest.Click += new System.EventHandler(this.tsRetakeTest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // tsManageApplications
            // 
            this.tsManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLocalLicenseApplication,
            this.tsInternationalLicenseApplication});
            this.tsManageApplications.Image = global::Course19.Properties.Resources.Manage_Applications_32;
            this.tsManageApplications.Name = "tsManageApplications";
            this.tsManageApplications.Size = new System.Drawing.Size(258, 26);
            this.tsManageApplications.Text = "Manage Applications";
            // 
            // tsLocalLicenseApplication
            // 
            this.tsLocalLicenseApplication.Image = global::Course19.Properties.Resources.LocalDriving_License1;
            this.tsLocalLicenseApplication.Name = "tsLocalLicenseApplication";
            this.tsLocalLicenseApplication.Size = new System.Drawing.Size(312, 26);
            this.tsLocalLicenseApplication.Text = "Local Driving License Application";
            this.tsLocalLicenseApplication.Click += new System.EventHandler(this.tsLocalLicenseApplication_Click);
            // 
            // tsInternationalLicenseApplication
            // 
            this.tsInternationalLicenseApplication.Image = global::Course19.Properties.Resources.International_321;
            this.tsInternationalLicenseApplication.Name = "tsInternationalLicenseApplication";
            this.tsInternationalLicenseApplication.Size = new System.Drawing.Size(312, 26);
            this.tsInternationalLicenseApplication.Text = "International License Application";
            this.tsInternationalLicenseApplication.Click += new System.EventHandler(this.tsInternationalLicenseApplication_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
            // 
            // tsDetainLicense
            // 
            this.tsDetainLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsManageDetainedLicenses,
            this.tsDetainLicenseDropDown,
            this.tsReleaseDetainedLicenseDropDown});
            this.tsDetainLicense.Image = global::Course19.Properties.Resources.Detain_32;
            this.tsDetainLicense.Name = "tsDetainLicense";
            this.tsDetainLicense.Size = new System.Drawing.Size(258, 26);
            this.tsDetainLicense.Text = "Detain License";
            // 
            // tsManageDetainedLicenses
            // 
            this.tsManageDetainedLicenses.Image = global::Course19.Properties.Resources.Detain_321;
            this.tsManageDetainedLicenses.Name = "tsManageDetainedLicenses";
            this.tsManageDetainedLicenses.Size = new System.Drawing.Size(269, 26);
            this.tsManageDetainedLicenses.Text = "Manage Detained Licenses";
            this.tsManageDetainedLicenses.Click += new System.EventHandler(this.tsManageDetainedLicenses_Click);
            // 
            // tsDetainLicenseDropDown
            // 
            this.tsDetainLicenseDropDown.Image = global::Course19.Properties.Resources.Detain_322;
            this.tsDetainLicenseDropDown.Name = "tsDetainLicenseDropDown";
            this.tsDetainLicenseDropDown.Size = new System.Drawing.Size(269, 26);
            this.tsDetainLicenseDropDown.Text = "Detain License";
            this.tsDetainLicenseDropDown.Click += new System.EventHandler(this.tsDetainLicenseDropDown_Click);
            // 
            // tsReleaseDetainedLicenseDropDown
            // 
            this.tsReleaseDetainedLicenseDropDown.Image = global::Course19.Properties.Resources.Release_Detained_License_322;
            this.tsReleaseDetainedLicenseDropDown.Name = "tsReleaseDetainedLicenseDropDown";
            this.tsReleaseDetainedLicenseDropDown.Size = new System.Drawing.Size(269, 26);
            this.tsReleaseDetainedLicenseDropDown.Text = "Release Detained License";
            this.tsReleaseDetainedLicenseDropDown.Click += new System.EventHandler(this.tsReleaseDetainedLicenseDropDown_Click);
            // 
            // tsManageApplicationTypes
            // 
            this.tsManageApplicationTypes.Image = global::Course19.Properties.Resources.Application_Types_64;
            this.tsManageApplicationTypes.Name = "tsManageApplicationTypes";
            this.tsManageApplicationTypes.Size = new System.Drawing.Size(258, 26);
            this.tsManageApplicationTypes.Text = "Manage Application Types";
            this.tsManageApplicationTypes.Click += new System.EventHandler(this.tsManageApplicationTypes_Click);
            // 
            // tsManageTestTypes
            // 
            this.tsManageTestTypes.Image = global::Course19.Properties.Resources.Test_Type_64;
            this.tsManageTestTypes.Name = "tsManageTestTypes";
            this.tsManageTestTypes.Size = new System.Drawing.Size(258, 26);
            this.tsManageTestTypes.Text = "Manage Test Types";
            this.tsManageTestTypes.Click += new System.EventHandler(this.tsManageTestTypes_Click);
            // 
            // btPeople
            // 
            this.btPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPeople.FlatAppearance.BorderSize = 0;
            this.btPeople.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btPeople.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPeople.Image = global::Course19.Properties.Resources.People_64;
            this.btPeople.Location = new System.Drawing.Point(273, 3);
            this.btPeople.Name = "btPeople";
            this.btPeople.Size = new System.Drawing.Size(264, 136);
            this.btPeople.TabIndex = 2;
            this.btPeople.Text = "People";
            this.btPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPeople.UseVisualStyleBackColor = false;
            this.btPeople.Click += new System.EventHandler(this.btPeople_Click);
            // 
            // btDrivers
            // 
            this.btDrivers.FlatAppearance.BorderSize = 0;
            this.btDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDrivers.Image = global::Course19.Properties.Resources.Drivers_64;
            this.btDrivers.Location = new System.Drawing.Point(543, 3);
            this.btDrivers.Name = "btDrivers";
            this.btDrivers.Size = new System.Drawing.Size(264, 136);
            this.btDrivers.TabIndex = 3;
            this.btDrivers.Text = "Drivers";
            this.btDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDrivers.UseVisualStyleBackColor = true;
            this.btDrivers.Click += new System.EventHandler(this.btDrivers_Click);
            // 
            // btUsers
            // 
            this.btUsers.FlatAppearance.BorderSize = 0;
            this.btUsers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.Image = global::Course19.Properties.Resources.Users_2_64;
            this.btUsers.Location = new System.Drawing.Point(813, 3);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(264, 136);
            this.btUsers.TabIndex = 4;
            this.btUsers.Text = "Users";
            this.btUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // button7
            // 
            this.button7.ContextMenuStrip = this.ctMenuAccountSet;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::Course19.Properties.Resources.account_settings_64;
            this.button7.Location = new System.Drawing.Point(1083, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(264, 136);
            this.button7.TabIndex = 5;
            this.button7.Text = "Account Settings";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // ctMenuAccountSet
            // 
            this.ctMenuAccountSet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctMenuAccountSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextUserInfo,
            this.ContextChangePassword,
            this.contextSignOut});
            this.ctMenuAccountSet.Name = "contextMenuStrip1";
            this.ctMenuAccountSet.Size = new System.Drawing.Size(198, 82);
            // 
            // ContextUserInfo
            // 
            this.ContextUserInfo.Image = global::Course19.Properties.Resources.PersonDetails_321;
            this.ContextUserInfo.Name = "ContextUserInfo";
            this.ContextUserInfo.Size = new System.Drawing.Size(197, 26);
            this.ContextUserInfo.Text = "Current User Info";
            this.ContextUserInfo.Click += new System.EventHandler(this.ContextUserInfo_Click);
            // 
            // ContextChangePassword
            // 
            this.ContextChangePassword.Image = global::Course19.Properties.Resources.Password_321;
            this.ContextChangePassword.Name = "ContextChangePassword";
            this.ContextChangePassword.Size = new System.Drawing.Size(197, 26);
            this.ContextChangePassword.Text = "Change Password";
            this.ContextChangePassword.Click += new System.EventHandler(this.ContextChangePassword_Click);
            // 
            // contextSignOut
            // 
            this.contextSignOut.Image = global::Course19.Properties.Resources.sign_out_32__2;
            this.contextSignOut.Name = "contextSignOut";
            this.contextSignOut.Size = new System.Drawing.Size(197, 26);
            this.contextSignOut.Text = "Sign Out";
            this.contextSignOut.Click += new System.EventHandler(this.ContextSignOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course19.Properties.Resources.Logo_Final1;
            this.ClientSize = new System.Drawing.Size(1489, 964);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ctMenuApplications.ResumeLayout(false);
            this.ctMenuAccountSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btApplications;
        private System.Windows.Forms.Button btPeople;
        private System.Windows.Forms.Button btDrivers;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ContextMenuStrip ctMenuAccountSet;
        private System.Windows.Forms.ToolStripMenuItem ContextUserInfo;
        private System.Windows.Forms.ToolStripMenuItem ContextChangePassword;
        private System.Windows.Forms.ToolStripMenuItem contextSignOut;
        private System.Windows.Forms.ContextMenuStrip ctMenuApplications;
        private System.Windows.Forms.ToolStripMenuItem tsLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem tsManageApplications;
        private System.Windows.Forms.ToolStripMenuItem tsDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsManageTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsRenewDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsReplacementLostDamaged;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsReleaseDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem tsRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem tsLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsLocalLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem tsInternationalLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem tsManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsDetainLicenseDropDown;
        private System.Windows.Forms.ToolStripMenuItem tsReleaseDetainedLicenseDropDown;
    }
}

