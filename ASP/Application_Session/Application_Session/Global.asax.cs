using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Application_Session
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["Comapanyname"] = "MKPITS";
            Application["Counter"] = 0;
        }
        void Session_start(object sender,EventArgs e)
        {
            Session["Usercount"] = 0;
            Session["Username"] = "";
            Session["Email"] = "";
        }
    }
}