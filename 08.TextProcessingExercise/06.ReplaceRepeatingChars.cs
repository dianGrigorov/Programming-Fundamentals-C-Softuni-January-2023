
string input = Console.ReadLine();

char currChar = input[0];

Console.Write(currChar);

for (int i = 1; i < input.Length; i++)
{
	if (currChar != input[i])
	{
		currChar = input[i];

		Console.Write(currChar);
	}
}