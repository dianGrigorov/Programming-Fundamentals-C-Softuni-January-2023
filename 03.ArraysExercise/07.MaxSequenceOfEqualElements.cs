using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int bestCnt = 0;
            int bestIndex = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int bestSequence = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        bestSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bestSequence > bestCnt)
                {
                    bestCnt = bestSequence;
                    bestIndex = i;
                }


            }
            for (int i = 0; i < bestCnt; i++)
            {
                Console.Write(numbers[bestIndex] + " ");
            }
        }
    }
}
