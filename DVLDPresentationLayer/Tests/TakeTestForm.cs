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
    public partial class TakeTestForm : Form
    {
        private int _appointmentID;
        TestTypeAppointmentsForm.eTestAppointmentType eType;

        public TakeTestForm(TestTypeAppointmentsForm.eTestAppointmentType etype,int testAppointmentID)
        {
            eType= etype;
            _appointmentID = testAppointmentID;
            InitializeComponent();

            updateTitle();
            setInformation();
            
        }

        private void setInformation()
        {
            int locAppID = -1;
            string className = "";
            string fullName = "";
            int trialcount = -1;
            DateTime date= DateTime.Now.AddYears(-1);
            decimal fees = 0;


            if(clsAppointment.getTestInfo(_appointmentID, (int)eType, ref locAppID, ref className, ref fullName, ref trialcount, ref date, ref fees))
            {
                lbID.Text = locAppID.ToString();
                lbClass.Text = className.ToString();
                lbName.Text = fullName.ToString();
                lbFees.Text = fees.ToString();
                lbDate.Text= date.ToShortDateString();
                lbTrial.Text = trialcount.ToString();


            }


        }
        private void updateTitle()
        {
            if (eType == eTestAppointmentType.Vision)
            {
                this.Text = "Vision Test Appointments";
                groupBoxTest.Text = "Vision Test Appointments";
                BigPictureBox.Image = Properties.Resources.Vision_512;

            }
            else if (eType == eTestAppointmentType.Written)
            {
                this.Text = "Written Test Appointments";
                groupBoxTest.Text = "Written Test Appointments";
                BigPictureBox.Image = Course19.Properties.Resources.Written_Test_512;
            }
            else
            {
                this.Text = "Street Test Appointments";
                groupBoxTest.Text = "Street Test Appointments";
                BigPictureBox.Image = Properties.Resources.driving_test_512;
            }
        }
       private bool areValuesChosen()
        {
            
            return radioFail.Checked || radioPass.Checked;


        }

        private void takeTest()
        {
            int locAppID = clsAppointment.getLocAppID(_appointmentID);
            if (clsLocalApplication.getPassedTests(locAppID) == 3)
                return;

            int testID = -1;
            if (areValuesChosen())
            {
               testID= clsTakeTest.addNewTest(_appointmentID,radioPass.Checked,txtBoxNotes.Text,clsSession.currentUser._userID);
                if (testID != -1)
                {
                    MessageBox.Show("Test taken Successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed To Take Test", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Choose values","Try Again",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            takeTest();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
