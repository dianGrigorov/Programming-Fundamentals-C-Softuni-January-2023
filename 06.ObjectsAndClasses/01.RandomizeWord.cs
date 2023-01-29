string[] words = Console.ReadLine().Split(" ");

Random word = new Random();

for (int i = 0; i < words.Length; i++)
{
    int rndIndex = word.Next(0, words.Length);
    // 1 2 3 4 5 6
    string currentWord = words[i];
    words[i] = words[rndIndex];
    words[rndIndex] = currentWord;
    

    
    
}
Console.WriteLine(string.Join(Environment.NewLine, words));