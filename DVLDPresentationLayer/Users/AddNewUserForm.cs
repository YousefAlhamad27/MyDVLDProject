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
    public partial class AddNewUserForm : Form
    {
        public enum enMode {AddNew=1,Update=2 }
        enMode Mode=enMode.AddNew;

        private bool toBeClosed = false;
        private bool toAddPerson = true;
        private bool allowNextButton=true;
        private bool _toAddUser;
        private string _nationalNumber;
        
        public string userID { get; set; }

        public string personID {  get; set; }
        private bool cancelSave = false;
        public AddNewUserForm(bool toAddUser,string userID1="-1")
        {
            _toAddUser = toAddUser;
            userID = userID1;
            if (_toAddUser == true)
                Mode = enMode.AddNew;
            else Mode = enMode.Update;
                InitializeComponent();
            clsUser user = clsUser.getUserByUserID(Convert.ToInt32(userID));
            if (user != null)
            {
                setUserTabValues(user);
                personID = user._PersonID.ToString();
                personDetails1.personID = personID;
                personDetails1.setValues();
            }
          


            if (!toAddUser)
            {
                label3.Text = "Update User";
                this.Text = "Update User";
                gbFilter.Enabled= false;
            }
        }
     
        public bool returnToBeClosed()
        {
            return toBeClosed;

        }
        public bool returnToAddPerson()
        {
            return toAddPerson;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toBeClosed = true;
            toAddPerson = false;
            this.Close();
        }

      

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
         comboBox1.SelectedIndex = 0;  
                
        }

     

       

   
       

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     



        private void setUserTabValues(clsUser user)
        {
            if (user != null)
            {
                txtBoxUsername.Text = user._username;
                txtBoxPassword.Text = user._password;
                txtBoxConfirmPassword.Text = user._password;
                checkBoxIsActive.Checked = user._isActive;

            }

        }

        private void setUserTabDefaultValues()
        {
            lbUserID.Text = "??";
            txtBoxUsername.Text = "";
            txtBoxPassword.Text = "";
            txtBoxConfirmPassword.Text = "";
                checkBoxIsActive.Checked = false;

            

        }

        private void addUser()
        {
            clsUser user = new clsUser();

            if (!clsUser.doesUserExistUsername(txtBoxUsername.Text.Trim()) || clsPerson.doesPersonExistID(1072))
            {
                user._username = txtBoxUsername.Text;
                user._password = txtBoxPassword.Text;
                user._PersonID = Convert.ToInt32(personID);;
                user._isActive = checkBoxIsActive.Checked;
                user._userID = user.addNewUser();

                if (user._userID == -1)
                {
                    cancelSave = true;
                }
                cancelSave = false;
                lbUserID.Text = user._userID.ToString();
            }
            else
            {
                MessageBox.Show("Username Already exists, try another one", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void updateUser()
        {
            
         
            clsUser user =    clsUser.getUserByUserID(Convert.ToInt32(userID));
            clsUser user2 = clsUser.getUserByUserName(txtBoxUsername.Text);
            if(user2!=null)
            if (user._userID != user2._userID)
            {
                cancelSave=true;
                return;
            }
                
            

            user._username = txtBoxUsername.Text;
            user._password = txtBoxPassword.Text;
            user._PersonID = Convert.ToInt32(personID); 
            user._isActive = checkBoxIsActive.Checked;

            if (clsUser.doesUserExistUsername(user._username))
            {
                if(user != null)
                    user.updateUser();

                return;
            }

            else
            {
                user.updateUser();
            }
;       }
        private void setAddNewUserInterface()
        {
            this.Text = "Add New User";
            label3.Text = "Add New User";
        }
        private void setUpdateUserInterface()
        {
            this.Text = "Update User";
            label3.Text = "Update User";
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPassword.Text) || 
                string.IsNullOrEmpty(txtBoxConfirmPassword.Text) || string.IsNullOrEmpty(txtBoxUsername.Text)) { 
                cancelSave = true;
            return; }


            if (Mode == enMode.AddNew)
            {
                addUser();
                Mode = enMode.Update;
                setUpdateUserInterface();
            }
            else if (Mode == enMode.Update)
            {
                updateUser();
            }

                if (cancelSave)
            {
                MessageBox.Show("Creditentials are not valid", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            MessageBox.Show("Saved Successfully!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                personDetails1.setValuesToDefault();
                return;

            }

            clsPerson person = new clsPerson();
            if (comboBox1.SelectedIndex == 0)
            {
                person = clsPerson.getPersonInfoUsingNationalNumber(textBox1.Text);


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                person = clsPerson.getPersonInfoUsingPersonID(Convert.ToInt32(textBox1.Text));
            }

            if (person != null)
            {
                personDetails1.personID = person._personID.ToString();
                _nationalNumber = person._nationalNumber;
                personDetails1.setValues();

            }
            else
            {
                MessageBox.Show("Person Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            personID = person._personID.ToString();
           
            clsUser user = clsUser.getUserByPersonID(Convert.ToInt32(personID));
            if (user != null)
            {
                allowNextButton = false;
                
                setUserTabValues(user);
            }
            else
            { allowNextButton = true;
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if(Mode==enMode.Update)
            {
               
                return;
            }
            personDetails1.setValuesToDefault();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                personDetails1.setValuesToDefault();
                return;

            }
            if (textBox1.Text != personID || textBox1.Text != _nationalNumber)
            {
                personDetails1.setValuesToDefault();
                setUserTabDefaultValues();
            }

            
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {


                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                if ((textBox1.Text.Length == 0 && !char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back)
                {
                    if ((e.KeyChar == 'n' || e.KeyChar == 'N'))
                    {

                        e.Handled = false;
                    }
                }
                else if (textBox1.Text.Length > 0 && (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }
        }

        private void txtBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxUsername.Text == "")
            {

            }
        }

        private void txtBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                e.Cancel = true;
                cancelSave = true;
                errorProvider1.SetError(txtBoxPassword, "Password Should have a value.");
            }

            else
            {
                e.Cancel = false;
                cancelSave = false;
                errorProvider1.SetError(txtBoxPassword, "");
            }
        }

    

        private void btBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (allowNextButton)  
            tabControl1.SelectedIndex = 1;

            else
            {
                MessageBox.Show("Selected Person is already a user, choose another person."
                    ,"Select Another Person",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if(e.TabPageIndex == 1)
            { if (!allowNextButton)
                    e.Cancel = true;
                else
                {
                    e.Cancel = false;
                }

            }
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            AddNewPeopleForm form = new AddNewPeopleForm(true,AddNewPerson.enMode.AddNew);
            form.ShowDialog();
        }
    }
}
