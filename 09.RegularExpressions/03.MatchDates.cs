
using System;
using System.Text.RegularExpressions;

string pattern = @"\b(?<day>\d{2})(.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

string input = Console.ReadLine();

Regex regex = new Regex(pattern); 

MatchCollection validDates = regex.Matches(input);

foreach(Match date in validDates)
{
    string day = date.Groups["day"].Value;
    string month = date.Groups["month"].Value;
    string year = date.Groups["year"].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}