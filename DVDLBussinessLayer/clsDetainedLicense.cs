using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsDetainedLicense
    {
        public enum eFilterBasis { None = 0, detainID = 1, notReleased = 2, released = 3, nationalNo = 4, fullName = 5, releaseAppID = 6 }
        public  eFilterBasis _filter;
        public int _detainID {  get; set; }
        public int _licenseID {  get; set; }
        public DateTime _detainDate {  get; set; }
        public DateTime _releaseDate { get; set;}
        public decimal _paidFees {  get; set; }
        public int _createdByUserID {  get; set; }
        public int _releasedByUserID {  get; set; }
        public bool _isReleased {  get; set; }
        public int _releaseApplicationID {  get; set; }

        private clsDetainedLicense(int detainID,int licenseID,DateTime detainDate,decimal paidFees,int createdUserID,bool isReleased,
            DateTime releaseDate,int releasedByUserID,int releaseApplicationID) {

            _detainID = detainID;
           _detainDate = detainDate;
            _createdByUserID = createdUserID;
            _licenseID = licenseID;
            _releaseApplicationID = releaseApplicationID;
            _releasedByUserID = releasedByUserID;
            _releaseDate = releaseDate;
            _paidFees = paidFees;
            _isReleased = isReleased;
        }

        public clsDetainedLicense() {

            _detainID = -1;
            _detainDate = new DateTime();
            _createdByUserID = -1;
            _licenseID = -1;
            _releaseApplicationID = -1;
            _releasedByUserID = -1;
            _releaseDate = new DateTime();
            _paidFees = 0;
            _isReleased = false;
        }



        static public DataTable getDetainedLicenses()
        {
            return clsDetainedLicensesDataAccess.getDetainedLicenesDataTable();
        }
        static public DataTable getFilteredDetainedTable(string filterData,eFilterBasis filter)
        {
            return clsDetainedLicensesDataAccess.getFilteredTable(filterData,(clsDetainedLicensesDataAccess.eFilterBasis)filter);
        }
        static public int addNewDetainedLicense(int licenseID,decimal fineFees)
        {
            return clsDetainedLicensesDataAccess.detainLicense(licenseID,fineFees,clsSession.currentUser._userID);
        }

        static public bool isLicenseDetained(int licenseID) {
        return clsDetainedLicensesDataAccess.isLicenseDetained(licenseID);
        
        }
        static public clsDetainedLicense getDetainObject(int licenseID) {
            int detainID = -1;
            DateTime detainDate = new DateTime();
            int createdByUserID = -1;

            int releaseApplicationID = -1;
            int releasedByUserID = -1;
            DateTime releaseDate = new DateTime();
            decimal paidFees = 0;
            bool isReleased = false;

            if(clsDetainedLicensesDataAccess.getDetainInfo(licenseID,ref detainID, ref detainDate, ref paidFees,ref createdByUserID,ref isReleased
                ,ref releaseDate,ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicense(detainID,licenseID,detainDate ,paidFees,createdByUserID,isReleased,releaseDate,releasedByUserID,releaseApplicationID);
            }
            return null;
        }
        static public clsDetainedLicense getDetainObjectDetainID(int detainID)
        {
            int licenseID = -1;
            DateTime detainDate = new DateTime();
            int createdByUserID = -1;

            int releaseApplicationID = -1;
            int releasedByUserID = -1;
            DateTime releaseDate = new DateTime();
            decimal paidFees = 0;
            bool isReleased = false;

            if (clsDetainedLicensesDataAccess.getDetainInfoByDetainID(detainID, ref licenseID, ref detainDate, ref paidFees, ref createdByUserID, ref isReleased
                , ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicense(detainID, licenseID, detainDate, paidFees, createdByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }
            return null;
        }

        static public bool releaseDetainedLicense(int detainID,int appID)
        {
            return clsDetainedLicensesDataAccess.releaseLicense(detainID,clsSession.currentUser._userID,appID);
        }
    }
}
