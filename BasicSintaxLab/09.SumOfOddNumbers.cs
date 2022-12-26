using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; n > 0; i++)
            {
                if (i %2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    n--;
                   
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
