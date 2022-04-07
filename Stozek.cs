using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    delegate void ObslugaBledu(string opisBledu);
    class Stozek
    {
        public event ObslugaBledu Blad;
        private double promien;
        public double Promien
        {
            get { return promien; }
            set
            {
                if (value <= 0) Blad("Zła wartość");
                promien = value;
            }
        }
        private double wysokosc;
        public double Wysokosc { 
            get { return wysokosc; } 
            set 
            { 
                if (value <= 0) Blad("Zła wartość");
                wysokosc = value;
            }
        }

    }
}
