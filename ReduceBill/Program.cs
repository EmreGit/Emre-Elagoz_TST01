using System;

namespace ReduceBill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Typ uw factuur bedrag in om te zien of u recht hebt op korting: \n");
            double userInput = double.Parse(Console.ReadLine());
            KortingVoorUser(userInput);
        }
        private static void KortingVoorUser(double userInput)
        {
            if (userInput > 5000)
            {
                double kortingBerekening = (userInput / 100) * 5;
                double eindtotaal = userInput - kortingBerekening;
                Console.Clear();
                Console.WriteLine("\nUw nieuwe te betalen factuur met korting is: " + eindtotaal + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nU heeft geen recht op korting\n");
                Console.ResetColor();
            }
        }
    }
}
