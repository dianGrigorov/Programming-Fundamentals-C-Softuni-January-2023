using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sum += letters;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
