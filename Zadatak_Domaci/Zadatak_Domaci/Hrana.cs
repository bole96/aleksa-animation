using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_Domaci
{
    internal class Hrana : Artikal
    {
        protected float preostaliRokUpotrebe;

        public Hrana(float preostaliRokUpotrebe, string naziv, int cena) : base(naziv, cena)
        {
            this.preostaliRokUpotrebe = preostaliRokUpotrebe;
        }

        public override float ProdajnaCena()
        {
            if(preostaliRokUpotrebe < 10)
            {
                return (float)cena * 0.6f;
            }
            else
            {
                return cena;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Rok upotrebe: {preostaliRokUpotrebe}";
        }

    }
}
