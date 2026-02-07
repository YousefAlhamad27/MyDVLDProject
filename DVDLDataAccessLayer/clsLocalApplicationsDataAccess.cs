using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DVDLDataAccessLayer.clsLocalApplicationsDataAccess;
using static System.Net.Mime.MediaTypeNames;

namespace DVDLDataAccessLayer
{
    public class clsLocalApplicationsDataAccess
    {
        public enum eApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enum eFilterBasis {None=0,LocalApplicationLicenseID=1, NationalNo=2 ,fullName=3, Status=4}
    
        
        static public DataTable getAllApplicationsTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT  distinct LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D App ID'," +
                "\r\nLicenseClasses.ClassName as 'Driving Class', People.NationalNo as 'National No.'," +
                " (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' ' +People.LastName) as" +
                " 'Full Name',\r\n Applications.ApplicationDate as 'Application Date', \r\n " +
                "  (SELECT COUNT(*)\r\n     FROM Tests \r\n     INNER JOIN TestAppointments " +
                "ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\n   " +
                "  WHERE" +
                " TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n" +
                "     and Tests.TestResult=1\r\n        ) " +
                "as 'Passed Tests'" +
                "  , \r\ncase when Applications.ApplicationStatus=2 then 'Cancelled'\r\n" +
                "when Applications.ApplicationStatus=3 then 'Completed'\r\nwhen Applications.ApplicationStatus=1 " +
                "then 'New'\r\nend as 'Status'\r\nFROM     Applications INNER JOIN\r\n               " +
                "   People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n       " +
                "           LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n " +
                "                 LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID CROSS JOIN\r\n" +
                "                  Tests";

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

        static public DataTable getFilteredData(string filterData,eFilterBasis filter)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "";
            string upperCase = "";
            string lowerCase = "";

            if (filter == eFilterBasis.None)
            {
                 query = "SELECT  distinct LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D App ID'," +
                    "\r\nLicenseClasses.ClassName as 'Driving Class', People.NationalNo as 'National No.'," +
                    " (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' ' +People.LastName) as" +
                    " 'Full Name',\r\n Applications.ApplicationDate as 'Application Date', \r\n " +
                    "  (SELECT COUNT(*)\r\n     FROM Tests \r\n     INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\n     WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n     and Tests.TestResult=1\r\n        ) as 'Passed Tests'" +
                    "  , \r\ncase when Applications.ApplicationStatus=2 then 'Cancelled'\r\n" +
                    "when Applications.ApplicationStatus=3 then 'Completed'\r\nwhen Applications.ApplicationStatus=1 " +
                    "then 'New'\r\nend as 'Status'\r\nFROM     Applications INNER JOIN\r\n               " +
                    "   People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n       " +
                    "           LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n " +
                    "                 LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID CROSS JOIN\r\n" +
                    "                  Tests";
            }
            else if (filter==eFilterBasis.LocalApplicationLicenseID)
            {
                query = "SELECT  distinct LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D App ID'," +
                    "\r\nLicenseClasses.ClassName as 'Driving Class', People.NationalNo as 'National No.'," +
                    " (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' ' +People.LastName) as" +
                    " 'Full Name',\r\n Applications.ApplicationDate as 'Application Date', \r\n " +
                    "  (SELECT COUNT(*)\r\n     FROM Tests \r\n     INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\n     WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n     and Tests.TestResult=1\r\n        ) as 'Passed Tests'" +
                    "  , \r\ncase when Applications.ApplicationStatus=2 then 'Cancelled'\r\n" +
                    "when Applications.ApplicationStatus=3 then 'Completed'\r\nwhen Applications.ApplicationStatus=1 " +
                    "then 'New'\r\nend as 'Status'\r\nFROM     Applications INNER JOIN\r\n               " +
                    "   People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n       " +
                    "           LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n " +
                    "                 LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID CROSS JOIN\r\n" +
                    "                  Tests " +
                    "where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@filterData ";
            }

