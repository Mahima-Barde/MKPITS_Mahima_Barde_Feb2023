using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Item_Trasaction_TRUST
{
    public partial class ItemsInfo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=FieldTransaction");
        DataSet ds=new DataSet();
        SqlDataAdapter da;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();

        }
        public void loadData()
        {
            query = "Select * from Item_master";
            da = new SqlDataAdapter(query, con);
            da.Fill(ds, "Item_master");
            GridView1.DataSource = ds.Tables["Item_master"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            query = "insert into Item_master values(@Item_Name,@Category,@rate,@balace_quantity)";
            SqlCommand command= new SqlCommand(query, con);
            //command.Parameters.AddWithValue("@Item_Id",Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Item_Name", TextBox2.Text);
            command.Parameters.AddWithValue("@Category", TextBox3.Text);
            command.Parameters.AddWithValue("@rate", Convert.ToSingle(TextBox4.Text));
            command.Parameters.AddWithValue("@balace_quantity", Convert.ToInt32(TextBox5.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox1.Focus();
            loadData();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "update Item_master set Item_Name=@Item_name,Category=@Category,rate=@rate,balace_quantity=@balace_quantity where Item_Id=@Item_Id";
                        
            
            SqlCommand command= new SqlCommand(query, con);

            command.Parameters.AddWithValue("@Item_Name", TextBox2.Text);
            command.Parameters.AddWithValue("@Category", TextBox3.Text);
            command.Parameters.AddWithValue("@rate", Convert.ToDecimal(TextBox4.Text));
            command.Parameters.AddWithValue("@balace_quantity", Convert.ToInt32(TextBox5.Text));
            command.Parameters.AddWithValue("@Item_Id", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery(); 
            con.Close();
            TextBox1.Text = "";
            TextBox1.Focus();
            loadData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            query = "delete from Item_master where Item_Id=@Item_Id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Item_Id", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox1.Focus();
            loadData();
        }
    }
}