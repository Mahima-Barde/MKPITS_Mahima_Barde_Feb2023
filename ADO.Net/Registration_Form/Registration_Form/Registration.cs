namespace Registration_Form
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            string mobileno = textBox3.Text;
            // SaveValue(name, age, mobileno);
            Display display = new Display();
            display.Show();



        }


        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        //    string name=te
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //}
    }
}