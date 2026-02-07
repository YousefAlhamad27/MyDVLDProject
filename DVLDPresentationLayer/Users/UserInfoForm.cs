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
    public partial class UserInfoForm : Form
    {
         private bool toClose;
     
        public UserInfoForm(string userID)
        {
           
            InitializeComponent();

            userInformationCardcs1._userID = Convert.ToInt32(userID);

           
            userInformationCardcs1.UpdateNestedControl();


        }
       
         public bool returnToClose()
        {
            return toClose;
        }
      

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
