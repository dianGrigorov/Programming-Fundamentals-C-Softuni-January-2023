using System;
using System.Linq;
using System.Numerics;

namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[] commandArg = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commandArg[0] != "end")
            {
                string command = commandArg[0];

                if (command == "swap")
                {
                    int firstIndex = int.Parse(commandArg[1]);
                    int secondIndex = int.Parse(commandArg[2]);

                    int firstNum = arr[firstIndex];
                    int secondNum = arr[secondIndex];

                    arr[firstIndex] = secondNum;
                    arr[secondIndex] = firstNum;
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(commandArg[1]);
                    int secondIndex = int.Parse(commandArg[2]);

                    arr[firstIndex] = arr[firstIndex] * arr[secondIndex];
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= 1;
                    }
                }
                commandArg = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

              
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
