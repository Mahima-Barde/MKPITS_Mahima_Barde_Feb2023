namespace Arithmetic_operation_twonumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int Add = num1 + num2;
            label3.Text = "Addition =" + Add;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int sub = num1 - num2;
            label4.Text = "Substraction = " + sub;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int mul = num1 * num2;
            label5.Text = "Multiplication =" + mul;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            float num1 = Convert.ToSingle(textBox1.Text);
            float num2 = Convert.ToSingle(textBox2.Text);
            float div = num1 / num2;
            label6.Text = "Division = " + div;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}