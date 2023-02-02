
using System.Globalization;

List<Article> articles= new List<Article>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] curArticle = Console.ReadLine().Split(", ");
    string title = curArticle[0];
    string content = curArticle[1];
    string author = curArticle[2];

    Article article = new Article(title, content, author);

    articles.Add(article);
}
string line = Console.ReadLine();

foreach (Article article in articles)
{
    Console.WriteLine(article.ToString());
}
public class Article
{
    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;

    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}