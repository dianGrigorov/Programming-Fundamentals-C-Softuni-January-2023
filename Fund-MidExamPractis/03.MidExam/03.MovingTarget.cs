using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currCommand = commArg[0];

                if (currCommand == "Shoot")
                {
                    ShootingTargets(targets, commArg);
                }
                else if (currCommand == "Add")
                {
                    InsertTargets(targets, commArg);
                }
                else if (currCommand == "Strike")
                {
                    StrikeTargetsWithRadius(targets, commArg);
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }

        static void StrikeTargetsWithRadius(List<int> targets, string[] commArg)
        {
            int index = int.Parse(commArg[1]);
            int radius = int.Parse(commArg[2]);

            if (index - radius >= 0 && index + radius < targets.Count)
            {
                targets.RemoveRange(index - radius, radius * 2 + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }

        static void InsertTargets(List<int> targets, string[] commArg)
        {
            int index = int.Parse(commArg[1]);
            int value = int.Parse(commArg[2]);

            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void ShootingTargets(List<int> targets, string[] commArg)
        {
            int index = int.Parse(commArg[1]);
            int power = int.Parse(commArg[2]);

            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;
                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
        }
    }
}
