namespace Display_array_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         private int[] array = new int[5];
         private  int buttoncounter = 0;
        public int[] array1 = new int[5];
        private int[] button2_Click(object sender, EventArgs e)
        {
            buttoncounter++;
            int a = buttoncounter;

            array[buttoncounter - 1] = Convert.ToInt32(textBox1.Text);

            return array;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < 6; count++)
            {
                array1[count] = array[count];
            }
            foreach (int val in array1)
            {
                
            }

        }
    }
}