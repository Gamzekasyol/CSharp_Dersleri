namespace VeriTipleri_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncalculate_Click(object sender, EventArgs e)
        {
            // Kare Alan
            double kare_kenar = Convert.ToDouble(textBoxkarekenar.Text);
            double alan_kare = kare_kenar * kare_kenar;
            label5.Text = alan_kare.ToString();
            label5.Visible = true;

            // Dikt�rtgen Alan
            double dikdortgen_alan = Convert.ToDouble(textBoxkisakenar.Text) *
                Convert.ToDouble(textBoxuzunkenar.Text);
            labelalandikd�rtgen.Text = dikdortgen_alan.ToString();
            labelalandikd�rtgen.Visible= true;

            // �ember Alan 
            double cember_alan = Math.PI * (Convert.ToInt32(textBoxyaricap.Text) * Convert.ToInt32(textBoxyaricap.Text));
            labelalancember.Text = cember_alan.ToString();
            labelalancember.Visible = true;
        }
    }
}
