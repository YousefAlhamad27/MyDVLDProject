using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DVDLDataAccessLayer.clsPeopleDataAccess;

namespace DVDLDataAccessLayer
{
    public class clsUserDataAccess
    {

        public enum enFilterBasis { eNone = 0, eUserID = 1, ePersonID = 2,eFullName=3, eUsername = 4, eIsActive = 5 };
        private bool returnIsActiveByBit(int isActive) {

            return isActive == 1 ? true : false;
        
        }
        static public bool getUserByID(int userID,ref int personID,ref string username,ref string password,ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from users where userID=@userID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["personID"];
                    username = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isFound = false;

            }

            finally
            {
                connection.Close();
            }

            return isFound;



        }
        static public bool getUserByPersonID(int personID, ref int userID, ref string username, ref string password, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from users where personID=@personID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    userID = (int)reader["userID"];
                    username = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isFound = false;

            }

            finally
            {
                connection.Close();
            }

            return isFound;



        }
        static public bool getPersonIDByUserID(int userID , ref int personID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select personID from users where userID=@userID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["personID"];
                   
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isFound = false;

            }

            finally
            {
                connection.Close();
            }

            return isFound;



        }
        static public bool doesUserExistByPersonID(int personID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from users where personID=@personID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isFound = false;

            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public bool doesUserExistByUserID(int userID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from users where userID=@userID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;


                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isFound = false;

            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public bool doesUserExistByUsername(string username)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from users where username=@username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;


                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isFound = false;

            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public bool getUserByUsername(string username,ref int userID, ref int personID, ref string password,ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from users where username=@username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["personID"];
                    userID = (int)reader["userID"];
                    password = (string)reader["password"];
                    isActive = (bool)reader["isActive"];
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isFound = false;

            }

            finally
            {
                connection.Close();
            }

            return isFound;



        }
        static public DataTable getAllUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Users.UserID as 'User ID', People.PersonID as 'Person ID'," +
                "(People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName)as 'Full Name', " +
                "Users.UserName as 'Username', Users.IsActive as 'Is Active' FROM     Users INNER JOIN " +
                "           People ON Users.PersonID = People.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();




            try
            {

                SqlDataReader reader = command.ExecuteReader();


                dataTable.Load(reader);


                connection.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message)
                    ;
            }
            finally
            {
                connection.Close();

            }

            return dataTable;
        }
        static public DataTable filteredData(string filterData, enFilterBasis filterType, bool isActive = false)
        {
            int bit;

            if (isActive == false)
                bit = 0;
            else
                bit = 1;
                DataTable dataTable = new DataTable();
            string query = "";


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);



            if (filterType == enFilterBasis.eNone)
                return getAllUsers();

            else if (filterType == enFilterBasis.ePersonID)
            {

                query = "SELECT Users.UserID as 'User ID', People.PersonID as 'Person ID'," +
                    "(People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName)as 'Full Name'," +
                    "  Users.UserName as 'Username', Users.IsActive as 'Is Active' FROM   " +
                    "  Users INNER JOIN" +
                    "  People ON Users.PersonID = People.PersonID" +
                    "      where People.personID=@filterData";
            }

             else if (filterType== enFilterBasis.eUserID)
            {
                query = "SELECT Users.UserID as 'User ID', People.PersonID as 'Person ID'," +
                   "(People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName)as 'Full Name'," +
                   "  Users.UserName as 'Username', Users.IsActive as 'Is Active' FROM   " +
                   "  Users INNER JOIN" +
                   "  People ON Users.PersonID = People.PersonID" +
                   "      where Users.userID=@filterData";
            }

            else if (filterType == enFilterBasis.eFullName)
            {
                query = "SELECT Users.UserID as 'User ID', People.PersonID as 'Person ID'," +
                   "(People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName)as 'Full Name'," +
                   "  Users.UserName as 'Username', Users.IsActive as 'Is Active' FROM   " +
                   "  Users INNER JOIN" +
                   "  People ON Users.PersonID = People.PersonID" +
                   "      where (People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName)=@filterData";
            }
            else if (filterType == enFilterBasis.eUsername)
            {
                query = "SELECT Users.UserID as 'User ID', People.PersonID as 'Person ID'," +
                   "(People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName)as 'Full Name'," +
                   "  Users.UserName as 'Username', Users.IsActive as 'Is Active' FROM   " +
                   "  Users INNER JOIN" +
                   "  People ON Users.PersonID = People.PersonID" +
                   "      where Users.username=@filterData";
            }
            else if (filterType == enFilterBasis.eIsActive)
            {
                query = "SELECT Users.UserID as 'User ID', People.PersonID as 'Person ID'," +
                   "(People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName)as 'Full Name'," +
                   "  Users.UserName as 'Username', Users.IsActive as 'Is Active' FROM   " +
                   "  Users INNER JOIN" +
                   "  People ON Users.PersonID = People.PersonID" +
                   "      where Users.isActive=@isActive";
            }



            SqlCommand command = new SqlCommand(query, connection);

            if (filterType != enFilterBasis.eIsActive)
            {
                command.Parameters.AddWithValue("@filterData", filterData);
            }
            else
            {
                command.Parameters.AddWithValue("@isActive", isActive); // Pass bool directly
            }









            connection.Open();




            try
            {

                SqlDataReader reader = command.ExecuteReader();


                dataTable.Load(reader);


                connection.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message)
                    ;
            }
            finally
            {
                connection.Close();

            }

           

            return dataTable;
        }
        static public bool updateUserUserID(int userID, int personID, string username, string password, bool isActive)
        {


            bool isUpdated = false;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Update users set personID=@personID,username=@username,password=@password," +
                "isActive=@isActive   where userID=@userID;";

            SqlCommand command = new SqlCommand(query, connection);




            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@isActive", isActive);



            try
            {

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    isUpdated = true;

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {

                connection.Close();
            }




            return isUpdated;
        }
        static public int addNewUser(int personID,string username,string password,bool isActive)
        {

            int userID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into users (personID,UserName,Password,IsActive)" +
                "values(@personID,@username,@password,@isActive);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    userID = insertedID;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {

                connection.Close();
            }

            return userID;


        }
        static public bool deleteUserByUserID(int userID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "delete from users where userID=@userID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@userID", userID);
            int rowsAffected = 0;

            try
            {

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }


    

}
}
