
using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"(#|@)(?<firstWords>[A-Za-z]{3,})\1{2}(?<secondWord>[A-Za-z]{3,})\1";

MatchCollection matchCollection = Regex.Matches(text, pattern);
List<string> matchedWords = new List<string>();

foreach (Match match in matchCollection)
{
    string firstWord = match.Groups["firstWords"].Value;
    string secondWord = match.Groups["secondWord"].Value;

    if (firstWord == new string(secondWord.Reverse().ToArray()))
    {
        string matches = firstWord + " <=> " + secondWord;
        matchedWords.Add(matches);
       
    }
}
if (matchCollection.Count == 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{matchCollection.Count} word pairs found!");
}

if (matchedWords.Count == 0)
{
    Console.WriteLine("No mirror words!");
}
else
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(string.Join(", ", matchedWords));
}