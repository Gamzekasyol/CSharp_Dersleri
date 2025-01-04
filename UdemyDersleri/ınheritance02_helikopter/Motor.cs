using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınheritance02_helikopter
{
    internal class Motor
    {
        private int beygirGucu;
        private int tork;
        private PictureBox pictureBox;
        private RichTextBox richTextBox;


    
     

        public Motor(int beygirgucu, int tork, PictureBox pictureBox, RichTextBox richTextBox)
        {
            this.beygirGucu = beygirgucu;
            this.tork = tork;
            this.pictureBox = pictureBox;
            this.richTextBox = richTextBox;
        }
        public void motoruCalistir()
        {
            richTextBox.Text = "Motor çalıştırılıyor";
            pictureBox.Load("C:\\Users\\Gamze\\Downloads\\helicalisan.jpg");

        }
        public void motoruDurdur()
        {
            richTextBox.Text = "Motor durduruluyor.";
            pictureBox.Load("C:\\Users\\Gamze\\Downloads\\heliduran.jpg");

        }

    }
}
