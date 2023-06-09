using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application_Session
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int uc = (int)Session["Usercount"];
            uc = uc + 1;
            Session["Usercount"] = uc;
            Response.Write("User Session Count" + uc);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Username"]=TextBox1.Text;
            Session["Email"]=TextBox2.Text;
            Label1.Text = "you value are stored in sessional variable";
        }
    }
}