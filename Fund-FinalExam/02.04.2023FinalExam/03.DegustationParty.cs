
string commands;
Dictionary<string, List<string>> guestList = new Dictionary<string, List<string>>();
int unlikedMeals = 0;

while ((commands = Console.ReadLine()) != "Stop")
{
    string[] commArg = commands.Split("-", StringSplitOptions.RemoveEmptyEntries);
	string currCom = commArg[0];
	string guest = commArg[1];
	string meal = commArg[2];

	if (currCom == "Like")
	{
		if (!guestList.ContainsKey(guest))
		{
            guestList.Add(guest, new List<string>());
            guestList[guest].Add(meal);
        }
		else
		{
            guestList[guest].Add(meal);
        }
		
	}
	else if (currCom == "Dislike")
	{
		if (!guestList.ContainsKey(guest))
		{
            Console.WriteLine($"{guest} is not at the party.");
        }
		else
		{
			if (guestList[guest].Contains(meal))
			{
				guestList[guest].Remove(meal);
                Console.WriteLine($"{guest} doesn't like the {meal}.");
				unlikedMeals++;
            }
			else
			{
                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
            }

		}
		
	}
}
foreach (var guest in guestList)
{
    Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
}
Console.WriteLine($"Unliked meals: {unlikedMeals}");