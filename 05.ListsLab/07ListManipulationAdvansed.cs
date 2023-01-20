List<int> num = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
bool flag = false;
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] splitCommand = input.Split();
    string command = splitCommand[0];
    if (command == "Add")
    {
        int number = int.Parse(splitCommand[1]);
        num.Add(number);
        flag = true;
    }
    else if (command == "Remove")
    {
        int number = int.Parse(splitCommand[1]);
        num.Remove(number);
        flag = true;
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(splitCommand[1]);
        num.RemoveAt(index);
        flag = true;

    }
    else if (command == "Insert")
    {
        int number = int.Parse(splitCommand[1]);
        int index = int.Parse(splitCommand[2]);
        num.Insert(index, number);
        flag = true;
    }
    else if (command == "Contains")
    {
        int number = int.Parse(splitCommand[1]);
        if (num.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }

    }
    else if (command == "PrintEven")
    {
        Console.WriteLine(string.Join(" ", num.Where(x => x % 2 == 0)));

    }
    else if (command == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", num.Where(x => x % 2 != 0)));
    }
    else if (command == "GetSum")
    {
        Console.WriteLine(num.Sum());
    }
    else if (command == "Filter")
    {
        string condition = splitCommand[1];
        int number = int.Parse(splitCommand[2]);
        if (condition == "<")
        {
            Console.WriteLine(string.Join(" ", num.Where(x => x < number))); 
        }
        else if (condition == ">") 
        {
            Console.WriteLine(string.Join(" ", num.Where(x => x > number)));
        }
        else if (condition == ">=")
        {
            Console.WriteLine(string.Join(" ", num.Where(x => x >= number)));
        }
        else if (condition == ">=")
        {
            Console.WriteLine(string.Join(" ", num.Where(x => x <= number)));
        }
    }
}

if (flag)
{
    Console.WriteLine(string.Join(" ", num));
}