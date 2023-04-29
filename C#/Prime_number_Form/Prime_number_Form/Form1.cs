namespace Prime_number_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            int counter = 2;
            int Flag = 0;
            for (counter=2; counter < number; counter++)
            {
                if (number % counter == 0)
                {
                    Flag = 1;
                    break;
                }
            }
            if (Flag == 0)
            {
                label2.Text = number + " is a prime number";
            }
            else
            {
                label2.Text = number + " is not prime number";
            }
        }
    }
}