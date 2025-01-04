

using System.Data.SqlClient;

namespace Ado.Net_İLe_VeriTabanı_Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=Gamze\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            // update personel_table set Ad="Zeyno", Soyad="Yılmaz", ...
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE personel_table SET Ad= @AD, Soyad= @Soyad, Adres= @Adres WHERE Personel_id = @Personel_id", sqlConnection);
                cmd.Parameters.AddWithValue("@Ad", textBox2.Text);
                cmd.Parameters.AddWithValue("@Soyad", textBox3.Text);
                cmd.Parameters.AddWithValue("@Adres", textBox4.Text);
                cmd.Parameters.AddWithValue("@Personel_id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı bir şekilde güncellendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası oluştu!");
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM personel_table WHERE Personel_id = " + textBox5.Text, sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı bir şekilde silindi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası oluştu!");
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
    }
}
