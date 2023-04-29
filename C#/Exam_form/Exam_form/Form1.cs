namespace Exam_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Newzeland_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
            int Marks = 0;
            if (radioButton2.Checked)
            {
                Marks = Marks + 2;
            }
            if (radioButton6.Checked)
            {
                Marks = Marks + 2;
            }
            if (radioButton9.Checked)
            {
                Marks = Marks + 2;
            }
            if (radioButton11.Checked)
            {
                Marks = Marks + 2;
            }
            if (radioButton13.Checked)
            {
                Marks = Marks + 2;
            }
            label13.Text = "Total Marks= " + Marks;
            int a=
        }
        int cnt = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt >=0 )
            {
                label12.Text = "Time:00:" + cnt + "sec";

            }
            else
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("Time over");
            }
            cnt = cnt - 1;
        }
    }
}