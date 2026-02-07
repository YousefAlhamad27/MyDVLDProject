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
    public partial class FormDetainLicense : Form
    {
        private bool toDetainLicense = false;
        private int _licenseID {  get; set; }
        private clsLocalLicense localLicense;
        private int driverID;
        private int detainID {  get; set; }
        private clsPerson person;

        decimal fineFees;
     
        public FormDetainLicense()
        {
            InitializeComponent();
            filterLicenseDriverInfo1.LicenseIDSubmitted += licenseID_Submitted;
        }
        private void licenseID_Submitted(object sender, UserDataEventArgs e)
        {
            localLicense = e.license;
            driverID = e.driverID;
            lbLicenseInfo.Enabled = true;
            lbLicensesHistory.Enabled = true;
            setValues();
            test();

        }
           
private bool test()
        {



    if (!isExpired())
    {

        if (clsDetainedLicense.isLicenseDetained(_licenseID))
        {
            MessageBox.Show($"Selected License is already Detained, choose another one.",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btDetain.Enabled = false;
            return false;
        }

        else
        {
                    btDetain.Enabled = true;
        }

        return true;
    }

    else
    {
        MessageBox.Show("Selected License is Expired,you are not allowed detain it.", "Choose Another License",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        btDetain.Enabled = false;
        return false;
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
        

            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory(
                localLicense._licenseClassID, person._nationalNumber, -1, Convert.ToInt32(localLicense._driverID));

            form.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detainLicense()
        {
           

            detainID = clsDetainedLicense.addNewDetainedLicense(_licenseID,Convert.ToDecimal(textBoxFees.Text));
            if (detainID != -1)
            {
                lbDetainID.Text = detainID.ToString();
                toDetainLicense = true;
            }
            else
            {
                MessageBox.Show($"Failed to detain License. Try again.",
                  "Something gone wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isTextBoxEmpty()
        {
            if(textBoxFees.Text.Length == 0)
            {
                MessageBox.Show($"Choose Fees amount.",
                  "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false ;
        }
        private void btDetain_Click(object sender, EventArgs e)
        {
            if (isTextBoxEmpty())
                return;

            int licenseID = -1;
            DateTime date = DateTime.Now;

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                detainLicense();
                if (toDetainLicense)
                {
                    MessageBox.Show($"License Detained Successfully with ID = {detainID}.", "License Detained",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

             
            }
            
        }

        private void FormDetainLicense_Load(object sender, EventArgs e)
        {
            lbUsername.Text = clsSession.currentUser._username;
            lbDetainDate.Text = DateTime.Now.ToShortDateString();
            clsLocalLicense.updateLicenes();
        }
    }
}
