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
using static System.Net.Mime.MediaTypeNames;

namespace Course19
{
    public partial class ShowApplicationDetails : Form
    {
        private int _ApplicationID;
        public ShowApplicationDetails(int applicationID)
        {

            InitializeComponent();
            _ApplicationID = applicationID;
            setApplicationDetails();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setApplicationDetails()
        {
            clsLocalApplication application = clsLocalApplication.getLocalApplicationByID(_ApplicationID);
            if (application != null) {

                lbApplicationID.Text = application._applicationID.ToString();
                lbApplicationDate.Text = application._ApplicationDate.ToShortDateString();
                lbApplicationType.Text = clsApplication.getTypeNameByAppID(_ApplicationID);
                lbLastStatusDate.Text=application._lastStatusDate.ToShortDateString();
                clsUser user = clsUser.getUserByUserID(Convert.ToInt32(application._createdByUserID));
                lbUsername.Text=user._username.ToString();
                lbPersonID.Text=application._personID.ToString();
                lbPaidFees.Text=application._paidFees.ToString();

                if (application._applicationStatus == 1)
                {
                    lbApplicationStatus.Text = "New";
                }
                else if (application._applicationStatus == 2) {
                    lbApplicationStatus.Text = "Cancelled";
                }
                else if (application._applicationStatus == 3)
                {
                    lbApplicationStatus.Text = "Completed";
                }
               


            }

        }


    }
}
