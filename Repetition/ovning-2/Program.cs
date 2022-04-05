using System;

namespace ovning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en string-array med namnen på fem olika leksaker.
            string[] leksaker = {"boll", "racket", "hopprep", "pussel", "kortlek"};

            // Skriv ut innehållet i arrayen
            // Alternativ 1
            for (int i = 0; i < leksaker.Length; i++)
            {
                Console.WriteLine(leksaker[i]);     // leksaker[0] = "boll"
            }

            // Alternativ 2
            foreach (var leksak in leksaker)
            {
                Console.WriteLine(leksak);
            }
        }
    }
}
