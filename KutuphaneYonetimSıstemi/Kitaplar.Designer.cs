namespace KutuphaneYonetimSıstemi
{
    partial class Kitaplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            button2 = new Button();
            btnDelete = new Button();
            button3 = new Button();
            groupBox5 = new GroupBox();
            buttonkitapEkle = new Button();
            buttonkitapGuncelle = new Button();
            btnBookDelete = new Button();
            textBoxkitapturkodu = new TextBox();
            label7 = new Label();
            label4 = new Label();
            textBoxisbn = new TextBox();
            textBoxyazaradi = new TextBox();
            label5 = new Label();
            textBoxyazarsoyadi = new TextBox();
            label6 = new Label();
            labelid = new Label();
            label2 = new Label();
            textBoxkitapadi = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonkitapAl = new Button();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            textBoxoduncalma = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            buttoniadeEt = new Button();
            label13 = new Label();
            labelodeme = new Label();
            buttongecilkmebedelihesapla = new Button();
            label11 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(textBoxkitapturkodu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxisbn);
            groupBox1.Controls.Add(textBoxyazaradi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxyazarsoyadi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(labelid);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxkitapadi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(632, 424);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kaydet ve Güncelle";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button2);
            groupBox6.Controls.Add(btnDelete);
            groupBox6.Controls.Add(button3);
            groupBox6.Location = new Point(342, 318);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(290, 100);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            groupBox6.Text = "Arama";
            // 
            // button2
            // 
            button2.Location = new Point(3, 26);
            button2.Name = "button2";
            button2.Size = new Size(81, 55);
            button2.TabIndex = 15;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(204, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 53);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Temizle";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.Location = new Point(89, 26);
            button3.Name = "button3";
            button3.Size = new Size(113, 55);
            button3.TabIndex = 16;
            button3.Text = "Tüm Kitapları Göster";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonkitapEkle);
            groupBox5.Controls.Add(buttonkitapGuncelle);
            groupBox5.Controls.Add(btnBookDelete);
            groupBox5.Location = new Point(8, 318);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(328, 100);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kayıt Düzenleme İşlemleri";
            // 
            // buttonkitapEkle
            // 
            buttonkitapEkle.Location = new Point(6, 26);
            buttonkitapEkle.Name = "buttonkitapEkle";
            buttonkitapEkle.Size = new Size(86, 53);
            buttonkitapEkle.TabIndex = 12;
            buttonkitapEkle.Text = "Yeni Kitap Ekle";
            buttonkitapEkle.UseVisualStyleBackColor = true;
            buttonkitapEkle.Click += buttonkitapEkle_Click;
            // 
            // buttonkitapGuncelle
            // 
            buttonkitapGuncelle.Location = new Point(98, 26);
            buttonkitapGuncelle.Name = "buttonkitapGuncelle";
            buttonkitapGuncelle.Size = new Size(124, 53);
            buttonkitapGuncelle.TabIndex = 13;
            buttonkitapGuncelle.Text = "Kitap Bilgilerini Güncelle";
            buttonkitapGuncelle.UseVisualStyleBackColor = true;
            buttonkitapGuncelle.Click += buttonkitapGuncelle_Click;
            // 
            // btnBookDelete
            // 
            btnBookDelete.Location = new Point(228, 26);
            btnBookDelete.Name = "btnBookDelete";
            btnBookDelete.Size = new Size(84, 53);
            btnBookDelete.TabIndex = 14;
            btnBookDelete.Text = "Kitap Sil";
            btnBookDelete.UseVisualStyleBackColor = true;
            btnBookDelete.Click += btnBookDelete_Click;
            // 
            // textBoxkitapturkodu
            // 
            textBoxkitapturkodu.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxkitapturkodu.Location = new Point(177, 275);
            textBoxkitapturkodu.Name = "textBoxkitapturkodu";
            textBoxkitapturkodu.Size = new Size(274, 30);
            textBoxkitapturkodu.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F);
            label7.Location = new Point(8, 278);
            label7.Name = "label7";
            label7.Size = new Size(181, 23);
            label7.TabIndex = 11;
            label7.Text = "Kitap Türü Kodu: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F);
            label4.Location = new Point(18, 227);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 9;
            label4.Text = "ISBN:";
            // 
            // textBoxisbn
            // 
            textBoxisbn.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxisbn.Location = new Point(178, 227);
            textBoxisbn.Name = "textBoxisbn";
            textBoxisbn.Size = new Size(274, 30);
            textBoxisbn.TabIndex = 8;
            // 
            // textBoxyazaradi
            // 
            textBoxyazaradi.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxyazaradi.Location = new Point(178, 128);
            textBoxyazaradi.Name = "textBoxyazaradi";
            textBoxyazaradi.Size = new Size(274, 30);
            textBoxyazaradi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F);
            label5.Location = new Point(18, 133);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 6;
            label5.Text = "Yazar Adı: ";
            // 
            // textBoxyazarsoyadi
            // 
            textBoxyazarsoyadi.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxyazarsoyadi.Location = new Point(178, 175);
            textBoxyazarsoyadi.Name = "textBoxyazarsoyadi";
            textBoxyazarsoyadi.Size = new Size(274, 30);
            textBoxyazarsoyadi.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F);
            label6.Location = new Point(18, 180);
            label6.Name = "label6";
            label6.Size = new Size(145, 23);
            label6.TabIndex = 4;
            label6.Text = "Yazar Soyadı: ";
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Microsoft Sans Serif", 12F);
            labelid.Location = new Point(188, 41);
            labelid.Name = "labelid";
            labelid.Size = new Size(19, 25);
            labelid.TabIndex = 3;
            labelid.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F);
            label2.Location = new Point(21, 41);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 2;
            label2.Text = "Kitap ID: ";
            // 
            // textBoxkitapadi
            // 
            textBoxkitapadi.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxkitapadi.Location = new Point(178, 81);
            textBoxkitapadi.Name = "textBoxkitapadi";
            textBoxkitapadi.Size = new Size(274, 30);
            textBoxkitapadi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F);
            label1.Location = new Point(21, 86);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonkitapAl);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxoduncalma);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(649, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 397);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Alma ";
            // 
            // buttonkitapAl
            // 
            buttonkitapAl.Location = new Point(87, 214);
            buttonkitapAl.Name = "buttonkitapAl";
            buttonkitapAl.Size = new Size(118, 56);
            buttonkitapAl.TabIndex = 14;
            buttonkitapAl.Text = "Kitap Ödünç Ver";
            buttonkitapAl.UseVisualStyleBackColor = true;
            buttonkitapAl.Click += buttonkitapAl_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 12F);
            label9.Location = new Point(7, 123);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 16;
            label9.Text = "Alınan Tarih";
            // 
            // textBoxoduncalma
            // 
            textBoxoduncalma.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxoduncalma.Location = new Point(137, 54);
            textBoxoduncalma.Name = "textBoxoduncalma";
            textBoxoduncalma.Size = new Size(159, 30);
            textBoxoduncalma.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F);
            label8.Location = new Point(6, 55);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 14;
            label8.Text = "Ödünç Alan:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttoniadeEt);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(labelodeme);
            groupBox3.Controls.Add(buttongecilkmebedelihesapla);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(979, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(239, 397);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "İade İşlemleri";
            // 
            // buttoniadeEt
            // 
            buttoniadeEt.Location = new Point(66, 209);
            buttoniadeEt.Name = "buttoniadeEt";
            buttoniadeEt.Size = new Size(118, 56);
            buttoniadeEt.TabIndex = 20;
            buttoniadeEt.Text = "İade Et";
            buttoniadeEt.UseVisualStyleBackColor = true;
            buttoniadeEt.Click += buttoniadeEt_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 12F);
            label13.Location = new Point(197, 55);
            label13.Name = "label13";
            label13.Size = new Size(36, 23);
            label13.TabIndex = 19;
            label13.Text = "TL";
            // 
            // labelodeme
            // 
            labelodeme.AutoSize = true;
            labelodeme.Font = new Font("Century", 12F);
            labelodeme.Location = new Point(150, 58);
            labelodeme.Name = "labelodeme";
            labelodeme.Size = new Size(21, 23);
            labelodeme.TabIndex = 18;
            labelodeme.Text = "0";
            // 
            // buttongecilkmebedelihesapla
            // 
            buttongecilkmebedelihesapla.Location = new Point(66, 126);
            buttongecilkmebedelihesapla.Name = "buttongecilkmebedelihesapla";
            buttongecilkmebedelihesapla.Size = new Size(118, 56);
            buttongecilkmebedelihesapla.TabIndex = 14;
            buttongecilkmebedelihesapla.Text = "Gecikme Bedeli Hesapla";
            buttongecilkmebedelihesapla.UseVisualStyleBackColor = true;
            buttongecilkmebedelihesapla.Click += buttongecilkmebedelihesapla_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 12F);
            label11.Location = new Point(6, 55);
            label11.Name = "label11";
            label11.Size = new Size(150, 23);
            label11.TabIndex = 14;
            label11.Text = "Ödeme Bedeli: ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(1, 440);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1217, 169);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1211, 143);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Kitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1230, 621);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Kitaplar";
            Text = "Kütüphane Yönetim Sistemi";
            FormClosed += Kitaplar_FormClosed;
            Load += Kitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxkitapadi;
        private Label label1;
        private GroupBox groupBox2;
        private Button buttonkitapEkle;
        private Label label7;
        private TextBox textBoxkitapturkodu;
        private Label label4;
        private TextBox textBoxisbn;
        private TextBox textBoxyazaradi;
        private Label label5;
        private TextBox textBoxyazarsoyadi;
        private Label label6;
        private Label labelid;
        private Label label2;
        private Button buttonkitapGuncelle;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox textBoxoduncalma;
        private Label label8;
        private Button buttonkitapAl;
        private GroupBox groupBox3;
        private Button buttoniadeEt;
        private Label label13;
        private Label labelodeme;
        private Button buttongecilkmebedelihesapla;
        private Label label11;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button button2;
        private Button btnBookDelete;
        private Button button3;
        private Button btnDelete;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
    }
}