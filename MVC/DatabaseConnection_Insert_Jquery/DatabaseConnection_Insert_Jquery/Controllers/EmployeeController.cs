using DatabaseConnection_Insert_Jquery.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DatabaseConnection_Insert_Jquery.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

       
        private SqlConnection con;

        private void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=Employee";
            con = new SqlConnection(constr);
        }
        public ActionResult Index()
        {
            return View();
        }
       
        //[HttpPost]      
        //public ActionResult Index(Employeemodel em)
        //{
        //   AddDetails(em);
        //   return View();
        //}
    
       
        //[HttpPost]
        //public void AddDetails(Employeemodel em)
        //{

        //    try
        //    {
        //        connection();
        //        SqlCommand com = new SqlCommand("Addemp", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@Name", em.Name);
            
        //        com.Parameters.AddWithValue("@City", em.City);
        //        com.Parameters.AddWithValue("@Address", em.Address);
        //        con.Open();
        //        com.ExecuteNonQuery();
        //        con.Close();
        //    }
        //    catch(Exception ee)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ee.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //}

        [HttpPost]
        public ActionResult UpdateEmployee(Employeemodel em)
        {

            UpdateDetails(em);
            return View();
        }
        //To update Records into database
        private void UpdateDetails(Employeemodel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("Updatevalue", con);
                //addemp is the name of stored procedure
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", obj.Name); 
                com.Parameters.AddWithValue("@City", obj.City);
                com.Parameters.AddWithValue("@Address", obj.Address);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        [HttpPost]
        public ActionResult DeleteEmpDetails(Employeemodel em)
        {
            DeleteEmp(em);
            return View();
        }

        public void DeleteEmp(Employeemodel em)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("DeleteEmployee", con);
                com.Parameters.AddWithValue("@Name", em.Name);
                com.Parameters.AddWithValue("@City", em.City);
                com.Parameters.AddWithValue("@Address", em.Address);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }

        }
            
    }
           
}
