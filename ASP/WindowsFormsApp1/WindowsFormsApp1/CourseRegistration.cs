using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using static System.Windows.Forms.AxHost;

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
            SqlCommand command= new SqlCommand(query, con);
            command.Parameters.AddWithValue("@categoryid", categoryid);
            command.Parameters.AddWithValue("@fullname", Fullname);
            command.Parameters.AddWithValue("@genderid", Gender);
            command.ExecuteNonQuery();
            con.Close();
            return"record saved in  TableCourseRegDetail";
        }
        static int Courseid = 0;
        public static string saveRegAddress(int Nation_Id, int , int State_Id, int City_Id)
        { 
         SqlConnection con=GetConnection();
            con.Open();
            string query = "SELEECT top 1 courseid FROM" +
                " tablecoursedetails ORDER BY cousere ";
            SqlCommand command = new SqlCommand(query, con);
            Courseid = Convert.ToInt32(command.ExecuteScalar());
            query = "insert into TableRegAddress values(@Courseid,@Nation_ID,@State_ID,@City_ID)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CourseRegID", Courseid);
            command.Parameters.AddWithValue("@NationID", Nation_Id);
            command.Parameters.AddWithValue("@StateID", State_Id);
            command.Parameters.AddWithValue("@CityID", City_Id);
            command.ExecuteNonQuery();
            con.Close();
            return "Record Save in RegAddress";
        }
        public static string SaveFeeDetail(double TotalAmount, double MinPer, double PaidAmount, double BalAmount, DateTime PaidDate)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableFeeDetail values(@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CourseRegID", Courseid);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@MinPer", MinPer);
            command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            command.Parameters.AddWithValue("@BalAmount", BalAmount);
            command.Parameters.AddWithValue("PaidDate", PaidDate);
            command.ExecuteNonQuery();
            con.Close();
            return "Record save In Feedetails";


        }



    }


}

