
int n = int.Parse(Console.ReadLine());
Dictionary<string, string> pieceComposer = new Dictionary<string, string>();
Dictionary<string, string> pieceKey = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string[] pieceInfo = Console.ReadLine().Split("|");
    string name = pieceInfo[0];
    string composer = pieceInfo[1];
    string key = pieceInfo[2];
    
    if (!pieceComposer.ContainsKey(name))
    {
        pieceComposer.Add(name, composer);
        pieceKey.Add(name, key);
    }
}

string input;
while ((input = Console.ReadLine()) != "Stop")
{
    string[] commandArg = input.Split("|");
    string command = commandArg[0];

    if (command == "Add")
    {
        string piece = commandArg[1];
        string composer = commandArg[2];
        string key = commandArg[3];

        if (!pieceComposer.ContainsKey(piece))
        {
            
            pieceComposer.Add(piece, composer);
            pieceKey.Add(piece, key);
            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
        else
        {
            Console.WriteLine($"{piece} is already in the collection!");
        }
    }
    else if (command == "Remove")
    {
        string piece = commandArg[1];

        if (pieceComposer.ContainsKey(piece))
        {
            pieceComposer.Remove(piece);
            pieceKey.Remove(piece);
            Console.WriteLine($"Successfully removed {piece}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
    else if (command == "ChangeKey")
    {
        string piece = commandArg[1];
        string key = commandArg[2];

        if (pieceComposer.ContainsKey(piece))
        {
            pieceKey[piece] = key;
            Console.WriteLine($"Changed the key of {piece} to {key}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }

}

foreach (var item in pieceComposer)
{
    //"{Piece} -> Composer: {composer}, Key: {key}"
    foreach (var key in pieceKey)
    {
        if (item.Key == key.Key)
        {
            Console.WriteLine($"{item.Key} -> Composer: {item.Value}, Key: {key.Value}");
        }
    }
   
}