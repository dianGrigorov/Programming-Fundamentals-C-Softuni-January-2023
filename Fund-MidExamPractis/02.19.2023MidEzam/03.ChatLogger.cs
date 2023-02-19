List<string> massage = new List<string>();

string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] commArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string currComand = commArg[0];

    if (currComand == "Chat")
    {
        string currMassage = commArg[1];
        massage.Add(currMassage);
    }
    else if (currComand == "Delete")
    {
        string currMassage = commArg[1];
        if (massage.Contains(currMassage))
        {
            massage.Remove(currMassage);
        }
    }
    else if (currComand == "Edit")
    {
        string currMassage = commArg[1];
        string editedMassage = commArg[2];
        int index = massage.IndexOf(currMassage);
        if (massage.Contains(currMassage))
        {
            massage.RemoveAt(index);
            massage.Insert(index, editedMassage);
        }
    }
    else if (currComand == "Pin")
    {
        string currMassage = commArg[1];
        if (massage.Contains(currMassage))
        {
            massage.Remove(currMassage);
            massage.Add(currMassage);
        }
        
    }
    else if (currComand == "Spam")
    {
        string currMassage = commArg[1];
        string[] spam = input.Split(" ").Skip(1).ToArray();
        for (int i = 0; i < spam.Length; i++)
        {
            massage.Add(spam[i]);
        }
    }
}

Console.WriteLine(string.Join(Environment.NewLine, massage));