
string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double sum = 0;
foreach (string item in input)
{
    char firstLetter = item[0];
    char lastLetter = item[item.Length - 1];

    double result = 0;
    double num = double.Parse(item.Substring(1, item.Length - 2));
        //If it's uppercase you divide the number by the letter's position in the alphabet. 
        //If it's lowercase you multiply the number with the letter's position in the alphabet. 

    if (firstLetter >= 65 && firstLetter <= 90)
    {
        int uperLetterPosition = (int)firstLetter - 64;
        result += num / uperLetterPosition;
    }
    else
    {
        int lowerLetterPosition = (int)firstLetter - 96;
        result += num * lowerLetterPosition;
    }

        //•	If it's uppercase you subtract its position from the resulted number.
        //•	If it's lowercase you add its position to the resulted number.

    if (lastLetter >= 65 && lastLetter <= 90)
    {
        int uperLetterPosition = (int)lastLetter - 64;
        result -= uperLetterPosition;
    }
    else
    {
        int lowerLetterPosition = (int)lastLetter - 96;
        result += lowerLetterPosition;
    }
    sum += result;
}

Console.WriteLine($"{sum:f2}");