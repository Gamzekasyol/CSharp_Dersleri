using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınheritance02_helikopter
{
    internal class Helikopter
    {
        private int hacim;
        private string kuyruk_nb;
        private Motor motor;
        private Pervane pervane;


     

        public Helikopter(int hacim, string kuyruk_nb, Motor motor, Pervane pervane)
        {
            this.hacim = hacim;
            this.kuyruk_nb = kuyruk_nb;
            this.motor = motor;
            this.pervane = pervane;
        }

        public void helikopteriCalistir()
        {
            motor.motoruCalistir();
        }
        public void helikopteriDurdur()
        {
            motor.motoruDurdur();
        }
    }
}
