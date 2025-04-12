namespace Oppgave_2
{
    class Oppgave2
    {
        static void Main()
        {
            try
            { 
                Biblotek biblotek = new Biblotek();
               biblotek.Startmeny();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}