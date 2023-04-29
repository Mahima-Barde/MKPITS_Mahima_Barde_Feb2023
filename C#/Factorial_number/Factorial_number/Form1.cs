namespace Factorial_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            int num = Convert.ToInt32(textBox1.Text);
            for(int counter=1;counter<=num;counter++)
            {
                factorial = factorial * counter;
            }
            label2.Text = "Factorial of " + num + " is" + factorial;
        }
    }
}