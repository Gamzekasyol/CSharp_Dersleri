namespace Fonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // TOPLAMA ÝÞLEMÝ
        private int ToplaveGöster(int sayi1, int sayi2)
        {
            int topla = sayi1 + sayi2;
            return topla;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            int top = ToplaveGöster(sayi1, sayi2);
            label1.Text = top.ToString();
        }


        // ÇARPMA ÝÞLEMÝ
        private int CarpveGoster(int sayi1, int sayi2)
        {
            int carp = sayi1 * sayi2;
            return carp;
        }

        private void buttoncarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBoxcarp1.Text);
            int sayi2 = Convert.ToInt32(textBoxcarp2.Text);
            int carpma = CarpveGoster(sayi1, sayi2);
            label6.Text = carpma.ToString();
        }


        // BÖLME ÝÞLEMÝ 

        private int BolveGoster()
        {
            int sayi1 = Convert.ToInt32(textBoxbolme1.Text);
            int sayi2 = Convert.ToInt32(textBoxbolme2.Text);
            int bol = sayi1 / sayi2;
            return bol;
        }
        private void buttonbolme_Click(object sender, EventArgs e)
        {
            label9.Text = BolveGoster().ToString();

        }

        // ÝSÝM 

        private string ÝsimGoster()
        {
            string isim = textBoxisim.Text;
            return isim;
            
        }
        private void buttongoster_Click(object sender, EventArgs e)
        {
            labelisim.Text = ÝsimGoster();

        }
    }
}
