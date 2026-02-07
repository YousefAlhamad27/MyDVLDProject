using DVDLBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course19
{
    public partial class FormUpdateApplicationTypecs : Form
    {
        private bool toSave = false;
        private int appID {  get; set; }
        public FormUpdateApplicationTypecs(int appTypeID)
        {
         appID = appTypeID;
            InitializeComponent();
            setValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setValues()
        {
            clsApplicationType type = clsApplicationType.getType(appID);
            lbID.Text = appID.ToString();
  
            txtBoxFees.Text = type._fees.ToString();
            txtBoxTitle.Text = type._title;

        }
        private void updateType()
        {
            string title = txtBoxTitle.Text.Trim();

            decimal fees = Convert.ToDecimal(txtBoxFees.Text.Trim());



            if (clsApplicationType.updateType(appID, title, fees))
            {
                toSave = true;
            }
            else
            {
                toSave = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            updateType();

            if (toSave) {
                MessageBox.Show("Data Saved Successfuly!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed To Save Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBoxFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Allow digits and backspace without any other checks
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                // ONLY allow the decimal point if the text box doesn't already contain one
                if (txtBoxFees.Text.Contains('.'))
                {
                    e.Handled = false; // Block it if it already exists
                }
                else
                {
                    e.Handled = true; // Allow the first decimal point
                }
            }
            else
            {
                // Block all other characters (letters, symbols, etc.)
                e.Handled = true;
            }
        }
    }
}
