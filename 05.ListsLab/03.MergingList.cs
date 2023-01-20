List<int> firstNum = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

List<int> secondNum = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> num = new List<int>();

int n = Math.Min(firstNum.Count, secondNum.Count);
for (int i = 0; i < n; i++)
{
    num.Add(firstNum[i]);
    num.Add(secondNum[i]);
}
if (firstNum.Count > secondNum.Count)
{
    for (int i = n; i < firstNum.Count; i++)
    {
        num.Add(firstNum[i]);
    }
}
if (secondNum.Count > firstNum.Count)
{
    for (int i = n; i < secondNum.Count; i++)
    {
        num.Add(secondNum[i]);
    }
}

Console.WriteLine(string.Join(" ", num));