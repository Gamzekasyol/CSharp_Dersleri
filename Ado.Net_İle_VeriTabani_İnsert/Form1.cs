

using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Ado.Net_İle_VeriTabani_İnsert
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
            try
            {
                sqlConnection.Open();
                //string sql_cümlesi = "INSERT INTO personel_table VALUES('" + textBox1.Text + "', '" +
                //  textBox2.Text + "', '" +
                //  textBox3.Text + "', '" +
                //  textBox4.Text + "')";
                SqlCommand cmd = new SqlCommand( "INSERT INTO personel_table(Ad, Soyad, Adres, Personel_id) VALUES( @Ad, @Soyad, @Adres, @Personel_id)" , sqlConnection);
                cmd.Parameters.AddWithValue("@Ad", textBox2.Text);
                cmd.Parameters.AddWithValue("@Soyad", textBox3.Text);
                cmd.Parameters.AddWithValue("@Adres", textBox4.Text);
                cmd.Parameters.AddWithValue("@Personel_id", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();

            MessageBox.Show("Personel bilgileri eklendi");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantıda bir hata oluştu!" + ex);
            }
            finally 
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
                
            }

        }
    }
}
