
string[] words = Console.ReadLine().Split();

Dictionary<string, int> counts = new Dictionary<string, int>();

foreach (string word in words)
{
    string wordInLowerCase = word.ToLower();

    if (!counts.ContainsKey(wordInLowerCase))
    {
        counts.Add(wordInLowerCase, 0);
    }
    counts[wordInLowerCase]++;
}

foreach (var count in counts)
{
    if (count.Value % 2 != 0)
    {
        Console.Write($"{count.Key}" + " ");
    }
}

