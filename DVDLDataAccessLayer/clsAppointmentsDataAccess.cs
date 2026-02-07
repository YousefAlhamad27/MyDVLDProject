using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVDLDataAccessLayer
{
    public class clsAppointmentsDataAccess
    {
       
        static public DataTable getAppointmentsTable(int locAppID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = " SELECT TestAppointments.TestAppointmentID AS 'Appointment ID'," +
                " TestAppointments.AppointmentDate AS 'Appointment Date'," +
                " TestAppointments.PaidFees AS 'Paid Fees', TestAppointments.IsLocked AS 'Is Locked'\r\nFROM TestAppointments INNER JOIN\r\n\r\n  " +
                "               LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID " +
                "= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n\r\n     " +
                "            where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID= @locAppID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocAppID",locAppID);

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

        static public bool getTakeTestInfo(int testAppointmentID,int testTypeID, ref int locAppID, ref string drivingClassName,
            ref string applicantFullName, ref int trialCount, ref DateTime date, ref decimal Fees)
        {
            bool isEligible = true;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query = "SELECT   LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,\r\nLicenseClasses.ClassName, " +
                "(People.FirstName+' '+ People.SecondName+' '+ People.ThirdName+' '+ People.LastName) as 'Full Name',\r\n          " +
                "            (SELECT COUNT(*) AS Expr1\r\n                       FROM      TestAppointments\r\n              " +
                "         WHERE   (TestTypeID = @testTypeID) AND (LocalDrivingLicenseApplicationID = 30)) AS 'Trial Count', TestAppointments_1.AppointmentDate, TestAppointments_1.PaidFees\r\nFROM  " +
                "   TestAppointments AS TestAppointments_1 INNER JOIN\r\n             " +
                "     LocalDrivingLicenseApplications ON TestAppointments_1.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN\r\n       " +
                "           LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN\r\n               " +
                "   Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN\r\n                " +
                "  People ON Applications.ApplicantPersonID = People.PersonID\r\nWHERE  (TestAppointments_1.TestAppointmentID = @testAppointmentID);";
            

            

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testTypeID", testTypeID);
            command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    locAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                    drivingClassName = (string)reader["ClassName"];
                    applicantFullName = (string)reader["Full Name"];
                    trialCount = (int)reader["Trial count"];
                    date = (DateTime)reader["AppointmentDate"];
                    Fees = (decimal)reader["PaidFees"];


                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isEligible = true;

            }

            finally
            {
                connection.Close();
            }

            return isEligible;


        }
        static public int addAppointment(int testTypeID,int locAppID,DateTime appointmentDate,decimal paidFees,int userID,bool isLocked)
        {
            int testAppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into testAppointments (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked)" +
                " values (@testTypeID,@locAppID,@appointmentDate,@paidFees,@userID,@isLocked);" +
                " select SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testTypeID", testTypeID);
            command.Parameters.AddWithValue("@locAppID", locAppID);
            command.Parameters.AddWithValue("@appointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@isLocked", isLocked);




            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    testAppointmentID = insertedID;
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

            return testAppointmentID;
        }
        static public bool doesApplicantHaveAnOpenAppointment(int locAppID)
        {
            bool isEligible = true;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from testAppointments where LocalDrivingLicenseApplicationID=@locAppID and isLocked=0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@locAppID", locAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isEligible = false;
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                isEligible = true;

            }

            finally
            {
                connection.Close();
            }

            return isEligible;
        }
        static public bool lockAppointment(int appointmentID) {

            bool isUpdated = false;
            

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Update testAppointments set IsLocked=1 where testAppointmentID=@appointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appointmentID", appointmentID);
          
          




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
        static public int testTypeAppointmentsCount(int locAppID,int testTypeID)
        {
            int count = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string query = "SELECT COUNT(*) as count  \r\nFROM     Tests INNER JOIN\r\n      " +
                "            TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN\r\n     " +
                "             LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID =\r\n    " +
                "              LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n              " +
                "    where TestTypeID=@testTypeID and LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@locAppID";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testTypeID", testTypeID);
            command.Parameters.AddWithValue("@locAppID", locAppID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = (int)reader["count"];
                   


                }

                reader.Close();
            }

            catch (Exception ex)
            {

                count = -1;

            }

            finally
            {
                connection.Close();
            }

            return count;
        }
        static public int getLocalAppID(int testAppointmentID)
        {
            int locAppID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT TestAppointments.TestAppointmentID," +
                " LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\nFROM  " +
                "   TestAppointments INNER JOIN\r\n              " +
                "    LocalDrivingLicenseApplications ON \r\n            " +
                "      TestAppointments.LocalDrivingLicenseApplicationID =\r\n         " +
                "         LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID\r\n    " +
                "              where TestAppointmentID=@testAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                     
                }

                reader.Close();
            }

            catch (Exception ex)
            {

                

            }

            finally
            {
                connection.Close();
            }

            return locAppID;

        }
        static public bool updateAppointment(int testAppointmentID, DateTime appointmentDate)
        {
            bool isUpdated = false;

            SqlConnection connection=new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update testAppointments set appointmentDate=@appointmentDate " +
                "where testappointmentID=@testAppointmentID";

            SqlCommand command=new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@appointmentDate", appointmentDate);

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
