List<int> firstInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> secondInput = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
List<int> result= new List<int>();
int min = Math.Min(firstInput.Count, secondInput.Count);

for (int i = 0; i < min; i++)
{
    result.Add(firstInput[i]);
    result.Add(secondInput[i]);
}
if (firstInput.Count > secondInput.Count)
{
    for (int i = min; i < firstInput.Count; i++)
    {
        result.Add(firstInput[i]);
    }
}
if (firstInput.Count < secondInput.Count)
{
    for (int i = min; i < secondInput.Count; i++)
    {
        result.Add(secondInput[i]);
    }
}
Console.WriteLine(string.Join(" ", result));
