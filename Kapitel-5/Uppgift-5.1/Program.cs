/* 
Skapa ett program som innehåller en array som ska innehålla namnen på tre svenska städer. Skriv in två av namnen i programmets kod men låt användaren få skriva in namnet på den tredje staden. Skriv avslutningsvis ut alla stadsnamnen på samma rad.
 */
using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uppgift 5.1");

            // Skapa en array för 3 svenska städer
            string[] städer = new string[3];

            städer[0] = "Malmö";
            städer[1] = "Göteborg";

            // Låt användaren få skriva in namnet på den tredje staden.
            Console.Write("Nämn en svensk stad: ");
            städer[2] = Console.ReadLine();

            // Skriv avslutningsvis ut alla stadsnamnen på samma rad.
            Console.WriteLine($"{städer[0]}, {städer[1]}, {städer[2]}");

            // Ett annat sätt att skapa en array
            string[] länder = {"Sverige", "Finland", "Danmark", "Norge"};
            länder[0] = "Tyskland";

            // Skriv ut alla länder
            // Loopa igenom arrayen länder
            foreach (var land in länder)
            {
                Console.WriteLine(land);
            }
        }
    }
}
