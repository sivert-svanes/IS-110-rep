using System;

namespace Labøvelse2
{

public class Bil
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}
}

/*
Henvis til første forelesning når du jobber med denne øvelsen.

Lag en klasse "Bil" og definer "merke", "modell" og "år" som private string instansvariabler. Lag get/sett metoder som ikke returnerer noe verdi, 
men tar parameter som tilsvarer hver instansvariabel. Lag hent/get metoder som returnerer verdien til hver instansvariabel. 
I Program.cs lag et objekt av "Bil" klassen, kall sett-metodene (for merke, modell, år) på det objektet og gi verdiene "Mercedes" som "merke", 
"S-Class" som "modell" og "1998" som "år" til hver sett-metode. Kall hent-metodene på objektet for å hente disse verdiene du satt, 
her skal du definere variabler i Program.cs som beholder de returnerte verdiene fra hent-metodene. 
Da skal du skrive ut verdiene som disse variablene beholder.^
*/  