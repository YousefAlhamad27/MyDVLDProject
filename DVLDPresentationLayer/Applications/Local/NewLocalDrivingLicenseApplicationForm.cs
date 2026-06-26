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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course19
{
    public partial class NewLocalDrivingLicenseApplicationForm : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;
        private bool toAddPerson = true;
        private bool toBeClosed = false;
        private bool allowNextButton = true;
        private bool saved;
        private string _nationalNumber;
        public int localApplicationID {  get; set; }
        public string personID {  get; set; }
        public NewLocalDrivingLicenseApplicationForm(enMode mode ,string applicationID1="-1",string nationalNumber="0")
        {
            InitializeComponent();
           

            _Mode = mode;
            setClassesComboBoxValues();
            comboBox1.SelectedIndex = 0;
            _nationalNumber = nationalNumber;
            lbUsername.Text = clsSession.currentUser._username;
            if (mode == enMode.Update)
            {
                localApplicationID = Convert.ToInt32(applicationID1);
                int applicationID=clsLocalApplication.getAppIDByLocID(localApplicationID);
                clsLocalApplication application = clsLocalApplication.getLocalApplicationByID(applicationID);
                setApplicationTabDefaultValues();
                if (application != null)
                {
                    updateTitle(nationalNumber);
                    setApplicationTabValues(application);
                    clsPerson person = clsPerson.getPersonInfoUsingNationalNumber(nationalNumber);
                    personID = person._personID.ToString();
                    personID = application._personID.ToString();
                    personDetails1.personID = personID;
                    personDetails1.setValues();
                }
            }
            
           
        }
        private void setClassesComboBoxValues()
        {
            DataTable table = clsLocalLicense.getLicenseClassesNamesTable();


            for (int i = 0; i < table.Rows.Count; i++)
            {
                comboBox2.Items.Add(table.Rows[i][0].ToString());
            }
            comboBox2.SelectedIndex = 2;
        }

        private void setApplicationTabDefaultValues()
        {
            lbApplicationDate.Text = DateTime.Now.ToString();
            lbUsername.Text = clsSession.currentUser._username;
            lbFees.Text = clsApplicationType.getFeesByID(1).ToString();
        }
    private void setApplicationTabValues(clsLocalApplication application)
        {

            lbApplicationDate.Text = application._ApplicationDate.ToString();
            lbApplicationID.Text = application._applicationID.ToString();
            clsUser user = clsUser.getUserByUserID(application._createdByUserID);
            lbUsername.Text = user._username;
            lbFees.Text = clsApplicationType.getFeesByID(1).ToString();
            comboBox2.SelectedIndex = clsLocalApplication.getLicenseID(localApplicationID)-1;

        }
        public bool returnToBeClosed()
        {
            return toBeClosed;

        }
        public bool returnToAddPerson()
        {
            return toAddPerson;

        }
        public void updateTitle(string nationalNumber )
        {
            label3.Text = "Update Local Driving License Application";
            textBox1.Text= nationalNumber;
            
            gbFilter.Enabled = false;
        }
        private void btAddUser_Click(object sender, EventArgs e)
        {
            AddNewPeopleForm form = new AddNewPeopleForm(true, AddNewPerson.enMode.AddNew);
            form.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toBeClosed = true;
            toAddPerson = false;
            this.Close();
        }

        private void NewLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
           // comboBox1.SelectedIndex = 2;
            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
        }

  

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                personDetails1.setValuesToDefault();
                return;

            }

            clsPerson person = new clsPerson();
            if (comboBox1.SelectedIndex == 0)
            {
                person = clsPerson.getPersonInfoUsingNationalNumber(textBox1.Text);


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                person = clsPerson.getPersonInfoUsingPersonID(Convert.ToInt32(textBox1.Text));
            }

            if (person != null)
            {
                personDetails1.personID = person._personID.ToString();
               
                personDetails1.setValues();

            }
            else
            {
                MessageBox.Show("Person Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            personID = person._personID.ToString();
            _nationalNumber = person._nationalNumber;

            clsLocalApplication application = clsLocalApplication.getApplicationByPersonID(Convert.ToInt32(personID));
            if (application != null)
            {
                allowNextButton = false;

                setApplicationTabValues(application);
            }
            else
            {
                allowNextButton = true;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            personDetails1.setValuesToDefault();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 4;

            if (comboBox1.SelectedIndex == 1)
            {


                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                if ((textBox1.Text.Length == 0 && !char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back)
                {
                    if ((e.KeyChar == 'n' || e.KeyChar == 'N'))
                    {

                        e.Handled = false;
                    }
                }
                else if (textBox1.Text.Length > 0 && (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }
            }

        private void btNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool addNewApplication()
        {
            if (personID == null) 
                return false;
            if (!isPersonEligibleForApplication())
            {
                saved = false;
                return false;
            }

            clsLocalApplication application = new clsLocalApplication();

            application._applicationStatus = 1;
            application._ApplicationDate = DateTime.Now;
            application._lastStatusDate = DateTime.Now;
            application._createdByUserID = clsSession.currentUser._userID;
            application._paidFees = Convert.ToDecimal(clsApplicationType.getFeesByID(1));
            application._personID = Convert.ToInt32(personID);
            application._applicationTypeID = 1;
            application._licenseClassID = comboBox2.SelectedIndex + 1;
         application._applicationID=   application.addNewApplication();
            localApplicationID = clsLocalApplication.getLocApplicationID(application._applicationID);
            if (application._applicationID != -1)
            {
                saved = true;
                lbApplicationID.Text = application._applicationID.ToString();
                return true;
            }
           
                return false;
            

        }
        private bool isPersonEligibleForApplication()
        {
            int applicationID = -1;

            if (!clsLocalApplication.doesApplicantHaveSameStatusForSameLicenseClassApplication(_nationalNumber, comboBox2.SelectedIndex + 1,ref applicationID))
            {
                return true;
            }
            else
            {
                if (clsLocalApplication.getApplicationStatusAppID(applicationID) == 3)
                {

                    MessageBox.Show("Choose another license class.Person Already has a license for this license Class.", "Choose Another License Class"
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                MessageBox.Show($"Person Already has an Application with same class. Application ID is {applicationID}", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
           
            
        }
        private void UpdateApplication()
        {
            //  clsLocalApplication application = new clsLocalApplication();
            //    application = clsLocalApplication.getApplicationByID(localApplicationID);
           

            if (isPersonEligibleForApplication()) { 
                if (clsLocalApplication.updateApplicationByLocAppID(localApplicationID, comboBox2.SelectedIndex + 1))
                {

                    MessageBox.Show("Application Updated Successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } }
                
            


        }
        private void btSave_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.AddNew)
            {
                addNewApplication();
                
                
            }
            else if (_Mode == enMode.Update){

               
                
                UpdateApplication();
                }
            if(_Mode == enMode.AddNew)
            if (saved)
            {
                MessageBox.Show("Application Added Successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateTitle(_nationalNumber);
                    _Mode = enMode.Update;
                    return;

            }
          //  else MessageBox.Show("Creditentials are not valid", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                if (!allowNextButton)
                    e.Cancel = true;
                else
                {
                    e.Cancel = false;
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
