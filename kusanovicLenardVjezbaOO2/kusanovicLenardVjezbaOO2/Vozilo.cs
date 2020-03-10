using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardVjezbaOO2
{
    class Vozilo
    {
        string vrsta;
        int maxBrzina;
        int brojKotaca;

        public override string ToString()
        {
            string ispis = "\nVrsta automobila: " + vrsta + "\n Max brzina: " + maxBrzina + "\n Broj kotaca:" + brojKotaca; 
            return ispis;
        }


        public string Vrsta { get => vrsta; set => vrsta = value; }
        public int MaxBrzina { get => maxBrzina; set => maxBrzina = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }

        public Vozilo(string vrsta, int maxBrzina, int brojKotaca)
        {
            this.vrsta = vrsta;
            this.maxBrzina = maxBrzina;
            this.brojKotaca = brojKotaca;
        }
    }
}
