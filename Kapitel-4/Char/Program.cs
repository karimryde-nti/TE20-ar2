using System;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hej på dig!";

            // Skriv ut hela stränge (string)
            Console.WriteLine(meddelande);

            // Skriv ut första bokstaven 'H'
            Console.WriteLine(meddelande[0]);

            // Skriv ut sista tecknet '!'
            Console.WriteLine(meddelande[10]);

            char bokstav = 'Z';

            // Skriv ut alla tecken
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"index {i} {meddelande[i]}");
            }

            // Skriv ut alla tecken baklänges
            for (int i = 11; i >= 0; i--)
            {
                Console.WriteLine($"index {i} {meddelande[i]}");
            }
        }
    }
}
