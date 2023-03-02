

string message = Console.ReadLine();

string info;

while ((info = Console.ReadLine()) != "Reveal")
{
    string[] commArg = info.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

    string currComm = commArg[0];

    if (currComm == "InsertSpace")
    {
        int index = int.Parse(commArg[1]);
        message = message.Insert(index, " ");
        Console.WriteLine(message);
    }
    else if (currComm == "Reverse")
    {
        string subString = commArg[1];

        if (message.Contains(subString))
        {

            //char[] subChars = subString.ToCharArray();
            //subChars.Reverse();
            //Array.Reverse(subChars);
            string reversed = new string(subString.Reverse().ToArray());

            int index = message.IndexOf(subString);
            message = message.Remove(index, subString.Length);
            message += reversed;
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (currComm == "ChangeAll")
    {
        string oldStr = commArg[1];
        string newStr = commArg[2];

        if (message.Contains(oldStr))
        {
            message = message.Replace(oldStr, newStr);
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine(message);
        }
    }
}

Console.WriteLine($"You have a new text message: {message}");