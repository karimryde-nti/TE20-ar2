using System;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett tal 1: ");
            int tal1 = ReadInt();

            Console.Write("Ange ett tal 2: ");
            int tal2 = ReadInt();
        }

        static int ReadInt()
        {
            int heltal;
            while (int.TryParse(Console.ReadLine(), out heltal) == false)
            {
                Console.Write("Du skrev inte in ett heltal, försök igen: ");
            }
            return heltal;
        }
    }
}
