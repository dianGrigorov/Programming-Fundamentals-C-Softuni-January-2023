using System.Text;
using System.Text.RegularExpressions;

int massage = int.Parse(Console.ReadLine());

StringBuilder sb = new StringBuilder();

List<string> atacedPlanet = new List<string>();
List<string> destroyedPlanet= new List<string>();

for (int i = 0; i < massage; i++)
{
    string input = Console.ReadLine();

    int count = input.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
    foreach (var ch in input)
    {
        char newChar = (char)(ch - count);
        sb.Append(newChar);
    }
    string result = sb.ToString();
    string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<soldiers>[\d]+)";
    Regex regex = new Regex(pattern);
    MatchCollection matchCollection = regex.Matches(result);

    foreach (Match match in matchCollection)
    {
        string planetName = match.Groups["name"].Value;
        int planetPopulation = int.Parse(match.Groups["population"].Value);
        char type = char.Parse(match.Groups["type"].Value);
        int soldiers = int.Parse(match.Groups["soldiers"].Value);

        if (type == 'A')
        {
            atacedPlanet.Add(planetName);
        }
        else if (type == 'D')
        {
            destroyedPlanet.Add(planetName);
        }

    }
    sb.Clear();
}
Console.WriteLine($"Attacked planets: {atacedPlanet.Count}");
atacedPlanet.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));
Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");
destroyedPlanet.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));


