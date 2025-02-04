using System;
using labøvelse_3;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.SetNummer1(10);
            kalkulator.SetNummer2(5);
            kalkulator.addisjon();
            kalkulator.subtraksjon();
            kalkulator.multiplikasjon();
            kalkulator.divisjon();
        }
    }
}