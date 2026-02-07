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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbRecords_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewUserForm form = new AddNewUserForm(true);
           // form.userID= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();
            setToDefault();

        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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

            dataGridView1.DataSource = clsUser.getAllUsers();

            dataGridView1.Columns[0].Width = 170;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].Width = 200;

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
            dataGridView1.Columns[0].Width = 170;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].Width = 200;
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();

        }
        private void findFilteredData()
        {
            clsUser user = new clsUser();
            DataTable dataTable = new DataTable();

            if (comboBox1.SelectedIndex == 0)
            {
                user.eFilter = clsUser.enFilter.eNone;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                user.eFilter = clsUser.enFilter.eUserID;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                user.eFilter = clsUser.enFilter.ePersonID;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                user.eFilter = clsUser.enFilter.eFullName;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                user.eFilter = clsUser.enFilter.eUsername;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    user.eFilter = clsUser.enFilter.eNone;
                }
                else  {
                    user.eFilter = clsUser.enFilter.eIsActive;
                }
            }
            if (user.eFilter == clsUser.enFilter.eIsActive)
            {
                dataTable = user.getFilteredDataTable(textBox1.Text, comboBox2.SelectedIndex == 1);
                RefreshValues(dataTable);
            }
            else if(user.eFilter != clsUser.enFilter.eIsActive)
            {
                if (textBox1.Text != "")
                {

                    dataTable = user.getFilteredDataTable(textBox1.Text);
                    RefreshValues(dataTable);
                }  
            }
            else setToDefault();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                setToDefault();
            }
            findFilteredData();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

                else if (comboBox1.SelectedIndex == 5)
                {
                    e.Handled = true;
                    textBox1.Enabled= false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox2.SelectedIndex = 0;
            setToDefault();

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Visible = false;
                textBox1.Enabled = false;
                textBox1.Visible = true;
                }
            else if(comboBox1.SelectedIndex == 5)
            {              
                textBox1.Visible = false;               
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                textBox1.Visible = true;
                textBox1.Enabled = true;
            }
            


        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm(dataGridView1.CurrentRow.Cells[0].Value.ToString());
          
            userInfoForm.ShowDialog();

            if (userInfoForm.returnToClose())
            {
                AddNewPeopleForm addNewPeopleForm = new AddNewPeopleForm(false, AddNewPerson.enMode.Update);
                addNewPeopleForm.ShowDialog();
            }

        }

        private void tsAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm(true);

            addNewUserForm.ShowDialog();

            setToDefault();
            if (addNewUserForm.returnToBeClosed())
            {
                AddNewPeopleForm addPersonForm = new AddNewPeopleForm(true, AddNewPerson.enMode.AddNew);
                addPersonForm.ShowDialog();
            }

        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm(false, dataGridView1.CurrentRow.Cells[0].Value.ToString());
           
            addNewUserForm.ShowDialog();
            setToDefault();
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setToDefault();
            findFilteredData();

        }

        private void tsChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
           
            changePasswordForm.ShowDialog();
        }

       
        private void tsDeleteUser_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to delete this user?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == clsSession.currentUser._userID)
                {
                    MessageBox.Show("Can't Delete User, because it has Data Linked to it.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


              else  if (clsUser.deleteUser(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("User has been Successfully Deleted", "Done!",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    MessageBox.Show("Can't Delete User, because it has Data Linked to it.", "Warning",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
            else
            {
                return;
            }
            setToDefault();
        }
    }
}
