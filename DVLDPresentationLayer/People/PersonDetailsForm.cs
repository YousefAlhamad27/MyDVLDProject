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
    public partial class PersonDetailsForm : Form
    {
        private bool toBeClosed=false;
        
        public PersonDetailsForm(string personID)
        {
            InitializeComponent();
            personDetails1.personID = personID;
            personDetails1.setValues();
            this.MouseDown += PersonDetailsForm_MouseDown;
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void PersonDetailsForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Only allow dragging from the top 30 pixels and only with left click
            if (e.Button == MouseButtons.Left && e.Y <= 30)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        public bool returnToBeClosed(){
        return toBeClosed;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toBeClosed = true;
            this.Close();
            

        }

       
    }
}
