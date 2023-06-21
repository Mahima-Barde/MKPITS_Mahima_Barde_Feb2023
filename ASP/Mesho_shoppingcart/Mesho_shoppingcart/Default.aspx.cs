using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mesho_shoppingcart
{
    public partial class _Default : Page
    { 
        SqlConnection con=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meeshocart");
        SqlDataAdapter da;
        DataSet ds;
         protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                da = new SqlDataAdapter("select * from productitem", con);
                ds=new DataSet();
                da.Fill(ds,"Productitem");
                DataList1.DataSource = ds.Tables["productitem"].DefaultView;
                DataList1.DataBind();
            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}