using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public class Student : IComparable
    {
        public string Nazwisko { set; get; }
        public int Ocena { set; get; }

        public Student(string nazw)
        {
            this.Nazwisko = nazw;
        }

        public Student(string nazw, int ocen)
        {
            this.Nazwisko = nazw;
            this.Ocena = ocen;
        }
       
        public override string ToString()
        {
            return $"Nazwisko: {Nazwisko}, Ocena: {Ocena}";
        }
        public int CompareTo(object o)
        {
            return this.Nazwisko.CompareTo(((Student)o).Nazwisko);
        }
    }
    public static class Wiekszy
    {
        public static T ZnajdzWiekszy<T>(T l, T r) where T : IComparable
        {
            if (l.CompareTo(r) >= 0)
            {
                return l;
            }
            else
            {
                return r;
            }
        }

    }
    public class Regal<R>
    {
        public R Polka1 { set; get; }
        public R Polka2 { set; get; }
        public R Polka3 { set; get; }

        public Regal(R p1, R p2, R p3)
        {
            this.Polka1 = p1;
            this.Polka2 = p2;
            this.Polka3 = p3;
        }
        public override string ToString()
        {
            return $"Półka 1: {Polka1}, Półka 2: {Polka2}, Półka 3: {Polka3}";
        }

        public R WstawNaWolnaPolke (R a)
        {
            return a;
        }
    }
}
