using System;
using System.Linq;
namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] bestDna = new int[n];
            int sample = 0;
            int bestSample = 0;
            int bestCnt = 0;
            int bestSum = 0;
            int bestDnaIndex = 0;
            int statrIndex = 0;

            string command;
            while ((command = Console.ReadLine()) != "Clone them!")
            {

                sample++;
                int[] dna = command
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                int sum = dna.Sum();
                for (int i = 0; i < dna.Length - 1; i++)
                {
                    int cntSequence = 1;
                    if (dna[i] == 1 && dna[i] == dna[i + 1])
                    {
                        if (cntSequence == 1)
                        {
                            statrIndex = i;
                        }
                        cntSequence++;
                    }

                    if (cntSequence > bestCnt)
                    {
                        bestCnt = cntSequence;
                        bestDna = dna;
                        bestSample = sample;
                        bestSum = sum;
                        bestDnaIndex = statrIndex;
                    }
                    else if (cntSequence == bestCnt)
                    {
                        if (statrIndex < bestDnaIndex)
                        {
                            bestDna = dna;
                            bestSample = sample;
                            bestSum = sum;
                            bestDnaIndex = statrIndex;
                        }
                        else if (statrIndex == bestDnaIndex)
                        {
                            if (sum > bestSum)
                            {
                                bestDna = dna;
                                bestSample = sample;
                                bestSum = sum;
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDna));

        }
    }
}