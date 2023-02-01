

string[] phrases = new string[] { "Excellent product.", "Such a great product.",
    "I always use that product.", "Best product of its category.", "Exceptional product."
    , "I can't live without this product." };

string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.", "I feel great!" };

string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

//{phrase} {event} {author} – {city}.

int n = int.Parse(Console.ReadLine());



for (int i = 0; i < n; i++)
{
    string currPhrase = GetRandomWord(phrases);
    string currEvent = GetRandomWord(events);
    string currAuth = GetRandomWord(authors);
    string currCity = GetRandomWord(cities);

    Console.WriteLine($"{currPhrase} {currEvent} {currAuth} – {currCity}.");
}


static string GetRandomWord(string[] words)
{ 
    Random word = new Random();
    int wordIndex = word.Next(0, words.Length);
    string randomWord = words[wordIndex];

    return randomWord;
}