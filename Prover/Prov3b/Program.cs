using System;

namespace Prov3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program for listing countries!");

            // Array of country names
            string[] countries = { "Andorra", "Afghanistan", "Antigua och Barbuda", "Bulgarien", "Vitryssland", "Benin", "Chile", "Kina", "Dominikanska republiken", "Eritrea", "Indonesien", "Kirgizistan", "Liechtenstein", "Madagaskar", "Papua Nya Guinea" };

            // Minimum length
            int minLength = 4;

            // Length och longest country name
            int topLength = 0;

            // Calculate topLength
            foreach (var country in countries)
            {
                if (topLength <= country.Length)
                {
                    topLength = country.Length;
                }
            }
            
            // maxlength for names to output
            int maxLength = 0;

            while (true)
            {
                // Users inputs maxLength
                Console.Write("Please input max length: ");
                maxLength = InputInt(minLength, topLength);

                // Output all countries
                outputCountries(maxLength, countries);

                // One more time?
                Console.Write("Try again (y/n): ");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
            }
        }

        // Method for inputing an int
        static int InputInt(int minLength, int topLength)
        {
            int max = 0;

            while (true)
            {
                // 1. Make sure user inputs an int
                while (!int.TryParse(Console.ReadLine(), out max))
                {
                    Console.Write("DU måste mata in ett heltal. Vg försök igen: ");
                }

                // 2. Make sure usre inputs number between 4 and 22
                if (max < minLength || max > topLength)
                {
                    Console.Write("DU måste mata ett heltal > 4 och < 23. Vg försök igen: ");
                }
                else
                {
                    break;
                }
            }

            return max;
        }

        static void outputCountries(int maxCountryLength, string[] countriesList)
        {
            foreach (var country in countriesList)
            {
                if (country.Length <= maxCountryLength)
                {
                    Console.WriteLine($"* {country}");
                }
            }
        }
    }
}
