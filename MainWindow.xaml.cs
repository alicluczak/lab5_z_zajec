using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Generyki;

namespace lab5
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Dictionary<int, Student> dict;
        public MainWindow()
        {
            InitializeComponent();

            dict = new Dictionary<int, Student>();
            dict.Add(1, new Student("Kowalski"));
            dict.Add(2, new Student("Kowalski1"));
            dict.Add(4, new Student("Kowalski2"));
            dict.Add(6, new Student("Kowalski3"));
        }

        static void Tekst(string blad)
        {
            MessageBox.Show(blad);
        }
        static void Tekst2(string blad)
        {
          //lblTekst.Content = blad;
        }
        
        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            Stozek stoz = new Stozek();
            stoz.Blad += Tekst;
            stoz.Blad += Tekst2;
            stoz.Promien = -5;
            stoz.Wysokosc = 0;
        }
        
        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(txtAlbum.Text);
            if (dict.ContainsKey(a))
            {
                MessageBox.Show(dict[a].Nazwisko.ToString());
            }
            else
            {
                MessageBox.Show("Taki album nie istnieje");
            }
        }

        private void btnWiekszy_Click(object sender, RoutedEventArgs e)
        {
            double a = 2.0;
            double b = 3.0;
            string aa = "AA";
            string bb = "BB";
            Student stud1 = new Student("AAA", 3);
            Student stud2 = new Student("BBB", 3);
            var s = Wiekszy.ZnajdzWiekszy(a, b);
            var r = Wiekszy.ZnajdzWiekszy(aa, bb);
            var s1 = Wiekszy.ZnajdzWiekszy(stud1, stud2);
            MessageBox.Show($"Wynik: {s}, powinno być 3");
            MessageBox.Show($"Wynik: {r}, powinno być BB");
            MessageBox.Show($"Wynik: {s1.Nazwisko}, powinno być BBB");
        }

        private void btnZadDom1_Click(object sender, RoutedEventArgs e)
        {
            Samochod sam = new Samochod(1000);
            lbxLista.Items.Add(((IZmniejszany)sam).Zmien);
            lbxLista.Items.Add(((IZwiekszany)sam).Zmien);
        }
    }
}
