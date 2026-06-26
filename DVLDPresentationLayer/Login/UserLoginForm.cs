using Course19.Properties;
using DVDLBussinessLayer;
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
using System.Web;
using System.Configuration;


namespace Course19
{
    public partial class UserLoginForm : Form
    {
        private bool _isAuthorized = false;
        private bool _toTerminate = false;
        private bool _tologin=true;
        private bool isPasswordHidden = true;
        public UserLoginForm()
        {
            InitializeComponent();
            this.MouseDown += ManagePeopleForm_MouseDown;
            if (Settings.Default.RememberMe)
            {
                textBox1.Text = Settings.Default.SavedUserName;
                textBox2.Text = DecryptPassword(Settings.Default.SavedPassword);
                checkBox1.Checked = true;
            }
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void ManagePeopleForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Only allow dragging from the top 30 pixels and only with left click
            if (e.Button == MouseButtons.Left && e.Y <= 30)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _toTerminate = true;
            _tologin = false;
            clsLogin.setToTerminate(true);
            this.Close();

        }
        public bool returnToLogin()
        {
            return _tologin;
        }
        private string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;

            byte[] data = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(data);
        }

        // Simple decryption
        private string DecryptPassword(string encrypted)
        {
            try
            {
                if (string.IsNullOrEmpty(encrypted))
                    return string.Empty;

                byte[] data = Convert.FromBase64String(encrypted);
                return Encoding.UTF8.GetString(data);
            }
            catch
            {
                return string.Empty;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Settings.Default.RememberMe = true;
                Settings.Default.SavedUserName = textBox1.Text;
                Settings.Default.SavedPassword = EncryptPassword(textBox2.Text);
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.RememberMe = false;
                Settings.Default.SavedUserName = "";
                Settings.Default.SavedPassword = "";
                Settings.Default.Save();
            }
            if (textBox1.Text == ""||textBox2.Text=="")
                  
                    {
                        MessageBox.Show("Enter Creditentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                    }

            clsSession.currentUser=clsUser.getUserByUserName(textBox1.Text);

            if(clsSession.currentUser!=null)

           if(textBox2.Text== clsSession.currentUser._password) { 
                _isAuthorized = true;
                _tologin = true;
                this.Close();
                return;
                
                
            }
         
            else
            {
                MessageBox.Show("Invalid Username/Password", "Wrong Creditentials", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
            
        }
        public bool returnToTerminate()
        {
            return _toTerminate;
        }
        public bool returnIsAuthorized()
        {
            return _isAuthorized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                textBox2.UseSystemPasswordChar = false;
                isPasswordHidden = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                isPasswordHidden = true;
            }
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.CornflowerBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }
    }
}
