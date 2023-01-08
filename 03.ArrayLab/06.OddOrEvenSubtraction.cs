using System;
using System.Linq;

namespace _06.OddOrEvenSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] % 2 == 1)
                {
                    oddSum += firstArr[i];
                }
                else
                {
                    evenSum += firstArr[i];
                }
            }
            Console.WriteLine(evenSum - oddSum);
            
        }
    }
}
