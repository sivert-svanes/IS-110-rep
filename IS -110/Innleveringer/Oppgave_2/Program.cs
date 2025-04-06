using System.Diagnostics;

namespace Oppgave_2
{
    class Oppgave2
    {
        static void Main()
        {

            try
            {
                Biblotek.LeggTilBok();
                Biblotek.PrintAlleBøker();
                Biblotek.LeggTilBok();
                Biblotek.LeggTilBok();
                Biblotek.PrintAlleBøker();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}