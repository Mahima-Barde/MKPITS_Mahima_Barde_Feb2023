using Get_connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Get_connection_DLL_forms
{
    public partial class VendorWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                getvendorid();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertVendor_mast(TextBox2.Text);
            Label1.Text= res;
            getvendorid();
            TextBox3.Text= "";
            
        }


        //Chatgpt program added
            public void getvendorid()
            {
                string vendorIdString = VendorClass.getVendor_id();
                int res = 0;

                if (int.TryParse(vendorIdString, out res))
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
            string res = VendorClass.updateVendor_Mast(TextBox2.Text,Convert.ToInt32(TextBox3.Text));
            Label1.Text = res;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string res = VendorClass.deleteVendor_Mast(Convert.ToInt32(TextBox3.Text));
            Label1.Text = res;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searcVendor_Mast(Convert.ToInt32(TextBox3.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }



        }
    }
}