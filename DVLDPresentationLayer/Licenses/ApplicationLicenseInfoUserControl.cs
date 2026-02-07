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
    public partial class ApplicationLicenseInfoUserControl : UserControl
    {
        public int localAppID { get; set; }
        public int applicationID { get; set; }
        public ApplicationLicenseInfoUserControl()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void setValues()
        {
            lbDrivingLicenseApplicationID.Text = localAppID.ToString();

            clsLocalApplication application=clsLocalApplication.getLocalApplicationByID(applicationID);
            application._applicationID = applicationID;

            if (application != null) { 
            lbLicenseClass.Text=clsLocalApplication.getLicenseClassNameByLocID(localAppID);
                int passedTests = clsLocalApplication.getPassedTests(localAppID);

                if (passedTests==0)
                {
                    lbNumPassedTests.Text = "0/3";
                }
                else if (passedTests == 1)
                {
                    lbNumPassedTests.Text = "1/3";
                }
                else if (passedTests == 2)
                {
                    lbNumPassedTests.Text = "2/3";
                }
                else if (passedTests == 3)
                {
                    lbNumPassedTests.Text = "3/3";
                }

                lbApplicationID.Text = applicationID.ToString();
                lbApplicantName.Text=clsPerson.getPersonFullNameByID(application._personID);
                lbDate.Text=application._ApplicationDate.ToShortDateString();
                lbStatusDate.Text=application._lastStatusDate.ToShortDateString();
                lbFees.Text=application._paidFees.ToString();
                clsUser user= clsUser.getUserByPersonID(application._personID);
                if (user != null)
                    lbUsername.Text = user._username;
                else
                    lbUsername.Text = "Doesn't Exist anymore";
                    lbType.Text = clsApplicationType.getTypeNameByAppID(application._applicationID);

                //if (clsDriver.exists())
                //{
                //    linkShowLicenseInfo.Enabled = true;
                //}

                if (application._applicationStatus == 1)
                {
                    lbStatus.Text = "New";
                }
                else if (application._applicationStatus == 2)
                {
                    lbStatus.Text = "Cancelled";
                }
                else
                {
                    lbStatus.Text = "Completed";
                }


                lbLicenseClass.Text = clsLocalApplication.getLicenseClassNameByLocID(localAppID);

            }

            




        }
        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoForm licenseInfoForm = new LicenseInfoForm();
            licenseInfoForm.ShowDialog();

        }

        private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonDetailsForm personDetailsForm = new PersonDetailsForm("0");  
            personDetailsForm.Show();
        }
    }
}
