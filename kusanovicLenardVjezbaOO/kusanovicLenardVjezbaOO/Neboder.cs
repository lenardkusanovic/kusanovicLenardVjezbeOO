using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardVjezbaOO
{
    class Neboder
    {
        float visina;
        int brojKatova;

        public override string ToString(float prosjekKata)
        {
            string ispis = "\n Visina nebodera: " + visina + "m" + "\n Broj katova: " + brojKatova + "\n Prosjecna visina kata: " + prosjekKata "m";
            return ispis;
        }

        public float getVisina()
        {
            return visina;

        }

        public int getBrojKatova()
        {
            return brojKatova;
        }

        public void setVisina(float visina)
        {
            this.visina = visina;
        }

        public void setBrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }

        public Neboder(float visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }
    }
}
