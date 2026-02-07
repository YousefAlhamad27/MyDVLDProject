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
using static Course19.TestTypeAppointmentsForm;

namespace Course19
{
    public partial class ScheduleTestForm : Form
    {
        private bool toSave = false;
        private bool _retakeTest = false;
       
        public TestTypeAppointmentsForm.eTestAppointmentType eTestType;
        public enum enMode {New=1,Retake=2 }
        enMode mode;
        public int _LocAppID { get; set; }
        private bool _updateMode;
        private struct stTestDetails{

       public int localAppID { get; set; }
       public string className { get; set; }
       public string fullName { get; set; }
       public int trailCount { get; set; }
       public DateTime date { get; set; }
       public decimal fees { get; set; }

           
        }
        stTestDetails stDetails;
        private struct stRetakeDetails
        {
            public decimal retakeFees { get; set; }
            public decimal TotalFees { get; set; }
            public int retakeTestID { get; set; }
           

        }
        stRetakeDetails sRetakeDetails;
        private int _testAppointmentID;

        public ScheduleTestForm(TestTypeAppointmentsForm.eTestAppointmentType eTestType, int localAppID, bool updateMode = false,bool retakeTest=false,int testAppointmentID=-1)
        {
            InitializeComponent();
            this.eTestType = eTestType;
            _retakeTest = retakeTest;
            if (retakeTest)
                mode = enMode.Retake;
            else
                mode = enMode.New;
                _LocAppID = localAppID;
            _updateMode = updateMode;
            _testAppointmentID = testAppointmentID;

         setModeDetails();
            setValues();
        }
        private void setValues()
        {
            lbID.Text = _LocAppID.ToString();
            stDetails.localAppID= _LocAppID;
            int appID= clsLocalApplication.getAppIDByLocID(_LocAppID); 
            clsLocalApplication application = clsLocalApplication.getLocalApplicationByID(appID);
            if (application != null)
            {


                stDetails.fullName = clsPerson.getPersonFullNameByID(application._personID);
                lbName.Text = stDetails.fullName;

                stDetails.className = clsLocalApplication.getLicenseClassNameByLocID(_LocAppID);
                lbClass.Text = stDetails.className;

                stDetails.fees = clsTestType.getTestTypeApplicationFees((int)(eTestType));
                lbFees.Text = stDetails.fees.ToString();

            //    stDetails.date = DateTime.Now;
             //   dateTimePicker1.Value =DateTime.Now;

                stDetails.trailCount = clsTestType.getCountOfTrialsLocAppID(_LocAppID, (int)eTestType);
                lbTrial.Text = stDetails.trailCount.ToString();

                if (!_retakeTest)
                {
                   
                    sRetakeDetails.TotalFees =  stDetails.fees;
                    lbTotalFees.Text = sRetakeDetails.TotalFees.ToString();
                }
                else
                {
                    sRetakeDetails.retakeFees = 5;

                    lbRetakeFees.Text = sRetakeDetails.retakeFees.ToString();

                    sRetakeDetails.TotalFees = sRetakeDetails.retakeFees + stDetails.fees;
                   
                    lbTotalFees.Text = sRetakeDetails.TotalFees.ToString();
                  // lbRetakeTestID.Text=
                }
             //   setStructureValues(_LocAppID,lbClass.Text,lbName.Text,Convert.ToInt32(lbTrial.Text),application._ApplicationDate,
               //     Convert.ToInt32(lbTotalFees.Text),Convert.ToInt32(lbRetakeFees.Text));
            }
        }
        private void setStructureValues(int locappID,string className,string fullName,int trialCount,DateTime date,decimal Fees,decimal totalFees,decimal retakeFees=0,int retakeTestID=-1)
        {
            stDetails.localAppID = locappID;
            stDetails.className = className;
            stDetails.fullName = fullName;
            stDetails.trailCount = trialCount;
            stDetails.date = date;
            sRetakeDetails.retakeFees = retakeFees;
            sRetakeDetails.TotalFees = retakeFees + Fees;
            

        }

        private void setModeDetails()
        {

            if (eTestType == eTestAppointmentType.Vision)
            {
                groupBoxTest.Text = "Vision Test Appointments";

                BigPictureBox.Image = Properties.Resources.Vision_512;

            }
            else if (eTestType == eTestAppointmentType.Written)
            {
                groupBoxTest.Text = "Written Test Appointments";
                BigPictureBox.Image = Course19.Properties.Resources.Written_Test_512;

            }
            else
            {
                groupBoxTest.Text = "Street Test Appointments";
                BigPictureBox.Image = Properties.Resources.driving_test_512;

            }

            if (_retakeTest)
            {
                bigLabel.Text = "Schedule Retake Test";
                groupBoxRetake.Enabled = true;
            }
            else
            {
                bigLabel.Text = "Schedule Test";
                groupBoxRetake.Enabled = false;
            }
        }

            
        private void btClose_Click(object sender, EventArgs e)
        {
             this.Close();
        }
        private void scheduleTest() {

            if (!_updateMode)
            {
                if (!clsAppointment.isApplicantEligibleForAnotherAppointment(_LocAppID))
                {
                    toSave = false;
                    return;
                }
                int appointmentID = -1;


                appointmentID = clsAppointment.addNewAppointment((int)eTestType,
                   _LocAppID, dateTimePicker1.Value, sRetakeDetails.TotalFees, clsSession.currentUser._userID, false);
                if (appointmentID != -1)
                {
                    lbRetakeTestID.Text = appointmentID.ToString();
                    toSave = true;
                }
                else
                {
                    toSave = false;
                }
            }

            else if (_updateMode)
            {
                if (clsAppointment.updateAppointment(_testAppointmentID, dateTimePicker1.Value))
                {
                    toSave = true;
                }
            }

            }
          

        
        private void btSave_Click(object sender, EventArgs e)
        {
            scheduleTest();
            if (toSave) {
                MessageBox.Show("Data Saved Successfully!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            }
            else
            {
                MessageBox.Show( "Failed To Schedule Appointment", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
