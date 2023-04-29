namespace Display_FOrm_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int buttoncounter = 0;
        private int[] array = new int[5];
        private int[] array1 = new int[5];
        private int[] button1_Click(object sender, EventArgs e)
        {
            buttoncounter = buttoncounter + 1 
            int a = buttoncounter;

            array[buttoncounter - 1] = Convert.ToInt32(textBox1.Text);

            return array;
        }
    }
}