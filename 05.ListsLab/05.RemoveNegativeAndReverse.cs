List<int> num = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

num.RemoveAll(x => x < 0);
num.Reverse();

if (num.Count == 0)
{
    Console.WriteLine("empty");
}

Console.WriteLine(string.Join(" ", num));