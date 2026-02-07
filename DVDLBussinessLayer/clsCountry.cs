using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVDLBussinessLayer
{
    public class clsCountry
    {

        public string _countryName { get; set; }
        public int _countryID { get; set; }

        public clsCountry(int countryID, string countryName)
        {
            _countryID = countryID;
            _countryName = countryName;

        }

    static    public string getCountryNameByID(int ID) {
            string countryName = "";
            if (clsCountriesDataAccess.findCountrybyID(ID, ref countryName))

                return countryName;

            else return "";
        }
        static public string getCountryIDByName(string countryName)
        {
            string countryID = "";
            if (clsCountriesDataAccess.getCountryIDByName(countryName, ref countryID))

                return countryID;

            else return "";
        }
       static public DataTable getCountriesTable()
        {
            return  clsCountriesDataAccess.allCountriesDataTable();
        }

    }
}
