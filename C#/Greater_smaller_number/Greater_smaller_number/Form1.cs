namespace Greater_smaller_number
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
            if (num1 > num2)
            {
                label3.Text = num1 + "Greater";
            }
            else
            {
                label3.Text = num2 + "Greater";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            if (num1 < num2)
            {
                label3.Text = num1 + " is Smaller";
            }
            else
            {
                label3.Text = num2 + " is Smaller";
            }

        }
    }
}