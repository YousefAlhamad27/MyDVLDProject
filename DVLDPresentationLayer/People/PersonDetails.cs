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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course19
{
    public partial class PersonDetails : UserControl
    {
        static private bool close = false;
       public string personID {  get; set; }

        public PersonDetails()
        {
            InitializeComponent();
            
        }
       public void setValuesToDefault()
        {
            lbPersonID.Text = "[????]";
            lbName.Text = "[????]";
            lbNationalID.Text = "[????]";
            lbGender.Text = "[????]";
            lbCountry.Text = "[????]";
            lbAddress.Text = "[????]";
            lbDateOfBirth.Text = "[????]";
            lbEmail.Text = "[????]";
            lbPhone.Text = "[????]";

            try
            {
                bigPicture.Image = Resources.Male_512;
            }
            catch (Exception ex)
            {
                return;
            }
        }

    
        public void setValues()
        {


            clsPerson person = clsPerson.getPersonInfoUsingPersonID(Convert.ToInt32(personID));
            if (person != null)
            {
                lbPersonID.Text = personID;
                lbName.Text = person.returnFullName(person._firstName, person._secondName, person._thirdName, person._lastName);
                lbNationalID.Text = person._nationalNumber.ToString();
                lbGender.Text = person._gender.ToString();
                lbCountry.Text = clsCountry.getCountryNameByID(person._countryID);
                lbAddress.Text = person._address;
                lbDateOfBirth.Text = person._birthDate.ToString();
                lbEmail.Text = person._email;
                lbPhone.Text = person._phone;
                try
                {
                    // CHANGED: Dispose old image first
                    if (bigPicture.Image != null)
                    {
                        bigPicture.Image.Dispose();
                    }

                    
                    // Load without locking
                    using (var stream = new FileStream(person._imagePath, FileMode.Open, FileAccess.Read))
                    {
                        bigPicture.Image = Image.FromStream(stream);
                    }
                }
                catch (Exception ex) {
                    person._imagePath = "";
                    bigPicture.Image = Resources.Male_512;
                    return;
                }
            }

           
            

        }
       
        static public bool returnToClose() { 
            return close;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewPeopleForm form = new AddNewPeopleForm(false, AddNewPerson.enMode.Update,personID);
            
            form.ShowDialog();
        }

      
    }
}
