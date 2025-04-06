namespace Oppgave_2;
using System;
using System.Collections.Generic;


public class Biblotek
{
    private static List<Bok> books = new List<Bok>();
    
    public static void LeggTilBok()
    {
        // Add a new Bok to the static list
        books.Add(new Bok());
    }
    
    public static void PrintAlleBøker()
    {
        foreach (Bok book in books)
        {
            Bok.VisInfoBok();
        }
    }

}


