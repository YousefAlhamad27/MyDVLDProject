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
    public partial class ShowInternationalLicenseInfo : Form
    {
        private int _driverID {  get; set; }
        private int _personID { get; set; }
        private int _licenseID {  get; set; }
        private int _intLicenseID {  get; set; }

        public ShowInternationalLicenseInfo(int licenseID,int intLicenseID,int personID , int driverID)
        {
            InitializeComponent();
            _driverID=driverID;
            _licenseID=licenseID;
            _intLicenseID=intLicenseID;
            _personID=personID;
            setValues();
        }
        private void setValues()
        {
           
          clsPerson  person = clsPerson.getPersonInfoUsingPersonID(_personID);
            
            
            
            clsInternationalLicense internationalLicense = clsInternationalLicense.getInternationalLicenseByDriverID(_driverID);

            if (internationalLicense != null)
            {
                lbName.Text = person._firstName + " " + person._secondName + " " + person._thirdName + " " + person._lastName;
                lbInternationalLicenseID.Text = _intLicenseID.ToString();
                lbLocalLicenseID.Text = _licenseID.ToString();
                lbDriverID.Text = _driverID.ToString();
                lbDateOfBirth.Text = person._birthDate.ToShortDateString();
                lbDateOfExpiration.Text = internationalLicense._expirationDate.ToShortDateString();
                lbIssueDate.Text=internationalLicense._issueDate.ToShortDateString();
                lbGender.Text = person._gender;
                lbNationalID.Text = person._nationalNumber;
                lbApplicationID.Text = internationalLicense._applicationID.ToString();
                if (internationalLicense._isActive)
                    lbIsActive.Text = "Yes";
                else
                    lbIsActive.Text = "No";

                    clsUser user = clsUser.getUserByUserID(internationalLicense._createdByUserID);

                if (person._imagePath != null)
                {
                    try
                    {
                        using (var stream = new FileStream(person._imagePath, FileMode.Open, FileAccess.Read))
                        {
                            bigPictureBox.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception e)
                    {
                        bigPictureBox.Image = Resources.Male_512;
                    }



                }
                else bigPictureBox.Image = Resources.Male_512;

            }
            
           
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
