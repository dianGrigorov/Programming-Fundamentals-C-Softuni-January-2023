

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

MultiplierString(input);

static void MultiplierString(string[] input)
{ 
    string firstStr = input[0];
    string secondStr = input[1];
	int sum = 0;
	if (firstStr.Length < secondStr.Length)
	{
		for (int i = 0; i < firstStr.Length; i++)
		{
			sum += firstStr[i] * secondStr[i];
		}
		for (int i = firstStr.Length; i < secondStr.Length; i++)
		{
			sum += secondStr[i];
		}
	}
	else
	{
		for (int i = 0; i < secondStr.Length; i++)
		{
            sum += firstStr[i] * secondStr[i];
        }

		for (int i = secondStr.Length; i < firstStr.Length; i++)
		{
			sum += firstStr[i];
		}
	}
	Console.WriteLine(sum);
}