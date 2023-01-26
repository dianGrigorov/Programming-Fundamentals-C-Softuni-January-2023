using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> num = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int moves = 0;
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool flag = true;
            while (command[0] != "end")
            {
                int firstIndex = int.Parse(command[0]);
                int secondIndex = int.Parse(command[1]);

                moves++;

                if (firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0
                    || firstIndex >= num.Count || secondIndex >= num.Count)
                {
                    
                    int index = num.Count / 2;

                    string value = "-" + (moves) + "a";

                    num.Insert(index, value);
                    num.Insert(index, value);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");


                }
                else if (num[firstIndex] == num[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {num[firstIndex]}!");
                    string hitedElement = num[firstIndex];
                    num.Remove(hitedElement);
                    num.Remove(hitedElement);

                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (num.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    flag = false;
                    break;
                }
                command = Console.ReadLine().Split();
            }

            if (flag)
            {
                Console.WriteLine("Sorry you lose :(");

                Console.WriteLine(string.Join(" ", num));
            }
            
        }
    }
}
