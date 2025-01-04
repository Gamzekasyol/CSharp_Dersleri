using System.Data.SqlClient;

namespace KutuphaneYonetimSıstemi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection sqlconnection = new SqlConnection(@"Data Source=Gamze\SQLEXPRESS;Initial Catalog=Db_Kutuphane;Integrated Security=True");
        Kitaplar kitaplar;
        private void buttongiris_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT sifre FROM TableKutuphaneYoneticileri Where Kullanıcı_Adı =@p1", sqlconnection);
                cmd.Parameters.AddWithValue("@p1", textBoxkullaniciadi.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                // veri tabaına girip ordaki sifreyi sifre değişkenine atar.
                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                   
                }

                // şifre değişkenini arayüzde girilen şifre ile karşılaştırır.
                if (sifre == textBoxsifre.Text)
                {
                    kitaplar = new Kitaplar();
                    this.Hide(); // Diğer sayfa açılınca mevcut sayfayı saklar.
                    kitaplar.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreyi tekrar deneyiniz.");
                    textBoxkullaniciadi.Text = "";
                    textBoxsifre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası!" + ex.Message);
            }
            finally { sqlconnection.Close(); }

        }
    }
}
