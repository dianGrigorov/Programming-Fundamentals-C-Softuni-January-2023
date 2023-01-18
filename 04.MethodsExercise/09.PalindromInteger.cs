string input;
while ((input = Console.ReadLine()) != "END")
{
    if (IsPalindromeOrNot(input))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}

static bool IsPalindromeOrNot(string input)
{
    string reverceString = string.Empty;

    for (int i = input.Length - 1; i >= 0; i--)
    {
        reverceString += input[i];
    }

    if (input == reverceString)
    {
        return true;
    }
    return false;
}
