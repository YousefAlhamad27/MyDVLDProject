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
    public partial class QuestionRetakeTestTypeForm : Form
    {
        public bool userClosed {  get; set; }
      public TestTypeAppointmentsForm.eTestAppointmentType type { get; set; }

        public QuestionRetakeTestTypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userClosed = true;
            MessageBox.Show("No Test Will be retaken.","Operation Cancelled",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (radioStreet.Checked)
            {
                type = TestTypeAppointmentsForm.eTestAppointmentType.Street;
            }
            else if (radioVision.Checked)
            {
                type = TestTypeAppointmentsForm.eTestAppointmentType.Vision;
            }
            else   {
                type = TestTypeAppointmentsForm.eTestAppointmentType.Written;
            }
            this.Close();
        }

        private void QuestionRetakeTestTypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userClosed = true;
            this.Close();
        }
    }
}
