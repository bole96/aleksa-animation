using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_Domaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artikal a1 = new Hrana(8, "Plazma", 190);
            Artikal a2 = new Hrana(12, "Mleko", 250);
            Artikal p1 = new Pice(45,"Rakija", 455);
            Artikal p2 = new Pice(15, "Vino", 899);

            Korpa k1 = new Korpa(4);
            IKupovina kupovina = k1;
            IProdaja prodaja = k1;

            kupovina.Dodaj(a1);
            kupovina.Dodaj(a2);
            kupovina.Dodaj(p1);
            kupovina.Dodaj(p2);

            Console.WriteLine(kupovina.ToString());
            prodaja.CenaKorpe();
            Console.WriteLine("Ukupna cena: " + prodaja.CenaKorpe());

            Console.ReadKey();
        }
    }
}
