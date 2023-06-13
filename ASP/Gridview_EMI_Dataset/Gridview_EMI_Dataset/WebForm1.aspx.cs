using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gridview_EMI_Dataset
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds=new DataSet();
            DataTable dt = new DataTable("Table of info");
            DataRow dr;
            string[] str = { "Mahima", "shreya", "Rupali" };
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("DateTime", typeof(DateTime)));
            for (int i = 0; i <= 2; i++)
            {
                dr = dt.NewRow();
                dr[0] = i+1;
                dr[1] = str[i];
                dr[2] = DateTime.Now.ToString();
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["Table of info"].DefaultView;
            GridView1.DataBind();   
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Table of EMI");
            DataRow dr1;
            int totalamount = 30000;
            double ramount= totalamount / 3.0;
            string productn = "Laptop";
            dt.Columns.Add(new DataColumn("sr.no", typeof(int)));
            dt.Columns.Add(new DataColumn("Product Name",typeof(string)));
            dt.Columns.Add(new DataColumn("EMI Amount", typeof(decimal)));
            for(int i=1;i<=3;i++)
            {
                dr1[0] = i;
                dr1[1] = productn;
                dr1[2] = dt.NewRow();
            }

        }
    }
}