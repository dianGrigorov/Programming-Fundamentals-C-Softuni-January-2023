

int n = int.Parse(Console.ReadLine());

Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();


for (int i = 0; i < n; i++)
{
    string[] pieceInfo = Console.ReadLine().Split("|");
    string name = pieceInfo[0];
    string composer = pieceInfo[1];
    string key = pieceInfo[2];

    if (!pieces.ContainsKey(name))
    {
        pieces.Add(name, new Piece(composer, key));
       
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

        if (!pieces.ContainsKey(piece))
        {

            pieces.Add(piece, new Piece(composer, key));
            
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

        if (pieces.ContainsKey(piece))
        {
            pieces.Remove(piece);
            
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

        if (pieces.ContainsKey(piece))
        {
            pieces[piece].Key = key;
            Console.WriteLine($"Changed the key of {piece} to {key}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }

}

foreach (var item in pieces)
{
    //"{Piece} -> Composer: {composer}, Key: {key}"
    Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
    
}

public class Piece
{
    public Piece(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }

    public string Composer { get; set; }

    public string Key { get; set; }
}