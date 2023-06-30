using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_with_database
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result = StudentDatabaseConnection.Insertvalue(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            label6.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

        }

        private void student_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = null;
            result = StudentDatabaseConnection.updatevalues(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            label6.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = null;
            result = StudentDatabaseConnection.deletevalue(Convert.ToInt32(textBox1.Text));
            label6.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = StudentDatabaseConnection.SearchValues(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = ds.Tables[0];
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            textBox3.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            label6.Text = "Result is search";

        }
    }
}
