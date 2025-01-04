namespace KutuphaneYonetimSıstemi
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttongiris = new Button();
            textBoxkullaniciadi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxsifre = new TextBox();
            SuspendLayout();
            // 
            // buttongiris
            // 
            buttongiris.Font = new Font("Neue Haas Grotesk Text Pro Medi", 12F);
            buttongiris.Location = new Point(227, 253);
            buttongiris.Name = "buttongiris";
            buttongiris.Size = new Size(158, 58);
            buttongiris.TabIndex = 0;
            buttongiris.Text = "Giriş";
            buttongiris.UseVisualStyleBackColor = true;
            buttongiris.Click += buttongiris_Click;
            // 
            // textBoxkullaniciadi
            // 
            textBoxkullaniciadi.Location = new Point(278, 126);
            textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            textBoxkullaniciadi.Size = new Size(230, 27);
            textBoxkullaniciadi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Neue Haas Grotesk Text Pro Medi", 12F);
            label1.Location = new Point(122, 128);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Neue Haas Grotesk Text Pro Medi", 12F);
            label2.Location = new Point(122, 193);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 4;
            label2.Text = "Şifre: ";
            // 
            // textBoxsifre
            // 
            textBoxsifre.Location = new Point(278, 191);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.Size = new Size(230, 27);
            textBoxsifre.TabIndex = 3;
            textBoxsifre.UseSystemPasswordChar = true;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(638, 395);
            Controls.Add(label2);
            Controls.Add(textBoxsifre);
            Controls.Add(label1);
            Controls.Add(textBoxkullaniciadi);
            Controls.Add(buttongiris);
            Name = "Giris";
            Text = "Kütüphane Kullanıcı Giriş ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttongiris;
        private TextBox textBoxkullaniciadi;
        private Label label1;
        private Label label2;
        private TextBox textBoxsifre;
    }
}
