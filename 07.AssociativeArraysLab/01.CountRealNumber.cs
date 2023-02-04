
List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

SortedDictionary<int, int> result = new SortedDictionary<int, int>();

foreach (var number in numbers)
{
    if (!result.ContainsKey(number))
    {
        result.Add(number, 0);
    }

    result[number]++;
}

foreach(var number in result)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}