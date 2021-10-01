using System;

namespace BoolskaOperationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom");

            Console.Write("Har du feber? (j/n) ");
            string feber = Console.ReadLine();

            Console.Write("Hostar du? (j/n) ");
            string hosta = Console.ReadLine();

            Console.Write("Har du tappat smaken? (j/n) ");
            string smak = Console.ReadLine();

            Console.Write("Är du vaccinerad mot Covid? (j/n) ");
            string vaccin = Console.ReadLine();

            // Om dessa tre villkor är uppfyllda (&& betyder och)
           /* if (feber == "ja" && hosta == "ja" && smak == "ja")
           {
               Console.WriteLine("DU har troligen Covid-19");
           }

            if (hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("DU har troligen Covid-19");
            }

            if (feber == "ja" && smak == "ja")
            {
                Console.WriteLine("DU har troligen Covid-19");
            } */

            if (feber == "j" || hosta == "j" && smak == "j")
            {
                Console.WriteLine("DU har troligen Covid-19");
            }

        }
    }
}
