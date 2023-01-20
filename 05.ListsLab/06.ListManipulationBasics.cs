List<int> num = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] splitCommand = input.Split();
    string command = splitCommand[0];
    if (command == "Add")
    {
        int number = int.Parse(splitCommand[1]);
        num.Add(number);
    }
    else if (command == "Remove")
    {
        int number = int.Parse(splitCommand[1]);
        num.Remove(number);
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(splitCommand[1]);
        num.RemoveAt(index);

    }
    else if (command == "Insert")
    {
        int number = int.Parse(splitCommand[1]);
        int index = int.Parse(splitCommand[2]);
        num.Insert(index, number);
    }
}

Console.WriteLine(string.Join(" ", num));