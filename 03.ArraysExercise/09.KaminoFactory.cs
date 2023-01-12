using System;
using System.Linq;
namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            int maxSeq = 0;
            int indexOfBestDna = 0;
            int range = int.Parse(Console.ReadLine());
            int[] bestDna = new int[range];

            int currSum = 0;
            int bestSum = 0;

            int sample = 0;
            int bestSample = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int cntSeq = 1;
                int[] dna = new int[range];
                dna = command
                      .Split("!", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToArray();
                currSum = dna.Sum();
                sample++;

                for (int currIndex = 0; currIndex < dna.Length - 1; currIndex++)
                {
                    if (dna[currIndex] != dna[currIndex + 1])
                    {
                        cntSeq = 1;
                        continue;
                    }
                    cntSeq++;
                    if (cntSeq > maxSeq)
                    {
                        maxSeq = cntSeq;
                        bestDna = dna;
                        indexOfBestDna = currIndex;
                        bestSum = currSum;
                        bestSample = sample;
                        continue;

                    }

                    if (cntSeq == maxSeq)
                    {
                        if (currIndex < indexOfBestDna)
                        {
                            bestDna = dna;
                            indexOfBestDna = currIndex;
                            bestSum = currSum;
                            bestSample = sample;

                        }
                        else if (currIndex == indexOfBestDna)
                        {
                            if (currSum > bestSum)
                            {
                                bestDna = dna;
                                indexOfBestDna = currIndex;
                                bestSum = currSum;
                                bestSample = sample;

                            }
                        }

                    }

                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestDna));
        }
    }
}