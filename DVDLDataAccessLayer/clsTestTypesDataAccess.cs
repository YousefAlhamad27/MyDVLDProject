using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLDataAccessLayer
{
    public class clsTestTypesDataAccess
    {
        static public int getTrialCountByLocAppID(int locAppID,int testTypeID)
        {
            int count =-1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT COUNT(*)\r\nFROM     " +
                "TestAppointments\r\nwhere TestTypeID=@testTypeID and" +
                " LocalDrivingLicenseApplicationID=@locAppID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@locAppID", locAppID);
            command.Parameters.AddWithValue("@testTypeID", testTypeID);

            try
            {
                connection.Open();
               
               

                     count = (int)command.ExecuteScalar();
                   





                

               
            }

            catch (Exception ex)
            {

                return count;

            }

            finally
            {
                connection.Close();
            }

            return count;



        }
        static public decimal getTestTypeFeesByTestTypeID(int testTypeID)
        {
            decimal Fees =0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select TestTypeFees from TestTypes where TestTypeID=@testTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testTypeID", testTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    Fees = (decimal)reader["TestTypeFees"];





                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return Fees;

            }

            finally
            {
                connection.Close();
            }

            return Fees;



        }

        static public bool getTestType(int testTypeID, ref string title, ref string description, ref decimal fees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select * from TestTypes where TestTypeID=@testTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testTypeID", testTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    isFound = true;

                    fees    = (decimal)reader["TestTypeFees"];
                    title= (string)reader["testTypeTitle"];
                    description= (string)reader["testTypeDescription"];



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
        static public DataTable getTestsTypesDataTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "select  testTypeID as ID, TestTypeTitle as Title,TestTypeDescription as" +
                " Description, TestTypeFees as Fees from TestTypes";


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
        static public bool updateTestType(int ID,string title,string description,decimal fees) {

            bool isUpdated = false;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update testTypes set testTypeTitle=@title,testTypeDescription=@description,testTypeFees=@Fees" +
                " where testTypeID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@description", description);
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
