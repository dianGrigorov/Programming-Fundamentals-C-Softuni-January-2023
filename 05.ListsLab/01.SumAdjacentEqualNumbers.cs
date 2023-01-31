List<int> num = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList(); ;
List<int> gaus = new List<int>();
for (int i = 0; i < num.Count / 2; i++)
{
    gaus.Add(num[i] + num[num.Count - i -1]);
 
}
if (num.Count % 2 != 0)
{
    gaus.Add(num[num.Count / 2]);
}
Console.WriteLine(string.Join(" ",gaus));
