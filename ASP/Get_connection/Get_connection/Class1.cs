using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Get_connection
{
    public static class VendorClass
    {
      static SqlConnection con = ConnectionDB.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in vendor table
        public static string insertVendor_mast(string vendor_name)
        {
            string res = null;
            try
            {
                query = "insert into Vendor_mast values(@Vendor_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Vendor_name",vendor_name);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in vendor master successfully";

            }
            catch (Exception ee)
            {
             res= ee.ToString();
            }
            finally 
            {
                con.Close(); 
            }
            return res;

        }
        //method to return vendor_id

        public static string getVendor_id()   //get_Vendorid()
        {
            string res = null;
            try
            {
                query = "select max(Vendor_id) from Vendor_mast";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());
                res = vid.ToString();
            }
            catch (Exception ee)
            {
                res= ee.ToString();
            }
            finally
            { 
                
                con.Close(); 
            }   
            return res;
        }


        //method to update record in vendor table
        public static string updateVendor_Mast(string vendor_name, int vendor_id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Vendor_mast where Vendor_id=@Vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vendor_id", vendor_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "update  Vendor_mast set Vendor_name=@Vendor_name where Vendor_id=@Vendor_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Vendor_name", vendor_name);
                    cmd.Parameters.AddWithValue("@Vendor_id", vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in vendor master successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "no record exist ";
            }
            return res;
        }

        //method to delete record in vendor master

        public static string deleteVendor_Mast(int vendor_id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Vendor_mast where Vendor_id=@Vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Vendor_id", vendor_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "delete from  Vendor_mast where Vendor_id=@Vendor_id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Vendor_id", vendor_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in vendor master successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "no record exist ";
            }
            return res;
        }

        //method to search record in vendor master

        public static DataSet searcVendor_Mast(int vendor_id)
        {

            query = "select * from  Vendor_mast where Vendor_id=@Vendor_id";


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Vendor_id", vendor_id);
            da.Fill(ds, "Vendor_mast");
            return ds;


        }
    }
}



    

