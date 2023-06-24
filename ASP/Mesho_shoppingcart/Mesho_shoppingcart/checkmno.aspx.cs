using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Mesho_shoppingcart
{
    public partial class checkmno : System.Web.UI.Page
    {
        string prodid;

        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meeshocart");
        SqlCommand cmd;
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            prodid = Convert.ToInt32(Session["prodid"]).ToString();
            Response.Write("prodid" + prodid);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string result = TextBox1.Text;
            string prodname = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            string prodimage = null;
            if (result == "123456")
            {
                query = "select * from productitem where prodid=@prodid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prodid", prodid);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prodname = dr["prodname"].ToString();
                    prodprice = Convert.ToInt32(dr["prodprice"].ToString());
                    qty = 1;
                    sessionid = Session.SessionID;
                    prodimage = dr["prodimage"].ToString();
                }
                con.Close();
                Response.Write("prodname " + prodname + "<br>");
                Response.Write("prodprice " + prodprice + "<br>");
                Response.Write("qty" + qty + "<br>");
                Response.Write("sessionid " + sessionid + "<br>");

                //save the product data into carttable

                //insertion code into cart table
                query = "Insert into Cart values(@prodname,@prodprice,@Quantity,@Sessionid,@prodimage)";
                cmd = new SqlCommand(query, con);
               cmd.Parameters.AddWithValue("@prodname", prodname);
               cmd.Parameters.AddWithValue("@prodprice", prodprice);
                cmd.Parameters.AddWithValue("@Quantity", qty);
               cmd.Parameters.AddWithValue("@Sessionid", sessionid);
                cmd.Parameters.AddWithValue("@prodimage", prodimage);
                con.Open();
               cmd.ExecuteNonQuery();
                con.Close();
             

                // Response.Redirect("cart1.aspx");
            }
            else
            {
                Label1.Text = "invalid otp";
            }
            //query = "select prodimage from productitem where prodid=@prodid";
           // cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@prodid", prodid);
           // cmd.Parameters.AddWithValue("@prodimage", prodimage);

         
            



        }

    }
    
}
