using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLDataAccessLayer
{
    public class clsCountriesDataAccess
    {
       
      static  public bool findCountrybyID(int countryID,ref string countryName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select CountryName from Countries where countryID=@countryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@countryID", countryID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    countryName = (string)reader["countryname"];
                   

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
        static public bool getCountryIDByName(string countryName, ref string countryID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select countryID from Countries where countryName=@countryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@countryName", countryName);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    countryID = (string)reader["countryID"];


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
        static public DataTable allCountriesDataTable()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "Select CountryName from countries";
                

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

    }
}
