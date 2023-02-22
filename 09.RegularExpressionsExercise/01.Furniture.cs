
using System;
using System.Text.RegularExpressions;

string pattern = @">>(?<furniture>[A-z]+)<<(?<price>\d*.?[\d]+)!(?<quantity>[\d]+)";

string input;

Regex regex = new Regex(pattern);

List<string> furnitures = new List<string>();

double sum = 0;
while ((input = Console.ReadLine()) != "Purchase")
{
    Match matches = regex.Match(input);
    if (matches.Success)
    {
        string furniture = matches.Groups["furniture"].Value;
        furnitures.Add(furniture);
        double price = double.Parse(matches.Groups["price"].Value);
        int quanttity = int.Parse(matches.Groups["quantity"].Value);
        sum += price * quanttity;
    }
       
    

}
Console.WriteLine("Bought furniture:");
Console.WriteLine(string.Join(Environment.NewLine, furnitures));
Console.WriteLine($"Total money spend: {sum:f2}");

