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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course19
{
    public partial class ManageDetainedLicense : Form
    {
        public ManageDetainedLicense()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDetainLicense_Click(object sender, EventArgs e)
        {
            FormDetainLicense form=new FormDetainLicense();
           
            form.ShowDialog();
        }

        private void btReleaseLicense_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm form=new ReleaseDetainedLicenseForm();

            form.ShowDialog();
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

            dataGridView1.DataSource = clsDetainedLicense.getDetainedLicenses();

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 125;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 300;
            dataGridView1.Columns[8].Width = 150;

            
            lbNumRecords.Text = dataGridView1.Columns.Count.ToString();

        }
        private void ManageDetainedLicense_Load(object sender, EventArgs e)
        {
            setToDefault();
            comboBox1.SelectedIndex = 0;
            comboBoxIsReleased.SelectedIndex = 0;
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
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 125;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 300;
            dataGridView1.Columns[8].Width = 150;
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();

        }
        private void findFilteredData()
        {
            clsDetainedLicense detainedLicense = new clsDetainedLicense();
            DataTable dataTable = new DataTable();

            if (comboBox1.SelectedIndex == 0)
            {
                detainedLicense._filter = clsDetainedLicense.eFilterBasis.None;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                detainedLicense._filter = clsDetainedLicense.eFilterBasis.detainID;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if(comboBoxIsReleased.SelectedIndex==0)
                detainedLicense._filter = clsDetainedLicense.eFilterBasis.None;
                else if (comboBoxIsReleased.SelectedIndex == 1)
                {
                    detainedLicense._filter = clsDetainedLicense.eFilterBasis.released;
                }
                else if (comboBoxIsReleased.SelectedIndex == 2)
                {
                    detainedLicense._filter = clsDetainedLicense.eFilterBasis.notReleased;
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                detainedLicense._filter = clsDetainedLicense.eFilterBasis.nationalNo;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                detainedLicense._filter = clsDetainedLicense.eFilterBasis.fullName;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
               
                    detainedLicense._filter = clsDetainedLicense.eFilterBasis.releaseAppID;
                
                
            }



            if (comboBox1.SelectedIndex == 2)
            {
                if (comboBoxIsReleased.SelectedIndex == 0)
                {
                    setToDefault();
                }
                else if(comboBoxIsReleased.SelectedIndex == 1||comboBoxIsReleased.SelectedIndex==2)
                {
                    dataTable = clsDetainedLicense.getFilteredDetainedTable("",detainedLicense._filter);
                    RefreshValues(dataTable);
                    return;
                }
               
            }

            else {
                dataTable = clsDetainedLicense.getFilteredDetainedTable(textBox1.Text,detainedLicense._filter);
                RefreshValues(dataTable);
                return;
            }
                
                
            
             setToDefault();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setToDefault();
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Enabled = false;
                comboBoxIsReleased.Enabled = false;
                comboBoxIsReleased.Visible = false;
            }
            else
                textBox1.Enabled = true;

            if(comboBox1.SelectedIndex == 2)
            {

                textBox1.Enabled = false;
                textBox1.Visible = false;
                comboBoxIsReleased.Enabled = true;
                comboBoxIsReleased.Visible = true;
                comboBoxIsReleased.SelectedIndex = 0;
            }
            else if(comboBox1.SelectedIndex!=0)
            {
                textBox1.Enabled = true;
                textBox1.Visible = true;
                comboBoxIsReleased.Enabled = false;
                comboBoxIsReleased.Visible = false;
            }
            if (comboBox1.SelectedIndex != 2 && comboBox1.SelectedIndex != 0)
            {
                
                textBox1.Enabled = true;

            }

            textBox1.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 5))
            {
                textBox1.MaxLength = 4;

                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.MaxLength = 1;
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {

                    e.Handled = true;
                }


            }
           
            else if (comboBox1.SelectedIndex == 3)
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
                else e.Handled = true;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBox1.MaxLength = 50;



                e.Handled = false;

            }
            else { e.Handled = true; }
        
    }

        private void tsShowPersonDetails_Click(object sender, EventArgs e)
        {
            string nationalnumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            clsPerson person = clsPerson.getPersonInfoUsingNationalNumber(nationalnumber);

            PersonDetailsForm form = new PersonDetailsForm(person._personID.ToString());
           
            
            form.ShowDialog();
        }

        private void tsShowLicenseHistory_Click(object sender, EventArgs e)
        {
            int licenseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            clsLocalLicense license = clsLocalLicense.getLIcenseByID(licenseID);
      


            ShowInternationalLicenseInfo form = new ShowInternationalLicenseInfo(licenseID,-1,clsDriver.getPersonIDByDriverID(license._driverID),license._driverID);
     
            form.ShowDialog();
        }

        private void tsShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            //     string driverID = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            int licenseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            clsLocalLicense license = clsLocalLicense.getLIcenseByID(licenseID);

            FormShowPersonLicenseHistory form = new FormShowPersonLicenseHistory(licenseID, dataGridView1.CurrentRow.Cells[6].Value.ToString(),-1,license._driverID);


            form.ShowDialog();
        }

        private void tsReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm form = new ReleaseDetainedLicenseForm();
        
            form.disableFilter(dataGridView1.CurrentRow.Cells[1].Value.ToString(),Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
          
            form.ShowDialog();
            setToDefault();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            if (clsDetainedLicense.isLicenseDetained(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value)))
            {
                tsReleaseDetainedLicense.Enabled = true;
            }
            else
            {
                tsReleaseDetainedLicense.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                setToDefault();
            }
            findFilteredData();
        }

        private void comboBoxIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            setToDefault();
            findFilteredData();
        }
    }
}
