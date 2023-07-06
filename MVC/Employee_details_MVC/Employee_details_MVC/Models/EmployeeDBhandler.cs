using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Employee_details_MVC.Models
{
    public class EmployeeDBhandler
    {
        SqlConnection con = null;
        public void connection()
        {
             string str = "server=.\\sqlexpress;integrated security=true;database=Employeedetail";
             con=new SqlConnection(str);
        }

        public List<EmployeeModel> GetEmployees()
        {
            connection();
            List<EmployeeModel> info= new List<EmployeeModel>();
            string query = "select * from Employe_d";
            SqlCommand cmd=new SqlCommand(query, con);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
             
            foreach(DataRow dr in dt.Rows)
            {
                info.Add(new EmployeeModel
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Name = Convert.ToString(dr["name"]),
                    price = Convert.ToInt32(dr["price"]),
                    age = Convert.ToInt32(dr["age"]),
                    Department = Convert.ToString(dr["department"])
                });
            }
            return info;
        }

        //*************** insert method ***************

        public bool insertEmployee(EmployeeModel em)
        {
            connection();
            string query = "insert into Employe_d values('" + em.Name + "','" + em.price + "','" + em.age + "','" + em.Department + "')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}