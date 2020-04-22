using Microsoft.VisualBasic.CompilerServices;
using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            while (keepgoing)
            {
                int number = ReadIntegers("Enter an integer: ");
                Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", "Number", "Cubed", "Squared"));
                for (int i = 1; i <= number; i++)
                {
                    int squared = i * i;
                    int cubed = i * i * i;
                    Console.WriteLine(String.Format("|{0,6}|{1,5}|{2,7}|", i, squared, cubed));
                }
                keepgoing = KeepRunning();
            }
        }

        public static int ReadIntegers(string message)
        {
            {
                Console.Write(message);
                int input;
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("That was invalid. Enter a valid number.");
                    Console.Write(message);
                }
                return input;
            }
        }

        public static bool KeepRunning()
        {
            Console.WriteLine("Do you wish to keep going? y/n");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter y or n");
                return KeepRunning();
            }
        }
    }
}
