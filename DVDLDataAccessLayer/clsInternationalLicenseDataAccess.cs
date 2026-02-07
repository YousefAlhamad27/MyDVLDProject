using DVDLDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVDLDataAccessLayer.clsLocalApplicationsDataAccess;
using static System.Net.Mime.MediaTypeNames;

namespace DVDLBussinessLayer
{
    public class clsInternationalLicensesDataAccess
    {
        public enum eFilterBasis { None = 0, InterLicenseID = 1, AppID = 2, DriverID = 3, LocalLicenseID = 4 }
        static public DataTable getInternationalLicensesTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = " SELECT InternationalLicenses.InternationalLicenseID, \r\n          " +
                "      InternationalLicenses.ApplicationID, Licenses.DriverID,Licenses.LicenseID,  \r\n " +
                "               InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate,\r\n     " +
                "            InternationalLicenses.IsActive FROM     InternationalLicenses INNER JOIN\r\n          " +
                "                       Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID";

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

        static public DataTable getFilteredTable(string filterData, eFilterBasis filter)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "";




            if (filter == eFilterBasis.None)
            {
                query = "SELECT InternationalLicenses.InternationalLicenseID" +
                   ", InternationalLicenses.ApplicationID, Licenses.LicenseID," +
                   " InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, " +
                   "InternationalLicenses.IsActive\r\nFROM     InternationalLicenses INNER JOIN\r\n    " +
                   "              Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN\r\n   " +
                   "               Drivers ON InternationalLicenses.DriverID =" +
                   " Drivers.DriverID AND Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n        " +
                   "          Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID" +
                   " ";
            }
            else if (filter == eFilterBasis.InterLicenseID)
            {
                query = "SELECT InternationalLicenses.InternationalLicenseID" +
                    ", InternationalLicenses.ApplicationID, Licenses.LicenseID," +
                    " InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, " +
                    "InternationalLicenses.IsActive\r\nFROM     InternationalLicenses INNER JOIN\r\n    " +
                    "              Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN\r\n   " +
                    "               Drivers ON InternationalLicenses.DriverID =" +
                    " Drivers.DriverID AND Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n        " +
                    "          Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID" +
                    " where InternationalLicenses.InternationalLicenseID=@filterData  ";
            }
            else if (filter == eFilterBasis.AppID)
            {
                query = "SELECT InternationalLicenses.InternationalLicenseID" +
                    ", InternationalLicenses.ApplicationID, Licenses.LicenseID," +
                    " InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, " +
                    "InternationalLicenses.IsActive\r\nFROM     InternationalLicenses INNER JOIN\r\n    " +
                    "              Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN\r\n   " +
                    "               Drivers ON InternationalLicenses.DriverID =" +
                    " Drivers.DriverID AND Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n        " +
                    "          Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID" +
                    " where Applications.ApplicationID=@filterData  ";
            }
            else if (filter == eFilterBasis.DriverID)
            {
                query = "SELECT InternationalLicenses.InternationalLicenseID" +
                    ", InternationalLicenses.ApplicationID, Licenses.LicenseID," +
                    " InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, " +
                    "InternationalLicenses.IsActive\r\nFROM     InternationalLicenses INNER JOIN\r\n    " +
                    "              Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN\r\n   " +
                    "               Drivers ON InternationalLicenses.DriverID =" +
                    " Drivers.DriverID AND Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n        " +
                    "          Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID" +
                    " where Drivers.DriverID=@filterData  ";
            }
            else if (filter == eFilterBasis.LocalLicenseID)
            {
                query = "SELECT InternationalLicenses.InternationalLicenseID" +
                    ", InternationalLicenses.ApplicationID, Licenses.LicenseID," +
                    " InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, " +
                    "InternationalLicenses.IsActive\r\nFROM     InternationalLicenses INNER JOIN\r\n    " +
                    "              Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN\r\n   " +
                    "               Drivers ON InternationalLicenses.DriverID =" +
                    " Drivers.DriverID AND Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n        " +
                    "          Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID" +
                    " where Licenses.LicenseID=@filterData  ";
            }



            

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@filterData", filterData);

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

        static public bool addNewInternationalLicenseApplication(ref int internationalLicenseID, int applicationID, int driverID,
            int localLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            bool isAdded = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into InternationalLicenses (applicationID,driverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID)" +
                " values(@applicationID,@driverID,@localLicenseID,@issueDate,@expirationDate,@isActive,@createdByUserID);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationID", applicationID);
            command.Parameters.AddWithValue("@localLicenseID", localLicenseID);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expirationDate", expirationDate);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            command.Parameters.AddWithValue("@driverID", driverID);

            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    internationalLicenseID = insertedID;
                    isAdded = true;

                    // addApplicationToLocalApplications(applicationID, licenseClassID);
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

            return isAdded;
        }

        static public int doesPersonAlreadyHaveAnInternationalLicense(int driverID)
        {
            int intLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select internationalLicenseID from internationalLicenses where DriverID=@driverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@driverID", driverID);

            try
            {
                connection.Open();
             
                object result= command.ExecuteScalar();

                if(result!=null)
                    intLicenseID = (int)result;





                

                
            }

            catch (Exception ex)
            {

                return intLicenseID;

            }

            finally
            {
                connection.Close();
            }

            return intLicenseID;
        }
        static public bool getInternationalLicenseByDriverID(int driverID,ref int intLicenseID,ref int appID,ref int localLicenseID,
            ref DateTime issueDate,ref DateTime expirationDate,ref bool isActive,ref int createdByUserID) {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select * from InternationalLicenses where DriverID=@driverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@driverID", driverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    intLicenseID = (int)reader["InternationalLicenseID"];
                    appID= (int)reader["ApplicationID"];
                    localLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = (bool)reader["IsActive"];
                    createdByUserID = (int)reader["createdByUserID"];




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



    }
}
