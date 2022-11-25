using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public int calcolaArea(int baseR, int altezzaR) 
        {
            return baseR * altezzaR;
        }
        public int calcolaPerimetro(int baseR, int altezzaR)
        {
            return 2*(baseR + altezzaR);
        }
        public void stampaRettangolo()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Base: " + baseRettangolo +" cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro(baseRettangolo, altezzaRettangolo) + " cm");
            Console.WriteLine("Area:  " + calcolaArea(baseRettangolo, altezzaRettangolo) + " cm²");
            Console.WriteLine("---------------");
        }
    }
}
