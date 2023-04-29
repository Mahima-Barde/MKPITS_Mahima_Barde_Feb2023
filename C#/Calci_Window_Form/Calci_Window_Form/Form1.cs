using System.Text;

namespace Calci_Window_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num = 0;
        int operation;
        int counter = 0;
        StringBuilder sb = new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "+"|| textBox1.Text=="-" || textBox1.Text=="*"
              ||  textBox1.Text=="/")
            {
                textBox1.Text = " ";
                textBox1.Text = "1";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "1";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "2";
                counter++;
            }
            else if (textBox1.Text == " ")
            {
                textBox1.Text = "2";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "3";
                counter++;

            }
            else if (textBox1.Text == " ")
            {
                textBox1.Text = "3";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+";
            operation = '+';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            if (operation == '+')
            {

                int number = num + b;
                string str = Convert.ToString(number);
                textBox1.Text = str;
                num = 0;
            }
            else if (operation == '*')
            {

                int number = num * b;
                string str = Convert.ToString(number);
                textBox1.Text = str;
                num = 0;
            }
            else if (operation == '/')
            {

                int number = num / b;
                string str = Convert.ToString(number);
                textBox1.Text = str;
                num = 0;
            }
            else
            {

                int number = num - b;
                string str = Convert.ToString(number);
                textBox1.Text = str;
                num = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {//6

            if(textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
                || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "6";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "6";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {//4

            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "4";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "4";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {//5
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "5";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "5";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {//7

            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "7";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "7";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {//8

            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "8";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "8";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {//9
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "9";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "9";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {//0
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*"
              || textBox1.Text == "/")
            {
                textBox1.Text = " ";
                textBox1.Text = "0";
                counter++;
            }



            else if (textBox1.Text == " ")
            {
                textBox1.Text = "0";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                if (counter == 0)
                {
                    num = Convert.ToInt32(textBox1.Text);
                }
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {//*
            textBox1.Text = "*";
            operation = '*';

        }

        private void button15_Click(object sender, EventArgs e)
        {//'/'
            textBox1.Text = "/";
            operation = '/';

        }

        private void button16_Click(object sender, EventArgs e)
        {//-
            textBox1.Text = "-";
            operation = '-';
        }
    }
}