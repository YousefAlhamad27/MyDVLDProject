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
    public partial class InternationalLicenseApplicationsForm : Form
    {
        public InternationalLicenseApplicationsForm()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;

            textBox1.Text = "";
            setToDefault();
        }

        private void btAddApplication_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplicationForm form = new NewInternationalLicenseApplicationForm();
            form.ShowDialog();

            setToDefault();
        }
        private void InternationalLicenseApplicationsForm_Load(object sender, EventArgs e)
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

            dataGridView1.DataSource = clsInternationalLicense.getInternationalLicensesTable();
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 125;
          
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();


           
        }
        private void tsShowPersonDetails_Click(object sender, EventArgs e)
        {
           int personID= clsDriver.getPersonIDByDriverID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));

            PersonDetailsForm form = new PersonDetailsForm(personID.ToString());
           
          
            form.ShowDialog();
        }

        private void tsShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            int driverID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int localLicenseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            int intLicenseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int personID = clsDriver.getPersonIDByDriverID(driverID);
           clsPerson person= clsPerson.getPersonInfoUsingPersonID(personID);

            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory(localLicenseID,person._nationalNumber,intLicenseID,driverID);
            

            form.ShowDialog();
        }

        private void tsShowLicenseDetails_Click(object sender, EventArgs e)
        {
            int driverID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int localLicenseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            int intLicenseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int personID = clsDriver.getPersonIDByDriverID(driverID);
            ShowInternationalLicenseInfo form = new ShowInternationalLicenseInfo(localLicenseID,intLicenseID,personID,driverID);
            
            form.ShowDialog();
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
         
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                setToDefault();
            }

           clsInternationalLicense internationalLicense= new clsInternationalLicense();
            DataTable dataTable = new DataTable();


            if (comboBox1.SelectedIndex == 0)
            {
                internationalLicense._filter = clsInternationalLicense.eFilterBasis.None;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                internationalLicense._filter = clsInternationalLicense.eFilterBasis.InterLicenseID;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                internationalLicense._filter = clsInternationalLicense.eFilterBasis.AppID;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                internationalLicense._filter = clsInternationalLicense.eFilterBasis.DriverID;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                 internationalLicense._filter = clsInternationalLicense.eFilterBasis.LocalLicenseID;
            }

            if (textBox1.Text != "")
            {
                dataTable = clsInternationalLicense.getFilteredTable(textBox1.Text,internationalLicense._filter);
                dataGridView1.Refresh();
                RefreshValues(dataTable);
            }
            else setToDefault();
        }
    }
}
