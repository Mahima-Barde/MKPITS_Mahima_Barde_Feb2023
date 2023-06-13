using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Item_Trasaction_TRUST
{
    public partial class vendoraspx : System.Web.UI.Page
    {
            SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=FieldTransaction");
            SqlDataAdapter da;
            DataSet ds= new DataSet();
            string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Vendor_mast values(@Vendor_name)";
            SqlCommand command= new SqlCommand(str, con);
            //command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Vendor_name", TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox1.Focus();   
            loaddata();

        }

        public void loaddata()
        {
            str = "select * from Vendor_mast ";
            da=new SqlDataAdapter(str,con);
            da.Fill(ds,"Vendor_mast");
            GridView1.DataSource = ds.Tables["Vendor_mast"].DefaultView; 
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "insert into Vendor_mast values(@Vendor_name)";
            SqlCommand command=new SqlCommand(str, con);
           // command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Vendor_name", TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            loaddata();
            TextBox1.Text = "";
            TextBox1.Focus();
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            str = "delete from Vendor_mast where Vendor_Id=@Vendor_Id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery(); 
            con.Close();
            loaddata();
            TextBox1.Text = "";
            TextBox1.Focus();
        }


    }
}