using System;
using Labøvelse2;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      Bil Ford = new Bil();
      Ford.Brand = "Mercedes";
      Ford.Model = "S-Class";
      Ford.Year = 1998;
      string brand = Ford.Brand;
      string model = Ford.Model;
      int year = Ford.Year;
      Console.WriteLine("Brand: " + brand + " Model: " + model + " Year: " + year);
    }
  }
}

/*
I Program.cs lag et objekt av "Bil" klassen, kall sett-metodene (for merke, modell, år) på det objektet og gi verdiene "Mercedes" som "merke", 
"S-Class" som "modell" og "1998" som "år" til hver sett-metode. Kall hent-metodene på objektet for å hente disse verdiene du satt, 
her skal du definere variabler i Program.cs som beholder de returnerte verdiene fra hent-metodene. 
Da skal du skrive ut verdiene som disse variablene beholder.^
*/  