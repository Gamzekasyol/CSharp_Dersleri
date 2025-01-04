namespace Döngüler
{
    partial class Form1
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
            buttontopla = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            labelsonuc = new Label();
            panel1 = new Panel();
            textBoxbaslangic = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxbitiş = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttontopla
            // 
            buttontopla.Location = new Point(258, 34);
            buttontopla.Name = "buttontopla";
            buttontopla.Size = new Size(106, 46);
            buttontopla.TabIndex = 0;
            buttontopla.Text = "Topla";
            buttontopla.UseVisualStyleBackColor = true;
            buttontopla.Click += buttontopla_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Sonuç: ";
            // 
            // labelsonuc
            // 
            labelsonuc.AutoSize = true;
            labelsonuc.Location = new Point(494, 47);
            labelsonuc.Name = "labelsonuc";
            labelsonuc.Size = new Size(50, 20);
            labelsonuc.TabIndex = 3;
            labelsonuc.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelsonuc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(buttontopla);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 186);
            panel1.TabIndex = 4;
            // 
            // textBoxbaslangic
            // 
            textBoxbaslangic.Location = new Point(55, 324);
            textBoxbaslangic.Name = "textBoxbaslangic";
            textBoxbaslangic.Size = new Size(125, 27);
            textBoxbaslangic.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 269);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 6;
            label2.Text = "Başlangıç Değeri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 269);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 8;
            label3.Text = "Bitiş  Değeri";
            // 
            // textBoxbitiş
            // 
            textBoxbitiş.Location = new Point(261, 324);
            textBoxbitiş.Name = "textBoxbitiş";
            textBoxbitiş.Size = new Size(125, 27);
            textBoxbitiş.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(548, 250);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Sonuç";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(548, 293);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(258, 252);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(413, 303);
            button1.Name = "button1";
            button1.Size = new Size(114, 48);
            button1.TabIndex = 11;
            button1.Text = "Çift Sayıları Bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 579);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxbitiş);
            Controls.Add(label2);
            Controls.Add(textBoxbaslangic);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttontopla;
        private TextBox textBox1;
        private Label label1;
        private Label labelsonuc;
        private Panel panel1;
        private TextBox textBoxbaslangic;
        private Label label2;
        private Label label3;
        private TextBox textBoxbitiş;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}
