
using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(=|/)(?<place>[A-Za-z]{3,})\1";

List<string> places = new List<string>();

MatchCollection matches = Regex.Matches(input, pattern);

int sum = 0;

foreach (Match match in matches)
{
    places.Add(match.Groups["place"].Value);
    sum += match.Groups["place"].Value.Length;
}
Console.WriteLine($"Destinations: {string.Join(", ", places)}");
Console.WriteLine($"Travel Points: {sum}");