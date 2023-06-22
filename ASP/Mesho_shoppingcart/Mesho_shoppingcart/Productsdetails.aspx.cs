using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mesho_shoppingcart
{
    public partial class Productsdetails : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meeshocart");
        SqlDataAdapter da;
        DataSet ds;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

            string prodid = Request.QueryString["prodid"].ToString();
            da = new SqlDataAdapter("select * from productitem where prodid=@prodid", con);
            ds = new DataSet();
            da.SelectCommand.Parameters.AddWithValue("@prodid", prodid);
            da.Fill(ds, "productitem");
            DataList1.DataSource = ds.Tables["productitem"].DefaultView;
            DataList1.DataBind();

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}