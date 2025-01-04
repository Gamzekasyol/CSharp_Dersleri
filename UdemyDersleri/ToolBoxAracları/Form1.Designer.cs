namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            progressBar1 = new ProgressBar();
            buttonstart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonstop = new Button();
            buttonreset = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(309, 67);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(486, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(120, 195);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(561, 57);
            progressBar1.TabIndex = 4;
            // 
            // buttonstart
            // 
            buttonstart.Location = new Point(135, 289);
            buttonstart.Name = "buttonstart";
            buttonstart.Size = new Size(117, 41);
            buttonstart.TabIndex = 5;
            buttonstart.Text = "Start";
            buttonstart.UseVisualStyleBackColor = true;
            buttonstart.Click += buttonstart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonstop
            // 
            buttonstop.Location = new Point(549, 289);
            buttonstop.Name = "buttonstop";
            buttonstop.Size = new Size(117, 41);
            buttonstop.TabIndex = 6;
            buttonstop.Text = "Stop";
            buttonstop.UseVisualStyleBackColor = true;
            buttonstop.Click += buttonstop_Click;
            // 
            // buttonreset
            // 
            buttonreset.Location = new Point(325, 289);
            buttonreset.Name = "buttonreset";
            buttonreset.Size = new Size(117, 41);
            buttonreset.TabIndex = 7;
            buttonreset.Text = "Reset";
            buttonreset.UseVisualStyleBackColor = true;
            buttonreset.Click += buttonreset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonreset);
            Controls.Add(buttonstop);
            Controls.Add(buttonstart);
            Controls.Add(progressBar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ProgressBar progressBar1;
        private Button buttonstart;
        private System.Windows.Forms.Timer timer1;
        private Button buttonstop;
        private Button buttonreset;
    }
}
