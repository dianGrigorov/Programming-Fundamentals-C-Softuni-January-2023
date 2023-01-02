using System;

namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = n; i <= m; i++)
            {
                Console.Write($"{i} ");
                sum = sum + i;
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
