
using System.Numerics;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string patternEmoji = @"(:{2}|\*{2})(?<name>[A-Z][a-z]{2,})\1";

BigInteger thresholdSum = 1;

MatchCollection matchesEmoji = Regex.Matches(input, patternEmoji);

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
    {
        thresholdSum *= BigInteger.Parse(input[i].ToString());
    }
}

Console.WriteLine($"Cool threshold: {thresholdSum}");

Console.WriteLine($"{matchesEmoji.Count} emojis found in the text. The cool ones are:");

foreach (Match match in matchesEmoji)
{
    int emojiSum = 0;
    foreach(char ch in match.Groups["name"].Value)
    {
        emojiSum += ch;
    }
    if (emojiSum > thresholdSum)
    {
        Console.WriteLine(match);
    }
}