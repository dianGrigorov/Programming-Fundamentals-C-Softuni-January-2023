using System;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());
            int[] train = new int[vagons];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;
                sum += people;
            }
            Console.WriteLine(string.Join((" "), train));
            Console.WriteLine(sum);
        }
    }
}
