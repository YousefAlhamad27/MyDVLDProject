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
    public partial class ManageDriversForm : Form
    {
        public ManageDriversForm()
        {
            InitializeComponent();
        }

        private void ManageDriversForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex =0;
            setToDefault();

            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2||comboBox1.SelectedIndex==5))
            {
                textBox1.MaxLength = 4;

                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else if (comboBox1.SelectedIndex == 6)
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
         
            
            
        
          

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;

            

         
            if (comboBox1.SelectedIndex != 0) {
                textBox1.Text = "";
                textBox1.Enabled = true;
                

            }
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
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[3].Width = 400;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[4].Width = 150;


            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();

            
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

            dataGridView1.DataSource = clsDriver.getAllDriversTable();

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[3].Width = 400;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[4].Width = 150;
        }
        private void findFilteredData()
        {
            clsDriver user = new clsDriver();
            DataTable dataTable = new DataTable();

            if (comboBox1.SelectedIndex == 0)
            {
                user._filter = clsDriver.enFilter.None;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                user._filter = clsDriver.enFilter.DriverID;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                user._filter = clsDriver.enFilter.PersonId;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                user._filter = clsDriver.enFilter.NationalNo;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                user._filter = clsDriver.enFilter.FullName;
            }
            else if (comboBox1.SelectedIndex == 5)
            {

                user._filter = clsDriver.enFilter.NumberOfLicenses;
            }

            if (textBox1.Text != "")
            {

                dataTable = user.getFilteredDataTable(textBox1.Text);
                RefreshValues(dataTable);
            }


            else setToDefault();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                setToDefault();
            }
            findFilteredData();

        }
    }
}
