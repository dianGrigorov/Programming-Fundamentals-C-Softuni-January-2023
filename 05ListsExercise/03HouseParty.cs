int numberOfCommands = int.Parse(Console.ReadLine());

List<string> guests = new List<string>();

for (int i = 0; i < numberOfCommands; i++)
{
    List<string> cmd = Console.ReadLine().Split().ToList();
    string name = cmd[0];
    cmd.RemoveAt(0);
    string currCmd = string.Join(" ",cmd);

    if (currCmd == "is going!")
    {
        if (guests.Contains(name)) 
        {
            Console.WriteLine($"{name} is already in the list!");
            continue;
        }
        else
        {
            guests.Add(name);
        }
    }
    else if (currCmd == "is not going!")
    {
        if (guests.Contains(name))
        {
            guests.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

Console.WriteLine(string.Join("\n", guests));