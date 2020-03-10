using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardStatickeVarijable
{
    class PrvaKlasa
    {
        string ime;
        int godina;

        static int brojac = 0;

        public override string ToString()
        {
            string ispis = "\n Ime: " + ime + "\n Godiste:" + godina + "g" + "\n RB: " + brojac;
            return ispis;
        }

        public string Ime { get => ime; set => ime = value; }
        public int Godina { get => godina; set => godina = value; }

        public PrvaKlasa(string ime, int godina)
        {
            brojac++;
            this.ime = ime;
            this.godina = godina;
        }
    }
}
