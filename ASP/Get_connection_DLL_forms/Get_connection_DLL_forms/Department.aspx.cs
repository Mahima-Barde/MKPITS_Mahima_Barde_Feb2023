﻿using Get_connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Get_connection_DLL_forms
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getDepartmentid();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = Get_connection.Department.insertdepartment(TextBox2.Text);
            Label3.Text = res;
            getDepartmentid();
            TextBox3.Text = "";
        }
      
        //Chatgpt program added
        public void getDepartmentid()
        {
            string departmentIdString = Get_connection.Department.getdepartment_id();
            int res = 0;

            if (int.TryParse(departmentIdString, out res))
            {
                res += 1;
                TextBox3.Text = res.ToString();
            }
            else
            {
                TextBox3.Text = "Invalid vendor ID";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = Get_connection.Department.updatedepartment_Mast(TextBox2.Text, Convert.ToInt32(TextBox3.Text));
            Label3.Text = res;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string res = Get_connection.Department.deletedepartment_Mast(Convert.ToInt32(TextBox3.Text));
            Label3.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Get_connection.Department.searchdepartment_Mast(Convert.ToInt32(TextBox3.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["Department_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label3.Text = "no record exist";
            }
        }
    }
}