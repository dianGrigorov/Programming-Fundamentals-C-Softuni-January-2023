int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    ColumnMethod(i); ;
}
for (int i = n -1; i >= 1; i--)
{
    ColumnMethod(i);
}
static void ColumnMethod(int i)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}