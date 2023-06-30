using System.Data;

namespace Employee_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string gender = null;
        private void button1_Click(object sender, EventArgs e)
        {
            getGender();
            string result;
            result = EmployeeConnection.InsertValue(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, textBox3.Text, Convert.ToInt64(textBox4.Text), Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value);
            label8.Text = result;
        }

        public void getGender()
        {
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = EmployeeConnection.searchvalue(Convert.ToInt32(textBox1.Text));
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string gender = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if (gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else if (gender == "Female")
            {
                radioButton2.Checked = true;
            }
            textBox3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeConnection.GetCity();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "cityid";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getGender();
            string result = EmployeeConnection.updatevalue(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, textBox3.Text, Convert.ToInt64(textBox4.Text), Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value);
            label8.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getGender();
            string result = EmployeeConnection.deletevalue(Convert.ToInt32(textBox1.Text));
            label8.Text = result;
        }
    }
}