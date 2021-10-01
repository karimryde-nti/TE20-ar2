using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? ");
            string ålder = Console.ReadLine();
            
            Console.WriteLine($"Du är {ålder} gammal");

            // Konvertera från string till heltal
            int ålderTal = int.Parse(ålder);

            Console.WriteLine($"Du har {20 -ålderTal} år kvar tills du får gå på Systemet");

            Console.Write("Hur mycket väger du? ");
            float vikt = float.Parse(Console.ReadLine());

            Console.WriteLine($"Din vikt blir {vikt * 2.2} Lbs");

            float viktLbs = vikt * 2.2f;

            // Formatera till en snygg utskrift
            string viktString = viktLbs.ToString("0.##");
            Console.WriteLine($"Din vikt är {viktString} Lbs");
        }
    }
}
