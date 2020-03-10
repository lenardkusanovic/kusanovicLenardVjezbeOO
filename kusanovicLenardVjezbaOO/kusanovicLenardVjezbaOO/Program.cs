using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardVjezbaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            float prosjekKata;

            Neboder Tower = new Neboder(200,100);

            Tower.setVisina(Tower.getVisina() + 10);
            Tower.setBrojKatova(Tower.getBrojKatova() + 1);

            prosjekKata = Tower.getVisina() / Tower.getBrojKatova();

            
            
            Console.WriteLine(Tower.ToString() + "\n Prosjecna visina kata: " + prosjekKata "m";);
            Console.ReadKey();


        }
    }
}
