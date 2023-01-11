using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < num.Length; i++)
            {

                for (int j = i +1; j < num.Length; j++)
                {
                    if (num[i] + num[j] == n)
                    {
                        Console.WriteLine(num[i] + " " + num[j]);
                        break;
                    }
                }
            }
        }
    }
}
