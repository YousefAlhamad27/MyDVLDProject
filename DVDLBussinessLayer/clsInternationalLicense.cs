using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsInternationalLicense
    {
        public enum eFilterBasis { None = 0, InterLicenseID = 1, AppID = 2, DriverID = 3, LocalLicenseID = 4 }
        public  eFilterBasis _filter;
        public int _internationalLicenseID {  get; set; }
        public int _applicationID {  get; set; }
        public int _localLicenseID {  get; set; }
        public int _driverID {  get; set; }
        public DateTime _issueDate {  get; set; }
        public DateTime _expirationDate { get; set; }

        public  bool _isActive {  get; set; }
        public int _createdByUserID {  get; set; }
       
        public clsInternationalLicense()
        {
            _internationalLicenseID = -1;
            _applicationID = -1;
            _localLicenseID = -1;
            _createdByUserID = -1;
            _driverID = -1;
            _issueDate = DateTime.Now;
            _expirationDate = DateTime.Now;
            _isActive = false;

        }

        private clsInternationalLicense(int internationalLicenseID,
            int applicationID,int driverID, int localLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            _internationalLicenseID = internationalLicenseID;
            _applicationID = applicationID;
            _localLicenseID = localLicenseID;
            _issueDate = issueDate;
            _expirationDate = expirationDate;
            _isActive = isActive;
            _createdByUserID = createdByUserID;
            _driverID = driverID;
        }
        static public DataTable getInternationalLicensesTable()
        {
            return clsInternationalLicensesDataAccess.getInternationalLicensesTable();
        }
        static public DataTable getFilteredTable(string filterData,eFilterBasis filter)
        {
            return clsInternationalLicensesDataAccess.getFilteredTable(filterData,(clsInternationalLicensesDataAccess.eFilterBasis)filter);
        }
        static public int addNewInternationalLicenseApplication(int applicationID,int driverID, int localLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive)
        {
            int internationalLicenseID = -1;

            if (clsInternationalLicensesDataAccess.addNewInternationalLicenseApplication(ref internationalLicenseID,applicationID, driverID, localLicenseID, issueDate, expirationDate, isActive, clsSession.currentUser._userID))
            {
                return internationalLicenseID;
            }

            return internationalLicenseID;
        }
     static public int doesPersonHaveAnInternationalLicense(int driverID)
        {
            return clsInternationalLicensesDataAccess.doesPersonAlreadyHaveAnInternationalLicense(driverID);
        }
        static public clsInternationalLicense getInternationalLicenseByDriverID(int driverID)
        {
             int internationalLicenseID = -1;
             int applicationID = -1;
             int localLicenseID = -1;
             int createdByUserID = -1;
             DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
             bool isActive = false;

            if(clsInternationalLicensesDataAccess.getInternationalLicenseByDriverID(driverID,ref internationalLicenseID,ref applicationID,ref localLicenseID,
                ref issueDate,ref expirationDate,ref isActive,ref createdByUserID))
            {
                return new clsInternationalLicense(internationalLicenseID, applicationID, driverID, localLicenseID, issueDate, expirationDate, isActive, createdByUserID);
            }
            return null;
        }

    }
}
