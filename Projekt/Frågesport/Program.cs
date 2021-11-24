using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frågesport!");

            // Första frågan
            Console.WriteLine("Vilken 1960-tal amerikanska popgrupp skapade 'surfin-ljudet'?");
            Console.WriteLine("a - The Beach Boys");
            Console.WriteLine("b - The Monkeys");
            Console.WriteLine("c - The Who");
            string svar = Console.ReadLine().ToLower(); // Bara läser in små bokstäver
                                                 // Kolla om svaret är rätt
            if (svar == "a")
            {
                Console.WriteLine("Rätt svar");
            }
            else
            {
                Console.WriteLine("Fel svar");
            }

            // Andra frågan
            Console.WriteLine("Från vilken brittisk stad kommer The Beatles?");
            Console.WriteLine("a - London");
            Console.WriteLine("b - Dublin");
            Console.WriteLine("c - Liverpool");
            svar = Console.ReadLine().ToLower(); // Bara läser in små bokstäver

            // Kolla om svaret är rätt
            if (svar == "c")
            {
                Console.WriteLine("Rätt svar");
            }
            else
            {
                Console.WriteLine("Fel svar");
            }

            // Tredje frågan
            Console.WriteLine("Vilken är den mest streamade låten på spotify genom tiderna (räknat fram till den 6 maj 2020)?");
            Console.WriteLine("a - The Shape of You, Ed Sheeran");
            Console.WriteLine("b - Billie jean, Michael Jackson");
            Console.WriteLine("c - Tones and I, Dance Monkey");
            svar = Console.ReadLine().ToLower(); // Bara läser in små bokstäver

            // Kolla om svaret är rätt
            if (svar == "a")
            {
                Console.WriteLine("Rätt svar");
            }
            else
            {
                Console.WriteLine("Fel svar");
            }
        }
    }
}