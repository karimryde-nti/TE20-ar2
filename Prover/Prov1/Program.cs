using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berätta vad programmet gör
            Console.WriteLine("Uträkning av nettolön\n---------------------");

            // Upprepa med loop
            while (true)
            {
                // Fråga efter namn
                Console.Write("Vad heter du? ");
                string namn = Console.ReadLine();

                // Fråga efter bruttolön
                Console.Write("Ange din bruttolön i kronor: ");
                int bruttolön = int.Parse(Console.ReadLine());

                // KOlla att villkoren är uppfyllda för bruttolön
                if (bruttolön >= 10000 && bruttolön <= 45000)
                {
                    // Fråga efter skattesats
                    Console.Write("Ange din skattesats i kronor: ");
                    int skattesats = int.Parse(Console.ReadLine());

                    // KOlla att villkoren är uppfyllda för skattesats
                    if (skattesats >= 10 && skattesats <= 45)
                    {
                        // Räkna ut nettolön
                        int nettolön = bruttolön * (100 - skattesats) / 100;
                        Console.WriteLine($"{namn}, din lön efter skatt är {nettolön}");
                    }
                    else
                    {
                        Console.WriteLine("skattesats måste vara mellan 10 och 45");
                    }
                }
                else
                {
                    Console.WriteLine("Bruttolön måste vara mellan 10000 och 450000");
                }

                // Vill du köra igen?
                Console.WriteLine("Vill du köra igen? (j/n)");
                string svar = Console.ReadLine();
                if (svar != "j") // (svar == "n")
                {
                    break;
                }
            }
        }
    }
}
