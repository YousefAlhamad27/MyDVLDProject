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
    public partial class ChangePasswordForm : Form
    {
        private bool cancelSave;
        private int _userID {  get; set; }
        public ChangePasswordForm(int userID)
        {
            InitializeComponent();
            _userID = userID;
            setValues();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void setValues()
        {
          
            userInformationCardcs1._userID = _userID;
            userInformationCardcs1.UpdateNestedControl()
                ;

        }

        private void saveValues()
        {
            clsUser user = clsUser.getUserByUserID(_userID) ;

            if (txtBoxConfirm.Text != txtBoxNew.Text)
            {
                cancelSave = true;
                return;
            }
            if (txtBoxCurrent.Text.Trim() != user._password)
            {
                MessageBox.Show("Current Password is wrong", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cancelSave = true;
                return;
            }
            user._password=txtBoxNew.Text.Trim();
            if (user.updateUser())
            {
                cancelSave = false;
            }

        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNew.Text) || string.IsNullOrEmpty(txtBoxCurrent.Text) || string.IsNullOrEmpty(txtBoxConfirm.Text))
                cancelSave = true;

            saveValues();

            if (cancelSave)
            {
                MessageBox.Show("Passwords are not indentical", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Saved Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBoxConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxConfirm.Text != txtBoxNew.Text)
            {
                cancelSave = true;
                txtBoxConfirm.Focus();
                errorProvider1.SetError(txtBoxConfirm, "Passwords are not indentical.");
            }
            else
            {
                cancelSave = false;

                errorProvider1.SetError(txtBoxConfirm, "");
            }
        }
    }
}
