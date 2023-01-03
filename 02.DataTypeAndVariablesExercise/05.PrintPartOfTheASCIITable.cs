using System;

namespace _05.PrintPartOfTheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            char character = '\0';
            for (int i = start; i <= end; i++)
            {
               character = Convert.ToChar(i);
                Console.Write($"{character} ");
            }
           
        }
    }
}
