using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enFilter {
           none=0, personID = 1, nationalNumber = 2, firstName = 3, secondName = 4, thirdName = 5, lastName = 6
        , nationality, gender, Phone, Email
        };
        public enFilter eFilter;

        public int _personID { get; set; }
        public string _firstName { get; set; }
        public string _secondName { get; set; }
        public string _thirdName { get; set; }
        public string _lastName { get; set; }
        public string _nationalNumber { get; set; }
        public DateTime _birthDate { get; set; }
        public string _phone { get; set; }
        public string _email { get; set; }
        public string _address {  get; set; }
        public string _gender { get; set; }
        public int _countryID { get; set; }
        public string _imagePath { get; set; }
      public  clsPerson()
        {
            _personID = -1;
            _firstName =  "";
            _secondName ="";
            _thirdName =        "";
            _lastName =         "";
            _nationalNumber= "";
            _birthDate =   new DateTime();
            _phone = "";
            _email =  "";
            _gender = "";
            _countryID =-1;
            _imagePath = "";
            _address = "";
        }
        private clsPerson(int personID, string firstName, string secondName, string thirdName, string lastName, string nationalNumber,string address, DateTime birthDate
            , string gender, string phone, string email,  int countryID, string imagepath)
        {

            _personID = personID;
            _firstName = firstName;
            _secondName = secondName;
            _thirdName = thirdName;
            _lastName = lastName;
            _nationalNumber = nationalNumber;
            _birthDate = birthDate;
            _phone = phone;
            _email = email;
            _gender = gender;
            _countryID = countryID;
            _imagePath = imagepath;
            _address = address;
        }

      static  public clsPerson getPersonInfoUsingPersonID(int personID)
        {

            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            string nationalNumber = "";
            string address = "";
            DateTime birthDate = new DateTime();
            string phone = "";
            string email = "";
            string gender = "";
            int countryID = -1;
            string imagepath = "";

            if(clsPeopleDataAccess.getPersonInfoByID(personID, ref firstName, ref secondName, ref thirdName, ref lastName, ref nationalNumber, ref address,
            ref birthDate, ref gender
            , ref phone, ref email, ref countryID, ref imagepath))
            {
                return new clsPerson(personID,firstName,secondName,thirdName,lastName,nationalNumber,address,birthDate,
                    gender,phone,email,countryID,imagepath);
            }
            else
            {
                return null;
            }

        }
        static public clsPerson getPersonInfoUsingNationalNumber(string nationalNumber)
        {

            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            int personID =-1;
            string address = "";
            DateTime birthDate = new DateTime();
            string phone = "";
            string email = "";
            string gender = "";
            int countryID = -1;
            string imagepath = "";

            if (clsPeopleDataAccess.getPersonInfoByNationalNumber(nationalNumber, ref personID, ref firstName, ref secondName, ref thirdName, ref lastName, ref address,
            ref birthDate, ref gender
            , ref phone, ref email, ref countryID, ref imagepath))
            {
                return new clsPerson(personID, firstName, secondName, thirdName, lastName, nationalNumber, address, birthDate,
                    gender, phone, email, countryID, imagepath);
            }
            else
            {
                return null;
            }

        }
        public string returnFullName(string firstName, string secondName, string thirdName, string lastName)
        {

            return firstName + " " + secondName + " " + thirdName + " " + lastName;
        }
        static public bool doesPersonExistID(int personID)
        {
            
            return clsPeopleDataAccess.doesPersonExistID(personID);
        }
        static public bool doesPersonExistNational(string nationalNumber)
        {

            return clsPeopleDataAccess.doesPersonExistNational(nationalNumber);
        }
        static    public DataTable getPeopleTable()
        {
            return  clsPeopleDataAccess.getAllPeople();
        }
        public DataTable getFilterPeopleTable(string data)
        {
            return clsPeopleDataAccess.filteredData(data,(clsPeopleDataAccess.EFilterBasis)(int)eFilter);

        }

        public int addNewPerson(clsPerson person)
        {
          return  clsPeopleDataAccess.addNewPerson(person._firstName,person._secondName,person._thirdName,person._lastName,
                person._nationalNumber,person._address,person._birthDate,person._gender,
                person._phone,person._email,person._countryID,person._imagePath);




            
        }

        public bool updatePerson() {

           


            return clsPeopleDataAccess.updatePersonByID(this._personID, this._firstName, this._secondName, this._thirdName, this._lastName,
                this._nationalNumber, this._address, this._birthDate, this._gender,
                this._phone, this._email, this._countryID, this._imagePath);
        }
      public  static bool deletePerson(int personID)
        {
          return  clsPeopleDataAccess.deletePersonByID(personID);
        }
        static public string getPersonFullNameByID(int personID)
        {
            return clsPeopleDataAccess.getPersonFullName(personID);
        }

    }


}
