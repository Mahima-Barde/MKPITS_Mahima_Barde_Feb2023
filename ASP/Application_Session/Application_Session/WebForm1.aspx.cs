using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application_Session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Welcome on Webpage 1");
            Server.Execute("WebForm2.aspx");
            Response.Write("Welcome back to Webpage 2");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Welcome to Webpage1");
            Server.Execute("WebForm2.aspx");
            Response.Write("Welcome to back Webpage----1);
        }
    }
}