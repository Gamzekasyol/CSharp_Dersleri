namespace Oop_class_object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElektrikliOtomobil audielektriklioto = new ElektrikliOtomobil(240,"Kýrmýzý","Çelik");

            richTextBox1.Text = "Renk: " + audielektriklioto.Renk + " Cant: " + audielektriklioto.Cant +" "+ audielektriklioto.sarjDurumunuGetir();

            
            BenzinliOtomobil audibenzinlioto = new BenzinliOtomobil(50, "Mavi", "Metal");
            audibenzinlioto.Boy = 5;
            richTextBox1.Text = "Renk: " + audibenzinlioto.Renk + " Cant: " + audibenzinlioto.Cant + " " + audibenzinlioto.benzinDurumunuGetir()+ "\n En: "+ audibenzinlioto.En+ "\n Boy: "+ audibenzinlioto.Boy;

            
        }
    }
}
