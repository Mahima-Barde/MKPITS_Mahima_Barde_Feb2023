using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TMS_Project1_ASP.Net_web_application_.admin
{
    public partial class Admin_logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["useremail"]!=null)
            {
                Session.Abandon();
                //Session["useremail"]=null;
                Response.Redirect("Admin_login.aspx");
            }
        }
    }
}