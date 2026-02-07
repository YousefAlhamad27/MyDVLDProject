using DVDLBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Course19.FilterLicenseDriverInfo;
using static System.Net.Mime.MediaTypeNames;

namespace Course19
{
    public partial class NewInternationalLicenseApplicationForm : Form
    {
        private bool toIssueLicense = false;
        private int localLicenseID;
        private clsLocalLicense localLicense;
        private int driverID;
        private decimal paidFees;
        clsPerson person;
        private int applicationID {  get; set; }
        private string nationalNumber { get; set; }
        private int intLicenseID { get; set; }
        
        public NewInternationalLicenseApplicationForm()
        {
            
            InitializeComponent();
            filterLicenseDriverInfo1.LicenseIDSubmitted += licenseID_Submitted;
        }
        private void licenseID_Submitted(object sender, UserDataEventArgs e)
        {
            localLicense = e.license;
            driverID = e.driverID;
            setValues();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (localLicenseID == -1||localLicenseID==0)
                return;

            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory(Convert.ToInt32(localLicenseID),nationalNumber,intLicenseID,driverID);

            form.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setValues()
        {

            int personID = clsDriver.getPersonIDByDriverID(localLicense._driverID);
            person = clsPerson.getPersonInfoUsingPersonID(personID);
            nationalNumber = person._nationalNumber;
            intLicenseID = clsInternationalLicense.doesPersonHaveAnInternationalLicense(localLicense._driverID);
            localLicenseID = localLicense._licenseID;
            clsInternationalLicense internationalLicense = clsInternationalLicense.getInternationalLicenseByDriverID(driverID);

            if (internationalLicense == null)
            {
                
                lbUsername.Text = clsSession.currentUser._username;
                
                lbAppDate.Text = DateTime.Now.ToShortDateString();
                lbIssueDate.Text = DateTime.Now.ToShortDateString();
                lbExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            }
            else
            {

                intLicenseID = internationalLicense._internationalLicenseID;
                
                    clsUser user= clsUser.getUserByUserID(internationalLicense._createdByUserID);
                lbUsername.Text= user._username;
             clsLocalApplication application=   clsLocalApplication.getApplicationByID(internationalLicense._applicationID);
                lbIssueDate.Text = internationalLicense._issueDate.ToShortDateString();
              applicationID=application._applicationID;
                lbExpirationDate.Text= internationalLicense._expirationDate.ToShortDateString(); ;
                lbAppDate.Text = application._ApplicationDate.ToShortDateString();
                lbInternationalAppID.Text = internationalLicense._applicationID.ToString();
                lbInternationalLicenseID.Text = internationalLicense._internationalLicenseID.ToString();
            }
            paidFees = clsApplicationType.getFeesByID(6);
            lbFees.Text = paidFees.ToString();

            lbLocalLicenseID.Text = localLicenseID.ToString();

          
                if (intLicenseID != -1)
                    lbLicenseInfo.Enabled = true;
                else
                    lbLicenseInfo.Enabled = false;
                filterLicenseDriverInfo1.enableFilter();

            
        }

        private void issueLicense()
        {





            if (!clsDetainedLicense.isLicenseDetained(localLicense._licenseID))
            {
                if (intLicenseID == -1)
                {
                    applicationID = clsLocalApplication.addNewApplication(person._personID, DateTime.Now, 6, 1, DateTime.Now, paidFees, clsSession.currentUser._userID, -1, false);

                    if (applicationID != -1)
                    {
                        intLicenseID = clsInternationalLicense.addNewInternationalLicenseApplication(applicationID, localLicense._driverID, localLicenseID,
                           DateTime.Now, DateTime.Now.AddYears(1), true);
                        if (intLicenseID != -1)
                        {
                            toIssueLicense = true;
                            MessageBox.Show($"International License Issued Successfully with ID = {intLicenseID}", "License Issued",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbLicenseInfo.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Failed",
                                "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed To make Application",
                            "Try Again ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Person already has an active international license with ID = {intLicenseID}",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show($"License is Detained, choose another license",
                       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (applicationID != -1)
            {
                filterLicenseDriverInfo1.disableFilter();

            }
        }
       
        private void btIssue_Click(object sender, EventArgs e)
        {

            
           

            if (MessageBox.Show("Are you sure you want to Issue License?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                issueLicense();
                
            }

           
        }

        private void lbLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // filterLicenseDriverInfo1.licenseID = localLicenseID;
            FormShowLocalLicense form= new FormShowLocalLicense(Convert.ToInt32(localLicenseID));
            
            form.ShowDialog();
        }

        private void NewInternationalLicenseApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
