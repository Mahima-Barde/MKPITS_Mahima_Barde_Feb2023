using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace WindowsFormsApp1
{
   public static class CourseRegistration
    {
        private static string ConnectionString = "Server=.\\Sqlexpress;integrated security=true;database=Project2";
        
         public static  SqlConnection GetConnection()
         {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                return con;
            }
            catch(Exception ee)
            {
                return null;
            }
         }

        public static DataSet getNation()
        {
            string query = "select * from Nation";
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "Nation");
            return ds;
        }
         public static DataSet getState(string Nation_name) 
         {
            SqlConnection con = GetConnection();
            string query = "select s.State_Id,s.State_Name from State s inner join Nation t on s.Nation_Id = t.Nation_Id Where Nation_name =@Nation_name";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.SelectCommand.Parameters.AddWithValue("@Nation_name", Nation_name);
            da.Fill(ds, "State");
            return ds;
        
         }
        public static DataSet getCity(string State_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select c.City_Id,c.City_Name from City c inner join State s on c.State_Id= s.State_Id where State_Name=@State_Name";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.SelectCommand.Parameters.AddWithValue("@State_Name", State_Name);
            da.Fill(ds, "City");
            return ds;
        }
        public static string saveCourses(int categoryid,string Fullname,int Gender)
        {
            SqlConnection con = GetConnection(); 
            con.Open();
            string query = "insert into Courses(@categoryid,@Fullname,@Genderid)";
            Command.Parameters.AddwithValue("@categoryid", categoryid);
            Command.Parameters.Add

        
        
        }

        
   }
}
