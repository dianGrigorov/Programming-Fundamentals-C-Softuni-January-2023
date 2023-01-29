

int n = int.Parse(Console.ReadLine());


List<Song> songs = new List<Song>();


for (int i = 0; i < n; i++)
{
    string[] currInput = Console.ReadLine().Split("_");

    string typeList = currInput[0];
    string name = currInput[1];
    string time = currInput[2];

    Song song = new Song(typeList, name, time);

    songs.Add(song);
}

string list = Console.ReadLine();

for (int i = 0; i < songs.Count; i++)
{
    Song currSong = songs[i];

    if (list == "all")
    {
        Console.WriteLine(currSong.Name);
    }
    else if (list == currSong.TypeList)
    {
        Console.WriteLine(currSong.Name);
    }
}

public class Song
{
    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }

    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}