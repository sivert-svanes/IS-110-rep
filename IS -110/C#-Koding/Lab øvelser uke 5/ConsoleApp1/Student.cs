using System;

namespace Labøvo1;

    class Student
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public double Gjennomsnittskarakter { get; set; }

        public void SkrivInfo()
        {
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Alder: {Alder}");
            Console.WriteLine($"Gjennomsnittskarakter: {Gjennomsnittskarakter}");
        }

        public bool HarBestått()
        {
            return Gjennomsnittskarakter >= 4.0;
        }

        public double ForventetKarakterEtterXÅr(double forbedring, int year)
        {
            return Gjennomsnittskarakter + forbedring * year;
        }

        public char GetFirstCharacter(string Navn)
    {
      if (string.IsNullOrEmpty(Navn))
      {
        throw new ArgumentException("Input string cannot be null or empty.");
      }
      return Navn[0];
    }
    }







/*
 Legg til en funksjon i klassen som heter "ForventetKarakterEtterXÅr(double forbedring)".

Denne skal ta inn et tall som parameter (forventet forbedring per år), legge det til gjennomsnittskarakteren, og returnere resultatet.
Bruk funksjonen i "Program.cs" og skriv ut studentens forventede karakter om 2 år. La oss si at det blir en "1.0" forbedring per år.
*/






/*
Lag en klasse som heter "Student".
Klassen skal ha følgende egenskaper:    
string Navn
int Alder
double Gjennomsnittskarakter
Klassen skal ha følgende metoder:
SkrivInfo(): En metode uten returverdi som skriver ut informasjon om studenten.
HarBestått(): En metode som returnerer "bool" og sjekker om gjennomsnittskarakteren er 4.0 eller høyere (bestått).
*/