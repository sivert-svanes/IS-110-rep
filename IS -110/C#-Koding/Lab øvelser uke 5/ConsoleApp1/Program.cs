using System;
using Labøvo1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Skriv inn navn:");
            student.Navn = Console.ReadLine();
            Console.WriteLine("Skriv inn alder:");
            student.Alder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv inn gjennomsnittskarakter:");
            student.Gjennomsnittskarakter = Convert.ToDouble(Console.ReadLine());
            student.SkrivInfo();
            Console.WriteLine(student.HarBestått());

            
            if (student.HarBestått())
            {
                Console.WriteLine("Studenten har bestått");
            }
            else
            {
                Console.WriteLine("Studenten har ikke bestått");
            }
            Console.WriteLine(student.ForventetKarakterEtterXÅr(1.0, 2));


            if (student.Alder >= 18 && student.Gjennomsnittskarakter >= 5.0)
            {
                Console.WriteLine($"{student.Navn} er 18år eller eldre og har en gjennomsnittskarakter på 5.0 eller høyere");
            }
            else if (student.Alder < 18 || (student.GetFirstCharacter(student.Navn) == 'S'))
            {
                Console.WriteLine($"{student.Navn} er yngre enn 18år eller har et navn som starter på 'S'");
            }
            else
            {
                Console.WriteLine("Ingen av parameterene ble oppfykt, drep deg selv");
            }





        }
    }
}



















/*
I "Program.cs" skal du opprette et objekt av "Student" klassen.
Be brukeren om å oppgi navn, alder og gjennomsnittskarakter, og bruk dette for å fylle ut egenskapene i Student objektet.
*/