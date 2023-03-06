
string rawKey = Console.ReadLine();

string command;

while ((command = Console.ReadLine()) != "Generate")
{
    string[] commArg = command.Split(">>>");
    string currCom = commArg[0];

    if (currCom == "Contains")
    {
        string substring = commArg[1];
        if (rawKey.Contains(substring))
        {
            Console.WriteLine($"{rawKey} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (currCom == "Flip")
    {
        string upperOrLower = commArg[1];
        int startIndex = int.Parse(commArg[2]);
        int endIndex = int.Parse(commArg[3]);
        int lenght = endIndex - startIndex;

        if (upperOrLower == "Upper")
        {
            string subString = rawKey.Substring(startIndex, lenght);
            string upperSubString = subString.ToUpper();
            rawKey = rawKey.Replace(subString, upperSubString);
        }
        else if (upperOrLower == "Lower")
        {
            string subString = rawKey.Substring(startIndex, lenght);
            string lowerSubString = subString.ToLower();
            rawKey = rawKey.Replace(subString, lowerSubString);
            
        }
        Console.WriteLine(rawKey);
    }
    else if (currCom == "Slice")
    {
        int startIndex = int.Parse(commArg[1]);
        int endIndex = int.Parse(commArg[2]);
        int lenght = endIndex - startIndex;
        rawKey = rawKey.Remove(startIndex, lenght);
        Console.WriteLine(rawKey);
    }
}
Console.WriteLine($"Your activation key is: {rawKey}");