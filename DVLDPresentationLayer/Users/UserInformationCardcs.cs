using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLBussinessLayer;

namespace Course19
{
    public partial class UserInformationCardcs : UserControl
    {
        public int _userID { get; set; }

        clsUser user;

        public UserInformationCardcs()
        {
            InitializeComponent();
       
            personDetails1.setValues();
          

        }
    
        public void UpdateNestedControl()
        {
            user = clsUser.getUserByUserID(_userID);

            personDetails1.personID = user._PersonID.ToString() ;
            personDetails1.setValues();
            user = clsUser.getUserByUserID(Convert.ToInt32(_userID));
            setValues();
        }
       

        private string getIsActiveString(bool isActive) {
            string st;
            return (isActive == true) ? "Yes" : "False";
        }
        public void setValues()
        {
            lbUserID.Text = user._userID.ToString();
            lbUsername.Text = user._username;
            lbIsActive.Text = getIsActiveString(user._isActive);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void personDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
