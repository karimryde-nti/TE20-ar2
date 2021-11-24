using System;

namespace Slagsmålspelet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Slagsmålspelet!");

            // Mata in hjältens namn
            // Kolla att namn inte är för kort eller för långt
            // Isåfal fråga igen

            // Slumpa fram fiendens namn
            // Använd 3 förslag

            // Gamestate för våra spelare
            int hjälteHP = 100;
            int fiendenHP = 100;

            // Skapa en slumptalsgenerator (ung plocka fram en tärning)
            Random generator = new Random();

            // Slagsmålsloopen
            // "Vi kör tills någon dör", dvs någon får hp =< 0
            while (fiendenHP > 0 && hjälteHP > 0)
            {
                // Slumpa fram ett slag för hjälten
                int slag = generator.Next(0, 21);

                // Själva slaget för hjälten
                hjälteHP -= slag;

                Console.WriteLine($"{hjälte} har nu {hjälteHP} HP");

                // Slumpa fram ett slag för fienden
                slag = generator.Next(0, 21);

                // Slaget för fienden
                fiendenHP -= slag;

                Console.WriteLine($"{fienden} har nu {fiendenHP} HP");

                // Avbryt slagsmålet när ngån får hp <= 0
/*                 if (fiendenHP <= 0 || hjälteHP <= 0)
                {
                    break;
                } */

                // Pausa mellan varje slag
                Console.ReadKey();
            }

            // Vem vann?
            // Eller blev det oavgjort?
            if (hjälteHP < 0 && fiendenHP < 0)
            {
                Console.WriteLine("Matchen ovgjord!");
            }
            else if (hjälteHP > fiendenHP)
            {
                Console.WriteLine($"{hjälte} vann matchen!");
            } 
            else if (fiendenHP > hjälteHP)
            {
                Console.WriteLine($"{fienden} vann matchen!");
            }
            else
            {
                Console.WriteLine("Matchen ovgjord!");
            }
        }
    }
}
