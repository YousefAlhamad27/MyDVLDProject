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
    public partial class ManageLocalLicenseApplicationsFormcs : Form
    {
        private string _nationalNumber;
        public ManageLocalLicenseApplicationsFormcs()
        {
            InitializeComponent();
        }

        private void LocalLicenseApplicationsFormcs_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            setToDefault();
           

        }

        private void setToDefault()
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.Rows.Clear(); // Clears all rows from the DataTable
                                 // If you want to clear columns as well, you would also do:
                dt.Columns.Clear();
            }
            dataGridView1.DataSource = null; // Unbinds the DataGridView from the data source
            dataGridView1.Refresh(); // Refreshes the display

            dataGridView1.DataSource= clsLocalApplication.getAllApplications();
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 300;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 125;
            dataGridView1.Columns[6].Width = 125;
            


            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();
        }
        private void RefreshValues(DataTable dataTable)
        {

            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.Rows.Clear(); // Clears all rows from the DataTable
                                 // If you want to clear columns as well, you would also do:
                dt.Columns.Clear();
            }
            dataGridView1.DataSource = null; // Unbinds the DataGridView from the data source
            dataGridView1.Refresh(); // Refreshes the display

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 300;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 125;
            dataGridView1.Columns[6].Width = 125;
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();

        }
        private void btAddApplication_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplicationForm form = new NewLocalDrivingLicenseApplicationForm(NewLocalDrivingLicenseApplicationForm.enMode.AddNew);
            form.ShowDialog();

            setToDefault();


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        
        {
            setToDefault();
            if (comboBox1.SelectedIndex == 0)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;

            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Enabled = false;
            if (comboBox1.SelectedIndex == 1||comboBox1.SelectedIndex==4)
            {
                textBox1.MaxLength = 4;

                if (comboBox1.SelectedIndex == 4)
                   textBox1.MaxLength = 1;

                
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox1.MaxLength = 40;
                e.Handled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.MaxLength = 5;

                if ((textBox1.Text.Length == 0 && !char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back)
                {
                    if ((e.KeyChar == 'n' || e.KeyChar == 'N'))
                    {

                        e.Handled = false;
                    }
                    else if (e.KeyChar == (char)Keys.Back)
                        e.Handled = false;
                    else e.Handled = true;
                }
                else if (textBox1.Text.Length > 0 && (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = false;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    textBox1.MaxLength = 40;
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }

        }

        private void tsScheduleVisionTest_Click(object sender, EventArgs e)
        {
            TestTypeAppointmentsForm visionTestAppointmentsForm = new TestTypeAppointmentsForm(TestTypeAppointmentsForm.eTestAppointmentType.Vision
                ,Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        

            visionTestAppointmentsForm.ShowDialog();
            setContextMenuOptions();
            setToDefault();
        }

        private void tsShowAppDetails_Click(object sender, EventArgs e)
        {
        int appID=    clsLocalApplication.getAppIDByLocID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            ShowApplicationDetails form= new ShowApplicationDetails(appID);

            form.ShowDialog();
            
           
        }

        private void tsDeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this application?","Confirm",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                int applicationID = clsLocalApplication.getAppIDByLocID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                clsLocalApplication.deleteLocalApplicationByAppID(applicationID);

                MessageBox.Show("Application Deleted Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
            setToDefault();
                
        }

        private void tsEditApplication_Click(object sender, EventArgs e)
        {
           NewLocalDrivingLicenseApplicationForm form = new 
                NewLocalDrivingLicenseApplicationForm(NewLocalDrivingLicenseApplicationForm.enMode.Update, dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString());
          
           
            form.ShowDialog();
            setToDefault();
            
        }

        private void tsShowLicense_Click(object sender, EventArgs e)
        {
           
            int applicationID = clsLocalApplication.getAppIDByLocID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

          int licenseID=clsLocalLicense.getLicenseIDByAppID(applicationID);
            FormShowLocalLicense form= new FormShowLocalLicense(licenseID);
            form.ShowDialog();
            dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void tsScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            TestTypeAppointmentsForm writtenTestAppointment =
                new TestTypeAppointmentsForm(TestTypeAppointmentsForm.eTestAppointmentType.Written, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

           

            writtenTestAppointment.ShowDialog();
            setContextMenuOptions();
            setToDefault();
        }

        private void tsScheduleStreetTest_Click(object sender, EventArgs e)
        {
            TestTypeAppointmentsForm streetTestAppointmentForm =
                new TestTypeAppointmentsForm(TestTypeAppointmentsForm.eTestAppointmentType.Street, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

            

            streetTestAppointmentForm.ShowDialog();
            setContextMenuOptions();
            setToDefault();
        }

        private void tsIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            FormIssueDriverLicenseFirstTime form =new FormIssueDriverLicenseFirstTime(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[2].Value.ToString());

            form.ShowDialog();
            setToDefault();
        }

        private void tsShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
             dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int appID = clsLocalApplication.getAppIDByLocID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

            int licenseID = clsLocalLicense.getLicenseIDByAppID(appID);
            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory(licenseID, dataGridView1.CurrentRow.Cells[2].Value.ToString());
            form.ShowDialog();
        }

        private void tsCancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsLocalApplication.
                     updateApplicationStatusByLocID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                     clsLocalApplication.enApplicationStatus.Cancelled)) {  
 
                    MessageBox.Show("Application Cancelled Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setToDefault();
                }
                
                else
                {
                    MessageBox.Show("Failed To Delete Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                setToDefault();
            }

            clsLocalApplication Application = new clsLocalApplication();
            DataTable dataTable = new DataTable();


            if (comboBox1.SelectedIndex == 0)
            {
                Application.eFilter = clsLocalApplication.enFilter.None;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Application.eFilter = clsLocalApplication.enFilter.LocalApplicationLicenseID;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Application.eFilter = clsLocalApplication.enFilter.NationalNo;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Application.eFilter = clsLocalApplication.enFilter.fullName;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Application.eFilter = clsLocalApplication.enFilter.Status;
            }
            
            if (textBox1.Text != "")
            {
                dataTable = Application.getFilteredApplicationsDataTable(textBox1.Text);
                dataGridView1.Refresh();
                RefreshValues(dataTable);
            }
            else setToDefault();

        }

       private void setContextMenuOptions()
        {
            int locAppID=    Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            int licenseClassID = clsLocalApplication.getLicenseID(locAppID);
            int status = clsLocalApplication.getApplicationStatusLocAppID(locAppID);
          int passedTests= clsLocalApplication.getPassedTests(locAppID);
            switch (status)
            {
                case 3:
                    {
                        tsCancelApplication.Enabled = false;
                        tsDeleteApplication.Enabled = false;
                        tsEditApplication.Enabled = false;
                        tsIssueDrivingLicenseFirstTime.Enabled = false;
                        tsScheduleTests.Enabled = false;
                        tsShowAppDetails.Enabled = true;
                        tsShowLicense.Enabled = true;
                       
                    }
                    break;
                case 1:
                    {
                        tsCancelApplication.Enabled = true;
                        tsDeleteApplication.Enabled = true;
                        tsShowAppDetails.Enabled = true;
                        tsEditApplication.Enabled = true;
                        if (passedTests==3) {
                            tsIssueDrivingLicenseFirstTime.Enabled = true;
                            tsScheduleTests.Enabled = false;

                        }
                        else if (passedTests==2)
                        {
                            tsIssueDrivingLicenseFirstTime.Enabled = false;
                            tsScheduleTests.Enabled = true;
                            tsScheduleStreetTest.Enabled = true;
                            tsScheduleVisionTest.Enabled = false;
                            tsScheduleWrittenTest.Enabled = false;
                        }
                        else if (passedTests == 1)
                        {
                            tsIssueDrivingLicenseFirstTime.Enabled = false;
                            tsScheduleTests.Enabled = true;
                            tsScheduleStreetTest.Enabled = false;
                            tsScheduleVisionTest.Enabled = false;
                            tsScheduleWrittenTest.Enabled = true;
                        }
                        else if(passedTests == 0)
                        {
                            tsIssueDrivingLicenseFirstTime.Enabled = false;
                            tsScheduleTests.Enabled = true;
                            tsScheduleStreetTest.Enabled = false;
                            tsScheduleVisionTest.Enabled = true;
                            tsScheduleWrittenTest.Enabled = false;
                        }

                            tsShowLicense.Enabled = false;
                       
                    }
                    break;
                case 2:
                    {
                        tsCancelApplication.Enabled = false;
                        tsDeleteApplication.Enabled = true;
                        tsEditApplication.Enabled = false;
                        tsIssueDrivingLicenseFirstTime.Enabled = false;
                        tsScheduleTests.Enabled = false;
                        tsShowAppDetails.Enabled = true;
                       
                        tsShowPersonLicenseHistory.Enabled = true;
                        if (passedTests == 3)
                        {
                            tsShowLicense.Enabled = true;
                        }
                        else
                            tsShowLicense.Enabled = false;
                    }
                    break;
            }


        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            setContextMenuOptions();
        }
    }
}
