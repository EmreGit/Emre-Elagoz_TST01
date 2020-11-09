using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {

        static void Main(string[] args)
        {
            string password = Passgenerator(20);
            Console.WriteLine("Your new secure password is:");
            Console.WriteLine("\n" + password + "\n");
        }

        static string Passgenerator(int length)
        {
            string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZ&é!-_";

            StringBuilder userpassword = new StringBuilder(chars.Length);
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                userpassword.Append(chars[index]);
            }
            return userpassword.ToString();
        }

    }
}
