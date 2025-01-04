using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınheritance02_helikopter
{
    internal class Pervane
    {
        private int uzunluk;
        private int rpm; //(dk dönüş sayısı)

        public int Uzunluk { get; set; }
        public int Rpm { get; set; }

        public  Pervane(int uzunluk, int rpm)
        {
            this.uzunluk = uzunluk;
            this.rpm = rpm; 
        }
    }
}
