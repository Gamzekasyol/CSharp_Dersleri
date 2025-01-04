namespace DegişkenlerVeVeriTipleri
{
    public partial class Form1 : Form
    {
        string isim;
        int hesapla;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isim = textBox1.Text;
            textBox2.Text = textBox1.Text + 1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            hesapla = Convert.ToInt32(textBox1.Text) + 1;
            label1.Text = hesapla.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // float ve double veri tipi
            // f= 7 decimal digit d = 15 decimal digit

            float f = 5.1234567890f;  // 7 rakamına kadar yazar sonrasını göstermez!!
            double d = 5.123456789;
            textBox3.Text = d.ToString();

        }

        private void buttonhesapla_Click(object sender, EventArgs e)
        {
            double hesapla; 
            hesapla = (double)(Convert.ToInt16(textBoxnot1.Text) + Convert.ToInt16(textBoxnot2.Text) + Convert.ToInt16(textBoxnot1.Text)) / 3;  
            // double eklemek type casting yani tip dönüşyürmedir.
            textBoxsonucgoster.Text = hesapla.ToString();
        }
    }
}
