List<string> words = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input;
while ((input = Console.ReadLine()) != "3:1")
{
    string[] commArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commArg[0];
    if (command == "merge")
    {
        int startIndex = int.Parse(commArg[1]);
        int endIndex = int.Parse(commArg[2]);

        ValidateIndexes(words, ref startIndex, ref endIndex);
        MergeWords(words, startIndex, endIndex);

    }
    else if (command == "divide")
    {
        int index = int.Parse(commArg[1]);
        int partition = int.Parse(commArg[2]);

        string currWord = words[index];

        List<string> newWords = DivideWord(currWord, partition);

        words.RemoveAt(index);
        words.InsertRange(index, newWords);
    }
}

Console.WriteLine(string.Join(" ", words));

static void ValidateIndexes(List<string> words, ref int startIndex, ref int endIndex)
{
    if (startIndex < 0)
    {
        startIndex = 0;
    }
    if (endIndex > words.Count - 1)
    {
        endIndex = words.Count - 1;
    }
   
}

static void MergeWords(List<string> words, int startIndex, int endIndex)
{
    for (int i = startIndex; i < endIndex; i++)
    {
        words[startIndex] += words[i + 1];
        words.RemoveAt(i + 1);
        endIndex--;
        i--;

    }
}

static List<string> DivideWord(string currWord, int partition)
{
    int partitionLenght = currWord.Length / partition;
    int lastPartition = currWord.Length - ((partition - 1) * partitionLenght);

    List<string> newWords = new List<string>();
    for (int i = 0; i < partition; i++)
    {
        int desiredLenght = partitionLenght;
        if (i == partition - 1)
        {
            desiredLenght = lastPartition;
        }
        char[] newPartitinArr = currWord.Skip(i * partitionLenght)
            .Take(desiredLenght).ToArray();
        string newPartition = string.Join("", newPartitinArr);
        newWords.Add(newPartition);
    }
    return newWords;
}

