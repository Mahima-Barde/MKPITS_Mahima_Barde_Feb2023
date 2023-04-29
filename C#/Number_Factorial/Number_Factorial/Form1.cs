using System.Diagnostics.Metrics;

namespace Number_Factorial
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
            for (int Counter = 1; Counter <= num; Counter++)
            {
                factorial = factorial* Counter;
            }
            label2.Text = "Factorial =" + factorial;
        }
    }
}