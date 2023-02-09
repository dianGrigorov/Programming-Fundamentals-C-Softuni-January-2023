

string input = Console.ReadLine();

foreach (char ch in input)
{
	if (Char.IsDigit(ch))
	{
		Console.Write(ch);
	}
}
Console.WriteLine();
foreach(char ch in input)
{
	if (Char.IsLetter(ch))
	{
		Console.Write(ch);
	}
}
Console.WriteLine();
foreach (char ch in input)
{
    if (!Char.IsLetterOrDigit(ch))
    {
        Console.Write(ch);
    }
}