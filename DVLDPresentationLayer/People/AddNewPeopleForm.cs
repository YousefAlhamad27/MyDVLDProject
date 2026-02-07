using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course19
{
    public partial class AddNewPeopleForm : Form
    {
        
        public AddNewPeopleForm(bool addNew, AddNewPerson.enMode eMode,string personID="-1")
        {
           
            InitializeComponent();
            addNewPerson1.personID = personID;
            addNewPerson1.Mode = eMode;
            this.MouseDown += AddNewPeopleForm_MouseDown;
            if (!addNew)
            {
                
                lbToChange.Text = "Edit Person Info";
            }
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void AddNewPeopleForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Only allow dragging from the top 30 pixels and only with left click
            if (e.Button == MouseButtons.Left && e.Y <= 30)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            
            this.Close();   
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
