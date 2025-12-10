using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_Domaci
{
    internal class Pice : Artikal
    {
        protected float prAlkohola;

        public Pice(float prAlkohola, string naziv, int cena):base(naziv, cena)
        {
            this.prAlkohola = prAlkohola;
        }

        public override float ProdajnaCena()
        {
            return (float)cena * (1+prAlkohola / 100);
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Procenat alkohola: {prAlkohola}";
        }


    }
}
