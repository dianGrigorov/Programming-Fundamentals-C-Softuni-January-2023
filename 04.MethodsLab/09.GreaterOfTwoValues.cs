internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string firstValue = Console.ReadLine();
        string secondValue = Console.ReadLine();

        if (type == "int")
        {
            int firstInt = int.Parse(firstValue);
            int secindInt = int.Parse(secondValue);

            int result = GetMax(firstInt, secindInt);
            Console.WriteLine(result);
        }
        else if (type == "char")
        {
            char firstChar = char.Parse(firstValue);
            char secondChar = char.Parse(secondValue);

            char result = GetMax(firstChar, secondChar);
            Console.WriteLine(result);
        }
        else if (type == "string")
        {
            string result = GetMAx(firstValue, secondValue);
            Console.WriteLine(result);
        }

    }
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }
    static char GetMax(char a, char b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }

    static string GetMAx(string a, string b)
    {
        int sumA = 0;
        int sumB = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sumA += a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            sumB += b[i];
        }
        if (sumA > sumB)
        {
            return a;
        }
        return b;
    }
}