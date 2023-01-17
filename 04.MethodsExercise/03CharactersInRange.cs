char a = char.Parse(Console.ReadLine());
char b = char.Parse(Console.ReadLine());
PrintCharInRange(a, b);
static void PrintCharInRange(char a, char b)
{
   
    if (a < b)
    {
        for (int i = a + 1; i < b; i++)
        {
            Console.Write((char)i + " ");
        }
    }
    if (b < a)
    {
        for (int i = b + 1; i < a; i++)
        {
            Console.Write((char)i + " ");
        }
    }

}