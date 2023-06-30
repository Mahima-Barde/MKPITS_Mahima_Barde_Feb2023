using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Employee_Details
{
    public static class EmployeeConnection
    {
        private static string Connection = "server=.\\sqlexpress;integrated security=true;database=Civica";

        public static SqlConnection GetConnection()
        { 
          SqlConnection con= new SqlConnection(Connection);

            try 
            { 
                con.Open();
                return con;
            } 
            catch(SqlException ee)
            {
                return null;
            }
        }

        public static String InsertValue(int Empno,string Empname,string Gender,string Email,long Mobileno,int cityid,DateTime DOB )
        {
            string query = "insert into employee_civica values(@Empno,@Empname,@Gender,@Email,@Mobileno,@cityid,@DOB)";
            SqlConnection con = GetConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Empno", Empno);
                cmd.Parameters.AddWithValue("@Empname", Empname);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Mobileno", Mobileno);
                cmd.Parameters.AddWithValue("@cityid", cityid);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.ExecuteNonQuery();
                return "values are inserted successfully";
            }
            catch (SqlException ee)
            {
                return ee.ToString();
            }
            finally
            { 
                con.Close();
            }    

        }

        public static DataSet GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select name,cityid from CityDetails";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "CityDetails");
            return ds;
        }

        public static string updatevalue(int Empno, string Empname, string Gender, string Email, long Mobileno, int cityid, DateTime DOB)
        {
            SqlConnection con = GetConnection();
            string query = "update employee_civica set Empname=@Empname,Gender=@Gender,Email=@Email,Mobileno=@Mobileno,cityid=@cityid,DOB=@DOB where Empno=@Empno";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Empname", Empname);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Mobileno", Mobileno);
                cmd.Parameters.AddWithValue("@cityid", cityid);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Empno", Empno);
                cmd.ExecuteNonQuery();
                return "Values are updated successfully";

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

        public static string deletevalue(int Empno)
        {
            SqlConnection con = GetConnection();
            string query = "delete employee_civica where Empno=@Empno";
            try
            {
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@Empno", Empno);
                cmd.ExecuteNonQuery();
                return "delete the row";
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
        public static DataSet searchvalue(int Empno)
        {
            SqlConnection con = GetConnection();
            String query = "select * from employee_civica where Empno=@Empno";
            SqlDataAdapter da;
            
                da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet(); 

                da.SelectCommand.Parameters.AddWithValue("@Empno", Empno);
                da.Fill(ds, "employee_civica");
                return ds;
        }
    }
}