            else if (filter == eFilterBasis.NationalNo)
            {
                upperCase = filterData.ToUpper();
                lowerCase = filterData.ToLower();
                query =   "SELECT  distinct LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D App ID'," +
                    "\r\nLicenseClasses.ClassName as 'Driving Class', People.NationalNo as 'National No.'," +
                    " (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' ' +People.LastName) as" +
                    " 'Full Name',\r\n Applications.ApplicationDate as 'Application Date', \r\n " +
                    "  (SELECT COUNT(*)\r\n     FROM Tests \r\n     INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\n     WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n     and Tests.TestResult=1\r\n        ) as 'Passed Tests'" +
                    "  , \r\ncase when Applications.ApplicationStatus=2 then 'Cancelled'\r\n" +
                    "when Applications.ApplicationStatus=3 then 'Completed'\r\nwhen Applications.ApplicationStatus=1 " +
                    "then 'New'\r\nend as 'Status'\r\nFROM     Applications INNER JOIN\r\n               " +
                    "   People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n       " +
                    "           LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n " +
                    "                 LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID CROSS JOIN\r\n" +
                    "                  Tests " +
                    "where people.nationalNo=@upperCase or   people.nationalNo=@lowerCase";
            }
            else if (filter == eFilterBasis.fullName)
            {
                query = "SELECT  distinct LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D App ID'," +
                   "\r\nLicenseClasses.ClassName as 'Driving Class', People.NationalNo as 'National No.'," +
                   " (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' ' +People.LastName) as" +
                   " 'Full Name',\r\n Applications.ApplicationDate as 'Application Date', \r\n " +
                   "  (SELECT COUNT(*)\r\n     FROM Tests \r\n     INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\n     WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n     and Tests.TestResult=1\r\n        ) as 'Passed Tests'" +
                   "  , \r\ncase when Applications.ApplicationStatus=2 then 'Cancelled'\r\n" +
                   "when Applications.ApplicationStatus=3 then 'Completed'\r\nwhen Applications.ApplicationStatus=1 " +
                   "then 'New'\r\nend as 'Status'\r\nFROM     Applications INNER JOIN\r\n               " +
                   "   People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n       " +
                   "           LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n " +
                   "                 LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID CROSS JOIN\r\n" +
                   "                  Tests " +
                   "where (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' ' +People.LastName)=@filterData";
            }
            else if (filter == eFilterBasis.Status)
            {
                query = "SELECT  distinct LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D App ID'," +
                    "\r\nLicenseClasses.ClassName as 'Driving Class', People.NationalNo as 'National No.'," +
                    " (People.FirstName+' '+ People.SecondName+' '+People.ThirdName+' ' +People.LastName) as" +
                    " 'Full Name',\r\n Applications.ApplicationDate as 'Application Date', \r\n " +
                    "  (SELECT COUNT(*)\r\n     FROM Tests \r\n     INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\n     WHERE TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n     and Tests.TestResult=1\r\n        ) as 'Passed Tests'" +
                    "  , \r\ncase when Applications.ApplicationStatus=2 then 'Cancelled'\r\n" +
                    "when Applications.ApplicationStatus=3 then 'Completed'\r\nwhen Applications.ApplicationStatus=1 " +
                    "then 'New'\r\nend as 'Status'\r\nFROM     Applications INNER JOIN\r\n               " +
                    "   People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n       " +
                    "           LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n " +
                    "                 LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID CROSS JOIN\r\n" +
                    "                  Tests " +
                    "where Applications.ApplicationStatus=@filterData";
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

        static public bool getApplicationByID(int applicationID,ref  int personID, ref DateTime applicationDate,
          ref int applicationTypeID, ref byte applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Applications.*\r\nFROM     Applications INNER JOIN\r\n      " +
                "            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID\r\n    " +
                "              where LocalDrivingLicenseApplications.ApplicationID=@applicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationID", applicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["ApplicantPersonID"];
                    applicationDate = (DateTime)reader["applicationDate"];
                    applicationTypeID = (int)reader["applicationTypeID"];
                    applicationStatus = (byte)reader["applicationStatus"];
                    lastStatusDate = (DateTime)reader["lastStatusDate"];
                    paidFees = (decimal)reader["paidFees"];
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

        static public bool getApplicationByPersonID(int personID , ref int applicationID, ref DateTime applicationDate,
      ref int applicationTypeID, ref int applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from People where personID=@personID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    applicationID = (int)reader["applicationID"];
                    applicationDate = (DateTime)reader["applicationDate"];
                    applicationTypeID = (int)reader["applicationTypeID"];
                    applicationStatus = (int)reader["applicationStatus"];
                    lastStatusDate = (DateTime)reader["lastStatusDate"];
                    paidFees = (decimal)reader["paidFees"];
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

        static public int addNewApplication(  int personID,  DateTime applicationDate,
           int applicationTypeID,  int applicationStatus,  DateTime lastStatusDate, decimal paidFees,  int createdByUserID,int licenseClassID,bool localApplication=true)
        {
            



            int applicationID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into Applications (ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)" +
                " values(@personID,@applicationDate,@applicationTypeID,@applicationStatus,@lastStatusDate,@paidFees,@createdByUserID);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
        
            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    applicationID = insertedID;
                    if(localApplication)
                    addApplicationToLocalApplications(applicationID, licenseClassID);
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

            return applicationID;

        }

        static public int addApplicationToLocalApplications(int applicationID, int licenseClassID)
        {




            int localAppID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into LocalDrivingLicenseApplications (ApplicationID,LicenseClassID)" +
                " values(@applicationID,@licenseClassID); " +
                "select SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationID", applicationID);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
       

            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    localAppID = insertedID;
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

            return localAppID;

        }

        static public int getApplicationLicenseClassID(int localAppID)
        {
            int licenseID=-1 ;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT LicenseClasses.LicenseClassID\r\nFROM     Applications INNER JOIN\r\n   " +
                "               LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n   " +
                "               LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\nWHERE " 
                 +
                " LocalDrivingLicenseApplicationID = @localAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localAppID", localAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    licenseID = (int)reader["LicenseClassID"];
                    




                }

                reader.Close();
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
        static public int getLocalAppIDLicenseClassID(int ApplicationID)
        {
            int locAppID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID \r\nFROM     Applications INNER JOIN\r\n   " +
                "               LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN\r\n   " +
                "               LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\nWHERE "
                 +
                " Applications.ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    locAppID = (int)reader["LocalDrivingLicenseApplicationID"];





                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return locAppID;

            }

            finally
            {
                connection.Close();
            }

            return locAppID;


        }
        static public int getApplicationIDByLocAppID(int localAppID)
        {
            int applicationID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@localAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localAppID", localAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    applicationID = (int)reader["ApplicationID"];





                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return applicationID;

            }

            finally
            {
                connection.Close();
            }

            return applicationID;
        }

