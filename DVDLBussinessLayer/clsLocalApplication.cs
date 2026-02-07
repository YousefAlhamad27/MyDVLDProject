using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVDLBussinessLayer
{
    public class clsLocalApplication
    {

        
        public enum enApplicationStatus {New=1,Cancelled=2,Completed=3};
        public enApplicationStatus eStatus;
        public enum enFilter { None = 0, LocalApplicationLicenseID = 1, NationalNo = 2, fullName = 3, Status = 4 }
        public enFilter eFilter;
        public int _applicationID { get; set; }
        public int _personID { get; set; }
        public DateTime _ApplicationDate { get; set; }
        public int _applicationTypeID { get; set; }

        public int _applicationStatus { get; set; }
        public DateTime _lastStatusDate { get; set; }
        public decimal _paidFees { get; set; }
        public int _createdByUserID { get; set; }

        public int _licenseClassID {  get; set; }

       public clsLocalApplication()
        {
          _applicationID = -1;
         _personID = -1;
            _ApplicationDate = DateTime.Now;
         _applicationTypeID = -1;

         _applicationStatus = 1;
          _lastStatusDate = DateTime.Now;
            _paidFees = 0;
         _createdByUserID = -1;
    }
        private clsLocalApplication(int applicationID,int personID,DateTime applicationDate,
            int applicationTypeID,int applicationStatus,DateTime lastStatusDate, decimal paidFees,int createdByUserID,int licenseClassID )
        {
            _applicationID= applicationID;
            _personID= personID;
            _ApplicationDate= applicationDate;
            _applicationTypeID= applicationTypeID;
            _applicationStatus = applicationStatus;
            _lastStatusDate= lastStatusDate;
            _paidFees= paidFees;
            _createdByUserID= createdByUserID;
            _licenseClassID= licenseClassID;
        }

        static public DataTable getAllApplications() {

            return clsLocalApplicationsDataAccess.getAllApplicationsTable();
        }
         public DataTable getFilteredApplicationsDataTable(string filterData)
        {

            return clsLocalApplicationsDataAccess.getFilteredData(filterData,(clsLocalApplicationsDataAccess.eFilterBasis)this.eFilter);
        }
       static public clsLocalApplication getLocalApplicationByID(int applicationID)
        {

         
            int personID = -1;
            DateTime ApplicationDate = DateTime.Now;
             int applicationTypeID = -1;

          byte  applicationStatus = 1;
            DateTime  lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            int licenseClassID = -1;
            if (!clsLocalApplicationsDataAccess.getApplicationByID(applicationID, ref personID, ref ApplicationDate,ref applicationTypeID,
                ref applicationStatus,ref lastStatusDate,ref paidFees,ref createdByUserID))
            {
                return null;
            }
           
                return new clsLocalApplication(applicationID, personID, ApplicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID,licenseClassID);
        }
        static public clsLocalApplication getApplicationByID(int applicationID)
        {


            int personID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int applicationTypeID = -1;

            byte applicationStatus = 1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            int licenseClassID = -1;
            if (!clsApplicationsDataAccess.getApplicationByID(applicationID, ref personID, ref ApplicationDate, ref applicationTypeID,
                ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID))
            {
                return null;
            }

            return new clsLocalApplication(applicationID, personID, ApplicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID, licenseClassID);
        }
        static public clsLocalApplication getApplicationByPersonID(int personID )
        {


            int applicationID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int applicationTypeID = -1;

            byte applicationStatus = 1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = 0;
            int createdByUserID = -1;
            int licenseClassID = -1;
            if (!clsLocalApplicationsDataAccess.getApplicationByID(personID, ref  applicationID, ref ApplicationDate, ref applicationTypeID,
                ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID))
            {
                return null;
            }

            return new clsLocalApplication(applicationID, personID, ApplicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID,licenseClassID);
        }
        public int addNewApplication()
        {
            return clsLocalApplicationsDataAccess.addNewApplication(this._personID,this._ApplicationDate,this._applicationTypeID,this._applicationStatus
                ,this._lastStatusDate,this._paidFees,this._createdByUserID,this._licenseClassID);
        }

        static public int getLicenseID(int locApplicationID)
        {
            return clsLocalApplicationsDataAccess.getApplicationLicenseClassID(locApplicationID);
        }
        static public bool updateApplicationByLocAppID(int locAppID,int licenseClassID)
        {
            return clsLocalApplicationsDataAccess.updateApplicationByLocAppID(locAppID,licenseClassID);
        }
        static public bool doesApplicantHaveAnAppOfSameClassNationalNumber(string nationalNumber,int licenseClassID, ref int applicationID)
        {
            return clsLocalApplicationsDataAccess.doesApplicantHaveAnAppOfSameLicenseClassIDNationalNumber(nationalNumber,licenseClassID,ref applicationID);
        }
        static public bool doesApplicantHaveSameStatusForSameLicenseClassApplication(string nationalNumber, int licenseClassID, ref int applicationID) 
        {
            return clsLocalApplicationsDataAccess.doesApplicantHaveSameStatusForSameLicenseClassApplication(nationalNumber,licenseClassID, ref applicationID);
        }
        static public int getApplicationStatusAppID(int ApplicationID)
        {
            return clsLocalApplicationsDataAccess.getApplicationStatusAppID(ApplicationID);
        }
        static public int getApplicationStatusLocAppID(int ApplicationID)
        {
            return clsLocalApplicationsDataAccess.getApplicationStatusLocalAppID(ApplicationID);
        }
        static public int getLocApplicationID(int applicationID)
        {
            return clsLocalApplicationsDataAccess.getLocalAppIDLicenseClassID(applicationID);
        }
        static public int getAppIDByLocID(int locID)
        {
            return clsLocalApplicationsDataAccess.getApplicationIDByLocAppID(locID);
        }
        static public bool deleteLocalApplicationByAppID(int appID)
        {
            return clsLocalApplicationsDataAccess.deleteLocalApplicationByAppID(appID);
        }

        static public bool updateApplicationStatusByLocID(int locAppID,enApplicationStatus status)
        {
            return clsLocalApplicationsDataAccess.updateApplicationStatus(locAppID,(clsLocalApplicationsDataAccess.eApplicationStatus)status);
        }
        static public int getPassedTests(int locAppID)
        {
            return clsLocalApplicationsDataAccess.getPassedTestsAppID(locAppID);
        }
        static public string getLicenseClassNameByLocID(int locAppID)
        {
            return clsLocalApplicationsDataAccess.getLicenseClassNameByLocID(locAppID);
        }
        static public int addNewApplication(int personID, DateTime applicationDate,
          int applicationTypeID, int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID, int licenseClassID, bool localApplication = true)
        {
            return clsLocalApplicationsDataAccess.addNewApplication(personID, applicationDate,
               applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID, licenseClassID, localApplication);
        }
        }
}
