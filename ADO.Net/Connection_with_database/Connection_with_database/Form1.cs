using System.Data.SqlClient;

namespace Connection_with_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database.GetConnection();
            if (con != null )
            {
                label1.Text = "Connected Successfully";
            }
            else
            {
                label1.Text = "Cannot Connect";
            }
        }
    }
}