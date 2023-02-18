using System;

namespace T02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            bool isNotDead = true;
            string[] rooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i <= rooms.Length; i++)
            {
                string[] room = rooms[i - 1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = room[0];
                int value = int.Parse(room[1]);
                int bestRoom = i;

                if (command == "potion")
                {
                    health += value;

                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health + value} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");

                    }
                    else
                    {
                        Console.WriteLine($"You healed for {value} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                }
                else if (command == "chest")
                {
                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    health -= value;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        isNotDead = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }

            }
            if (isNotDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
