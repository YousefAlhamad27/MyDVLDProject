using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsLocalLicense
    {
        public enum eFilterBasis { None = 0, AppID = 1, DriverID = 2, LocalLicenseID = 3 }
        eFilterBasis filter;
        public int _licenseID {  get; set; }
        public int _applicationID { get; set; }
        public int _driverID { get; set; }
        public int _licenseClassID { get; set; }
        public DateTime _issueDate { get; set; }
        public DateTime _expirationDate { get; set; }
        public string _notes { get; set; }
        public decimal _paidFees { get; set; }
        public bool _isActive { get; set; }
        public byte _issueReason { get; set; }
        public int _createdByUserID { get; set; }

        public clsLocalLicense()
        {
            _applicationID = -1;
            _driverID = -1;
            _licenseClassID = -1;
            _issueDate      = DateTime.Now;
            _expirationDate = DateTime.Now;
            _notes = "";
            _paidFees = 0;
            _isActive = false;
            _issueReason = 0;
            _createdByUserID = -1;
        }

        private clsLocalLicense(int licenseID,int applicaitonID, int driverID, 
            int licenseClassID, DateTime date, DateTime expirationDate, string notes, decimal paidFees, bool isActive
            , byte issueReason, int createdByUserID)
        {
            _licenseID= licenseID;
            _applicationID= applicaitonID;
            _driverID= driverID;
            _licenseClassID = licenseClassID;
            _issueDate = date;
            _expirationDate = expirationDate;
            _notes = notes;
            _paidFees= paidFees;
            _isActive= isActive;
            _issueReason = issueReason;
            _createdByUserID = createdByUserID;
        }
        static public DataTable getLicenseClassesNamesTable()
        {
            return clsLicenseDataAccess.getLicenseClassesNames();
        }
        static public DataTable getLocalLicensesDataTable()
        {
            return clsLicenseDataAccess.getLocalLicensesTable();
        }
        static public DataTable getFilteredLocalLicenseTable(string filterData,eFilterBasis eFilter)
        {
            return clsLicenseDataAccess.getFilteredTable(filterData,(clsLicenseDataAccess.eFilterBasis)eFilter);
        }
        static public DataTable getInternationalLicensesDataTable()
        {
            return clsInternationalLicensesDataAccess.getInternationalLicensesTable();
        }
        static public int addNewLicense(int applicaitonID, int driverID, int licenseClassID, DateTime date, DateTime expirationDate, string notes,decimal paidFees, bool isActive
            , int issueReason, int createdByUserID,bool firstTime=true)
        {
            return clsLicenseDataAccess.issueLicense(applicaitonID, driverID, licenseClassID, date, expirationDate, notes,paidFees, isActive
            , issueReason, createdByUserID,firstTime);
        }
        static public int getMinimumAge(int licenseClassID)
        {
            return clsLicenseDataAccess.getMinimumAge(licenseClassID);
        }
        static public int defaultValidityYears(int licenseClassID)
        {
            return clsLicenseDataAccess.defaultValidityYears(licenseClassID);
        }
        static public decimal getFees(int licenseClassID) {
        return clsLicenseDataAccess.getFees(licenseClassID);
        
        }
        static public clsLocalLicense getLIcenseByID(int licenseID)
        {
            

            int applicationID = -1;
            int driverID = -1;

            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expiration = DateTime.Now;
            string notes = "";

            decimal paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;
            int createdByUserID = -1;



            if( clsLicenseDataAccess.getLicense(licenseID, ref applicationID, ref driverID, ref licenseClassID,
              ref issueDate, ref expiration, ref notes, ref paidFees, ref isActive,ref issueReason,ref createdByUserID))
            {
                return new clsLocalLicense(licenseID,  applicationID,  driverID,  licenseClassID,
               issueDate,  expiration,  notes,  paidFees,  isActive,  issueReason,  createdByUserID);
            }
            return null;
        }
        static public string getclassNameByID(int licenseClassID) {
        return clsLicenseDataAccess.getClassNameByID(licenseClassID);
        
        }
        static public int getLicenseIDByAppID(int appID)
        {
            return clsLicenseDataAccess.getLicenseIDByAppID(appID);
        }
        static public bool deactivateLicense(int licenseID)
        {
            return clsLicenseDataAccess.deactivateLicense(licenseID);
        }
        static public int doesDriverHaveAnActiveLicense(int driverID,int classID)
        {
            return clsLicenseDataAccess.doesDriverHaveAnActiveLicense(driverID, classID);
        }

        static public void updateLicenes()
        {
             clsLicenseDataAccess.setExpiredLicensesToInActive();
        }
    }
}
