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
    public partial class RenewLicenseForm : Form
    {
        private bool toIssueLicense = false;
        private clsLocalLicense localLicense;
        private int driverID;
        private clsPerson person;
        decimal paidFees;
        decimal applicationFees;
        int classDefaultValidtyYears {  get; set; }
        private int newLicenseApplicationID {  get; set; }
        private int newLicenseID {  get; set; }
        public RenewLicenseForm()
        {
            InitializeComponent();
            filterLicenseDriverInfo1.LicenseIDSubmitted += licenseID_Submitted;
        }
        private void licenseID_Submitted(object sender, UserDataEventArgs e)
        {
            localLicense = e.license;
            driverID = e.driverID;
            setValues();
           if (!isRenewAllowed())
            {
                MessageBox.Show($"Selected License is not yet expired, it will expire on:{localLicense._expirationDate}","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btIRenew.Enabled = false;
                lbLicenseInfo.Enabled = false;
            }
            else
            {
                
                btIRenew.Enabled = true;
               

            }
        }
       
        private bool isRenewAllowed()
        {
            if (localLicense._expirationDate > DateTime.Now)
            {
              
                 return false;
            }
            
            return true;
        }
        private void setValues()
        {

            int personID = clsDriver.getPersonIDByDriverID(localLicense._driverID);
            person = clsPerson.getPersonInfoUsingPersonID(personID);


            
            

             

                
                lbUsername.Text = clsSession.currentUser._username;
               // clsLocalApplication application = clsLocalApplication.getApplicationByID(localLicense._applicationID);
                lbIssueDate.Text = DateTime.Now.ToShortDateString();
            //  applicationID = application._applicationID;

            classDefaultValidtyYears = clsLocalLicense.defaultValidityYears(localLicense._licenseClassID);
                lbExpirationDate.Text = DateTime.Now.AddYears(classDefaultValidtyYears).ToShortDateString(); ;
                lbAppDate.Text = DateTime.Now.ToShortDateString();

             applicationFees = clsApplicationType.getFeesByID(2);
            lbApplicationFees.Text = applicationFees.ToString();

            decimal licenseFees = clsLocalLicense.getFees(localLicense._licenseClassID);
            lbLicenseFees.Text = licenseFees.ToString();
            paidFees = licenseFees + applicationFees;
            lbTotalFees.Text = (licenseFees + applicationFees).ToString();

            lbOldLicenseID.Text = localLicense._licenseID.ToString();
            
             


         //   if (intLicenseID != -1)
        //        lbLicenseInfo.Enabled = true;
          //  else
          //      lbLicenseInfo.Enabled = false;
          //  filterLicenseDriverInfo1.enableFilter();


        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void issueLicense()
        {
            int activeLocalLicenseID = clsLocalLicense.doesDriverHaveAnActiveLicense(localLicense._driverID, localLicense._licenseClassID);

            if (isRenewAllowed()&& activeLocalLicenseID==-1)
            {
                newLicenseApplicationID = clsLocalApplication.addNewApplication(person._personID,DateTime.Now,2,3,DateTime.Now,applicationFees,clsSession.currentUser._userID,localLicense._licenseClassID
                    ,false);
                if (newLicenseApplicationID != -1)
                {
                   if (clsLocalLicense.deactivateLicense(localLicense._licenseID))
                    {
                        newLicenseID = clsLocalLicense.addNewLicense(newLicenseApplicationID,localLicense._driverID,localLicense._licenseClassID,DateTime.Now,
                            DateTime.Now.AddYears(classDefaultValidtyYears),textBox1.Text,paidFees,true,2,clsSession.currentUser._userID,false);
                        if (newLicenseID != -1) {
                            toIssueLicense = true;
                        }
                    }
                }
              
          }
            else
            {
                MessageBox.Show($"Person already has an active license with ID = {activeLocalLicenseID}",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbLicenseInfo.Enabled = false;
                btIRenew.Enabled = false;

            }
        }
     

        private void lbLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            FormShowLocalLicense form = new FormShowLocalLicense(Convert.ToInt32(newLicenseID));
            
            form.ShowDialog();
        }

        private void lbLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory(localLicense._licenseClassID,person._nationalNumber,-1
                ,Convert.ToInt32(localLicense._driverID));

            form.ShowDialog();
        }

        private void filterLicenseDriverInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btIRenew_Click(object sender, EventArgs e)
        {
     
            int licenseID = -1;
            DateTime date = DateTime.Now;

            if (MessageBox.Show("Are you sure you want to renew this license?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                
            {
                lbLicenseInfo.Enabled = true;
                issueLicense();

                if (toIssueLicense)
                {
                    MessageBox.Show($"License Renewed Successfully with ID = {newLicenseID}", "License Issued",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
            }
            else return;

        }

        private void RenewLicenseForm_Load(object sender, EventArgs e)
        {
            clsLocalLicense.updateLicenes();
        }
    }
}
