using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace DrivenITForm
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=drivenitdb");
        string query = null;
        SqlCommand cmd = null;
        static int transid = 0;
       static int oldbalanceqty = 0;
        static int updateqty = 0;
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
                if(trans == "I")
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
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
            string type = GridView1.SelectedRow.Cells[3].Text;
            if (type == "I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;

            }
            else if (type == "R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;
            }
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            //value are saved and will used in updating
             oldbalanceqty = Convert.ToInt32(TextBox1.Text);
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                query = "update Transactions set ItemId=@ItemId,Transtype=@TransType,TransQty=@TransQty,TransDate=@TransDate where TransId=@TransId";
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
                cmd.Parameters.AddWithValue("@ItemId",DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@TransType",trans);
                cmd.Parameters.AddWithValue("@TransQty",Convert.ToInt32(TextBox1.Text));
                cmd.Parameters.AddWithValue("@TransDate",TextBox2.Text);
                cmd.Parameters.AddWithValue("@TransId",transid);
                con.Open();
                cmd.ExecuteNonQuery();


                //getting the balqty from itemmaster table for particular itemid
                query = "select max(Balqty) from Itemmaster where ItemId=@ItemId";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bqt = Convert.ToInt32(cmd.ExecuteScalar());
                updateqty = Convert.ToInt32(TextBox1.Text) - oldbalanceqty;
                

                if (RadioButton1.Checked)
                {
                    bqt = bqt - updateqty;
                }
                else if (RadioButton2.Checked)
                {
                    bqt = bqt + updateqty;
                }

                if (bqt < 0)

                    try
                    {
                        Label1.Text = "Stock is unavailable";
                        int pending = -bqt;
                        query = "Insert into pending values(@ItemID,@Tran_ID,@pending_item)";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                        cmd.Parameters.AddWithValue("@Tran_ID", transid);
                        cmd.Parameters.AddWithValue("@pending_item", pending);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Label1.Text = ex.ToString();
                    }
                    
                 else
                {
                    //updating bal qty on item master
                    query = "update Itemmaster set Balqty=@Balqty where ItemId=@ItemId";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Balqty", bqt);
                    cmd.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    Label1.Text = "record updated successfully";
                }

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

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from transactions where transid=@transid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@transid", transid);
                con.Open();
                cmd.ExecuteNonQuery();
                Label1.Text = "delete from record";
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
    }
}