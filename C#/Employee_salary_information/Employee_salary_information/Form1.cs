namespace Employee_salary_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int basisalary = Convert.ToInt32(textBox2.Text);
            //HRA:House Rent Allowance(35%)
            //DA :Dearness Allowance(45%)
            float hra = basisalary * 0.35f;
            label3.Text = "Hra =" + hra;
            float da = basisalary * 0.45f;
            label4.Text = "DA =" + da;
            float total = hra + da + basisalary;
            label5.Text = "Total Salary =" + total;



        }
    }
}