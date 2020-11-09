using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCity
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stadBelgie = new string[8] { "Brussel", "Antwerpen", "Turnhout ", "Kortrijk", "Gent", "Dendermonde", "Aalst", "Oudenaarde" };
            int[] postCode = { 1000, 2000, 2300, 8500, 9000, 9200, 9300, 9700 };

            Console.WriteLine("Hallo, om uw stad terug te vinden, kies een postcode uit deze lijst:" +
                              " 1000, 2000, 2300, 8500, 9000, 9200, 9300, 9700");

            FindCityMethod(stadBelgie, postCode);
        }
        private static void FindCityMethod(string[] stadBelgie, int[] postCode)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    int post = Array.IndexOf(postCode, result);
                    if (post >= 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nInput werd aanvaard\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Uw opgegeven postcode is van de stad: \n{stadBelgie[post]}\n");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Maak een keuze uit de lijst aub.");
                    }
                }
            }
        }
}
