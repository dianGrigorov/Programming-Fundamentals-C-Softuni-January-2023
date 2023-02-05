string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<char, int> occurrences = new Dictionary<char, int>();

foreach(string word in words)
{
    string currentWord = word;

	foreach (char item in currentWord)
	{
		if (!occurrences.ContainsKey(item))
		{
			occurrences.Add(item, 0);
		}
		occurrences[item]++;
	}
}
foreach(var item in occurrences)
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}