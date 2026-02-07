using DVDLBussinessLayer;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace Course19
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
          
            this.MouseDown += ManagePeopleForm_MouseDown;
        }
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

              private void ManagePeopleForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Only allow dragging from the top 30 pixels and only with left click
            if (e.Button == MouseButtons.Left && e.Y <= 30)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
          this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void ManagePeopleForm_Load(object sender, EventArgs e)
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

            dataGridView1.DataSource = clsPerson.getPeopleTable();
            dataGridView1.Columns[7].Width = 150;
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
            dataGridView1.Columns[7].Width = 150;
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();

        }
        private void btAddPeople_Click(object sender, EventArgs e)
        {
            AddNewPeopleForm addNewPeopleForm = new AddNewPeopleForm(true, AddNewPerson.enMode.AddNew);

            addNewPeopleForm.ShowDialog();
            setToDefault();
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {

              PersonDetailsForm personDetailsForm = new PersonDetailsForm(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            personDetailsForm.ShowDialog();

            if (personDetailsForm.returnToBeClosed())
            {
                AddNewPeopleForm form = new AddNewPeopleForm(false,AddNewPerson.enMode.Update);
                form.ShowDialog();
            }
        }

        private void tsAddNewPerson_Click(object sender, EventArgs e)
        {
            AddNewPeopleForm addNewPeopleForm = new AddNewPeopleForm(true, AddNewPerson.enMode.AddNew);
            addNewPeopleForm.ShowDialog();
            setToDefault();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            AddNewPeopleForm form = new AddNewPeopleForm(false, AddNewPerson.enMode.Update, dataGridView1.CurrentRow.Cells[0].Value.ToString());
           
           
            form.ShowDialog();
            setToDefault();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 9)
            {
                if (comboBox1.SelectedIndex == 1)
                    textBox1.MaxLength = 4;
                else textBox1.MaxLength = 10;


                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
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






                else { e.Handled = true; }

            }
            if (comboBox1.SelectedIndex != 2 && comboBox1.SelectedIndex != 1 && comboBox1.SelectedIndex != 9)
            {
                textBox1.MaxLength = 20;
                e.Handled = false;

            }

        
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text=="")
            {
                setToDefault();   
            }
            clsPerson person = new clsPerson();
            DataTable dataTable = new DataTable();


            if (comboBox1.SelectedIndex == 0)
            {
                person.eFilter = clsPerson.enFilter.none;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                person.eFilter = clsPerson.enFilter.personID;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                person.eFilter = clsPerson.enFilter.nationalNumber;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                person.eFilter = clsPerson.enFilter.firstName;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                person.eFilter = clsPerson.enFilter.secondName;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                person.eFilter = clsPerson.enFilter.thirdName;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                person.eFilter = clsPerson.enFilter.lastName;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                person.eFilter = clsPerson.enFilter.nationality;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                person.eFilter = clsPerson.enFilter.gender;
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                person.eFilter = clsPerson.enFilter.Phone;
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                person.eFilter = clsPerson.enFilter.Email;

            }
            if (textBox1.Text != "")
            {
                dataTable = person.getFilterPeopleTable(textBox1.Text);
                dataGridView1.Refresh();
                RefreshValues(dataTable);
            }
            else setToDefault();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            setToDefault();
            if (comboBox1.SelectedIndex==0)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;

            
            
        }

        private void tsDeletePerson_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            clsPerson person=clsPerson.getPersonInfoUsingPersonID(personID);

            if(clsPerson.doesPersonExistID(personID)) {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this perosn?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if ( result== DialogResult.Yes)
                {
                    if (clsPerson.deletePerson(personID))
                    {
                        File.Delete(person._imagePath);
                        MessageBox.Show("Person has been Deleted Successfuly!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Person cannot be deleted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                return;
            }
            setToDefault();
               
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            





            

        }
    }
}
