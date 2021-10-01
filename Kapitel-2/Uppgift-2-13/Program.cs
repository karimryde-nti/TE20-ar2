using System;

namespace Uppgift_2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in 3 löner");

            // Ange lön 1
            int lön1 = int.Parse(Console.ReadLine());
            int lön2 = int.Parse(Console.ReadLine()); 
            int lön3 = int.Parse(Console.ReadLine());
            
            // Räkna ut medelvärdet
            float medelvärde = (lön1 + lön2 + lön3) / 3;

            // Skriv ut resultatet
            Console.WriteLine($"Medelvärdet är {medelvärde}");
        }
    }
}
