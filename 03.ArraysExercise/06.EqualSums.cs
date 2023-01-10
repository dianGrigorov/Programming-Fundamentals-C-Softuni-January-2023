using System;
using System.Linq;

namespace _06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            if (numbers.Length <= 1)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < numbers.Length; i++) 
            {
               
                int rightSum = 0;
                int leftSum = 0;

                for (int j = i +1; j < numbers.Length; j++)
                {
                    rightSum+= numbers[j];

                }
                
                for (int k = i -1; k >= 0; k--)
                {
                    leftSum += numbers[k];
                }
               

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
