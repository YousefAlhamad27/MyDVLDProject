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
    public partial class FormShowPersonLicenseHistory : Form
    {
        private bool toBeClosed = false;
        private bool toAddPerson = true;
        private int personID {  get; set; }
        private int _licenseID {  get; set; }
        private int _intLicenseID { get; set; }
        private int _driverID {  get; set; }
        clsPerson person;
        public FormShowPersonLicenseHistory(int licenseID,string nationalNumber="-1",int intLicenseID=-1,int driverID=-1)
        {
            if (intLicenseID == -1)
            {
                _intLicenseID = clsInternationalLicense.doesPersonHaveAnInternationalLicense(driverID);
            }
            else
                _intLicenseID = intLicenseID;

            InitializeComponent();
            _licenseID = licenseID;
            _driverID = driverID;
         
             person = clsPerson.getPersonInfoUsingNationalNumber(nationalNumber);
            if (person != null)
            {
                personDetails1.personID = person._personID.ToString();
                personID = person._personID;
                personDetails1.setValues();
            }
            
        }

        private void setToDefault()
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.Rows.Clear(); // Clears all rows from the DataTable
                                 // If you want to clear columns as well, you would also do:
                dt.Columns.Clear();
            }
            dataGridView2.DataSource = null; // Unbinds the DataGridView from the data source
            dataGridView2.Refresh(); // Refreshes the display
            if (dataGridView1.DataSource is DataTable dts)
            {
                dts.Rows.Clear(); // Clears all rows from the DataTable
                                 // If you want to clear columns as well, you would also do:
                dts.Columns.Clear();
            }

            dataGridView2.DataSource = null; // Unbinds the DataGridView from the data source
            dataGridView2.Refresh(); // Refreshes the display
            

            dataGridView1.DataSource = clsLocalLicense.getFilteredLocalLicenseTable(_driverID.ToString(),clsLocalLicense.eFilterBasis.DriverID);
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 125;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
 

        
            dataGridView2.DataSource = clsInternationalLicense.getFilteredTable(_intLicenseID.ToString(),clsInternationalLicense.eFilterBasis.InterLicenseID);
            dataGridView2.Columns[0].Width = 180;
            dataGridView2.Columns[1].Width = 125;
            dataGridView2.Columns[2].Width = 150;
            dataGridView2.Columns[3].Width = 150;
            dataGridView2.Columns[4].Width = 150;
            dataGridView2.Columns[5].Width = 100;



            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();
            lbNumRecords2.Text = dataGridView2.Rows.Count.ToString();
            comboBox1.SelectedIndex = 1;
            textBox1.Text = personID.ToString();




        }

        private void FormShowPersonLicenseHistorycs_Load(object sender, EventArgs e)
        {

            setToDefault();
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AddNewPeopleForm addPersonForm = new AddNewPeopleForm(false, AddNewPerson.enMode.Update);
            addPersonForm.ShowDialog();

            toBeClosed = true;
            toAddPerson = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void tsShowLocalLicenseInfo_Click(object sender, EventArgs e)
        {
            FormShowLocalLicense frm=new FormShowLocalLicense(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void tsShowInternationalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInternationalLicenseInfo frm = new ShowInternationalLicenseInfo(Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value),
                Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value),person._personID,_driverID);

            frm.ShowDialog();
        }
    }
}
