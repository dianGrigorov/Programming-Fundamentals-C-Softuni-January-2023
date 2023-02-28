string road = Console.ReadLine();

string input;

while ((input = Console.ReadLine()) != "Travel")
{
    string[] commandArg = input.Split(":");
    string curCommand = commandArg[0];

    if (curCommand == "Add Stop")
    {
        int index = int.Parse(commandArg[1]);
        string place = commandArg[2];

        road = road.Insert(index, place);
        Console.WriteLine(road);
    }
    else if (curCommand == "Remove Stop")
    {
        int startIndex = int.Parse(commandArg[1]);
        int endIndex = int.Parse(commandArg[2]);


        if (startIndex > 0 && startIndex < road.Length && endIndex > 0 && endIndex < road.Length)
        {
            int count = endIndex - startIndex + 1;
            road = road.Remove(startIndex, count);
            Console.WriteLine(road);
        }
    }
    else if (curCommand == "Switch")
    {
        string oldString = commandArg[1];
        string newString = commandArg[2];

        if (road.Contains(oldString))
        {
            road = road.Replace(oldString, newString);
            Console.WriteLine(road);
        }
    }

}
Console.WriteLine($"Ready for world tour! Planned stops: {road}");