using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Samochod : IZwiekszany , IZmniejszany
    {
        private int predkosc;
        int IZwiekszany.Zmien { get { return predkosc + 10; }  }
        int IZmniejszany.Zmien { get { return predkosc - 5; } }
        public Samochod(int pred)
        {
            this.predkosc = pred;
        }
    }
}
