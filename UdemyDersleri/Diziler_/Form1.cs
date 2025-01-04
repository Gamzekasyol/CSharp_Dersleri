namespace Diziler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] diziler = { 1, 2, 3, 4 };               // son idextekini getirir.
            //richTextBox1.Text = richTextBox1.Text + diziler[diziler.Length - 1].ToString()+ "\n";

            //string[] isimler = { "Kaan", "Ali", "Ayþe", "Hatice" };

            //for (int i =0; i < isimler.Length; i++)
            //{
            //    richTextBox1.Text = richTextBox1.Text + isimler[i] +"\n";
            //}
            //for (int i = 0; i < diziler.Length; i++)
            //{
            //    richTextBox1.Text = richTextBox1.Text + diziler[i] + "\n";
            //}

            //foreach (int dizi in diziler)
            //{
            //    richTextBox1.Text = richTextBox1.Text + dizi.ToString()  + "          ";
            //}

            //foreach (string isim in isimler)
            //{
            //    richTextBox1.Text = richTextBox1.Text + isim + "  ";
            //}
            double ortalama = 0;
            int toplam = 0;
            for (int i = 0; i < diziler.Length; i++)
            {
                
                toplam = toplam + diziler[i];
            }
            ortalama = (double) toplam / diziler.Length;
            richTextBox1.Text = "Toplam: "+toplam +" Ortalama: " + ortalama;


        }
    }
}
