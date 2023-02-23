
using System.Text.RegularExpressions;

string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>\d+[.]?\d+)\$";
Regex regex = new Regex(pattern);

double totalSum = 0;
string input = Console.ReadLine();

while (input != "end of shift")
{
  Match match = regex.Match(input);

	if (!match.Success)
	{
        input = Console.ReadLine();
        continue;
    }

    string name = match.Groups["customer"].Value;
    string product = match.Groups["product"].Value;
    int count = int.Parse(match.Groups["count"].Value);
    double price = double.Parse(match.Groups["price"].Value);

    Console.WriteLine($"{name}: {product} - {count * price:f2}");
    totalSum += count * price;
    input = Console.ReadLine();
}

Console.WriteLine($"Total income: {totalSum:f2}");
