
using System.Text.RegularExpressions;

List<string> racers = Console.ReadLine().Split(", ").ToList();
Dictionary<string, int> score = new Dictionary<string, int>();

string regexLater = @"[A-Za-z]";
string regexDigits = @"[0-9]";

string input = Console.ReadLine();

while (input != "end of race")
{
    string name = string.Empty;
    int distance = 0;
    MatchCollection regexName = Regex.Matches(input, regexLater);
    MatchCollection regexNum = Regex.Matches(input, regexDigits);
    foreach (Match ch in regexName)
    {
        name += ch;
    }
    foreach (Match match in regexNum)
    {
        distance += int.Parse(match.Value);
    }
    if (racers.Contains(name))
    {
        if (!score.ContainsKey(name))
        {
            score.Add(name, distance);
        }
        else
        {
            score[name] += distance;
        }
    }
    
    input = Console.ReadLine();

}

var sortedRacer = score.OrderByDescending(x => x.Value);

int place = 1;
foreach (var item in sortedRacer)
{
   
    if (place == 1)
    {
        Console.WriteLine($"1st place: {item.Key}");
    }
    else if (place == 2)
    {
        Console.WriteLine($"2nd place: {item.Key}");
    }
    else if (place == 3)
    {
        Console.WriteLine($"3rd place: {item.Key}");
    }
    else
    {
        break;
    }
    place++;
}


