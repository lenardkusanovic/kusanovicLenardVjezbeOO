using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardVjezbaOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo auto = new Vozilo("Auto", 4);
            Console.WriteLine("Upisite maximalnu brzinu automobila: ");
            auto.MaxBrzina = Console.ReadLine(Convert.ToInt32());
        }
    }
}
