using System;

namespace _06.ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "USA" || input == "England")
            {
                Console.WriteLine("English");
            }
            else if (input == "Spain" || input == "Mexico" || input == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
