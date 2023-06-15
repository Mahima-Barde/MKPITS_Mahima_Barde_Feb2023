using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Add ClassLibrary here
using Bank_Library;
namespace BankLibrary_WebForm
{

    public partial class BankLibraryWebform : System.Web.UI.Page
    {
        Class1 c = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = c.Deposite(Convert.ToInt32(TextBox1.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = c.withdral(Convert.ToInt32(TextBox1.Text));
        }
    }
}