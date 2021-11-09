using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frågesport!");

            // Första fråga
            Console.WriteLine("Vilken 1960-tal amerikanska popgrupp skapade 'surfin-ljudet'?");
            Console.WriteLine("a - The Beach Boys");
            Console.WriteLine("b - The Monkeys");
            Console.WriteLine("c - The Who");
            string svar1 = Console.ReadLine().ToLower(); // Bara läser in små bokstäver
            
            // Kolla om svaret är rätt
            if (svar1 == "a")
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
