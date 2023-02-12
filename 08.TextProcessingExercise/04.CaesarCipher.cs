
using System.Text;

string input = Console.ReadLine();

StringBuilder result = new StringBuilder();

foreach (var ch in input)
{
    int currChar = ch + 3;
    result.Append((char)currChar);
}

Console.WriteLine(result.ToString());