namespace Fonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carpmaYap(int number1, int number2)
        {
            int sonuc = number1 * number2;
            label3.Text = sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            carpmaYap(sayi1, sayi2);


        }


        private void birlestir(string ad, string soyad)
        {
            label7.Text = ad + " " + soyad;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string isim = textBox4.Text;
            string soyisim = textBox3.Text;

            birlestir(isim, soyisim);

        }



        private double topla(double number1, double number2)
        {
            double toplam = number1 + number2;
            return toplam;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox6.Text);
            double sayi2 = double.Parse(textBox5.Text);

            double sonuc = topla(sayi1, sayi2);
            label9.Text = sonuc.ToString();

        }




        // Overloading (Aþýrý Yükleme)


        private int topla(int number1, int number2)  // Parametreleri farklý olursa isim ayný olabilir.
        {
            int toplam = number1 + number2;
            return toplam;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int sayi1 = int.Parse(textBox8.Text);
            int sayi2 = int.Parse(textBox7.Text);

            int sonuc = topla(sayi1, sayi2);
            label12.Text = sonuc.ToString();


        }
    }
}
