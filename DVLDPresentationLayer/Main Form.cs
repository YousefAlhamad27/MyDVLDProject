using DVDLBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Course19
{
    public partial class Main : Form
    {
      
        public clsLogin.ESignMode _mode=clsLogin.ESignMode.Terminate;

        public Main()
        {
           
            InitializeComponent();
        
        }

  
 
    

     

        private void button1_Click(object sender, EventArgs e)
        {
            ManagePeopleForm form = new ManagePeopleForm();
            form.ShowDialog();

            form.Close();

        }

      

        private void btApplications_Click(object sender, EventArgs e)
        {

        }

        private void btPeople_Click(object sender, EventArgs e)
        {
            
            ManagePeopleForm form = new ManagePeopleForm();
            form.ShowDialog();

            form.Close();
            
        }

     
         private void ContextSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            clsSession.currentUser = null;
            _mode = clsLogin.ESignMode.Signout;
            clsLogin.setToTerminate(false);

        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm form = new ManageUsersForm();
            form.ShowDialog();  
            
            
            form.Close();
        }

        private void ContextUserInfo_Click(object sender, EventArgs e)
        {
           UserInfoForm form = new UserInfoForm(clsSession.currentUser._userID.ToString());  
            form.ShowDialog();
        }

        private void ContextChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(clsSession.currentUser._userID);
            form.ShowDialog();
        }

        private void tsManageApplicationTypes_Click(object sender, EventArgs e)
        {
            ManageApplicationTypesForm form = new ManageApplicationTypesForm(); 
            form.ShowDialog();

        }

        private void tsManageTestTypes_Click(object sender, EventArgs e)
        {
            ManageTestTypesForm form = new ManageTestTypesForm();
            form.ShowDialog();
        }

        private void tsLocalLicense_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplicationForm form =new NewLocalDrivingLicenseApplicationForm(NewLocalDrivingLicenseApplicationForm.enMode.AddNew);
            form.ShowDialog();

            if (form.returnToBeClosed() )
            {
                AddNewPeopleForm addPersonForm = new AddNewPeopleForm(true, AddNewPerson.enMode.AddNew);
                addPersonForm.ShowDialog();
            }
          

            }

        private void tsLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            ManageLocalLicenseApplicationsFormcs form = new ManageLocalLicenseApplicationsFormcs();
            form.ShowDialog();

        }

        private void btDrivers_Click(object sender, EventArgs e)
        {
            ManageDriversForm form = new ManageDriversForm();   
            form.ShowDialog();
        }

        private void tsInternationalLicense_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplicationForm form=new NewInternationalLicenseApplicationForm();
            form.ShowDialog();
        }

        private void tsInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            InternationalLicenseApplicationsForm form = new InternationalLicenseApplicationsForm();
            form.ShowDialog();
        }

        private void tsRetakeTest_Click(object sender, EventArgs e)
        {

            QuestionRetakeTestTypeForm question = new QuestionRetakeTestTypeForm();
            question.ShowDialog();

            if (question.userClosed)
            {
                return;
            }

            

            TakeTestForm form = new TakeTestForm(question.type,-1);

            form.ShowDialog();
        }

        private void tsRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            RenewLicenseForm form = new RenewLicenseForm();
            form.ShowDialog();
        }

        private void tsReplacementLostDamaged_Click(object sender, EventArgs e)
        {
            ReplacementDamagedLostForm form = new ReplacementDamagedLostForm();
            form.ShowDialog();
        }

        private void tsDetainLicenseDropDown_Click(object sender, EventArgs e)
        {
            FormDetainLicense form = new FormDetainLicense();
            form.ShowDialog();
        }

        private void tsReleaseDetainedLicenseDropDown_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm form = new ReleaseDetainedLicenseForm();
            form.ShowDialog();
        }

        private void tsManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            ManageDetainedLicense manageDetainedLicense =new ManageDetainedLicense();

            manageDetainedLicense.ShowDialog();
        }

        private void tsReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm form=new ReleaseDetainedLicenseForm();
            form.ShowDialog();
        }
    }
}





