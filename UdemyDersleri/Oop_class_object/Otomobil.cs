using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_class_object
{
    internal class Otomobil
    {

        private string renk;
        private string cant;
        private string model = "Audi";
        private int en = 2;
        private int boy = 5;

        public int Boy { get; set; }
        public string Renk { get; set; }
        public string Cant { get; set; }

        public int En { get { return en; } }

        public Otomobil()
        { }

        public  Otomobil(string renk, string cant)
        {
             this.Renk= renk;
             this.Cant = cant;
           
        }
         
       

        public string modelGoster()
        {
            return model;
        }
    }
}
