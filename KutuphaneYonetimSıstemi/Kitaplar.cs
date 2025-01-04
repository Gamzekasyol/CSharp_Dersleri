using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSıstemi
{
    public partial class Kitaplar : Form
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=Gamze\SQLEXPRESS;Initial Catalog=Db_Kutuphane;Integrated Security=True");
        public Kitaplar()
        {
            InitializeComponent();
        }
        private void verileriGoster()
        {
            try
            {
                string komut = "SELECT * FROM TableKitaplar";
                SqlDataAdapter da = new SqlDataAdapter(komut, sqlconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası!" + ex.Message);
            }

        }
        private void Kitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonkitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TableKitaplar(KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTuruKodu) VALUES( @p1, @p2, @p3, @p4, @p5, @p6)", sqlconnection);
                cmd.Parameters.AddWithValue("@p1", textBoxkitapadi.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxyazaradi.Text);
                cmd.Parameters.AddWithValue("@p3", textBoxyazarsoyadi.Text);
                cmd.Parameters.AddWithValue("@p4", textBoxisbn.Text);
                cmd.Parameters.AddWithValue("@p5", "True");
                cmd.Parameters.AddWithValue("@p6", textBoxkitapturkodu.Text);
                cmd.ExecuteNonQuery();

                verileriGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası!" + ex.Message);
            }
            finally { sqlconnection.Close(); }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelodeme.Text = "0";
            // tıklanılan hücrenin satırlarını seçme
            int secilensatır = dataGridView1.SelectedCells[0].RowIndex;

            // seçilen satırı textlere yerleştirme 
            labelid.Text = dataGridView1.Rows[secilensatır].Cells[0].Value.ToString();
            textBoxkitapadi.Text = dataGridView1.Rows[secilensatır].Cells[1].Value.ToString();
            textBoxyazaradi.Text = dataGridView1.Rows[secilensatır].Cells[2].Value.ToString();
            textBoxyazarsoyadi.Text = dataGridView1.Rows[secilensatır].Cells[3].Value.ToString();
            textBoxisbn.Text = dataGridView1.Rows[secilensatır].Cells[4].Value.ToString();
            textBoxoduncalma.Text = dataGridView1.Rows[secilensatır].Cells[6].Value.ToString();
            textBoxkitapturkodu.Text = dataGridView1.Rows[secilensatır].Cells[8].Value.ToString();

            if (dataGridView1.Rows[secilensatır].Cells[7].Value != DBNull.Value)
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[secilensatır].Cells[7].Value;


        }

        private void buttonkitapGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TableKitaplar SET KitapAdi= @p1, YazarAdi= @p2, YazarSoyadi= @p3, ISBN= @p4, KitapTuruKodu= @p5 WHERE ID= @p6", sqlconnection);
                cmd.Parameters.AddWithValue("@p1", textBoxkitapadi.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxyazaradi.Text);
                cmd.Parameters.AddWithValue("@p3", textBoxyazarsoyadi.Text);
                cmd.Parameters.AddWithValue("@p4", textBoxisbn.Text);
                cmd.Parameters.AddWithValue("@p5", textBoxkitapturkodu.Text);
                cmd.Parameters.AddWithValue("@p6", labelid.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncellemede işlemi sırasında bağlantı hatası!" + ex.Message);
            }
            finally { sqlconnection.Close(); }
            verileriGoster();
        }

        private void buttonkitapAl_Click(object sender, EventArgs e)
        {
            if (labelid.Text != "-")
            {
                try
                {
                    sqlconnection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TableKitaplar SET Oduncalan= @p1, OduncAlmaTarihi= @p2, Durum= @p3 WHERE ID= @p6", sqlconnection);
                    cmd.Parameters.AddWithValue("@p1", textBoxoduncalma.Text);
                    cmd.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    cmd.Parameters.AddWithValue("@p3", "false");
                    cmd.Parameters.AddWithValue("@p6", labelid.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödüç verme işlemi sırasında bağlantı hatası!" + ex.Message);
                }
                finally { sqlconnection.Close(); }
                verileriGoster();

            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız.");
            }
        }

        private void buttongecilkmebedelihesapla_Click(object sender, EventArgs e)
        {
            if (labelid.Text != "_")
            {
                DateTime today = DateTime.Now;
                int gunfarki = (int)(today - dateTimePicker1.Value.Date).TotalDays;
                if (gunfarki > 10)
                {
                    int gecikmeBedeli = (gunfarki - 10) * 1;
                    labelodeme.Text = gecikmeBedeli.ToString();
                }

            }
        }

        private void buttoniadeEt_Click(object sender, EventArgs e)
        {
            if (labelid.Text != "-")
            {
                try
                {
                    sqlconnection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TableKitaplar SET Oduncalan= @p1, OduncAlmaTarihi= @p2, Durum= @p3 WHERE ID= @p6", sqlconnection);
                    cmd.Parameters.AddWithValue("@p1", "");
                    cmd.Parameters.Add("@p2", SqlDbType.Date).Value = DBNull.Value;
                    cmd.Parameters.AddWithValue("@p3", "True");
                    cmd.Parameters.AddWithValue("@p6", labelid.Text);
                    cmd.ExecuteNonQuery();
                    textBoxoduncalma.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İade etme işemi sırasında bağlantı hatası!" + ex.Message);
                }
                finally { sqlconnection.Close(); }
                verileriGoster();

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi Like '"
                    + textBoxkitapadi.Text + "%' And YazarAdi Like '"
                    + textBoxyazaradi.Text + "%' And YazarSoyadi Like '"
                    + textBoxyazarsoyadi.Text + "%' And ISBN Like '"
                    + textBoxisbn.Text + "%' And KitapTuruKodu Like '"
                    + textBoxkitapturkodu.Text + "%' And OduncAlan Like '"
                    + textBoxoduncalma.Text + "%' ";


                SqlDataAdapter da = new SqlDataAdapter(q, sqlconnection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası!" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
        public void txtClear()
        {
            textBoxkitapadi.Text = "";
            textBoxyazaradi.Text = "";
            textBoxyazarsoyadi.Text = "";
            textBoxisbn.Text = "";
            textBoxkitapturkodu.Text = "";
            textBoxoduncalma.Text = "";
            labelid.Text = "-";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtClear();

        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (labelid.Text == "-" || labelid.Text == "")
            {
                MessageBox.Show("Lütfen lisateden silinecek kitabı seçiniz.");
            }
            else
            {

                try
                {
                    sqlconnection.Open();
                    SqlCommand cmd = new SqlCommand("Delete from TableKitaplar Where ID = @p1", sqlconnection);
                    cmd.Parameters.AddWithValue("@p1", labelid.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bağlantı hatası!" + ex.Message);
                }
                finally { sqlconnection.Close(); }
                verileriGoster();
                txtClear();
            }
        }

        private void Kitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Sayfada çarpıya basınca uygulmayı kapatır.
        }
    }
}


