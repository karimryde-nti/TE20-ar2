using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Använda array");

            // Skapa en array för 3 öar
            string[] öar = new string[3];

            // Första platsen (0)
            öar[0] = "Syros";
            öar[1] = "Naxos";
            öar[2] = "kreta";

            // Byt ut innehållet
            öar[0] = "Amorgos";

            // Skriv ut innehållet 
            Console.WriteLine(öar[0]);
            Console.WriteLine($"Två andra öar är {öar[1]} och {öar[2]}");
            
        }
    }
}
