namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox3.Text);
            int toplam = 0;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 1)
                {

                    textBox2.Text = textBox2.Text + " " + i;
                }
                else
                {

                }
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= (progressBar1.Maximum - 10))
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
        }
    }
}
