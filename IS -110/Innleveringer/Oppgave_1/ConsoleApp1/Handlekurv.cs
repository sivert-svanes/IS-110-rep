using System;
using System.Collections.Generic;

namespace Oppgave_1
{
  public class Handlekurv
  {
    private List<double> varepriser = new List<double>();
    private double totalpris = 0;
    private int antallVarer = 0;

    public void LeggTilVare(double pris)
    {
      varepriser.Add(pris);
      totalpris += pris;
      antallVarer++;
    }

    public double BeregnTotal()
    {
      return totalpris;
    }

    public void SkrivKvittering()
    {
      Console.WriteLine("Kvittering:");
      foreach (double pris in varepriser)
      {
        Console.WriteLine(pris);
      }
      Console.WriteLine($"Totalpris: {totalpris}");
    }
  }  
}







/*
Klasse: du skal opprett en klasse som heter Handlekurv. Klassen kan ha felt som lagrer en liste over varepriser eller en summert totalpris. 
Den kan også lagre hvor mange varer som er lagt til.

Metoder:
Du skal lage en metode uten returverdi (f.eks. LeggTilVare) som tar inn en pris som parameter og legger det til en intern sum eller liste.
Du skal lage en metode med returverdi (f.eks. BeregnTotal) som returnerer totalprisen.
Du skal lage en metode uten returverdi (f.eks. SkrivKvittering) som skriver ut en enkel oversikt.

I Program.cs:
Du skal du opprette et objekt av Handlekurv.
Du skal skrive kode som gir mulighet til brukeren å velge hvor mange varer som skal legges inn i handlekurven.
Løkker: du skal skrive en løkke som leser inn pris for hver vare.
Kall LeggTilVare-metoden for hver pris.
IF-betingelse: når du har summert opp totalprisen, 
skal du sjekke om totalprisen er over en viss sum (f.eks. 500 kr) for å gi brukeren en melding om gratis frakt.
*/