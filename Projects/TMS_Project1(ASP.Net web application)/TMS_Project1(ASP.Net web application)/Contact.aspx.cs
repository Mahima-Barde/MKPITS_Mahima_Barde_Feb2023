using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TMS_Project1_ASP.Net_web_application_
{
    public partial class Contact : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            string query = "spContact_Insert";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
            cmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
            cmd.Parameters.AddWithValue("@subject", SubjectDropDownList.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@message", MessageTextBox.Text);
            con.Open();
            int num=cmd.ExecuteNonQuery();
            if(num>0)
            {
                //if we want to call script function in asp.net then code is like this
                ScriptManager.RegisterStartupScript(this, GetType(),"Popup","submitsuccess();", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Errormessage();", true);
            }
            con.Close();            
        }
    }
}