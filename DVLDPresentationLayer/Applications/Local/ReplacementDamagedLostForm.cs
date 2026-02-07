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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course19
{
    public partial class ReplacementDamagedLostForm : Form
    {
        private bool toIssueLicense = false;
        private int _licenseID;
        private clsLocalLicense localLicense;
        private int driverID;
        private clsPerson person;
        decimal paidFees;
        decimal applicationFees;
        int classDefaultValidtyYears { get; set; }
        private int newLicenseApplicationID { get; set; }
        private int newLicenseID { get; set; }
        private string notes;
        DateTime previousExpirationDate;
        private byte issueReason;
        decimal licenseFees;
        int applicationTypeID;
        public ReplacementDamagedLostForm()
        {
            InitializeComponent();
            filterLicenseDriverInfo1.LicenseIDSubmitted += licenseID_Submitted;
        }
        private void licenseID_Submitted(object sender, UserDataEventArgs e)
        {
            localLicense = e.license;
            driverID = e.driverID;
            licenseFees = clsLocalLicense.getFees(localLicense._licenseClassID);
            setValues();
            test();
                
            
          

               


            
        }
        private bool isExpired()
        {
            if (localLicense._expirationDate > DateTime.Now)
                return false;

             return true;
        }
        private bool isActive()
        {
            if (localLicense._isActive)
                return true;

            return false ;
        }
        private void setValues()
        {
            previousExpirationDate = localLicense._expirationDate;
            lbLicensesHistory.Enabled = true;
            int personID = clsDriver.getPersonIDByDriverID(localLicense._driverID);
            person = clsPerson.getPersonInfoUsingPersonID(personID);


            _licenseID = localLicense._licenseID;
            lbLocalLicenseID.Text = _licenseID.ToString();

            classDefaultValidtyYears = clsLocalLicense.defaultValidityYears(localLicense._licenseClassID);
        }
        private bool test()
        {
            if (!isExpired())
            {
                if (!isActive())
                {
                    MessageBox.Show("Selected License is not active, choose another license.", "Choose Another License",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btReplace.Enabled = false;
                    return false;
                }
                btReplace.Enabled = true;
                return true;
            }

            else
            {
                MessageBox.Show("Selected License is Expired, You should renew it or choose another license.", "Choose Another License",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btReplace.Enabled = false;
                return false;
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          

            FormShowLocalLicense form = new FormShowLocalLicense(Convert.ToInt32(newLicenseID));

            form.ShowDialog();
        }

        private void replaceLicense()
        {
            
           

       
                newLicenseApplicationID = clsLocalApplication.addNewApplication(person._personID, DateTime.Now,applicationTypeID, 3, DateTime.Now, applicationFees, clsSession.currentUser._userID, localLicense._licenseClassID
                    , false);
                if (newLicenseApplicationID != -1)
                {
                    if (clsLocalLicense.deactivateLicense(localLicense._licenseID))
                    {
                        newLicenseID = clsLocalLicense.addNewLicense(newLicenseApplicationID, localLicense._driverID, localLicense._licenseClassID, DateTime.Now,
                           previousExpirationDate, notes, (licenseFees+applicationFees), true, issueReason, clsSession.currentUser._userID, false);
                        if (newLicenseID != -1)
                        {
                            toIssueLicense = true;
                            lbLicenseInfo.Enabled = true;
                        btReplace.Enabled = false;
                        filterLicenseDriverInfo1.disableFilter();
                        groupBoxReplacementFor.Enabled = false;
                        lbReplacedLicenseID.Text = newLicenseID.ToString();

                        }
                    
                }

            }
        }
        private bool radioBoxesChosen()
        {
            return radioDamaged.Checked || radioLost.Checked;
        }
        private void btReplace_Click(object sender, EventArgs e)
        {
            if (!radioBoxesChosen())
                return;

            if (MessageBox.Show("Are you sure you want to issue a replacement for this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                replaceLicense();
               

                if (toIssueLicense)
                {
                    MessageBox.Show($"Licensed has been replaced successfully with ID = {newLicenseID}", "License Issued",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

                else
                {
                    MessageBox.Show($"Failed to replace License",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }

        private void lbLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory
                (localLicense._licenseClassID, person._nationalNumber, -1, Convert.ToInt32(localLicense._driverID));

            form.ShowDialog();
        }

        private void ReplacementDamagedLostForm_Load(object sender, EventArgs e)
        {
            radioDamaged.Checked = true;
            lbUsername.Text = clsSession.currentUser._username;
            lbAppDate.Text = DateTime.Now.ToShortDateString();
            clsLocalLicense.updateLicenes();

        }

        private void radioDamaged_CheckedChanged(object sender, EventArgs e)
        {
            notes = "Replaced for Damaged License";
            applicationFees = clsApplicationType.getFeesByID(4);
            lbApplicationFees.Text = applicationFees.ToString();
            issueReason = 3;
            applicationTypeID = 4;
           
        }

        private void radioLost_CheckedChanged(object sender, EventArgs e)
        {
            applicationFees = clsApplicationType.getFeesByID(3);
            lbApplicationFees.Text = applicationFees.ToString();
            notes = "Replaced for Lost License";
            issueReason = 4;
            applicationTypeID = 3;

        }
    }
}
