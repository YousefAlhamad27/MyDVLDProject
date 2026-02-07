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

namespace Course19
{
    public partial class ReleaseDetainedLicenseForm : Form
    {
        private bool toReleaseLicense = false;
   
        private int _licenseID { get; set; }
        private clsLocalLicense localLicense;
        private int driverID;
        private int releaseID;
        private clsPerson person;
        clsDetainedLicense detainedLicense;
        decimal applicationFees;
        int releaseAppID;
        decimal fineFees;

        public ReleaseDetainedLicenseForm()
        {
            
            InitializeComponent();

            filterLicenseDriverInfo1.LicenseIDSubmitted += licenseID_Submitted;
        }
        private void licenseID_Submitted(object sender, UserDataEventArgs e)
        {
            localLicense = e.license;
            driverID = e.driverID;
            detainedLicense = clsDetainedLicense.getDetainObject(localLicense._licenseID);
            lbLicenseInfo.Enabled = true;
            lbLicensesHistory.Enabled = true;
            setValues();
            test();

        }
        private bool test()
        {

            if (!clsDetainedLicense.isLicenseDetained(_licenseID))
            {
                MessageBox.Show($"Selected License is  already Detained, choose another one.",
                       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btRelease.Enabled = false;
                return false;
            }

            else
            {
                btRelease.Enabled = true;
                return true;
            }
        }
        private bool isExpired()
        {
            if (localLicense._expirationDate > DateTime.Now)
                return false;

            return true;
        }
        private void setValues()
        {

            lbLicensesHistory.Enabled = true;
            int personID = clsDriver.getPersonIDByDriverID(localLicense._driverID);
            person = clsPerson.getPersonInfoUsingPersonID(personID);

            applicationFees = clsApplicationType.getFeesByID(5);
            lbApplicationFees.Text=applicationFees.ToString();
            lbDetainDate.Text=detainedLicense._detainDate.ToShortDateString();
            clsUser user = clsUser.getUserByUserID(detainedLicense._createdByUserID);

            lbUsername.Text = user._username;
            fineFees = detainedLicense._paidFees;
            lbFineFees.Text = fineFees.ToString();
            lbTotalFees.Text = (fineFees + applicationFees).ToString();
            lbDetainID.Text = detainedLicense._detainID.ToString();
            _licenseID = localLicense._licenseID;
            lbLicenseID.Text = _licenseID.ToString();
           


        }
      
        private void lbLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            FormShowLocalLicense form = new FormShowLocalLicense(Convert.ToInt32(_licenseID));

            form.ShowDialog();
        }

        private void lbLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory
                (localLicense._licenseClassID, person._nationalNumber, -1, Convert.ToInt32(localLicense._driverID));

            form.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void releaseLicense()
        {
            releaseAppID = clsLocalApplication.addNewApplication
                (person._personID, DateTime.Now,5, 3, DateTime.Now, applicationFees, clsSession.currentUser._userID, localLicense._licenseClassID, false);

            if (releaseAppID != -1)
            {
                if (clsDetainedLicense.releaseDetainedLicense(detainedLicense._detainID, releaseAppID))
                {
                    toReleaseLicense = true;
                    lbApplicationID.Text = releaseAppID.ToString();
                }
                else toReleaseLicense = false;

            }
            else toReleaseLicense = false;
        }
        public void disableFilter(string licenseID,int detainedID)
        {
            filterLicenseDriverInfo1.licenseID = licenseID;
            filterLicenseDriverInfo1.licenseID = licenseID;
            localLicense = clsLocalLicense.getLIcenseByID(Convert.ToInt32(licenseID));
            detainedLicense = clsDetainedLicense.getDetainObjectDetainID(Convert.ToInt32(detainedID));
            btRelease.Enabled = true;
            setValues();
        
            filterLicenseDriverInfo1.disableFilter();
        }
        private void btRelease_Click(object sender, EventArgs e)
        {
          // DateTime.Now;

            if (MessageBox.Show("Are you sure you want to release this license?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                releaseLicense();
                if (toReleaseLicense)
                {
                    MessageBox.Show($"Detained License released Successfully.", "License Detained",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btRelease.Enabled = false;
                }

                else
                {
                    if(releaseAppID==-1)
                    {
                        MessageBox.Show($"Failed to submit Release Application.Try again.",
                       "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show($"Failed to detain license.Try again.",
                        "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }
    }
}
