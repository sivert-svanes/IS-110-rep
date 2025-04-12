namespace Oppgave_2;

public abstract class Bok
{
    protected string ISBN { get; set; }
    protected internal List<string> Forfatter { get; set; }
    protected internal string Tittel { get; set; }
    protected internal int Utgivelsesår { get; set; }
    protected bool LevertInn { get; set; } = true;
    protected Bok()
    {
        //Legger til tittel til boken
        Console.WriteLine("Please write the title of the book you would like to add.");
        string tittel = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tittel))
        {
            throw new Exception("The book you would like to add must have a Title");
        }
        else
        {
            Tittel = tittel;
        }
        
        //Legger til ISBN til boken
        Random random = new Random();
        string thirteenDigitNumber = random.Next(100, 1000).ToString(); // First 3 digits to avoid leading zero
        for (int i = 0; i < 10; i++)
        {
            thirteenDigitNumber += random.Next(0, 10); // Add 10 more digits
        }
        ISBN = thirteenDigitNumber;
        
        //Legger til Forfatter til boken
        Forfatter = InputForfatter();
        
        //Legger til Utgivelsesår til boken
        Console.WriteLine("Please write the Utgivelsesår of the book you would like to add.");
        string utgivelsesår = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(utgivelsesår))
        {
            throw new Exception("The book you would like to add must have a release year");
        }
        else
        {
            Utgivelsesår = Convert.ToInt32(utgivelsesår);
        }
    }

    private List<string> InputForfatter()
    {
        List<string> forfatterList = new List<string>();  // Create a new list to store the forfatters
        string userInput;

        Console.WriteLine("Skriv inn navnet på forfatteren):");

        // Keep asking for input until the user types "N"
        while (true)
        {
            userInput = Console.ReadLine();  // Get user input
            
            if (userInput.ToUpper() == "N")  // If input is "N" (case-insensitive), break the loop
            {
                break;
            }
            
            if (string.IsNullOrWhiteSpace(userInput))
            {
                throw new Exception("Forfatteren du ønsker å legge til må ha et navn");
            }
            
            forfatterList.Add(userInput);  // Add the input to the list
            Console.WriteLine("Skriv inn navnet på forfatteren/e (Skriv ¨N¨ for å stoppe):");
        }

        return forfatterList;  // Return the list of strings
    }

    public abstract void VisInfoBok();
}