        static public bool updateApplicationByLocAppID(int localAppID, int licenseClassID)
        {
            bool isUpdated = false;
          

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update LocalDrivingLicenseApplications set licenseClassID=@licenseClassID where LocalDrivingLicenseApplicationID=@localAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@localAppID", localAppID);
           
            





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

        static public bool doesApplicantHaveAnAppOfSameLicenseClassIDNationalNumber(string nationalNumber,int licenseClassID, ref int applicationID)
        {
            

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Applications.ApplicationID " +" \r\nFROM     Applications INNER JOIN\r\n    " +
                "              People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n    " +
                "              LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID " +
                          "INNER JOIN\r\n" +
                "                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\n   " +
                "               where People.NationalNo=@nationalNumber" +
                "               and LicenseClasses.licenseClassID=@licenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationalNumber", nationalNumber);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    applicationID = (int)reader["applicationID"];
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

        static public bool doesApplicantHaveSameStatusForSameLicenseClassApplication(string nationalNumber,int licenseClassID, ref int applicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Applications.ApplicationID " + " \r\nFROM     Applications INNER JOIN\r\n    " +
                "              People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN\r\n    " +
                "              LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID " +
                          "INNER JOIN\r\n" +
                "                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\n   " +
                "               where People.NationalNo=@nationalNumber" +
                "               and LicenseClasses.licenseClassID=@licenseClassID" +
                "               and (Applications.ApplicationStatus=1 or Applications.ApplicationStatus=3)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationalNumber", nationalNumber);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
           
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    applicationID = (int)reader["applicationID"];
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

        static public int getApplicationStatusAppID(int applicationID)
        {
            int applicationStatus = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT  Applications.ApplicationStatus\r\nFROM  " +
                "   Applications INNER JOIN\r\n         " +
                "         LocalDrivingLicenseApplications ON Applications.ApplicationID \r\n " +
                "                 = LocalDrivingLicenseApplications.ApplicationID\r\n       " +
                "           where Applications.applicationID=@applicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationID", applicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    applicationStatus = (byte)reader["applicationStatus"];





                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return applicationStatus;

            }

            finally
            {
                connection.Close();
            }

            return applicationStatus;
        }
        static public int getApplicationStatusLocalAppID(int locAppID)
        {
            int applicationStatus = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT  Applications.ApplicationStatus\r\nFROM  " +
                "   Applications INNER JOIN\r\n         " +
                "         LocalDrivingLicenseApplications ON Applications.ApplicationID \r\n " +
                "                 = LocalDrivingLicenseApplications.ApplicationID\r\n       " +
                "           where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@locAppID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@locAppID", locAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    applicationStatus = (byte)reader["applicationStatus"];





                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return applicationStatus;

            }

