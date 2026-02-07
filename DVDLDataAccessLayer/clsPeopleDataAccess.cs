using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVDLDataAccessLayer
{
    public class clsPeopleDataAccess
    {
        public enum EFilterBasis {none=0,personID=1, nationalNumber=2,firstName=3,secondName=4,thirdName=5,lastName=6
        ,nationality,gender,Phone,Email};

     
     static   private string getGenderBit(string gender) {
           
            if(gender=="Male")
                gender = "0";


            else
                gender = "1";

            return gender;


        }
   static     private string getGenderName(string bit) {

            if (bit == "0")
                bit = "Male";


            else
                bit = "Female";

            return bit;

        }
        static public bool getPersonInfoByID(int personID, ref string  firstName, ref string secondName, ref string thirdName, ref string lastName, ref string nationalNumber, ref string Address,
            ref DateTime birthDate,ref string gender
            , ref string phone, ref string email, ref int countryID, ref string imagepath)
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

                    nationalNumber = (string)reader["NationalNo"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["secondName"];
                    thirdName = (string)reader["thirdName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    birthDate = (DateTime)reader["dateOfBirth"];
                    countryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["Imagepath"];
                    }
                    else
                    {
                        imagepath = null;
                    }
                   
                   
                       gender = getGenderName(reader["Gender"].ToString());
                  
                  

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
       
      static   public DataTable getAllPeople()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
          
            string query = "SELECT " +
                "    PersonID AS 'Person ID'," +"   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                " People ON Countries.CountryID = People.NationalityCountryID    ";

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
        static public bool doesPersonExistID(int personID)
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
        static public bool doesPersonExistNational(string nationalNumber)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from People where NationalNo=@nationalNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationalNumber", nationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
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
        static     public DataTable filteredData(string filterData ,EFilterBasis filterType) 
        {
            if (filterType == EFilterBasis.gender)
            {
                filterData = getGenderBit(filterData);
                Convert.ToInt32(filterData);
            }
        
            DataTable dataTable = new DataTable();
            string query = "";
            

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);


            string upperCase = "";
            string lowerCase = "";


            if (filterType == EFilterBasis.none)
                return getAllPeople();

            else if (filterType == EFilterBasis.personID)
            {
               
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where personID=@filterData ";

                

            }
            else if(filterType == EFilterBasis.nationalNumber)
            {
               upperCase= filterData.ToUpper();
               lowerCase=filterData.ToLower();
                query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where nationalNo=@lowerCase or nationalNo=@upperCase ";

            }
            else if (filterType == EFilterBasis.firstName)
            {
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where firstName=@filterData ";
            }
            else if (filterType == EFilterBasis.secondName)
            {
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where secondName=@filterData ";
            }
            else if (filterType == EFilterBasis.thirdName)
            {
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where thirdName=@filterData ";
            }
            else if (filterType == EFilterBasis.lastName)
            {
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where lastName=@filterData ";

            }
            else if (filterType == EFilterBasis.Email)
            {
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where email=@filterData ";
            }
            else if (filterType == EFilterBasis.Phone)
            {
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where phone=@filterData ";
            }
            else  
            {
                 query = "SELECT " +
                    "    PersonID AS 'Person ID'," + "   NationalNo AS 'National No.',    FirstName AS 'First Name',    SecondName AS 'Second Name',   ThirdName AS 'Third Name', " +
                    "  LastName AS 'Last Name',case when People.Gender=0 then 'Male' else 'Female' end AS Gender,    DateOfBirth AS 'Date Of Birth', Countries.CountryName As 'Nationality', Phone,    Email FROM     Countries INNER JOIN  " +
                    " People ON Countries.CountryID = People.NationalityCountryID where gender=@filterData ";

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
        
        static public int addNewPerson(string firstName,string secondName,string thirdName,string lastName,
            string nationalNumber,string address, DateTime birthDate, string gender,string phone
            ,string email,int countryID,string imagepath)
        {
            if (gender == "Male")
            {
                gender = "0";
                
            }
            else
            {
                gender = "1";
            }

            Convert.ToInt32(gender);
            


            int personID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "insert into people (NationalNo,FirstName,SecondName,ThirdName,LastName,Gender,DateOfBirth,Address," +
                "Phone,Email,NationalityCountryID,ImagePath) " +
                "values(@nationalNumber,@firstname,@secondname,@thirdname,@lastname,@gender,@DateOfBirth,@Address,@phone,@email,@countryID,@imagepath);" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@nationalNumber", nationalNumber);
            command.Parameters.AddWithValue("@CountryID", countryID);
            command.Parameters.AddWithValue("@DateOfBirth", birthDate);
            command.Parameters.AddWithValue("@gender", gender);




            if (imagepath != "")
            {
                command.Parameters.AddWithValue("@ImagePAth", imagepath);
            }
            else command.Parameters.AddWithValue("@ImagePAth", System.DBNull.Value);



            try
            {

                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    personID = insertedID;
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

            return personID;

        }
        static public bool getPersonInfoByNationalNumber(string nationalNumber,ref int personID, ref string  firstName, ref string secondName, ref string thirdName, ref string lastName, ref string address,
            ref DateTime birthDate, ref string gender
            , ref string phone, ref string  email, ref int countryID, ref string imagepath){
           bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select * from People where NationalNo=@nationalNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationalNumber", nationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["personID"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["secondName"];
                    thirdName = (string)reader["thirdName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    address = (string)reader["Address"];
                    birthDate = (DateTime)reader["dateOfBirth"];
                    countryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["Imagepath"];
                    }
                    else
                    {
                        imagepath = null;
                    }
                   
                   
                       gender = getGenderName(reader["Gender"].ToString());
                  
                  

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
        static public int getPersonIDByNationalNumber(string nationalNumber)
            
            
        {
           
            int personID = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select personID from People where NationalNo=@nationalNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationalNumber", nationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    

                    personID = (int)reader["personID"];
                    



                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return personID;

            }

            finally
            {
                connection.Close();
            }

            return personID;

        }
        static public bool updatePersonByID(int personID,  string firstName,  string secondName,  string  thirdName,  string  lastName,
          string  nationalNumber, string address,  DateTime birthDate,  string gender,  string phone
            ,  string email,  int countryID,  string imagepath)
        {
            bool isUpdated = false;
            gender = getGenderBit(gender);

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Update people set nationalno=@nationalNumber,firstname=@firstName,secondName=@secondName,thirdName=@thirdName" +
                ",lastname=@lastname,Email=@email,phone=@phone, address=@Address,gender=@gender," +
                "dateOfBirth=@birthDate,nationalityCountryID=@countryID,imagePath=@imagepath where personID=@personID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@nationalNumber", nationalNumber);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@CountryID", countryID);
            command.Parameters.AddWithValue("@birthDate", birthDate);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@gender",gender);
            if (imagepath != "")
            {
                command.Parameters.AddWithValue("@Imagepath", imagepath);
            }
            else command.Parameters.AddWithValue("@Imagepath",DBNull.Value);




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
        static public bool deletePersonByID(int personID) {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "delete from people where personID=@personID;";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@personID", personID);
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
        static public string getPersonFullName(int personID)
        {
            string fullName = "";

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "Select firstname,secondname,thirdname,lastname from People where personID=@personID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {


                    fullName += " "+(string)reader["firstname"]+ " " + (string)reader["secondname"]+ " " + (string)reader["thirdname"]+ " " + (string)reader["lastname"];




                }

                reader.Close();
            }

            catch (Exception ex)
            {

                return fullName;

            }

            finally
            {
                connection.Close();
            }

            return fullName;
        }


    }
}
