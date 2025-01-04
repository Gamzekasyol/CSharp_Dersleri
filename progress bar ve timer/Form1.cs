using System.Timers;

namespace progress_bar_ve_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 90)
                progressBar1.Value += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
        }
    }
}
