namespace Oppgave_2;

public class Fagbok : Bok
{
    private string Fagområde { get; set; }
    public Fagbok() : base()
    {
        //Legger til Fagområde til romanen
        Console.WriteLine("Please write the Fagområde of the bok you would like to add.");
        string fagom = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fagom))
        {
            throw new Exception("The bok you would like to add must have a Fagområde");
        }
        else
        {
            Fagområde = fagom;
        }
        
        // Confirmation that it is created
      Console.WriteLine("Fagbok created");  
    }
    
    public override void VisInfoBok()
    {
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Tittelen til boken: {Tittel}");
        Console.WriteLine($"Fagområde: {Fagområde}");
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
            Console.WriteLine("Denne Fagboken er allerede levert inn");
        }
        else
        {
            LevertInn = true;
            Console.WriteLine("Fagboken leveres inn");
        }
    }

    public void LånUt()
    {
        if (LevertInn == true)
        {
            LevertInn = false;
            Console.WriteLine("Fagboken leveres ut");
        }
        else
        {
            Console.WriteLine("Fagboken er allerede levert ut");
        }
    }
}