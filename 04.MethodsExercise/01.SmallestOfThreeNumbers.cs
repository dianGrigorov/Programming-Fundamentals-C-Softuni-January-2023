int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

ChecMinNumber(a, b, c);
static void ChecMinNumber(int a, int b, int c)
{
    int min = Math.Min(a, b);
    if (min > c)
    {
        min = c;
    }
    Console.WriteLine(min);
}