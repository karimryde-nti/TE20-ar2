using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett tal");
            //int tal = int.Parse(Console.ReadLine());

            int heltal;
            // Lyckas vi läsa in ett tal
            bool funkar = int.TryParse(Console.ReadLine(), out heltal);

            // Gick det?
            if (funkar == true)
            {
                Console.WriteLine($"Du matade in heltalet {heltal}");
            }
            else
            {
                Console.WriteLine("Du matade inte i ett tal");
            }
        }

        // En metod för att läsa in ett tal
        static int ReadInt()
        {
            Console.Write("Ange ett tal");
            int heltal;

            while (true)
            {
                // Lyckas vi läsa in ett tal
                bool funkar = int.TryParse(Console.ReadLine(), out heltal);

                // Gick det?
                if (funkar == true)
                {
                    Console.WriteLine($"Du matade in heltalet {heltal}");
                    break;
                }
                else
                {
                    Console.WriteLine("Du matade inte i ett tal, vg försök igen ");
                }
            }

            return heltal;
        }
    }
}
