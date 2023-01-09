using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            int optimaise = rotations % array.Length;

            for (int i = 1; i <= optimaise; i++)
            {
                int firstIndex = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }
                array[array.Length - 1] = firstIndex;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
