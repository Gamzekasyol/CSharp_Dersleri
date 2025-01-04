namespace Döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttontopla_Click(object sender, EventArgs e)
        {
            int sayilar = Convert.ToInt32(textBox1.Text);

            int toplam = 0;
            for (int i = 1; i <= sayilar; i++)
            {
                toplam = toplam + i;
                labelsonuc.Text = toplam.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangıc_degeri = Convert.ToInt32(textBoxbaslangic.Text);
            int bitiş_degeri = Convert.ToInt32(textBoxbitiş.Text);

            for (int i = baslangıc_degeri; i<= bitiş_degeri; i++)
            {
                if (i % 2 == 0)
                {
                    richTextBox1.Text = richTextBox1.Text + i + "   ";
                }
                else
                    continue;

            }
        }
    }
}
