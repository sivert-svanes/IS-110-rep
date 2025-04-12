namespace Oppgave_2;
using System.Collections.Generic;


public class Biblotek
{
    private List<Bok> books = new List<Bok>();
    public void LeggTilBokRoman()
    {
        books.Add(new Roman());
    }
    public void LeggTilBokFagbok()
    {
        books.Add(new Fagbok());
    }
    public void PrintAlleBøker()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Det finnes ingen bøker i bibloteket");
        }
        else
        {
            foreach (Bok book in books)
            {
                book.VisInfoBok();
            } 
        }
    }

    public void FinnBokEtterForfatter()
    {
        Console.WriteLine("Skriv inn forfatteren på boken du ønsker å finne: ");
        string forfatterSøk = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(forfatterSøk))
        {
            throw new Exception("Det finnes ingen bok med denne forfatteren");
        }
        else
        {
            var bokMedForfatter = from b in books
                where b.Forfatter.Contains(forfatterSøk,  StringComparer.OrdinalIgnoreCase)
                select b;
            
            if (!bokMedForfatter.Any())
            {
                Console.WriteLine("Det finnes ingen bøker med denne forfatteren i bibloteket");
            }
            else
            {
                foreach (Bok book in bokMedForfatter)
                {
                    book.VisInfoBok();
                }
            }
        }
    }
    
    public void FinnBokerEtterUtgittÅr()
    {
        Console.WriteLine("Skriv inn Utgivelsesåret du ønsker å finne bøker etter: ");
        string året = Console.ReadLine();
        int åretTall = Convert.ToInt32(året);
        if (string.IsNullOrWhiteSpace(året))
        {
            throw new Exception("Du må skrive inn et år å lete etter");
        }
        else
        {
            var bokMedTittel = from b in books
                where b.Utgivelsesår > åretTall
                select b;
            
            if (!bokMedTittel.Any())
            {
                Console.WriteLine("Det finnes ingen bøker etter dette årstallet");
            }
            else
            {
                foreach (Bok book in bokMedTittel)
                {
                    book.VisInfoBok();
                }
            }
        }
    }
    
    public void FinnBokEtterTittel()
    {
        Console.WriteLine("Skriv inn tittelen på boken du ønsker å finne: ");
        string tittelSøk = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tittelSøk))
        {
            throw new Exception("Boken du ønsker å søke etter må inneholde en tittel");
        }
        else
        {
            var bokMedTittel = from b in books
                where b.Tittel.Contains(tittelSøk,  StringComparison.OrdinalIgnoreCase)
                select b;

            if (!bokMedTittel.Any())
            {
                Console.WriteLine("Det finnes ingen bøker med denne tittel");
            }
            else
            {
                foreach (Bok book in bokMedTittel)
                {
                    book.VisInfoBok();
                }
            }
        }
        
    }

    public void Startmeny()
    {
        bool kjører = true;
        Console.WriteLine("Velkommen til Biblotek Applikasjonen");
        while (kjører)
        {
            StartMenyTekst();
            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    BokValg();
                    break;
                case "2":
                    PrintAlleBøker();
                    break;
                case "3":
                    FinnBokEtterForfatter();
                    break;
                case "4":
                    FinnBokerEtterUtgittÅr();
                    break;
                case "5":
                    FinnBokEtterTittel();
                    break;
                case "6":
                    Console.WriteLine("Avslutter programmet. Ha en fin dag!");
                    kjører = false;
                    break;
                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen ved å skrive et gyldig tall.");
                    break;
            }
            
            if (kjører)
            {
                Console.WriteLine("\nTrykk Enter for å fortsette...");
                Console.ReadLine();
                Console.Clear(); // Rens skjermen for neste menyvisning (valgfritt)
            }
        }
    }

    public void StartMenyTekst()
    {
        Console.WriteLine("Vennligst skriv inn tallet på den handlingen du ønsker å gjøre:");
        Console.WriteLine("[1] Legg til en ny bok");
        Console.WriteLine("[2] List opp alle bøker");
        Console.WriteLine("[3] Finn bøker etter forfatter");
        Console.WriteLine("[4] Fin bøker utgitt etter et årstall");
        Console.WriteLine("[5] Finn boken med en gitt tittel");
        Console.WriteLine("[6] Avslutt aplikasjonen");
    }

    public void BokValg()
    {
        Console.WriteLine("Vennligst skriv inn tallet på den handlingen du ønsker å gjøre:");
        Console.WriteLine("[1] Legg til en ny Fagbok");
        Console.WriteLine("[2] Legg til en ny Roman");
        string Bokvalg = Console.ReadLine();
        switch (Bokvalg)
        {
            case "1":
                LeggTilBokFagbok();
                break;
            case "2":
                LeggTilBokRoman();
                break;
            default:
                Console.WriteLine("Ugyldig valg, prøv igjen.");
                break;
        }
    }
}


