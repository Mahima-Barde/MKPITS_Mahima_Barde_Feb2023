using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_connection
{
    public static class Item
    {
        static SqlConnection con = ConnectionDB.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in item table
        public static string insertitem(string item_name,string category,double rate,int quantity)
        {
            string res = null;
            try
            {
                query = "insert into Item_master values(@Item_Name,@Category,@rate,@balance_quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Name",item_name);
                cmd.Parameters.AddWithValue("@Category",category);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@balance_quantity",quantity);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in item master successfully";

            }
            catch (Exception ee)
            {
                res = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;

        }
        //method to return item_id

        public static string getitem_id()   //get_itemid()
        {
            string res = null;
            try
            {
                query = "select max(Item_id) from Item_master";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());
                res = vid.ToString();
            }
            catch (Exception ee)
            {
                res = ee.ToString();
            }
            finally
            {

                con.Close();
            }
            return res;
        }


        //method to update record in Item table
        public static string updateitem_Mast(string item_name,int item_id,string category,double rate,int quantity)
        {
            string res = null;

            //checking whether itemid exists or not
            query = "select count(*) from Item_master where Item_Id=@Item_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_Id", item_id);

            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "update  Item_master set Item_Name=@Item_Name,Category=@Category,rate=@rate,balance_quantity=@balance_quantity where Item_Id=@Item_Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Item_Name", item_name);
    
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@rate", rate);
                    cmd.Parameters.AddWithValue("@balance_quantity",quantity);
                    cmd.Parameters.AddWithValue("@Item_Id", item_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in item master successfully";
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

        //method to delete record in item master

        public static string deletedepartment_Mast(int item_id)
        {
            string res = null;

            //checking whether itemid exists or not
            query = "select count(*) from Item_master where Item_Id=@Item_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Item_Id", item_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "delete from  Item_master where Item_Id=@Item_Id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Item_id", item_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in item master successfully";
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

        //method to search record in item master

        public static DataSet searchitem_Mast(int item_id)
        {

            query = "select * from  Item_master where Item_Id=@Item_Id";


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Item_Id", item_id);

            da.Fill(ds, "Item_master");
            return ds;

        }





    }
}
