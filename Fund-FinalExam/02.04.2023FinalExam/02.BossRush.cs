
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+\s[A-Za-z]+)#";

Regex regex = new Regex(pattern);
Dictionary<string, string> bosses = new Dictionary<string, string>(); 
for (int i = 0; i < n; i++)
{
    string token = Console.ReadLine();
    Match matches = regex.Match(token);
    if (matches.Success)
    {
        string name = matches.Groups["name"].Value;
        string title = matches.Groups["title"].Value;
        Console.WriteLine($"{name}, The {title}");
        Console.WriteLine($">> Strength: {name.Length}");
        Console.WriteLine($">> Armor: {title.Length}");
    }
    else
    {
        Console.WriteLine("Access denied!");
    }
}
