namespace Deposite_Withdrawal_Amount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int balance = 1000;
        private void button1_Click(object sender, EventArgs e)
        {

            int amount = Convert.ToInt32(textBox2.Text);
            if (amount > 0)
            {
                amount = balance + amount;
                label3.Text = "Balance =" + amount;
            }
            else
            {
                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {label3.Text = "Balance should be greater than 0 ";
            int amount = Convert.ToInt32(textBox2.Text);
            if(amount<=balance)
            {
                amount = balance - amount;
                label3.Text = "Balance =" + amount;
            }
            else
            {
                label3.Text = "Balance is not sufficient";
            }



        }
    }
}