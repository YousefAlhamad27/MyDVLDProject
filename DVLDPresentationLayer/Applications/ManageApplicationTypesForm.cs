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
    public partial class ManageApplicationTypesForm : Form
    {
        public ManageApplicationTypesForm()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setToDefault()
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                dt.Rows.Clear(); // Clears all rows from the DataTable
                                 // If you want to clear columns as well, you would also do:
                dt.Columns.Clear();
            }
            dataGridView1.DataSource = null; // Unbinds the DataGridView from the data source
            dataGridView1.Refresh(); // Refreshes the display

            dataGridView1.DataSource = clsApplicationType.getApplicationTypes();

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 150;
            lbNumRecords.Text = dataGridView1.Rows.Count.ToString();

        }
        private void tsEditType_Click(object sender, EventArgs e)
        {
            FormUpdateApplicationTypecs frm = new FormUpdateApplicationTypecs(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));   
 
            frm.ShowDialog();
            setToDefault();
        }

        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {
            setToDefault();
           
        }
    }
}
