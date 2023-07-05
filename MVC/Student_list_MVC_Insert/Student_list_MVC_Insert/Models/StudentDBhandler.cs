using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Diagnostics.Contracts;

namespace Student_list_MVC_Insert.Models
{

    public class StudentDBhandler
    {
        SqlConnection con=null;

        public void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=Students";
            con=new SqlConnection(constr);
         }

        // 2. ********** Get All Student information **********
        //list generic class to create collection of studentmodel objects

        public List<StudentModel> GetStudents()
        {
            connection();
            List<StudentModel> info = new List<StudentModel>();
            string query = "select * from stud1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                info.Add(new StudentModel
                {
                  roll_no = Convert.ToInt32(dr["roll_no"]),
                    name = (dr["name"]).ToString(),
                    subject = (dr["subject"]).ToString(),
                    Marks = Convert.ToInt32(dr["Marks"])
                });
                //here "roll_no" in dr["roll_no"] is from database.
            }
            return info;

        }
        //insert studentmethod to insert record into studentModel table

        public bool insertValue(StudentModel student)
        {
            connection();
            string query = "insert into stud1 values('" + student.name + "','" + student.subject + "','" + student.Marks + "')";
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //update a value
        public bool updateValue(StudentModel student)
        {
            connection();
            string query = "update stud1 set name='" + student.name + "',subject='" + student.subject + "',Marks='" + student.Marks + "' where roll_no='" + student.roll_no + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
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

        //delete a value

        public bool deleteValue(StudentModel student)
        {
            connection();
            string query = "delete stud1 where roll_no='" + student.roll_no + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
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