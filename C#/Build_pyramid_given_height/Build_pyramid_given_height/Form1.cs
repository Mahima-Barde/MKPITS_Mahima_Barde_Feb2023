using System.Text;

namespace Build_pyramid_given_height
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //strinBuilder used to append new string to existing string
            StringBuilder sb = new StringBuilder();
            int height = Convert.ToInt32(textBox1.Text);
            for (int outerloop = 1; outerloop <= height; outerloop++)
            {


                for (int innerloop = 1; innerloop <= height - outerloop; innerloop++)
                {
                    sb.Append(" ");
                }
                for (int space = 1; space <= (2 * outerloop - 1); space++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            for (int outerloop = height; outerloop >= 1; outerloop--)
            {
                for (int innerloop = height - outerloop; innerloop >= 1; innerloop--)
                {
                    sb.Append(" ");
                }
                for (int space = (2 * outerloop - 1); space >= 1; space--)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            label2.Text = sb.ToString(); /*
            for (int outerloop = height; outerloop >= 1; outerloop--)
            {

                for (int innerloop = 1; innerloop <= (2 * outerloop - 1); innerloop++)
                {
                    sb.Append(" ");
                }
                for (int space =; space <= height - 1 ; space++)
                {
                    sb.Append("*");
                }
            }
            sb.Append("\n");
            label2.Text = sb.ToString();*/
        }

    }
}