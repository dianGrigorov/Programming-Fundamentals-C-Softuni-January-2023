string input = Console.ReadLine();
MiddleCharacter(input);
static void MiddleCharacter(string input)
{
    string result = string.Empty;
    if (input.Length % 2 == 0)
    {
        result += (char)input[input.Length / 2 - 1];
        result += (char)input[input.Length / 2];
    }
    else
    {
        result+= input[input.Length / 2];
    }
    Console.WriteLine(result);
}