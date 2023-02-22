
using System.Text.RegularExpressions;

string input = Console.ReadLine();

string tamplate = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

MatchCollection mathcedNames = Regex.Matches(input,tamplate);

foreach(Match name in mathcedNames)
{
    Console.Write(name.Value + " ");
}