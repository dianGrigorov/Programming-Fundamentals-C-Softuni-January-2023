﻿List<int> targets = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

int[] bomb = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int currBomb = bomb[0];
int power = bomb[1];

for (int i = 0; i < targets.Count; i++)
{
    if (targets[i] == currBomb)
    {
        if (i - power < 0)
        {
            
                targets.RemoveRange(0, power + 1);
            
        }
        else if (i + power >= targets.Count)
        {
            for (int j = targets.Count - 1; j >= i - power; j--)
            {
                targets.RemoveAt(j);
            }
            
        }
        else
        {
            targets.RemoveRange(i - power, power * 2 + 1);
        }
    }
}

Console.WriteLine(targets.Sum());