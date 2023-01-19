List<double> num = Console.ReadLine()
	.Split()
	.Select(double.Parse)
	.ToList();

for(int i = 0;i < num.Count - 1; i++)
{
	if (num[i] == num[i + 1])
	{
		num[i] = num[i] + num[i + 1];
		num.Remove(num[i + 1]);
        i = -1;
    }
}
Console.WriteLine(string.Join(" ", num));