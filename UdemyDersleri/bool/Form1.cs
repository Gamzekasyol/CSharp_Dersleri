namespace bool_;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }


    private bool durum(int sayi1)
    {

        if (sayi1 % 2 == 0)
        {
            label1.Text = "Girilen say� �ift say�d�r.";
            return true;
        }
        else
        {
            label1.Text = "Girilen say� tek say�d�r.";
            return false;
        }
       

     }

    private void button1_Click(object sender, EventArgs e)
    {
        int number = int.Parse(textBox1.Text);
        durum(number);


    }
}
