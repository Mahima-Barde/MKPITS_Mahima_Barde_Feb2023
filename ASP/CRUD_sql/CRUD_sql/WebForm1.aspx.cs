using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace CRUD_sql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=project2");
        string str = null;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();

        }

        public void loaddata()
        {
            str = "select * from State";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "State");
            GridView1.DataSource = ds.Tables["State"].DefaultView;
            GridView1.DataBind();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            str="insert into State values(@State_Id,@State_Name,@Nation_Id)";
            SqlCommand command= new SqlCommand(str, con);
            command.Parameters.AddWithValue("@State_Id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@State_Name", TextBox2.Text);
            command.Parameters.AddWithValue("@Nation_Id", Convert.ToInt32(TextBox3.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label4.Text = "SUccessfully Inserted";
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "delete from State where State_Id=@State_Id";
            SqlCommand command=new SqlCommand(str, con);
            command.Parameters.AddWithValue("@State_Id", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label4.Text = "Successfully Deleted";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str=""
        }
    }
}