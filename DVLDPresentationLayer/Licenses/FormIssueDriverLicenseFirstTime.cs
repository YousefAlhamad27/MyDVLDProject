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

namespace Course19
{
    public partial class FormIssueDriverLicenseFirstTime : Form
    {
        private int _applicationID;
        private int _locAppID;
        private bool isLicenseIssue;
        private string nationalNo;
        public FormIssueDriverLicenseFirstTime(int locAppID = -1,string nationalnumber="")
        {
            InitializeComponent();

            if (locAppID != -1)
            {
                nationalNo = nationalnumber;
                _locAppID = locAppID;
                _applicationID = clsLocalApplication.getAppIDByLocID(locAppID);
            }
        }

        private void setApplicationLicenseInfoControlValues()
        {
            applicationLicenseInfoUserControl1.localAppID = _locAppID;
            applicationLicenseInfoUserControl1.applicationID = _applicationID;
            applicationLicenseInfoUserControl1.setValues();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int issueLicense()
        {
            int licenseID = -1;
         clsPerson person=clsPerson.getPersonInfoUsingNationalNumber(nationalNo);
            int driverID=clsDriver.isPersonADriver(person._personID);
            int licenseClassID=clsLocalApplication.getLicenseID(_locAppID);
            DateTime requiredAgeDate = person._birthDate.AddYears(clsLocalLicense.getMinimumAge(licenseID));

            if (requiredAgeDate > DateTime.Now)
            {
                // Person is NOT eligible yet
                MessageBox.Show("Person is not old enough for this license type.");
                return licenseID ;
            }

            DateTime expirationDate = DateTime.Now.AddYears(clsLocalLicense.defaultValidityYears(licenseClassID));

            if (driverID == -1) {

               driverID= clsDriver.addNewDriver(person._personID,DateTime.Now);
                
            
            }
            licenseID = clsLocalLicense.addNewLicense(_applicationID, driverID, licenseClassID, DateTime.Now, expirationDate, txtBoxNotes.Text,clsLocalLicense.getFees(licenseClassID), true, 1, clsSession.currentUser._userID);
            if (licenseID != -1)
            {
                isLicenseIssue = true;
                return licenseID;
            }
            return licenseID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int licenseID=-1;

          licenseID=  issueLicense();
            if (licenseID != -1)
            {
                MessageBox.Show("License Issues Successfully with license ID = " + licenseID, "Succeeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To issue License","Fail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            setApplicationLicenseInfoControlValues();


        }
    }
}
