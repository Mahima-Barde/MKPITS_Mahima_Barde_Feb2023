using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TMS_Project1_ASP.Net_web_application_.admin
{
    public partial class Admin_login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            string query = "select * from admin_login_tbl where Emailid=@Emailid and password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Emailid", EmailIdTextBox1.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox1.Text);
            con.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            if(dr.HasRows)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", " Swal.fire('Success!','Login successfully','success')", true);
                Session["useremail"] = EmailIdTextBox1.Text;
                Response.Redirect("DashboardContent.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", " Swal.fire('Failure!', 'Emailid or password is incorrect','error')", true);
            }
            con.Close();
        }
    }
}