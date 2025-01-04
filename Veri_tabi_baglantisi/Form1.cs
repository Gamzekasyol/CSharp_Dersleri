
using Microsoft.Data.SqlClient;

namespace Veri_tabi_baglantisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = null;
            
            try
            {
                sqlconnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Dbc#giri�;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                sqlconnection.Open();

                SqlCommand cmd = new SqlCommand("SELECT OgrenciID, OgrenciAd, Not1, Not2 FROM Table_1", sqlconnection);
                SqlDataReader sqlDR = cmd.ExecuteReader();

                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string �sim = sqlDR[1].ToString();
                    string not1 = sqlDR[2].ToString();
                    string not2 = sqlDR[3].ToString();

                    int ortalama = (Convert.ToInt32(not1) + Convert.ToInt32(not2)) / 2;

                    richTextBox1.Text = richTextBox1.Text + id + �sim + "  " + " Not1: " + not1 + " Not2: " + not2 + "  Ortalama: " + ortalama.ToString() ;

                    if (ortalama >= 50)
                    {
                        richTextBox1.Text = richTextBox1.Text + " Ge�ti! " +"\n";
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + " Kald�!" + "\n" ;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� hatas� olu�tu!"+ ex);
            }
            finally
            {
                if (sqlconnection != null)
                {
                    sqlconnection.Close();
                }
                
            }
        }
    }
}
