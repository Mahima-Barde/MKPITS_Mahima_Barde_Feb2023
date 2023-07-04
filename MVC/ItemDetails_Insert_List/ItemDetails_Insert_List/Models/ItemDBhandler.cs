using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ItemDetails_Insert_List.Models
{
    public class ItemDBhandler
    {
        SqlConnection con = null;

        public void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=ItemMaster";
            con = new SqlConnection(constr);
        }

        // 2. ********** Get All Item List **********
        //list generic class to create collection of itemmodel objects
        public List<ItemModel> GetItems()
        {
            connection();
            List<ItemModel> items = new List<ItemModel>();
            string query = "select * from Item_List";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow Dr in dt.Rows)
            {
                items.Add(new ItemModel
                {
                    ID = Convert.ToInt32(Dr["ID"]),
                    Name = (Dr["Name"]).ToString(),
                     Category = (Dr["Category"]).ToString(),    
                    Price = Convert.ToInt32(Dr["Price"])
                });

            }
            return items;
        }


        // insert itemmethod to insert record into itemlist table

        public bool insertvalue(ItemModel ilist)
        {
            connection();
            string query = "insert into  Item_List values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
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