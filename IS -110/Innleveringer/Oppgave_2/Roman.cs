namespace Oppgave_2;

public class Roman : Bok, IBokFunksjoner
{
    private string Sjanger { get; set; }
    
    public Roman() : base()
    {
        //Legger til sjanger til romanen
        Console.WriteLine("Please write the Sjanger of the bok you would like to add.");
        string sjanger = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(sjanger))
        {
            throw new Exception("The bok you would like to add must have a Sjanger");
        }
        else
        {
            Sjanger = sjanger;
        }
        
        // Confirmation that it is created
        Console.WriteLine("Roman created");    
    }
    
    public override void VisInfoBok()
    {
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Tittelen til boken: {Tittel}");
        Console.WriteLine($"Sjanger: {Sjanger}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Utgivelsesåret: {Utgivelsesår}");
        int i = 1;
        foreach (string forfatter in Forfatter)
        {
            Console.WriteLine($"Navnet på forfatter.{i}: {forfatter}");
            i++;
        }
        Console.WriteLine($"---------------------------------");
    }

    public void LeverInn()
    {
        if (LevertInn == true)
        {
            Console.WriteLine("Denne Romanen er allerede levert inn");
        }
        else
        {
            LevertInn = true;
            Console.WriteLine("Romanen leveres inn");
        }
    }

    public void LånUt()
    {
        if (LevertInn == true)
        {
            LevertInn = false;
            Console.WriteLine("Romanen leveres ut");
        }
        else
        {
            Console.WriteLine("Romanen er allerede levert ut");
        }
    }
}