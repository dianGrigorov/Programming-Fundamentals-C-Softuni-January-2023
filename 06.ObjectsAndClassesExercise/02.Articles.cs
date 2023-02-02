
string[] article = Console.ReadLine().Split(", ");


string title = article[0];
string content = article[1];
string author = article[2];

Articles art = new Articles(title, content, author);

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    List<string> commandArgument = Console.ReadLine().Split().ToList();
    string command = commandArgument[0];
    
    art.ChangeArticle(art, commandArgument, command);
}
Console.WriteLine(art.ToString());

public class Articles
{
    public Articles(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }

    public string Title { get; set; }

    public string Content { get; set; }

    public string Author { get; set; }

    public void ChangeArticle(Articles art, List<string>commandArgument, string command)
    {
        if (command == "Edit:")
        {
            commandArgument.RemoveAt(0);
            art.Content = string.Join(" ", commandArgument);
        }
        else if (command == "ChangeAuthor:")
        {
            commandArgument.RemoveAt(0);
            art.Author = string.Join(" ", commandArgument);
        }
        else if (command == "Rename:")
        {
            commandArgument.RemoveAt(0);
            art.Title = string.Join(" ", commandArgument);
        }
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }

}