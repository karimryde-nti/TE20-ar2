using System;

namespace FLF_160522
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metoder!");

            /* // Anropa metoden
            VertikalUtskrift("Karim Ryde");

            Console.Write("Skriv in ditt namn: ");
            string namn2 = Console.ReadLine();
            VertikalUtskrift(namn2); */

            // Använd metod 2
            int tal1 = SlumpaTal();
            int tal2 = SlumpaTal();
            Console.WriteLine($"Summan är {tal1 + tal2}");

            SkrivUtKvadrat(3);
            SkrivUtKvadrat(4);

            RepeteraOrd("Yara");
        }

        // En metod
        static void VertikalUtskrift(string namn)
        {
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }

        // En metod föra att slumpa fram ett tal 1-100
        static int SlumpaTal()
        {
            Random generator = new Random();
            int slumptal = generator.Next(0, 101);
            //Console.WriteLine($"Vi har ett slumptal {slumptal}");
            return slumptal;
        }

        // En metod som skriver ut kvadraten av talet man stoppar in
        static void SkrivUtKvadrat(int tal)
        {
            Console.WriteLine(tal * tal);
        }

        // En metod som skriver ut ett ord 5 gånger
        static void RepeteraOrd(string ord)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ord);
            }
        }
    }
}
