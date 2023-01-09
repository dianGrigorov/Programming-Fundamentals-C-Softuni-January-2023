using System;
using System.Linq;

namespace _03.Zig_ZagArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArry = new int[n];
            int[] secondArry = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 != 0)
                {
                    firstArry[i - 1] = numbers[0];
                    secondArry[i -1] = numbers[1];
                }
                else
                {
                    firstArry[i -1] = numbers[1];
                    secondArry[i - 1] = numbers[0];
                }
            }
            Console.WriteLine(string.Join((" "), firstArry));
            Console.WriteLine(string.Join(" ", secondArry));


        }
    }
}
