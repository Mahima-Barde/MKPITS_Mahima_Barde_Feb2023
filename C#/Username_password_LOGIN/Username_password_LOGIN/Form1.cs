namespace Username_password_LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string n = "Mahima_Barde";
            string psw="2065#yuni";
            if(name==n && password==psw)
            {
                label3.Text = "Login Successfully";
            }
             else if(name==n && password!=psw)
            {
                label3.Text = "Invalid Password";

            }
            else if(name != n && password == psw)
            {
                label3.Text = "Invalid Name";
            }
            else
            {
                label3.Text = "Invalid name and password";
            }
        }
    }
}