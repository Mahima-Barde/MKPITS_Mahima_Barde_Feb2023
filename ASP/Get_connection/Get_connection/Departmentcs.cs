using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_connection
{
    public static class Department
    {
        static SqlConnection con = ConnectionDB.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in department table
        public static string insertdepartment(string department_name)
        {
            string res = null;
            try
            {
                query = "insert into Department_mast values(@Department_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Department_name", department_name);
                con.Open();
                cmd.ExecuteNonQuery();

                res = "record saved in department master successfully";

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
        //method to return department_id

        public static string getdepartment_id()   //get_departmentid()
        {
            string res = null;
            try
            {
                query = "select max(Department_id) from Department_mast";
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


        //method to update record in vendor table
        public static string updatedepartment_Mast(string department_name, int department_id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Department_mast where Department_id=@Department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Department_id", department_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "update  Department_mast set Department_name=@Department_name where Department_id=@Department_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Department_name", department_name);
                    cmd.Parameters.AddWithValue("@Department_id", department_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record updated in department master successfully";
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

        public static string deletedepartment_Mast(int department_id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Department_mast where Department_id=@Department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Department_id", department_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {


                try
                {
                    query = "delete from  Department_mast where Department_id=@Department_id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Department_id", department_id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "record deleted in department master successfully";
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

        //method to search record in department master

        public static DataSet searchdepartment_Mast(int department_id)
        {

            query = "select * from  Department_mast where Department_id=@Department_id";


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_id", department_id);
            da.Fill(ds, "Department_mast");
            return ds;


        }
    }
}
