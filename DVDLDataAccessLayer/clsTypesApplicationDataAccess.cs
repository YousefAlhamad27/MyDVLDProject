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

namespace DVDLDataAccessLayer
{
    public class clsTypesApplicationDataAccess
    {

         
        static public DataTable getApplicationTypesTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select * from ApplicationTypes";

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
        static public bool getApplicationTypeByID(int appID,ref string title,ref decimal appFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from ApplicationTypes where ApplicationTypeID=@appID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    title = (string)reader["ApplicationTypeTitle"];
                    appFees = (decimal)reader["ApplicationFees"];
             
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
        static public bool getApplicationTypeFeesByID(int appID  , ref decimal appFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select ApplicationFees from ApplicationTypes where ApplicationTypeID=@appID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    
                    appFees = (decimal)reader["ApplicationFees"];

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
        static public bool editApplicationTypeById(int appID, string title,decimal appFees)
        {

            bool isUpdated = false;
        

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Update ApplicationTypes set ApplicationTypeTitle=@title,ApplicationFees=@appFees where ApplicationID=@appID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@ApplicationFees", appFees);

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
        static public string getApplicationTypeNameByID(int appID)
        {
            string title="None";
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT  ApplicationTypes.ApplicationTypeTitle\r\nFROM   " +
                "  Applications INNER JOIN\r\n     " +
                "             ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID\r\n     " +
                "             where ApplicationID=@appID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   

                    title = (string)reader["ApplicationTypeTitle"];
                    

                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return title;

            }

            finally
            {
                connection.Close();
            }

            return title;
        }

    }
}
