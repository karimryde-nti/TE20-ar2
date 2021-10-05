using System;

namespace GissaETtTal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spelet Gissa ett tal!!");

            // Slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 51);

            // Loopa 5 gånger
            int räknare = 0;
            while (true)
            {
                // Räkna upp varv
                räknare++;

                // Bryt efter 5 varv
                if (räknare >= 5)
                {
                    break;
                }
            }
        }
    }
}
