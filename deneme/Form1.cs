namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("L�tfen bir de�er se�iniz!");
            }
            else
            {
                label1.Text = comboBox1.SelectedItem.ToString();
            }
           
        }
    }
}
