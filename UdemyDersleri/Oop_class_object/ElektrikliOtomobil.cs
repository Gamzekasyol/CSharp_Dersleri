using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_class_object
{
    internal class ElektrikliOtomobil: Otomobil
    {
        private int sarjDurumu;

        public string sarjDurumunuGetir()
        {
            return sarjDurumu + "khW";
        }
        public void sarjEt()
        {
            this.sarjDurumu = 240;
        }

        public ElektrikliOtomobil(int sarjDurumu, string renk, string cant)
        {
            this.sarjDurumu = sarjDurumu;
            this.Renk = renk;
            this.Cant = cant;

        }

    }
}
