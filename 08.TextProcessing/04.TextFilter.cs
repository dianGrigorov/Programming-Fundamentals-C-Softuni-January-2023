

string[] bannedWords = Console.ReadLine().Split(", ");

string text = Console.ReadLine();

foreach(string currWord in bannedWords)
{
    text = text.Replace(currWord, new string('*', currWord.Length));
}

Console.WriteLine(text);
