// See https://aka.ms/new-console-template for more information
using Geometria;

Rettangolo rUno = new Rettangolo();
Console.WriteLine("Inserisci l'altezza del rettangolo");
rUno.altezzaRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci la base del rettangolo");
rUno.baseRettangolo = int.Parse(Console.ReadLine());

Console.Write("PERIMETRO:");
Console.WriteLine(rUno.calcolaPerimetro(rUno.baseRettangolo, rUno.altezzaRettangolo));
Console.Write("AREA:");
Console.WriteLine(rUno.calcolaArea(rUno.baseRettangolo, rUno.altezzaRettangolo));

rUno.stampaRettangolo();