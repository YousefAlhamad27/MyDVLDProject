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
    public partial class UpdateTestTypesForm : Form
    {
        private bool toSave = false;
        private int _ID {  get; set; }
        public UpdateTestTypesForm(int ID)
        {
            _ID = ID;
            InitializeComponent();
            setValues();
        }

        private void setValues()
        {
            clsTestType testType = clsTestType.getTestType(_ID);
            lbID.Text = _ID.ToString();
            txtBoxDescription.Text = testType._testTypeDescription;
            txtBoxFees.Text = testType._testTypeFees.ToString();
            txtBoxTitle.Text = testType._testTypeTilte;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveTestType()
        {
           

            
            string title=txtBoxTitle.Text.Trim();
            string description=txtBoxDescription.Text.Trim();
            decimal fees = Convert.ToDecimal(txtBoxFees.Text.Trim());



           if (clsTestType.updateTestType(_ID, title, description, fees))
            {
                toSave = true;
            }
            else
            {
                toSave = false;
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            saveTestType();
            if (toSave)
            {

                MessageBox.Show("Data Saved Successfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSave.Enabled = false;

            }
            else
            {
                MessageBox.Show("Failed To Save Data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBoxFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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
                e.Handled = false;
            }
        }
    }
}
