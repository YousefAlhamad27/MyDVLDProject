using Course19.Properties;
using DVDLBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Course19
{
    public partial class AddNewPerson : UserControl
    {
        public enum enMode { AddNew=1,Update=2}
        public enMode Mode;
        private readonly string STORAGE_DIRECTORY = Path.Combine(Application.StartupPath, @"C:\DVDL-Images");
        private string selectedImagePath = null;
        private string savedImagePath = null;
        private bool pendingRemoval = false;
        private string copyOfImagePathName = null;
        private bool toSave = false;
        private bool hasValuesBeenChanged = false;
        private bool imageChosen = false;
        private bool imageDeleted;
        private string copyOfImagepath;
        private string guidImagePathName;
        string previousImagePath;
        clsPerson person=new clsPerson();
        public string personID {  get; set; }

        public AddNewPerson()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(-2);
            setCountryComboBox();
}
        void setCountryComboBox()
        {
           
            DataTable table = clsCountry.getCountriesTable();
            

            for (int i = 0; i < table.Rows.Count; i++) {
                comboBoxCountry.Items.Add(table.Rows[i][0].ToString());
            }
            comboBoxCountry.SelectedIndex = -1;
        }
        private void linklabelImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            copyOfImagepath = person._imagePath;
            previousImagePath = person._imagePath;
            chooseImageFromFile();

          


        }

        private void chooseImageFromFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    try
                    {
                        // Dispose previous image to free memory

                        if (pbBigPicture.Image != null)
                        {
                            pbBigPicture.Image.Dispose();
                        }


                        using (var stream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            pbBigPicture.Image = Image.FromStream(stream);
                        }
                        // Enable both save and remove buttons since an image is selected

                        lbRemoveImage.Visible = true; // Enable remove for selected image
                        lbRemoveImage.Enabled = true;
                        // Reset saved image path since user selected a new image
                        savedImagePath = null;
                        imageChosen = true;
                        hasValuesBeenChanged = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
                    }
        private void UserControl1_Load(object sender, EventArgs e)
        {
          
            if (Mode == enMode.Update)
            {
                Form parent = this.FindForm();
                parent.Text = "Edit Person Info";
                TextBoxValues();
                lbRemoveImage.Enabled = true;
                lbRemoveImage.Visible = true;
            }
        }

        private void removeImageFromPictureBox()
        {
            // Dispose of current image to free memory
            pbBigPicture.Image?.Dispose();
            pbBigPicture.Image = null;

            // Reset paths
            selectedImagePath = null;
            savedImagePath = null;

            lbRemoveImage.Visible = false;
        }
        private void removeImageFromFile()
        {
            if (pendingRemoval == true)
            {

                try
                {
                    string fileName = Path.GetFileName(copyOfImagePathName);


                    // Clear everything
                    pbBigPicture.Image?.Dispose();
                    // Delete the file
                    File.Delete(copyOfImagePathName);
                    imageDeleted = true;
                 

                    pendingRemoval = false;

                    // Reset UI


                    lbRemoveImage.Visible = false;

                    




                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing image: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pendingRemoval = false;
                    btSave.Text = "Save";
                    lbRemoveImage.Text = "Remove Picture";
                }
            }
            }

        private void TextBoxValues()
        {
             person = clsPerson.getPersonInfoUsingPersonID(Convert.ToInt32(personID));
            if (person == null)
                return;
          

           

            lbBigChange.Text = "Update Person Info";
            lbPersonID.Text = person._personID.ToString();
            txtBoxNationalNumber.Text = person._nationalNumber;
            txtBoxFirst.Text = person._firstName;
            txtBoxSecond.Text = person._secondName;
            txtBoxThird.Text = person._thirdName;
            txtBoxLast.Text = person._lastName;
            txtBoxAddress.Text = person._address;
            txtBoxEmail.Text = person._email;
            txtBoxPhone.Text= person._phone;
            dateTimePicker1.Value = person._birthDate;
            try
            {
                // CHANGED: Dispose old image first
             

                // Load without locking
                using (var stream = new FileStream(person._imagePath, FileMode.Open, FileAccess.Read))
                {
                    pbBigPicture.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                pbBigPicture.Image = Resources.Male_512;
            }
            if(Mode==enMode.Update)
                comboBoxCountry.SelectedIndex = person._countryID-1;
            else
                comboBoxCountry.SelectedIndex = person._countryID;

            if (person._gender == "Male")
                rbMale.Checked = true;

            else rbFemale.Checked = true;
        }
        private void saveImageTofile()
        {


        

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                imageChosen = false;
                return;
            }
            else
            {
                imageChosen = true;
            }

                try
                {
                    // Ensure storage directory exists
                    if (!Directory.Exists(STORAGE_DIRECTORY))
                    {
                        Directory.CreateDirectory(STORAGE_DIRECTORY);
                    }
                    // Generate unique filename to avoid conflicts

                    string fileName = Path.GetFileName(selectedImagePath);
                    string destinationPath = Path.Combine(STORAGE_DIRECTORY, fileName);

                    // Handle duplicate names by adding a counter



                    Guid newGuid = Guid.NewGuid();
                    string newFileName = newGuid.ToString();


                    string extension = Path.GetExtension(fileName);
                    string fileNameWithExtension = newFileName + extension;
                    guidImagePathName = STORAGE_DIRECTORY + "\\" + fileNameWithExtension;
                    destinationPath = Path.Combine(STORAGE_DIRECTORY, $"{fileNameWithExtension}");



                    // Copy the file to storage directory
                    File.Copy(selectedImagePath, destinationPath);

                    // Store the saved image path for potential removal
                    savedImagePath = destinationPath;

                    copyOfImagePathName = savedImagePath;
                try
                {
                    if (pbBigPicture.Image != null && pbBigPicture.Image != Resources.Male_512)
                    {
                        imageDeleted = false;
                        previousImagePath = copyOfImagePathName;
                     
                    }
                }
                catch
                {

                }



            }
            catch (Exception ex)
                {
                    MessageBox.Show($"Error saving Data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private bool addPerson()
        {

            if (!clsPerson.doesPersonExistNational(txtBoxNationalNumber.Text))
                if (testToSave())
                {

                    
                    saveImageTofile();
                    assignValuesToPersonObject();

                    personID = person.addNewPerson(person).ToString();
                    person = clsPerson.getPersonInfoUsingPersonID(Convert.ToInt32(personID));
                    if (person._personID!= -1)
                    {
                      
                        return true;
                    }
                    else
                    {
                       
                        return false;
                    }


                  

                }
                else
                {
                    return false;
                }
            return false;
        }

        private void assignValuesToPersonObject()
         {
            person._firstName = txtBoxFirst.Text;
            person._lastName = txtBoxLast.Text;
            person._secondName = txtBoxSecond.Text;
            person._thirdName = txtBoxThird.Text;
            person._address = txtBoxAddress.Text;
            person._email = txtBoxEmail.Text;
            person._phone = txtBoxPhone.Text;
            person._nationalNumber = txtBoxNationalNumber.Text;
            person._birthDate = dateTimePicker1.Value;
            if (imageDeleted)
                person._imagePath = "";
            else if (guidImagePathName != null)
                person._imagePath = guidImagePathName;
            else
            {
                clsPerson person2 = clsPerson.getPersonInfoUsingPersonID(Convert.ToInt32(person._personID));
                person._imagePath = person2._imagePath;
            }

            person._countryID = comboBoxCountry.SelectedIndex + 1;
            if (rbFemale.Checked)
                person._gender = "Female";
            else person._gender = "Male";
        }
        private bool updatePerson()
        {
            if (hasValuesBeenChanged )

            {
                if (imageChosen)
                    saveImageTofile();
                assignValuesToPersonObject();

                return person.updatePerson();

            }


            else
            {
                return false;
            }

        
        }
        private void switchModeToUpdate()
        {
            TextBoxValues();
          
        }
        private void btSave_Click(object sender, EventArgs e)
        {
           
            if(pendingRemoval==true)
                removeImageFromFile();

            if (Mode == enMode.AddNew)
            {
               toSave = addPerson();
                Mode = enMode.Update;
                switchModeToUpdate();
            }
            else if (Mode == enMode.Update)
            {
                
                    toSave = updatePerson();
                selectedImagePath = person._imagePath;
            }
            if (toSave == true) {
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save Data.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

     
        private void lbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pendingRemoval)
            {
                pendingRemoval = false;
         

                return;
            }
            // Check if there's a selected image (before saving) or a saved image
        

            // Different behavior based on whether image is saved or just selected
         
            
                // Image has been saved - confirm removal from storage



                try
                {
                    pendingRemoval = true;
                copyOfImagePathName = person._imagePath;
                    // Clear everything
                    removeImageFromPictureBox();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing image from Database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

      
        private void btClose_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }

        private bool EmailNotEmpty()
        {

            string email = txtBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {

                // Optional: Handle empty email case if required
                errorProvider1.SetError(txtBoxEmail, "Email cannot be empty.");
                // Prevent focus change if validation fails
                return false;
            }
            else
            {
                errorProvider1.SetError(txtBoxEmail, "");
            }
                return true;
        }
        private bool confirmEmail()
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(txtBoxEmail.Text);
                // If no exception is thrown, the email format is valid.
                // Clear any previous error messages.
                errorProvider1.SetError(txtBoxEmail, "");
                return true;
            }
            catch (FormatException)
            {
                toSave = false;
              

                errorProvider1.SetError(txtBoxEmail, "Please enter a valid email address.");
                return false;

            }

        }
        private bool testToSave()
        {
            if(txtBoxFirst.Text!=""&& txtBoxSecond.Text != ""&& txtBoxThird.Text != ""&& txtBoxLast.Text != ""&&
                txtBoxNationalNumber.Text != ""&& txtBoxEmail.Text != ""&& txtBoxPhone.Text != ""&& comboBoxCountry.SelectedIndex != -1)
            {
               if( confirmEmail())
                toSave = true;
              
            }
            else
            {
                toSave = false;
            }
            return toSave;
        }
       

        private void txtBoxEmail_Validating(object sender, CancelEventArgs e)
        {
           if(EmailNotEmpty())
            confirmEmail();

        }

        private void txtBoxFirst_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxFirst.Text == "")
            {
                errorProvider1.SetError(txtBoxFirst, "First Name Cannot be Empty");

            }
            else
            {
                errorProvider1.SetError(txtBoxFirst, "");
            }
        }

        private void txtBoxSecond_Validating(object sender, CancelEventArgs e)
            {
            if (txtBoxSecond.Text == "")
            {
                errorProvider1.SetError(txtBoxSecond, "Second Name Cannot be Empty");

            }
            else
            {
                errorProvider1.SetError(txtBoxSecond, "");
            }
        }

        private void txtBoxThird_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxThird.Text == "")
            {
                errorProvider1.SetError(txtBoxThird, "Third Name Cannot be Empty");

            }
            else
            {
                errorProvider1.SetError(txtBoxThird, "");
            }
        }

        private void txtBoxLast_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxLast.Text == "")
            {
                errorProvider1.SetError(txtBoxLast, "Last Name Cannot be Empty");

            }
            else
            {
                errorProvider1.SetError(txtBoxLast, "");
            }
        }

     
        private void txtBoxNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxNationalNumber.Text == "")
            {
                errorProvider1.SetError(txtBoxNationalNumber, "National Number Cannot be Empty");

            }
            else
            {
                errorProvider1.SetError(txtBoxNationalNumber, "");
            }
        }


        private void txtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                hasValuesBeenChanged = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                return;
            }
            hasValuesBeenChanged = true;
        }

        private void txtBoxNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((txtBoxNationalNumber.Text.Length == 0 && !char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back)
            {
                if ((e.KeyChar == 'n' || e.KeyChar == 'N'))
                {

                    e.Handled = false;
                }
                else if (e.KeyChar == (char)Keys.Back)
                    e.Handled = false;
                else e.Handled = true;
            }
            else if (txtBoxNationalNumber.Text.Length > 0 && (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
            hasValuesBeenChanged = true;
        }

     

  

        private void txtBoxSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            hasValuesBeenChanged = true;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            hasValuesBeenChanged = true;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            hasValuesBeenChanged = true;
        }
    }
    }
        