            finally
            {
                connection.Close();
            }

            return applicationStatus;
        }

     
        static private int[] getTestAppointmentsIDArray(int locAppID, ref int count)
        {
            int[] array=new int[1];
            

            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT testAppointmentID from testAppointments where localDrivingLicenseApplicationID=@locAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@locAppID",locAppID);

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

            if(dataTable.Rows.Count > 0)
            {
                array = new int[dataTable.Rows.Count];
                 count = dataTable.Rows.Count;
                int counter = 0;
                foreach(DataRow row in dataTable.Rows)
                {
                    array[counter] = (int)row["testAppointmentID"];
                    counter++;
                }
            }
            return array;
        }

        static private bool deleteFromTestTable(int testAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "Delete from Tests where testAppointmentID=@testAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testAppointmentID",testAppointmentID);
          

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
        static private bool deleteTestAppointments(int locAppID)
        {
            int count = 0;
            int[] array = getTestAppointmentsIDArray(locAppID,ref count);
            bool isDeleted = false;

         for(int i = 0; i < count; i++)
            {
                if (!deleteFromTestTable(array[i]))
                    return isDeleted;
                if (i == count)
                    isDeleted = true;
            }
            return isDeleted;
        }

            
        static public bool deleteLocalApplicationByAppID(int appID)
        {
            int locAppID = getLocalAppIDLicenseClassID(appID);
            deleteTestAppointments(locAppID);
            
            

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "Delete from TestAppointments where localDrivingLicenseApplicationID=@locAppID;" +
                "Delete  from localDrivingLicenseApplications where ApplicationID=@appID;" +
                "delete from localDrivingLicenseApplications where applicationID=@appID;" +
                " delete from applications where applicationID=@appID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@appID", appID);
            command.Parameters.AddWithValue("@locAppID", locAppID);

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
        static public bool updateApplicationStatus(int locAppID,eApplicationStatus status)
        {
            bool isUpdated = false;

            string query = "";

            int applicationID=getApplicationIDByLocAppID(locAppID);

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            if (status == eApplicationStatus.Cancelled)
            {
                 query = "update Applications set ApplicationStatus=2 where ApplicationID=@applicationID";

            }

            else if (status == eApplicationStatus.Completed)
            {
                query = "update Applications set ApplicationStatus=3 where ApplicationID=@applicationID";
            }

                SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationID", applicationID);
          
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
        static public int getPassedTestsAppID(int locAppID)
        {
            int passedTests = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT  COUNT(*) as PassedTests  \r\nFROM  " +
                "   TestAppointments INNER JOIN\r\n        " +
                "          LocalDrivingLicenseApplications ON " +
                "TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID " +
                "INNER JOIN\r\n            " +
                "      Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID INNER JOIN\r\n   " +
                "               LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID\r\n " +
                "      \r\n         group by LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, " +
                "LicenseClasses.ClassName,Tests.TestResult\r\n      " +
                "   having    Tests.TestResult=1 and" +
                " LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@locAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@locAppID", locAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    passedTests = (int)reader["PassedTests"];





                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return passedTests;

            }

            finally
            {
                connection.Close();
            }

            return passedTests;
        }
        static public string getLicenseClassNameByLocID(int locAppID)
        {
            string className = "none";
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT LicenseClasses.ClassName\r\nFROM  " +
                "   LicenseClasses INNER JOIN\r\n          " +
                "        LocalDrivingLicenseApplications ON LicenseClasses.LicenseClassID =" +
                " LocalDrivingLicenseApplications.LicenseClassID " +
                "where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@locAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@locAppID", locAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    className = (string)reader["ClassName"];





                }

                reader.Close();
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


    }
}
