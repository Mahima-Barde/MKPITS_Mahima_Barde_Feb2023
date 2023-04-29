using System.Security.Cryptography.X509Certificates;

namespace bank_account_runtime_polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int amt = Convert.ToInt32(label2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            int amt = Convert.ToInt32(textBox2.Text);
            string acttype = textBox3.Text;
            Account act = null;
            if (acttype == "Saving")
            {
                act = new Saving();
                textBox4.Text = Convert.ToString(act.deposit(amt));
            }
            else if (acttype == "current")
            {
                act = new current();
                textBox4.Text = Convert.ToString(act.deposit(amt));
            }

        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string acttype = textBox3.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}