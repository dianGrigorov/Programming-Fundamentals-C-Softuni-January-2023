
using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"([#|\|])(?<food>[A-Za-z \s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

Regex regex = new Regex(pattern);

MatchCollection products = regex.Matches(input);

int totalCalories = 0;

foreach (Match product in products)
{
    totalCalories += int.Parse(product.Groups["calories"].Value);
}
int days = totalCalories / 2000;
Console.WriteLine($"You have food to last you for: {days} days!");
foreach (Match product in products)
{
    string food = product.Groups["food"].Value;
    string date = product.Groups["date"].Value;
    int calories = int.Parse(product.Groups["calories"].Value);
    Console.WriteLine($"Item: {food}, Best before: {date}, Nutrition: {calories}");
}