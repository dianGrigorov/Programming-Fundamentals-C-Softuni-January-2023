
using System.Text.RegularExpressions;

string phoneNumber = Console.ReadLine();

string pattern = @"\+\b359( |-)2\1\d{3}\1\d{4}\b";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(phoneNumber);


string[] result = matches.Select(x => x.Value).ToArray();

Console.WriteLine(string.Join(", ", result));  