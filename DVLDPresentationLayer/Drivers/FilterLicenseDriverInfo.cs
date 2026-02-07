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
    public partial class FilterLicenseDriverInfo : UserControl
    {
        public string licenseID { get; set; }
        public string driverID {  get; set; }

        public class UserDataEventArgs : EventArgs
        {
           
            public clsLocalLicense license {  get; set; }
            public int driverID {  get; set; }
      
        }
        public event EventHandler<UserDataEventArgs> LicenseIDSubmitted;



        public FilterLicenseDriverInfo()
        {
            InitializeComponent();
           
        }
   
        public void disableFilter()
        {
            
           // textBox1.Text = licenseID;
            groupBoxFilter.Enabled = false;
            textBox1.Text = licenseID;
            driverLicenseInfo1.licenseID= licenseID;
            driverLicenseInfo1.setValues();
        }
        public void enableFilter()
        {
           // textBox1.Text = "";
            groupBoxFilter.Enabled = true;

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            licenseID = textBox1.Text;

            driverLicenseInfo1.licenseID = licenseID;
        }

       

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            clsLocalLicense license = clsLocalLicense.getLIcenseByID(Convert.ToInt32(textBox1.Text));

            if (license != null)
            {
                license._licenseID = Convert.ToInt32(textBox1.Text);
                licenseID = textBox1.Text;
                licenseID = licenseID;

                driverLicenseInfo1.licenseID = license._licenseID.ToString();
                driverLicenseInfo1.setValues();


                var args = new UserDataEventArgs
                {
                    license = license,
                    driverID = driverLicenseInfo1.driverID
                };
               
                LicenseIDSubmitted?.Invoke(this, args);

            }




        }
    }
}
