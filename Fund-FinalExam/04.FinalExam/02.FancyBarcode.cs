using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());

string pattern = @"@\#+(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])@\#+";

for (int i = 0; i < n; i++)
{
    string barcode = Console.ReadLine();
	Match match = Regex.Match(barcode, pattern);
	if (match.Success)
	{
		string product = match.Groups[1].Value;
		string productGroup = string.Empty;
		foreach(char cha in product)
		{
			if (Char.IsDigit(cha))
			{
                productGroup += cha;
			}
		}
		if (productGroup == string.Empty)
		{
			productGroup = "00";
		}
        Console.WriteLine($"Product group: {productGroup}");
    }
	else
	{
        Console.WriteLine("Invalid barcode");
    }
}
