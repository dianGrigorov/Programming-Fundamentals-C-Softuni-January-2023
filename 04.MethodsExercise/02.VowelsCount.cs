string input = Console.ReadLine();
int cnt = CountVowelsLeter(input);
Console.WriteLine(cnt);
static int CountVowelsLeter(string input)
{
    char[] chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'y'};
    int cntChar = 0;
    
    
        foreach (var item in input.ToLower())
        {
            if (chars.Contains(item))
            {
            cntChar++;
            }
        }
    
    return cntChar;
}