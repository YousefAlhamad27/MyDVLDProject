using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLDataAccessLayer
{
    public class clsApplicationsDataAccess
    {

        static public DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "select  ApplicationTypeID as ID, ApplicationTypeTitle as Title, ApplicationFees as Fees from ApplicationTypes";


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
        static public string getApplicationTypeNameByAppID(int appID)
        {
            string typeName ="None";
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT  ApplicationTypes.ApplicationTypeTitle \r\nFROM  " +
                "   Applications INNER JOIN\r\n          " +
                "        ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID" +
                " where Applications.ApplicationID=@appID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    typeName = (string)reader["ApplicationTypeTitle"];


                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return typeName;

            }

            finally
            {
                connection.Close();
            }

            return typeName;

        }

        static public bool getApplicationByID(int applicationID, ref int personID, ref DateTime applicationDate,
          ref int applicationTypeID, ref byte applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select * from Applications where ApplicationID=@applicationID";

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

        static public bool getApplicationType(int applicationTypeID, ref string title, ref decimal fees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select * from applicationTypes where applicationTypeID=@applicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@applicationTypeID", applicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    isFound = true;

                    fees = (decimal)reader["ApplicationFees"];
                    title = (string)reader["ApplicationTypeTitle"];
              



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
        static public bool updateApplicationType(int ID, string title, decimal fees)
        {

            bool isUpdated = false;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update applicationTypes set applicationTypeTitle=@title,applicationFees=@Fees" +
                " where applicationTypeID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@fees", fees);







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
