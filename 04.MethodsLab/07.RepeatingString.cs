string input = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

string result = RepetingString(input, n);
Console.WriteLine(result);
static string RepetingString(string input, int n)
{
	string result = string.Empty;
	for (int i = 0; i < n; i++)
	{
		result += input;
	}
	return result;
}