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
            Console.WriteLine("////////////////");
            Console.WriteLine("Base: " + baseRettangolo +" cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro(baseRettangolo, altezzaRettangolo) + " cm");
            Console.WriteLine("Area:  " + calcolaArea(baseRettangolo, altezzaRettangolo) + " cm²");
            Console.WriteLine("////////////////");
        }
        public void discegnaRettangolo()
        {
            for (int i = 0; i <= baseRettangolo; i++)
            {
                if (i == 0)
                {
                    Console.Write(" -");
                }
                else if (i == baseRettangolo)
                {
                    Console.Write("- ");
                }
                else
                {
                    Console.Write("--");
                }
            }
            
            Console.WriteLine();

            for (int i = 0; i < altezzaRettangolo; i++)
            {
                Console.Write("|");
                for (int j = 0; j < baseRettangolo; j++)
                {
                    Console.Write("  ");

                }
                Console.WriteLine("|");
            }

            for (int i = 0; i <= baseRettangolo; i++)
            {
                if (i == 0)
                {
                    Console.Write(" -");
                }
                else if (i == baseRettangolo)
                {
                    Console.Write("- ");
                }
                else
                {
                    Console.Write("--");
                }
            }


        }
    }
}
