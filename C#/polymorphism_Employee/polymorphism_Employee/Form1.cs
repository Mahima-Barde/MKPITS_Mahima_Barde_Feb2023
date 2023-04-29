namespace polymorphism_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salary = Convert.ToInt32(textBox2.Text);
            Employee emp = null;
            string position = comboBox1.Text;
            if(position== "Manager")
            {
                emp = new Manager();
                label7.Text = Convert.ToString(emp.CalculateSalary(salary));
            }
            else if(position== "Engineer")
            {
                emp = new Engineer();
                label7.Text = Convert.ToString(emp.CalculateSalary(salary));
            }
            else if (position == "Salesperson")
            {
                emp = new Salesperson();
                label7.Text = Convert.ToString(emp.CalculateSalary(salary));
            }

        }
    }
}