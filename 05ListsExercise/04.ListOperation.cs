List<int> num = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] cmd = input.Split(" ");
    string currCmd = cmd[0];
    if (currCmd == "Add")
    {
        int number = int.Parse(cmd[1]);
        num.Add(number);
    }
    else if (currCmd == "Insert")
    {
        int number = int.Parse(cmd[1]);
        int index = int.Parse(cmd[2]);
        if (index < 0 || index >= num.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            num.Insert(index, number);
        }

    }
    else if (currCmd == "Remove")
    {
        int index = int.Parse(cmd[1]);
        if (index < 0 || index >= num.Count)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            num.RemoveAt(index);
        }
    }
    else if (currCmd == "Shift")
    {
        string secCmd = cmd[1];
        if (secCmd == "left")
        {
            int count = int.Parse(cmd[2]);

            for (int i = 0; i < count; i++)
            {
                int firstNum = num[0];
                num.RemoveAt(0);
                num.Add(firstNum);
            }

        }
        else if (secCmd == "right")
        {
            int count = int.Parse(cmd[2]);

            for (int i = 0; i < count; i++)
            {
                int lastNum = num[num.Count - 1];
                num.RemoveAt(num.Count - 1);
                num.Insert(0, lastNum);
            }
        }
    }
}

Console.WriteLine(string.Join(" ", num));