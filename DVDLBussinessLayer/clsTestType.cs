using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsTestType
    {

        public int _testTypeID {  get; set; }
        public string _testTypeTilte {  get; set; }
        public string _testTypeDescription {  get; set; } 
        public decimal _testTypeFees {  get; set; }

        public clsTestType() { 
            _testTypeID = -1;
            _testTypeTilte = "";
            _testTypeDescription = "";
            _testTypeFees = 0;
        }
        private clsTestType(int testTypeID,string title,string description,decimal fees)
        {
            _testTypeID = testTypeID;
            _testTypeTilte= title;
            _testTypeDescription= description;
            _testTypeFees= fees;
        }

        static public int getCountOfTrialsLocAppID(int locAppID,int testTypeID) {
            return clsTestTypesDataAccess.getTrialCountByLocAppID(locAppID,testTypeID);
        }
        static public decimal getTestTypeApplicationFees(int testType) {
        return clsTestTypesDataAccess.getTestTypeFeesByTestTypeID(testType);
        
        }

        static public DataTable getDataTable()
        {
            return clsTestTypesDataAccess.getTestsTypesDataTable();
        }

        static public bool updateTestType(int ID,string title, string description,decimal Fees)
        {
            return clsTestTypesDataAccess.updateTestType(ID,title,description,Fees);
        }
        static public clsTestType getTestType(int testTypeID)
        {
        
            string testTypeTilte = "";
           string testTypeDescription = "";
            decimal testTypeFees = 0;


            if (clsTestTypesDataAccess.getTestType(testTypeID,ref testTypeTilte,ref testTypeDescription,ref testTypeFees))
            {
                return new clsTestType(testTypeID, testTypeTilte, testTypeDescription, testTypeFees);
            }
            return null;
        }
    }
}
