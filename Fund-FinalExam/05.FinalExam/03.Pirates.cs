
using System;

Dictionary<string, int[]> towns = new Dictionary<string, int[]>();
string townsInfo = Console.ReadLine();
while (townsInfo != "Sail")
{
    string[] townArg = townsInfo.Split("||");
    string currTown = townArg[0];
    int population = int.Parse(townArg[1]);
    int gold = int.Parse(townArg[2]);

    if (!towns.ContainsKey(currTown))
    {
        towns.Add(currTown, new int[] { population, gold });
    }
    else
    {
        towns[currTown][0] += population;
        towns[currTown][1] += gold;
    }
    townsInfo = Console.ReadLine();
}

string command = Console.ReadLine();

while (command != "End")
{
    string[] commArg = command.Split("=>");
    string currComand = commArg[0];
    string currTown = commArg[1];

    if (currComand == "Plunder")
    {
        int population = int.Parse(commArg[2]);
        int gold = int.Parse(commArg[3]);

        if (towns.ContainsKey(currTown))
        {
            Console.WriteLine($"{currTown} plundered! {gold} gold stolen, {population} citizens killed.");
            towns[currTown][0] -= population;
            towns[currTown][1] -= gold;
            if (towns[currTown][0] <= 0 || towns[currTown][1] <= 0)
            {
                towns.Remove(currTown);
                Console.WriteLine($"{currTown} has been wiped off the map!");
            }
        }
    }
    else if (currComand == "Prosper")
    {
        int gold = int.Parse(commArg[2]);
        if (towns.ContainsKey(currTown))
        {
            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");

            }
            else
            {
                towns[currTown][1] += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {currTown} now has {towns[currTown][1]} gold.");
            }

        }

    }
    command = Console.ReadLine();
}
if (towns.Count == 0)
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
    foreach (var town in towns)
    {
        Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
    }
}