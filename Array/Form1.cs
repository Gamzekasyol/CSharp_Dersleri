namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array1 = { 3, 5, 27, 89 };
            string[] ogrenciler = { "Ali", "Veli", "Þeyma", "Gülendam" };

            for (int i =0; i< array1.Length; i++)
            {
                richTextBox1.Text = richTextBox1.Text + array1[i] + "\n";
                comboBox1.Items.Add(richTextBox1.Text);
            }
            
            
            foreach (string ogrenci in ogrenciler)
            {
                richTextBox1.Text = richTextBox1.Text + ogrenci + "\n";
                comboBox1.Items.Add(richTextBox1.Text);
            } 
        }
    }
}
