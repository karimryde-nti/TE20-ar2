﻿using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Räkna 1 till 10");

            // for (int i = 1; i < 11; i++)
            // {
            //     Console.WriteLine($"Loop nr {i}");
            // }

            // Läs in en meddelande
            Console.WriteLine("Skriv ett meddelande");
            string meddelande = Console.ReadLine();
            
            // Loopa igenom meddelandet
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
