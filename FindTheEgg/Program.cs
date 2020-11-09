using System;

namespace FindTheEgg
{
    class Program
    {
        static Random egglocation = new Random();
        static void Main(string[] args)
        {
            char[,] grassForEggs = new char[10, 10];
            bool found = false;
            int userGuessX;
            int userGuessY;
            int eggX, eggY;

            // The location of our egg, as randomly decided
            eggX = egglocation.Next(10);
            eggY = egglocation.Next(10);
            InitializeMap(grassForEggs);

            while (!found)
            {
                ShowMap(grassForEggs);

                userGuessX = AskNumber("Please enter a number on the X axis, from 0 - 9");
                userGuessY = AskNumber("Please enter a number on the Y axis, from 0 - 9");
                grassForEggs[userGuessX, userGuessY] = 'X';

                if (userGuessX == eggX && userGuessY == eggY)
                {
                    grassForEggs[eggX, eggY] = '0';
                    Console.Clear();
                    ShowMap(grassForEggs);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank you for finding the Golden egg, the Kingdom is saved ! Press ENTER");
                    Console.ResetColor();
                    Console.ReadLine();

                    Console.WriteLine("Press Q to quit the program or ENTER to play again");
                    if (Console.ReadLine().ToUpper() == "Q")
                    {
                        found = true;
                    }
                    else
                    {
                        InitializeMap(grassForEggs);
                        eggX = egglocation.Next(10);
                        eggY = egglocation.Next(10);
                        found = false;
                    }
                }
                Console.Clear();

                if (eggX < userGuessX)
                {
                    Console.WriteLine("Go North for X");
                }
                else if (eggX > userGuessX)
                {
                    Console.WriteLine("Go South for X");
                }
                else
                {
                    /* I would have removed this writeline but I think the program works better 
                    when you tell the user where they've guessed correctly on the axis, 
                    same goes for the "else" loop on line 79  */

                    //Console.WriteLine($"X is correct, stay on {userGuessX}");
                }
                if (eggY > userGuessY)
                {
                    Console.WriteLine("Go East for Y");
                }
                else if (eggY < userGuessY)
                {
                    Console.WriteLine("Go West for Y");
                }
                else
                {
                    //Console.WriteLine($"Y is correct, stay on {userGuessY}");
                }
            }
        }
        private static void ShowMap(char[,] grassForEggs)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(grassForEggs[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        private static void InitializeMap(char[,] grassForEggs)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grassForEggs[i, j] = '-';
                }
            }
        }
        static int AskNumber(string prompt)
        {
            int result;
            bool goodNumber;
            Console.WriteLine(prompt);
            goodNumber = int.TryParse(Console.ReadLine(), out result);

            while (!goodNumber || result < 0 || result > 9)
            {
                Console.WriteLine("Please enter NUMBERS only, no characters or letters, from 0 to 9 only !!!");
                goodNumber = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }
    }
}
