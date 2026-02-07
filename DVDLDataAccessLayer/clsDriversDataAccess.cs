using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DVDLDataAccessLayer.clsPeopleDataAccess;

namespace DVDLDataAccessLayer
{
    public class clsDriversDataAccess
    {
        public enum enFilterBasis {None=0,DriverID=1,PersonId=2,NationalNo=3,FullName=4,NumberOfLicenses=5 }

        static public DataTable getAllDrivers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Drivers.DriverID as 'Driver ID', People.PersonID as" +
                " 'Person ID', People.NationalNo as 'National No.',\r\n    " +
                "            (People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+People.LastName) as 'Full Name'\r\n   " +
                "             , COUNT(*) as 'Active Licenses' \r\n          " +
                "      FROM     Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID INNER JOIN\r\n   " +
                "             Licenses ON Drivers.DriverID = Licenses.DriverID\r\n   " +
                "               group by Drivers.DriverID,People.PersonID,People.NationalNo,People.FirstName,\r\n   " +
                "              People.SecondName,People.ThirdName,People.LastName";

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
        static public DataTable getFilteredDriversTable(string filterData,enFilterBasis filterType)
        {

            DataTable dataTable = new DataTable();
            string query = "";


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string upperCase = "";
            string lowerCase = "";


            if (filterType == enFilterBasis.None)
                return getAllPeople();

            else if (filterType == enFilterBasis.DriverID)
            {

                query = "SELECT Drivers.DriverID as 'Driver ID', People.PersonID as" +
                " 'Person ID', People.NationalNo as 'National No.',\r\n    " +
                "            (People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+People.LastName) as 'Full Name'\r\n   " +
                "             , COUNT(*) as 'Active Licenses' \r\n          " +
                "      FROM     Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID INNER JOIN\r\n   " +
                "             Licenses ON Drivers.DriverID = Licenses.DriverID\r\n   " +
                "               group by Drivers.DriverID,People.PersonID,People.NationalNo,People.FirstName,\r\n   " +
                "              People.SecondName,People.ThirdName,People.LastName" +
                " having Drivers.DriverID=@filterData";



            }
            else if (filterType == enFilterBasis.NationalNo)
            {
                upperCase = filterData.ToUpper();
                lowerCase = filterData.ToLower();
                query = "SELECT Drivers.DriverID as 'Driver ID', People.PersonID as" +
                " 'Person ID', People.NationalNo as 'National No.',\r\n    " +
                "            (People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+People.LastName) as 'Full Name'\r\n   " +
                "             , COUNT(*) as 'Active Licenses' \r\n          " +
                "      FROM     Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID INNER JOIN\r\n   " +
                "             Licenses ON Drivers.DriverID = Licenses.DriverID\r\n   " +
                "               group by Drivers.DriverID,People.PersonID,People.NationalNo,People.FirstName,\r\n   " +
                "              People.SecondName,People.ThirdName,People.LastName" +
                " having People.NationalNo=@upperCase or People.NationalNo=@lowerCase ";

            }
            else if (filterType == enFilterBasis.PersonId)
            {
                query = "SELECT Drivers.DriverID as 'Driver ID', People.PersonID as" +
                " 'Person ID', People.NationalNo as 'National No.',\r\n    " +
                "            (People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+People.LastName) as 'Full Name'\r\n   " +
                "             , COUNT(*) as 'Active Licenses' \r\n          " +
                "      FROM     Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID INNER JOIN\r\n   " +
                "             Licenses ON Drivers.DriverID = Licenses.DriverID\r\n   " +
                "               group by Drivers.DriverID,People.PersonID,People.NationalNo,People.FirstName,\r\n   " +
                "              People.SecondName,People.ThirdName,People.LastName" +
                " having people.personID=@filterData";
            }
            else if (filterType == enFilterBasis.FullName)
            {
                query = "SELECT Drivers.DriverID as 'Driver ID', People.PersonID as" +
                " 'Person ID', People.NationalNo as 'National No.',\r\n    " +
                "            (People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+People.LastName) as 'Full Name'\r\n   " +
                "             , COUNT(*) as 'Active Licenses' \r\n          " +
                "      FROM     Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID INNER JOIN\r\n   " +
                "             Licenses ON Drivers.DriverID = Licenses.DriverID\r\n   " +
                "               group by Drivers.DriverID,People.PersonID,People.NationalNo,People.FirstName,\r\n   " +
                "              People.SecondName,People.ThirdName,People.LastName" +
                " having (People.FirstName+''+ People.SecondName+''+ People.ThirdName+''+People.LastName)=@filterData ";
            }
            else if (filterType == enFilterBasis.NumberOfLicenses)
            {
                query = "SELECT Drivers.DriverID as 'Driver ID', People.PersonID as" +
                " 'Person ID', People.NationalNo as 'National No.',\r\n    " +
                "            (People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+People.LastName) as 'Full Name'\r\n   " +
                "             , COUNT(*) as 'Active Licenses' \r\n          " +
                "      FROM     Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID INNER JOIN\r\n   " +
                "             Licenses ON Drivers.DriverID = Licenses.DriverID\r\n   " +
                "               group by Drivers.DriverID,People.PersonID,People.NationalNo,People.FirstName,\r\n   " +
                "              People.SecondName,People.ThirdName,People.LastName" +
                " having COUNT(*)=@filterData";
            }


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@filterData", filterData);
            command.Parameters.AddWithValue("@upperCase", upperCase);
            command.Parameters.AddWithValue("@lowerCase", lowerCase);








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
        static public int addNewDriver(int personID,int userID,DateTime creationDate)
        {
            int driverID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into Drivers (personID,createdByUserID,createdDate)" +

                "values(@personID,@userID,@creationDate);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@creationDate", creationDate);
         






            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    driverID = insertedID;
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

            return driverID;
        }
        static public int isPersonAdriver(int personID)
        {
            int driverID=-1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "select driverID from drivers where personID=@personID";

            SqlCommand command=new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID",personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                
                if (result != null && result != DBNull.Value)
                {
                    driverID = (int)result;
                }
;            }
            catch
            {
                return driverID;
            }
            finally
            {
                connection.Close();
            }
            return driverID;

        }
        static public int getPersonIDByDriverID(int driverID)
        {
            int personID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "select personID from drivers where driverID=@driverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@driverID", driverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && result != DBNull.Value)
                {
                    personID = (int)result;
                }
;
            }
            catch
            {
                return personID;
            }
            finally
            {
                connection.Close();
            }
            return personID;

        }

    }
}
