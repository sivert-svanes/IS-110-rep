using System;

namespace labøvelse_3
{
    class Kalkulator
    {
        private decimal nummer1 { get; set; }
        private decimal nummer2 { get; set; }
        private decimal resultat { get; set; }

                public void SetNummer1(decimal value)
        {
            nummer1 = value;
        }

        public decimal GetNummer1()
        {
            return nummer1;
        }

        public void SetNummer2(decimal value)
        {
            nummer2 = value;
        }

        public decimal GetNummer2()
        {
            return nummer2;
        }

        public void SetResultat(decimal value)
        {
            resultat = value;
        }

        public decimal GetResultat()
        {
            return resultat;
        }

        public void addisjon()
        {
            resultat = nummer1 + nummer2;
            Console.WriteLine("Addisjon: " + resultat);
        }

        public void subtraksjon()
        {
            resultat = nummer1 - nummer2;
            Console.WriteLine("Subtraksjon: " + resultat);
        }
        public void multiplikasjon()
        {
            resultat = nummer1 * nummer2;
            Console.WriteLine("Multiplikasjon: " + resultat);
        }

        public void divisjon()
        {
            resultat = nummer1 / nummer2;
            Console.WriteLine("Divisjon: " + resultat);
        }
    }
}






/*
Lag en klasse og kall den "Kalkulator". Definer "nummer1", "nummer2" og "resultat" som desimale tall i klassen, 
her bruk C# sin automatiske egenskaper. 

Skrive koden som lager set og hent metoder for de instans variablene. 

Lag en metode eller flere metoder som tar verdiene for nummer1 og nummer2 fra brukeren og gjennomfør addisjon, 
subtraksjon, multiplikasjon og divisjon operasjoner på dem. 

Etterpå skal metoden/metodene skrive ut resultatet for hver matematisk operasjon til brukeren.

Lag et objekt av "Kalkulator" klassen i Program.cs og kall metoden/metodene på det objektet.
*/