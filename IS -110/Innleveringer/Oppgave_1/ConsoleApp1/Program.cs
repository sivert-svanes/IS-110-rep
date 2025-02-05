using Oppgave_1;
using System.Security.Cryptography;
using System;

class Program
{
    static void Main()
    {
        Handlekurv handlekurv = new Handlekurv();
        for (int i = 1; i < 100; i++)
        {
            try
            {
            Console.WriteLine($"Legg til prisen på vare {i} du ønsker å kjøpe: ");
            double pris = Convert.ToDouble(Console.ReadLine());
            handlekurv.LeggTilVare(pris);
            while (true)
            {
                Console.WriteLine("Ønsker du å kjøpe flere varer: Ja / Nei ");
                string svar = Console.ReadLine().ToLower();
                if (svar == "ja")
                {
                    // Gå tilbake til linje 12
                    break;
                }
                else if (svar == "nei")
                {
                    if (handlekurv.BeregnTotal() > 500)
                    {
                        Console.WriteLine("Du har fått gratis frakt!");
                        handlekurv.SkrivKvittering();
                    }
                    else
                    {
                        handlekurv.SkrivKvittering();
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Du har skrevet feil input");
                    continue;
                }
            }   }
            catch (Exception e)
            {
                Console.WriteLine(e);
                i--;
            }
        }
    }
}


/*
Du skal du opprette et objekt av Handlekurv.
Du skal skrive kode som gir mulighet til brukeren å velge hvor mange varer som skal legges inn i handlekurven.
*/

    /*
    Du skal du opprette et objekt av Handlekurv.
Du skal skrive kode som gir mulighet til brukeren å velge hvor mange varer som skal legges inn i handlekurven.
Løkker: du skal skrive en løkke som leser inn pris for hver vare.
Kall LeggTilVare-metoden for hver pris.
IF-betingelse: når du har summert opp totalprisen, 
skal du sjekke om totalprisen er over en viss sum (f.eks. 500 kr) for å gi brukeren en melding om gratis frakt.
    */