using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVDLDataAccessLayer
{
    public class clsTestsDataAccess
    {


        static public int takeTest(  int testID,int testAppointmentID,bool Result,string notes,int createdByUserID)
        {
           

            
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into tests (testAppointmentID,TestResult,Notes,CreatedByUserID) " +
                "values(@testAppointmentID,@Result,@notes,@createdByUserID);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@Result", Result);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
       



            if (notes != "")
            {
                command.Parameters.AddWithValue("@notes", notes);
            }
            else command.Parameters.AddWithValue("@notes", System.DBNull.Value);



            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    testID = insertedID;
                    clsAppointmentsDataAccess.lockAppointment(testAppointmentID);
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

            return testID;


        }


    }
}
