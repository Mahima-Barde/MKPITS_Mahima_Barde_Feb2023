using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DrivenITForm
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=drivenitdb");
        string query = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        
        }

        protected void Button1_Click(object sender, EventArgs e)


        {
            try
            {
                query = "insert into Transactions values(@ItemID,@TransType,@TransQty,@TransDate)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                string trans = null;
                if (RadioButton1.Checked)
                {
                    trans = "I";

                }
                else if (RadioButton2.Checked)
                {
                    trans = "R";
                }
                cmd.Parameters.AddWithValue("@TransType", trans);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                
                //getting the balqty from itemmaster table for particular itemid
                query = "select max(Balqty) from Itemmaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bqt = Convert.ToInt32(cmd.ExecuteScalar());
                if(trans=="I")
                {
                    bqt = bqt - Convert.ToInt32(TextBox1.Text);
                }
                else if(trans=="R")
                 {
                    bqt = bqt + Convert.ToInt32(TextBox1.Text);
                 }

                //updating bal qty on item master
                query = "update Itemmaster set Balqty=@Balqty where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Balqty",bqt);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();
                Label1.Text = "record saved";

            }
            catch(Exception ex)
            { 
                Label1.Text = ex.ToString();
            }
            finally
            {
                
                con.Close(); 
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                query = "update Transactions set Transtype=@TransType,TransQty=@TransQty,TransDate=@TransDate where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                string trans = null;
                if (RadioButton1.Checked)
                {
                    trans = "I";

                }
                else if (RadioButton2.Checked)
                {
                    trans = "R";
                }
                cmd.Parameters.AddWithValue("@TransType", trans);
                cmd.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                con.Open();
                cmd.ExecuteNonQuery();


                //getting the balqty from itemmaster table for particular itemid
                query = "select max(Balqty) from Itemmaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bqt = Convert.ToInt32(cmd.ExecuteScalar());
                if (trans == "I")
                {
                    bqt = bqt - Convert.ToInt32(TextBox1.Text);
                }
                else if (trans == "R")
                {
                    bqt = bqt + Convert.ToInt32(TextBox1.Text);
                }

                //updating bal qty on item master
                query = "update Itemmaster set Balqty=@Balqty where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Balqty", bqt);
                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();
                Label1.Text = "record updated successfully";

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally
            {

                con.Close();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            //.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[5].Text;

        }
    }
}