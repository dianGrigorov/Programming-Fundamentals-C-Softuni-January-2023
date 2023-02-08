
using System.Text;

string[] word = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

StringBuilder result = new StringBuilder();

foreach (var w in word)
{
    int count = w.Length;
	for (int i = 0; i < count; i++)
	{
		result = result.Append(w);
	}
}
Console.WriteLine(result);