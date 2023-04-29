namespace Display_result_t_p_g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, total, grade;
            float percentage;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            s4 = Convert.ToInt32(textBox4.Text);
            total = s1 + s2 + s3 + s4;
            percentage = (total / 400f) * 100;
            label5.Text = "Total =" + total;
            if (percentage >= 75)
            {
                label7.Text = "Grade =" + 'A';
            }
            else
            {
                label7.Text = "Grade =" + "Fail";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int s1, s2, s3, s4, total, grade;
            float percentage;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            s4 = Convert.ToInt32(textBox4.Text);
            total = s1 + s2 + s3 + s4;
            
            percentage = (total / 400f) * 100;
            label6.Text = "Percentage =" + percentage;
        }
    }
}