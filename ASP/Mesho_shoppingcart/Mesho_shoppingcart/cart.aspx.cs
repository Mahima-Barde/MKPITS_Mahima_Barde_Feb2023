﻿using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mesho_shoppingcart
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["prodid"].ToString();
            Session["prodid"] = prodid;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkmno.aspx");
        }
    }
}