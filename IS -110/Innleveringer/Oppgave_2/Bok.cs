namespace Oppgave_2;

public class Bok
{
    public string ISBN { get; set; }

    public string Tittel { get; set; }

    public string Forfatter { get; set; }

    public int Utgivelsesår { get; set; }
    
    // public abstract void VisInfo();

    public static List<Bok> books = new List<Bok>();

    public Bok()
    {
        Console.WriteLine("Please write the title of the book you would like to add.");
        Tittel = Console.ReadLine();
    }
    
    
    
    public static void LeggTilBok()
    { 
      books.Add(new Bok());
    }

    public void DoSomething()
    {
        Console.WriteLine("Doing something");
    }
}
