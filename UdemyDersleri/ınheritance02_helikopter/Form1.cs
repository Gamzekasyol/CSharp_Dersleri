namespace ınheritance02_helikopter
{
    public partial class helikopter : Form
    {
        Helikopter heli1;
        public helikopter()
        {
            InitializeComponent();

            InitmyHeli();
        }

        private void InitmyHeli()
        {
            Motor motor = new Motor(200, 350, pictureBox1, richTextBox1);
            Pervane pervane = new Pervane(10, 500);
            pervane.Uzunluk = 15;
            heli1 = new Helikopter(200, "GK-2002", motor, pervane);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            heli1.helikopteriCalistir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            heli1.helikopteriDurdur();
        }
    }
}
