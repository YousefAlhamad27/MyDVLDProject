using Course19.Properties;
using DVDLBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course19
{
    public partial class DriverLicenseInfo : UserControl
    {
        public string licenseID {  get; set; }
        public int driverID {  get; set; }
        public DriverLicenseInfo()
        {
            InitializeComponent();
        }
        public void setValues()
        {

            clsLocalLicense license = clsLocalLicense.getLIcenseByID(Convert.ToInt32(licenseID));

            if (license != null)
            {
                license._licenseID = Convert.ToInt32(licenseID);
                clsPerson person = clsPerson.getPersonInfoUsingPersonID(clsDriver.getPersonIDByDriverID(license._driverID));
                string className = clsLocalLicense.getclassNameByID(license._licenseClassID);

                lbClass.Text = className;
                lbLicenseID.Text = licenseID.ToString();
                lbDateOfBirth.Text = person._birthDate.ToShortDateString();
                lbIssueDate.Text = license._issueDate.ToShortDateString();
                lbDateOfExpiration.Text = license._expirationDate.ToShortDateString();
                if (license._issueReason == 1)
                    lbIssueReason.Text = "First Time";
                else if(license._issueReason==2)
                    lbIssueReason.Text = "Renew";
                else if (license._issueReason == 3)
                    lbIssueReason.Text = "Replacement For Damage";
                else if (license._issueReason == 4)
                    lbIssueReason.Text = "Replacement For Lost";


                if (license._isActive)
                    lbIsActive.Text = "Yes";
                else lbIsActive.Text = "No";
                lbGender.Text = person._gender;
                lbNationalID.Text = person._nationalNumber;
                lbName.Text = (person._firstName + " " + person._secondName + " " + person._thirdName + " " + person._lastName);
                lbDriverID.Text = license._driverID.ToString();
                driverID = license._driverID;
                if (clsDetainedLicense.isLicenseDetained(Convert.ToInt32(licenseID)))
                {
                    lbIsDetained.Text = "Yes";
                }
                else
                {
                    lbIsDetained.Text = "No";
                }
                if (license._notes != null)
                    lbNotes.Text = license._notes;
                else lbNotes.Text = "No Notes";
                if (person._imagePath != null)
                {
                    try
                    {
                        using (var stream = new FileStream(person._imagePath, FileMode.Open, FileAccess.Read))
                        {
                            bigPictureBox.Image = Image.FromStream(stream);
                        }
                    }
                    catch(Exception e)
                    {
                          bigPictureBox.Image = Resources.Male_512;
                    }
                    


                }
                else bigPictureBox.Image = Resources.Male_512;

            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
