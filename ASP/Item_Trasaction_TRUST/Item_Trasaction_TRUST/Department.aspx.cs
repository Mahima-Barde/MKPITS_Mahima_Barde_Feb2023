using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Web.DynamicData;

namespace Item_Trasaction_TRUST
{
    public partial class Department : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=FieldTransaction");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string query1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            dataload();
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            query1 = "insert into Department_mast values(@Department_name)";
            SqlCommand command=new SqlCommand(query1,con);
            command.Parameters.AddWithValue("@Department_name",TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            dataload();
            TextBox1.Text = "";
            TextBox1.Focus();
            

        }
        public void dataload()
        {
            query1 = " select * from Department_mast";
            da = new SqlDataAdapter(query1, con);
            da.Fill(ds, "Department_mast");
            GridView1.DataSource = ds.Tables["Department_mast"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query1 = "update Department_mast set Department_name=@Department_name where Department_Id=@Department_Id";
            SqlCommand command = new SqlCommand(query1,con);
            command.Parameters.AddWithValue("@Department_Id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Department_name", TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox1.Focus();
            dataload() ;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query1 = "delete from Department_mast where Department_Id=@Department_Id";
            SqlCommand command= new SqlCommand(query1,con);
            command.Parameters.AddWithValue("@Department_Id",Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery(); 
            con.Close();
            TextBox1.Text = "";
            TextBox1.Focus (); 
            dataload() ;

        }
    }
}