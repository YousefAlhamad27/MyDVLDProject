using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsApplicationType
    {


        public int _applicationID {  get; set; }
        public string _title {  get; set; }
        public decimal _fees {  get; set; }

        public clsApplicationType() {
        
            _applicationID = -1;
            _title = "";
            _fees = 0;
        }

        private clsApplicationType(int TypeID, string title, decimal fees)
        {

            _applicationID = TypeID;
            _title = title;
            _fees = fees;
        }
        static public decimal getFeesByID(int typeID)
        {
            decimal fees =0;
            clsTypesApplicationDataAccess.getApplicationTypeFeesByID(typeID, ref fees);
                

            return fees;
        }
        static public string getTypeNameByAppID(int appID)
        {
            return clsTypesApplicationDataAccess.getApplicationTypeNameByID(appID);
        }
        static public DataTable getApplicationTypes()
        {
            return clsApplicationsDataAccess.GetDataTable();
        }
        static public clsApplicationType getType(int ID) {
            
            string title = "";
           decimal fees = 0;

            if(clsApplicationsDataAccess.getApplicationType(ID,ref title,ref fees))
                return new clsApplicationType(ID,title,fees);
            return null;
        }
        static public bool updateType(int ID,string title,decimal fees)
        {
            return clsApplicationsDataAccess.updateApplicationType(ID,title,fees);    
        }

    }
}
