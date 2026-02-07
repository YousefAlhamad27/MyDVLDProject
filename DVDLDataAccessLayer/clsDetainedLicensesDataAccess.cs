using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLDataAccessLayer
{
    public class clsDetainedLicensesDataAccess
    {
        public enum eFilterBasis { None = 0, detainID = 1, notReleased = 2, released = 3 , nationalNo=4,fullName=5,releaseAppID=6}
        static public DataTable getDetainedLicenesDataTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "\r\nSELECT DetainedLicenses.DetainID as " +
                "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                "  DetainedLicenses INNER JOIN\r\n              " +
                "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                "    People ON Drivers.PersonID = People.PersonID ";


            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();




            try
            {

                SqlDataReader reader = command.ExecuteReader();


                dataTable.Load(reader);


                
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
        static public DataTable getFilteredTable(string filterData,eFilterBasis filter)
        {
            DataTable dataTable = new DataTable();
            string query = "";
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            if (filter == eFilterBasis.None)
            {
                query = "\r\nSELECT DetainedLicenses.DetainID as " +
                   "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                   "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                   "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                   "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                   "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                   "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                   "  DetainedLicenses INNER JOIN\r\n              " +
                   "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                   "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                   "    People ON Drivers.PersonID = People.PersonID ";
            }
            else if (filter == eFilterBasis.detainID)
            {
                query = "\r\nSELECT DetainedLicenses.DetainID as " +
                   "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                   "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                   "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                   "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                   "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                   "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                   "  DetainedLicenses INNER JOIN\r\n              " +
                   "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                   "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                   "    People ON Drivers.PersonID = People.PersonID" +
                   " where detainedLicenses.DetainID=@filterData;";
            }

            else if (filter == eFilterBasis.released)
            {
                query = "\r\nSELECT DetainedLicenses.DetainID as " +
                   "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                   "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                   "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                   "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                   "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                   "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                   "  DetainedLicenses INNER JOIN\r\n              " +
                   "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                   "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                   "    People ON Drivers.PersonID = People.PersonID" +
                   " where detainedLicenses.isReleased=1 ";
            }
            else if (filter == eFilterBasis.notReleased)
            {
                query = "\r\nSELECT DetainedLicenses.DetainID as " +
                   "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                   "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                   "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                   "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                   "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                   "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                   "  DetainedLicenses INNER JOIN\r\n              " +
                   "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                   "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                   "    People ON Drivers.PersonID = People.PersonID" +
                   " where detainedLicenses.isReleased=0 ";
            }
            else if (filter == eFilterBasis.nationalNo)
            {
                query = "\r\nSELECT DetainedLicenses.DetainID as " +
                   "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                   "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                   "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                   "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                   "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                   "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                   "  DetainedLicenses INNER JOIN\r\n              " +
                   "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                   "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                   "    People ON Drivers.PersonID = People.PersonID" +
                   " where People.NationalNo=@filterData ";

            
            }
            else if (filter == eFilterBasis.fullName)
            {
                query = "\r\nSELECT DetainedLicenses.DetainID as " +
                   "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                   "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                   "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                   "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                   "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                   "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                   "  DetainedLicenses INNER JOIN\r\n              " +
                   "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                   "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                   "    People ON Drivers.PersonID = People.PersonID" +
                   " where (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' '+ People.LastName)= @filterData ";

            }
            else if (filter == eFilterBasis.releaseAppID)
            {
                query = "\r\nSELECT DetainedLicenses.DetainID as " +
                   "'D.ID', Licenses.LicenseID as 'L.ID', DetainedLicenses." +
                   "DetainDate as 'D.Date', \r\nDetainedLicenses.IsReleased as " +
                   "'Is Released', \r\nDetainedLicenses.FineFees as 'Fine Fees', " +
                   "DetainedLicenses.ReleaseDate as 'Release Date', People.NationalNo as " +
                   "'N.No.',(People.FirstName+' '+ People.SecondName+' '+ \r\n             " +
                   "     People.ThirdName+' '+ People.LastName) as 'Full Name' , DetainedLicenses.ReleaseApplicationID as 'Release App.ID'\r\nFROM   " +
                   "  DetainedLicenses INNER JOIN\r\n              " +
                   "    Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN\r\n        " +
                   "          Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN\r\n              " +
                   "    People ON Drivers.PersonID = People.PersonID" +
                   " where DetainedLicenses.ReleaseApplicationID=@filterData ";

            }

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FilterData",filterData);

            connection.Open();




            try
            {

                SqlDataReader reader = command.ExecuteReader();


                dataTable.Load(reader);



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
        static public int detainLicense(int licenseID,decimal fineFees,int createdByUserID)
        {
            int detainID = -1;
            if (clsLicenseDataAccess.deactivateLicense(licenseID))
            {



                SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

                string query = "insert into detainedLicenses (licenseID,detainDate,FineFees,createdByUserID,IsReleased)" +
                    " values(@licenseID,@detainDate,@FineFees,@createdByUserID,0);" +
                    "select SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@licenseID", licenseID);
                command.Parameters.AddWithValue("@detainDate", DateTime.Now);
                command.Parameters.AddWithValue("@FineFees", fineFees);
                command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
              






                try
                {

                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        detainID = insertedID;
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
            return detainID;

        }
        static public bool isLicenseDetained(int licenseID) {

            bool isFound = false;
        
            SqlConnection connection=new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from detainedLicenses where licenseID=@licenseID and isReleased=0";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@licenseID", licenseID);

            

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    isFound = true;
                }
                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool getDetainInfo(int licenseID,ref int detainID,ref DateTime detainDate,ref decimal fineFees,
            ref int createdByUserID,ref bool isReleased,ref DateTime releaseDate, ref int releasedByUserID,ref int releaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from detainedLicenses where licenseID=@licenseID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@licenseID", licenseID);



            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    detainID = (int)reader["DetainID"];
                    if (reader["releaseDate"] == DBNull.Value)
                    {

                        releaseDate = new DateTime();

                        releasedByUserID = -1;

                        releaseApplicationID = -1;
                    }

                    else
                    {
                        releaseDate = (DateTime)reader["releaseDate"];
                     
                        releasedByUserID = (int)reader["releasedByUserID"];
                       
                        releaseApplicationID = (int)reader["releaseApplicationID"];
                    }
                    createdByUserID = (int)reader["createdByUserID"];
                    fineFees = (decimal)reader["fineFees"];
                    detainDate = (DateTime)reader["detainDate"];
                    isReleased = (bool)reader["isReleased"];

                }
                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public bool getDetainInfoByDetainID(int detainID , ref int licenseID, ref DateTime detainDate, ref decimal fineFees,
         ref int createdByUserID, ref bool isReleased, ref DateTime releaseDate, ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from detainedLicenses where detainID=@detainID";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@detainID", detainID);



            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    licenseID = (int)reader["licenseID"];
                    if (reader["releaseDate"] == DBNull.Value)
                    {

                        releaseDate = new DateTime();

                        releasedByUserID = -1;

                        releaseApplicationID = -1;
                    }

                    else
                    {
                        releaseDate = (DateTime)reader["releaseDate"];

                        releasedByUserID = (int)reader["releasedByUserID"];

                        releaseApplicationID = (int)reader["releaseApplicationID"];
                    }
                    createdByUserID = (int)reader["createdByUserID"];
                    fineFees = (decimal)reader["fineFees"];
                    detainDate = (DateTime)reader["detainDate"];
                    isReleased = (bool)reader["isReleased"];

                }
                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public bool releaseLicense(int detainID,int releasedByUserID,int releaseApplicationID)
        {
            bool isUpdated = false;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update detainedLicenses set isReleased=1,ReleaseDate=@releaseDate,ReleasedByUserID=@releasedByUserID" +
                ", releaseApplicationID=@releaseApplicationID where detainID=@detainID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@detainID", detainID);
            command.Parameters.AddWithValue("@releaseApplicationID", releaseApplicationID);
            command.Parameters.AddWithValue("@releaseDate", DateTime.Now);
            command.Parameters.AddWithValue("@releasedByUserID", releasedByUserID);







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

    }
}
