using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsDriver
    {
        public enum enFilter { None = 0, DriverID = 1, PersonId = 2, NationalNo = 3, FullName = 4, NumberOfLicenses = 5 }
        public enFilter _filter;
        public int _driverID { get; set; }
        public int _personID { get; set; }

        public int _userID { get; set; }
        public DateTime _creationDate { get; set; }


        public clsDriver()
        {
            _driverID = -1;
            _personID = -1;
            _userID = -1;
            _creationDate = DateTime.Now;

        }
        private clsDriver(int driverID, int personID, int userID, DateTime creationDate)
        {
            _driverID = driverID;
            _personID = personID;
            _userID = userID;
            _creationDate = creationDate;

        }
        static public DataTable getAllDriversTable()
        {
            return clsDriversDataAccess.getAllDrivers();
        }
        public DataTable getFilteredDataTable(string filterData)
        {
            return clsDriversDataAccess.getFilteredDriversTable(filterData, (clsDriversDataAccess.enFilterBasis)_filter);
        }
        static public int addNewDriver(int personID, DateTime datetime)
        {
            return clsDriversDataAccess.addNewDriver(personID, clsSession.currentUser._userID, datetime);
        }
        static public int isPersonADriver(int personID)
        {
            return clsDriversDataAccess.isPersonAdriver(personID);


        }
        static public int getPersonIDByDriverID(int driverID)
        {
            return clsDriversDataAccess.getPersonIDByDriverID(driverID);
        }


    }
    }
