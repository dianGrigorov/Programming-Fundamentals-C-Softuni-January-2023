
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
counts.Where(x => x.Value % 2 != 0);

foreach (var count in counts)
{

    Console.Write(count.Key + " ");
}

