using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Item_DatabaseConnection_MVC.Models
{
    public class Itemdbhadler
    {
        SqlConnection con = null;

        public void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=ItemMaster";
             con = new SqlConnection(constr);
        }

        // insert itemmethod to insert record into itemlist table

        public bool insertvalue(ItemModel ilist)
        {
            connection();
            string query = "insert into  Item_List values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i=command.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
