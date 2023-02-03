using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShopingList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> shopingList = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commandArguments = input.Split(" ");

                string command = commandArguments[0];

                UrgentCommand(shopingList, commandArguments, command);

                UnnecesseryCommand(shopingList, commandArguments, command);

                CorrectCommand(shopingList, commandArguments, command);

                RearrangeCommand(shopingList, commandArguments, command);
            }

            Console.WriteLine(string.Join(", ", shopingList));
        }

        private static void RearrangeCommand(List<string> shopingList, string[] commandArguments, string command)
        {
            if (command == "Rearrange")
            {
                string item = commandArguments[1];

                if (shopingList.Contains(item))
                {
                    shopingList.Remove(item);
                    shopingList.Add(item);

                }


            }
        }

        private static void CorrectCommand(List<string> shopingList, string[] commandArguments, string command)
        {
            if (command == "Correct")
            {
                string oldItem = commandArguments[1];
                string newItem = commandArguments[2];

                for (int i = 0; i < shopingList.Count; i++)
                {
                    if (oldItem == shopingList[i])
                    {
                        shopingList[i] = newItem;
                        break;
                    }

                }

            }
        }

        private static void UnnecesseryCommand(List<string> shopingList, string[] commandArguments, string command)
        {
            if (command == "Unnecessary")
            {
                string item = commandArguments[1];

                if (shopingList.Contains(item))
                {
                    shopingList.Remove(item);
                }

            }
        }

        private static void UrgentCommand(List<string> shopingList, string[] commandArguments, string command)
        {
            if (command == "Urgent")
            {
                string item = commandArguments[1];


                if (!shopingList.Contains(item))
                {
                    shopingList.Insert(0, item);
                }

            }
        }
    }
}
