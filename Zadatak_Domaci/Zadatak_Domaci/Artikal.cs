using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_Domaci
{
    internal abstract class Artikal
    {
        protected string naziv;
        protected int cena;

        public Artikal(string naziv, int cena)
        {
            this.naziv = naziv;
            this.cena = cena;
        }

        public virtual float ProdajnaCena()
        {
            return cena;
        }

        public override string ToString()
        {
            return $"Naziv: {naziv} Cena: {cena}";
        }


    }
}
