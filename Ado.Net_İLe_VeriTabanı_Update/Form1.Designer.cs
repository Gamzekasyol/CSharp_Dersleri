namespace Ado.Net_İLe_VeriTabanı_Update
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel id: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Ad: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Soyad: ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 193);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 200);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Adres: ";
            // 
            // button1
            // 
            button1.Location = new Point(94, 253);
            button1.Name = "button1";
            button1.Size = new Size(141, 56);
            button1.TabIndex = 8;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(59, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 340);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Güncelle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 37);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 10;
            label5.Text = "Personel id: ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(150, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(134, 110);
            button2.Name = "button2";
            button2.Size = new Size(141, 56);
            button2.TabIndex = 9;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(400, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 325);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button1;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox5;
        private Button button2;
        private GroupBox groupBox2;
    }
}
