using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVDLBussinessLayer
{
    public class clsUser
    {
        public enum enFilter { eNone = 0, eUserID = 1, ePersonID = 2, eFullName = 3, eUsername = 4, eIsActive = 5 };
        public enFilter eFilter;
        public int _userID { get; set; }
        public int _PersonID { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public bool _isActive { get; set; }

        static public DataTable getAllUsers()
        {
            return clsUserDataAccess.getAllUsers();
        }
        public clsUser()
        {
            _userID = -1;
            _PersonID = -1;
            _username = "";
            _password = "";
            _isActive = false;
        }
        public clsUser(int userid, int personID, string username, string password, bool isActive)
        {
            _userID = userid;
            _PersonID = personID;
            _username = username;
            _password = password;
            _isActive = isActive;


        }
        static public clsUser getUserByUserID(int userID)
        {


            int personID = -1;

            string username = "";
            string password = "";
            bool isActive = false;

            if (clsUserDataAccess.getUserByID(userID, ref personID, ref username, ref password, ref isActive))
            {
                return new clsUser(userID, personID, username, password, isActive);
            }

            return null;

        }
        static public int getPersonIDWithUserID(int userID)
        {
            int personID = 1;

            clsUserDataAccess.getPersonIDByUserID(userID, ref personID);
            return personID;
        }

        static public clsUser getUserByUserName(string username)
        {

            int personID = -1;
            int userId = -1;
            string password = "";
            bool isActive = false;


            if (clsUserDataAccess.getUserByUsername(username, ref userId, ref personID, ref password, ref isActive))
                return new clsUser(userId, personID, username, password, isActive);

            return null;
        }
        static public bool doesUserExistPersonID(int personID)
        {
            return clsUserDataAccess.doesUserExistByPersonID(personID);
        }
        static public bool doesUserExistUserID(int personID)
        {
            return clsUserDataAccess.doesUserExistByPersonID(personID);
        }
        static public clsUser getUserByPersonID(int personID)
        {
            int userID = -1;
            string username = "";
            string password = "";
            bool isActive = false;

            if (clsUserDataAccess.getUserByPersonID(personID, ref userID, ref username, ref password, ref isActive))
            {
                return new clsUser(userID, personID, username, password, isActive);
            }
            return null;
        }
        static public bool doesUserExistUsername(string username)
        {
            return clsUserDataAccess.doesUserExistByUsername(username);
        }


        public int addNewUser()
        {

            return clsUserDataAccess.addNewUser(this._PersonID, this._username, this._password, this._isActive);

        }
        public DataTable getFilteredDataTable(string filterData, bool isActive = false)
        {
            return clsUserDataAccess.filteredData(filterData, ((clsUserDataAccess.enFilterBasis)this.eFilter), isActive);
        }
        public bool updateUser()
        {

            return clsUserDataAccess.updateUserUserID(this._userID, this._PersonID, this._username, this._password, this._isActive);
        }
        static public bool deleteUser(int userID) { 
        return clsUserDataAccess.deleteUserByUserID(userID);
        }
      
    }
}
