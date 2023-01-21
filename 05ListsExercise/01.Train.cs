List<int> vagons = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

int maxCapacity = int.Parse(Console.ReadLine());
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] cmd = input.Split(" ");
    string currCmd = cmd[0];
    if (currCmd == "Add")
    {
        int passanger = int.Parse(cmd[1]);
        vagons.Add(passanger);
    }
    else
    {
        int passangers = int.Parse(cmd[0]);
        for (int i = 0; i < vagons.Count; i++)
        {
            if (vagons[i] + passangers <= maxCapacity)
            {
                vagons[i] += passangers;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", vagons));