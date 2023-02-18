using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Invertory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items= Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commandArg = input.Split(" - ");
                string currCommand = commandArg[0];

                if (currCommand == "Collect")
                {
                    string item = commandArg[1];
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }
                }
                else if (currCommand == "Drop")
                {
                    string item = commandArg[1];
                    items.Remove(item);
                }
                else if (currCommand == "Combine Items")
                {
                    string[] item = commandArg[1].Split(":");
                    string oldItem = item[0];
                    string newItem = item[1];
                    int index = items.IndexOf(oldItem);
                    if (items.Contains(oldItem))
                    {
                        items.Insert(index + 1, newItem);
                    }

                }
                else if (currCommand == "Renew")
                {
                    string item = commandArg[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
