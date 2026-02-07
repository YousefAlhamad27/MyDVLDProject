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
    public partial class FormShowLocalLicense : Form
    {
       
        public FormShowLocalLicense(int licenseID)
        {
            InitializeComponent();
            
            driverLicenseInfo1.licenseID = licenseID.ToString();
            driverLicenseInfo1.setValues();
        }

      
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
