namespace Square_of_2number_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int Square = num * num;
            label2.Text = "Square :" + Square;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}