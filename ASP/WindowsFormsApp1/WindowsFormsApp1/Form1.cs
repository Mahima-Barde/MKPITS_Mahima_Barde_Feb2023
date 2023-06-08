using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox2.Text = "1000";
            DataSet ds = new DataSet();
            ds = CourseRegistration.getNation();
            comboBox1.DataSource = ds.Tables["Nation"];
            comboBox1.DisplayMember = "Nation_name";
            comboBox1.ValueMember = "Nation_Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration.getState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables["State"];
            comboBox2.DisplayMember = "State_Name";
            comboBox2.ValueMember = "State_Id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration.getCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables["City"];
            comboBox3.DisplayMember = "City_Name";
            comboBox3.ValueMember = "City_Id";
        }
        
    }
}
