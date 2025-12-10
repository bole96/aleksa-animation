using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_Domaci
{
    internal class Korpa : IKupovina, IProdaja
    {

        private Artikal[] niz;
        private int brArtikala;

        public Korpa(int maxArt)
        {
            this.brArtikala = 0;
            this.niz = new Artikal[maxArt];
        }

        void IKupovina.Dodaj(Artikal a)
        {
            if(brArtikala < niz.Length)
            {
                niz[brArtikala++] = a;
            }
            else
            {
                Console.WriteLine("Nema mesta");
            }
        }

        float IProdaja.CenaKorpe()
        {
            float ukupnaCena = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] != null)   
                {
                    ukupnaCena += niz[i].ProdajnaCena();
                }
            }

            return ukupnaCena;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Artikal a in niz)
            {
                if(a != null)
                {
                    sb.AppendLine(a.ToString());
                }
            }
            if(sb.Length == 0)
            {
                sb.AppendLine("Nema artikala u nizu.");
            }
            return sb.ToString();
        }

    }
}
