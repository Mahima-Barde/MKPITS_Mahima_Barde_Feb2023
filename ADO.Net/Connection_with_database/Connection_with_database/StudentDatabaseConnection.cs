using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Connection_with_database
{
    public static class StudentDatabaseConnection
    {
        //create variable to make connection with database
        private static string connectionstring = "server=.\\sqlexpress;integrated security=true;database=Students";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //creating a static method to insert record into user table
        public static string Insertvalue(int rollno, string name, string subject, int marks)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into stud1 values(@roll_no,@name,@subject,@Marks)";

            //@roll and all are Sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@roll_no", rollno);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("subject", subject);
                command.Parameters.AddWithValue("@Marks", marks);

                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted succesfully";

            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        //creating a method to update a row
        public static string updatevalues(int rollno, string name, string subject, int marks)
        {
            string query = "update stud1 set name=@name,subject=@subject,Marks=@Marks where roll_no=@roll_no";

            SqlConnection con=GetConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
               
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@Marks", marks);
                cmd.Parameters.AddWithValue("@roll_no", rollno);
                cmd.ExecuteNonQuery();
                return "record Updated succesfully";
            }
            catch(Exception ee) 
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        //creating a method to delete a row
        public static string deletevalue(int rollno)
        { 
            string query = "delete stud1 where roll_no=@roll_no";

            SqlConnection con = GetConnection();

            try 
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll_no", rollno);
                cmd.ExecuteNonQuery();
                return "Row is deleted";

            
            }
            catch(Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        //creating a method to search a row values
          public static DataSet SearchValues(int rollno) 
          {
            SqlConnection con=GetConnection();
            string query = "select * from stud1 where roll_no=@roll_no";
           
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
               
                da.SelectCommand.Parameters.AddWithValue("@roll_no", rollno);
                da.Fill(ds, "stud1");
                return ds;
            
                   
          }
    }
}

