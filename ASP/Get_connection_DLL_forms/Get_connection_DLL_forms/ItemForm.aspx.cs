using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Get_connection_DLL_forms
{
    public partial class ItemForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                getitemid();
            }
        }
        //Chatgpt program added
        public void getitemid()
        {
            string itemIdString = Get_connection.Item.getitem_id();
            int res = 0;

            if (int.TryParse(itemIdString, out res))
            {
                res += 1;
                TextBox3.Text = res.ToString();
            }
            else
            {
                TextBox3.Text = "Invalid vendor ID";
            }
        }
     

            protected void Button1_Click(object sender, EventArgs e)
            {
            string res = Get_connection.Item.insertitem(TextBox2.Text, TextBox4.Text, Convert.ToDouble(TextBox5.Text), Convert.ToInt32(TextBox6.Text));
            Label6.Text = res;
            getitemid();
            TextBox3.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            //Code should be add here
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = Get_connection.Item.updateitem_Mast(TextBox2.Text,Convert.ToInt32(TextBox3.Text),TextBox4.Text,Convert.ToDouble(TextBox5.Text), Convert.ToInt32(TextBox6.Text));
            Label6.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = Get_connection.Item.deletedepartment_Mast(Convert.ToInt32(TextBox3.Text));
            Label6.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Get_connection.Item.searchitem_Mast(Convert.ToInt32(TextBox3.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["Item_master"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label6.Text = "no record exist";
            }
        }
    }
}