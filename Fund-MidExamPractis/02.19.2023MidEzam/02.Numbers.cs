List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command;

while ((command = Console.ReadLine()) != "Finish")
{
    string[] commArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string currCommand = commArg[0];
    int value = int.Parse(commArg[1]);
    if (currCommand == "Add")
    {
        numbers.Add(value);
    }
    else if (currCommand == "Remove")
    {
        numbers.Remove(value);
    }
    else if (currCommand == "Replace")
    {
        int replacement = int.Parse(commArg[2]);
        int index = numbers.IndexOf(value);
        if (numbers.Contains(value))
        {
            numbers.RemoveAt(index);
            numbers.Insert(index, replacement);
        }
        
    }
    else if (currCommand == "Collapse")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < value)
            {
                numbers.Remove(numbers[i]);
                i = -1;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", numbers));