using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVDLDataAccessLayer.clsLocalApplicationsDataAccess;
using static System.Net.Mime.MediaTypeNames;

namespace DVDLDataAccessLayer
{
    public class clsLicenseDataAccess
    {
        public enum eFilterBasis { None = 0, AppID = 1, DriverID = 2, LocalLicenseID = 3 }
        static public DataTable getLicenseClassesNames()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select ClassName from licenseClasses";

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
        static public DataTable getLocalLicensesTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Licenses.LicenseID," +
                " Licenses.ApplicationID, LicenseClasses.ClassName," +
                " Licenses.IssueDate, Licenses.ExpirationDate," +
                " Licenses.IsActive\r\nFROM     Licenses INNER JOIN\r\n          " +
                "        LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID";

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
                query = "SELECT Licenses.LicenseID," +
                    " Licenses.ApplicationID, Licenses.IssueDate," +
                    " Licenses.ExpirationDate, Licenses.IsActive\r\nFROM" +
                    "     Licenses INNER JOIN\r\n              " +
                    "    LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID";
            }
          
            else if (filter == eFilterBasis.AppID)
            {
                query = "SELECT Licenses.LicenseID, Licenses.ApplicationID, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive\r\nFROM     Licenses INNER JOIN\r\n                  LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID applicationID=@filterData  ";
            }
            else if (filter == eFilterBasis.DriverID)
            {
                query = "SELECT Licenses.LicenseID, " +
                    "Licenses.ApplicationID, Licenses.IssueDate," +
                    " Licenses.ExpirationDate, Licenses.IsActive\r\nFROM   " +
                    "  Licenses INNER JOIN\r\n             " +
                    "     LicenseClasses ON Licenses.LicenseClass =" +
                    " LicenseClasses.LicenseClassID where DriverID=@filterData";
                    
            }
            else if (filter == eFilterBasis.LocalLicenseID)
            {
                query = "SELECT Licenses.LicenseID," +
                    " Licenses.ApplicationID, Licenses.IssueDate, " +
                    "Licenses.ExpirationDate, Licenses.IsActive\r\nFROM" +
                    "     Licenses INNER JOIN\r\n                " +
                    "  LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID " +
                    "where licenseID=@filterData";
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

        static public bool deactivateLicense(int licenseID)
        {
            bool isUpdated = false;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update Licenses set isActive=0 where licenseID=@licenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseID", licenseID);
          







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
        static public int issueLicense(int applicaitonID,int driverID,int licenseClassID,DateTime date,DateTime expirationDate,string notes, decimal paidFees, bool isActive
            ,int issueReason,int createdByUserID,bool firstTime=true)
        {
            int licenseID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into Licenses (applicationID,DriverID,licenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)" +
                " values (@applicaitonID,@driverID,@licenseClassID,@date,@expirationDate,@notes,@PaidFees,@isActive,@issueReason,@createdByUserID);" +
                " select SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicaitonID", applicaitonID);
            command.Parameters.AddWithValue("@driverID", driverID);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@expirationDate", expirationDate);
           
           
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@issueReason", issueReason);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            if(notes!="")
            command.Parameters.AddWithValue("@notes", notes);
            else
                command.Parameters.AddWithValue("@notes", DBNull.Value);
            try
                {

                    connection.Open();

                    object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    licenseID = insertedID;

                    if (firstTime)
                    {
                        int locappId = clsLocalApplicationsDataAccess.getLocalAppIDLicenseClassID(applicaitonID);
                        clsLocalApplicationsDataAccess.updateApplicationStatus(locappId, clsLocalApplicationsDataAccess.eApplicationStatus.Completed);
                    }
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

            return licenseID;
        }


        static public int getMinimumAge(int licenseClassID)
        {
            int age = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT minimumAllowedAge from LicenseClasses where licenseclassID=@licenseClassID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    object result = command.ExecuteScalar();


                    if (result != null && result != DBNull.Value)
                    {
                        age = (int)result;
                    }


                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return age;

            }

            finally
            {
                connection.Close();
            }

            return age;
        }
        static public string getClassNameByID(int licenseClassID)
        {

            string className = "";
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT className from LicenseClasses where licenseclassID=@licenseClassID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);

            try
            {
                connection.Open();
              
              
                    object result = command.ExecuteScalar();


                    if (result != null && result != DBNull.Value)
                    {
                        className = (string)result;
                    }


                

              
            }

            catch (Exception ex)
            {

                return className;

            }

            finally
            {
                connection.Close();
            }

            return className;
        }
        static public int defaultValidityYears(int licenseClassID)
        {
            byte age = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT defaultValidityLength from LicenseClasses where licenseclassID=@licenseClassID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);

            try
            {
                connection.Open();
                
                    object result = command.ExecuteScalar();


                    if (result != null && result != DBNull.Value)
                    {
                        age = (byte)result;
                    }


                

              
            }

            catch (Exception ex)
            {

                return age;

            }

            finally
            {
                connection.Close();
            }

            return age;
        }
        

        static public decimal getFees(int licenseClassID)
        {
            decimal age = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT classFees from LicenseClasses where licenseclassID=@licenseClassID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && result != DBNull.Value)
                {
                    age = (decimal)result;
                }





            }

            catch (Exception ex)
            {

                return age;

            }

            finally
            {
                connection.Close();
            }

            return age;
        }
        static public bool getLicense(int licenseID, ref int applicationID,ref int driverID,ref int licenseClassID,ref DateTime issueDate,ref DateTime expirationDate,
            ref string notes, ref decimal paidFees, ref bool isActive,ref byte issueReason,ref int createdByUserID) {

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT * from licenses where licenseID=@licenseID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseID", licenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    


                   
                     isFound = true;
                    applicationID = (int)reader["applicationID"];
                    issueDate = (DateTime)reader["issueDate"];
                    licenseClassID = (int)reader["licenseClass"];
                    driverID = (int)reader["driverID"];
                    expirationDate = (DateTime)reader["expirationDate"];
                    paidFees = (decimal)reader["paidFees"];
                    createdByUserID = (int)reader["createdByUserID"];
                    isActive = (bool)reader["isActive"];
                    issueReason = (byte)reader["issueReason"];
                    if (reader["notes"] == DBNull.Value)
                        notes = null;
                    else
                        notes = (string)reader["notes"];



                }


                

                reader.Close();
            }

            catch (Exception ex)
            {

                return isFound;

            }

            finally
            {
                connection.Close();
            }

            return isFound;

        }
        static public  int getLicenseIDByAppID(int appID)
        {
            int licenseID = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT licenseID from licenses where applicationID=@appID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && result != DBNull.Value)
                {
                    licenseID = (int)result;
                }





            }

            catch (Exception ex)
            {

                return licenseID;

            }

            finally
            {
                connection.Close();
            }

            return licenseID;
        }
        static public int doesDriverHaveAnActiveLicense(int driverID, int licenseClassID)
        {


            int licenseID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT licenseID from licenses where driverID=@driverID and licenseClass=@licenseClassID and isActive=1 ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@driverID", driverID);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);



            try
            {
                connection.Open();
               object result= command.ExecuteScalar();

                if(result!=null)
                licenseID = (int)result;

            }

            catch (Exception ex)
            {

                return licenseID;

            }

            finally
            {
                connection.Close();
            }

            return licenseID;

        }
        static public void setExpiredLicensesToInActive()
        {
            bool isUpdated = false;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update Licenses set IsActive=0 where ExpirationDate<SYSDATETIME()";

            SqlCommand command = new SqlCommand(query, connection);

            








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




          
           
        }

    }
}
