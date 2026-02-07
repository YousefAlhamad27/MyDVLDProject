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
    public partial class TestTypeAppointmentsForm : Form
    {
       
        public enum eTestAppointmentType {Vision=1,Written=2,Street=3 }
        public eTestAppointmentType eType { get; set; }
        private int _applicationID;
        private int _locAppID;
        public TestTypeAppointmentsForm(eTestAppointmentType eType, int locAppID = -1 )
        {
            InitializeComponent();
            this.eType = eType;
            if (locAppID != -1)
            {
                _locAppID = locAppID;
                _applicationID = clsLocalApplication.getAppIDByLocID(locAppID);
            }

            
           
          
            }
        private void setMode()
        {
            if (eType == eTestAppointmentType.Vision)
            {
                this.Text = "Vision Test Appointments";
                lbTestAppointmentsType.Text = "Vision Test Appointments";
                BigPictureBox.Image = Properties.Resources.Vision_512;

            }
            else if (eType == eTestAppointmentType.Written)
            {
                this.Text = "Written Test Appointments";
                lbTestAppointmentsType.Text = "Written Test Appointments";
                BigPictureBox.Image = Course19.Properties.Resources.Written_Test_512;
            }
            else
            {
                this.Text = "Street Test Appointments";
                lbTestAppointmentsType.Text = "Street Test Appointments";
                BigPictureBox.Image = Properties.Resources.driving_test_512;
            }
        }
        private void setApplicationLicenseInfoControlValues()
        {
            applicationLicenseInfoUserControl2.localAppID = _locAppID;
            applicationLicenseInfoUserControl2.applicationID = _applicationID;
            applicationLicenseInfoUserControl2.setValues();
        }
        private void setToDefaultDataGridView()
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.Rows.Clear(); // Clears all rows from the DataTable
                                 // If you want to clear columns as well, you would also do:
                dt.Columns.Clear();
            }
            dataGridView1.DataSource = null; // Unbinds the DataGridView from the data source
            dataGridView1.Refresh(); // Refreshes the display

            dataGridView1.DataSource = clsAppointment.getAppointmentsTable(_locAppID);
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
          



            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();
        }
        private void VisionTestAppointmentsForm_Load(object sender, EventArgs e)
        {
            setMode();
            setToDefaultDataGridView();
            setApplicationLicenseInfoControlValues();
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();
         
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddNewAppointment_Click(object sender, EventArgs e)
        {
            ScheduleTestForm scheduleTestForm;
            if (!clsAppointment.isApplicantEligibleForAnotherAppointment(_locAppID))
                {
                MessageBox.Show("Person already has an open Appointment.","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                return; }
            else if(clsLocalApplication.getPassedTests(_locAppID) == 3)
            {
                MessageBox.Show("Person has already passed all tests.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (clsAppointment.getTestTypeAppointmentsCount(_locAppID, (int)eType) != 0)
            {
                scheduleTestForm = new ScheduleTestForm(eType, _locAppID, false, true);
            }

            else
            {
                scheduleTestForm = new ScheduleTestForm(eType, _locAppID, false, false);
            }
                 

            scheduleTestForm.ShowDialog();
            setToDefaultDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTestForm form= new ScheduleTestForm(eType, _locAppID,true,false, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
         //   form._appID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();


        }

        private void takeTesdtToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  if (dataGridView1.CurrentRow.Cells[3].Value == true)
            
                
            
                int testAppointmentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int passedTests = clsLocalApplication.getPassedTests(_locAppID);


            TakeTestForm form= new TakeTestForm(eType, testAppointmentID);

            
            form.ShowDialog();
            setToDefaultDataGridView();
            //if(passedTests!= clsLocalApplication.getPassedTests(_locAppID)){

            //    if (eType == eTestAppointmentType.Street)
            //    {
            //        tsTakeTest.Enabled = false;
            //        return;
            //    }
            //    else if(eType == eTestAppointmentType.Vision)
            //    {eType = eTestAppointmentType.Written;
            //        setMode();
            //    }
            //    else
            //    {
            //        eType = eTestAppointmentType.Street;
            //        setMode();
            //    }
            
            

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value) == true)
            {
                tsTakeTest.Enabled = false;
            }
            else
            {
                tsTakeTest.Enabled = true;
            }

        }
    }
}
