using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren om ålder
            Console.Write("Hur gammal är du? (heltal)");
            int ålder = int.Parse(Console.ReadLine());
            
            // Om ålder större än 18 "Du får ta körkort!"
            if (ålder >= 18)
            {
                Console.WriteLine("Du får ta körkort!");
            }

            // Om ålder är 15 eller högre -> "Du får ta mopedkörkort!"
            if (ålder >= 15)
            {
                Console.WriteLine("Du får ta mopedkörkort!");
            }

            // Fråga användaren "Vad heter ABBAs senaste låt?"
            Console.Write("Vad heter ABBAs senaste album? ");
            string låt = Console.ReadLine();
            
            // Är svaret korrekt?
            if (låt == "Voyage" || låt == "voyage")
            {
                Console.WriteLine("Bra svarat!");
            }
            else
            {
                Console.WriteLine("Fel! Albummet heter Voyage");
            }

            // Sista TP-fråga
            Console.Write("Vem missade straffen i matchen England-Frankrike? (efternamn) ");

            // läs in och tvinga till små bokstäver: 
            // Mbappe -> mbappe
            // mBappe -> mbappe
            string spelare = Console.ReadLine().ToLower();

            if (spelare == "mbappe")
            {
                Console.WriteLine("Bra, du är en expert!");
            } else
            {
                Console.WriteLine("Fel! Det var Mbappe");
            }

            Console.WriteLine("Sover du? (ja/nej)");
            string svar = Console.ReadLine();
            if (svar == "ja")
            {
                // Sover


            } else
            {
                // Sover inte
                
            }
        }
    }
}
