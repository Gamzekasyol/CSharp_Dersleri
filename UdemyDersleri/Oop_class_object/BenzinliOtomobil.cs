using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_class_object
{
    internal class BenzinliOtomobil : Otomobil
    {
        private int benzinDurumu;

        public BenzinliOtomobil(int benzinDurumu, string renk, string cant)
        {
            this.benzinDurumu= benzinDurumu;
            this.Renk = renk;
            this.Cant = cant;
        }

        public string benzinDurumunuGetir()
        {
            return benzinDurumu + "lt";
        }
        public void benzinDoldur()
        {
            benzinDurumu = 50;
        }
    }
}
