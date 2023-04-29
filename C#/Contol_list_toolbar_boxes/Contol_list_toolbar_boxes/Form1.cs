namespace Contol_list_toolbar_boxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = " ";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            MessageBox.Show(country);
            switch (country)
            {
                case "USA":
                    comboBox2.Items.Add("Miami");
                    comboBox2.Items.Add("Cicago");
                    comboBox2.Items.Add("lA");
                    break;
                case "India":
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Delhi");
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Gujarat");
                    break;
                case "UK":
                    comboBox2.Items.Add("London");
                    comboBox2.Items.Add("Oxford");
                    comboBox2.Items.Add("Liverpool");
                    break;



            }

        }

        private void Java_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Java.SetSelected(0, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "Country " + comboBox1.Text + "\n";
            label8.Text += "City " + comboBox2.Text + "\n";
            label8.Text += "Cources " + Java.Text + "\n";
            label8.Text += "Phone.No " + maskedTextBox1.Text + "\n";
            label8.Text += "Date of birth " + dateTimePicker1.Text + "\n";
        }
    }
}