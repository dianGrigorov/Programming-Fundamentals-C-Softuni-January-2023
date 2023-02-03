using System;
using System.Linq;

namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();
            
            int currIndex = 0;
            string input;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] jumpComand = input.Split(" ");

                int jumpIndex = int.Parse(jumpComand[1]);

                // 1 2 3 4 5
                currIndex += jumpIndex;

                if (currIndex >= neighborhood.Length)
                {
                    currIndex = 0;
                }

                if (neighborhood[currIndex] == 0)
                {
                    Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                }
                else
                {
                    neighborhood[currIndex] -= 2;
                    if (neighborhood[currIndex] == 0)
                    {
                        Console.WriteLine($"Place {currIndex} has Valentine's day.");
                        
                    }
                }


            }
            int houseCnt = 0;
            foreach (int house in neighborhood)
            {
                if (house > 0)
                {
                    houseCnt ++;
                }
            }
            Console.WriteLine($"Cupid's last position was {currIndex}.");

            if (neighborhood.All(x => x == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houseCnt} places.");
            }

        }
    }
}
