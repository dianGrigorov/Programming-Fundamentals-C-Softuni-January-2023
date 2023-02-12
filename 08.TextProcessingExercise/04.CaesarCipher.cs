
using System.Text;

string input = Console.ReadLine();

char[] result = input.ToCharArray();

for (int i = 0; i < input.Length; i++)
{
    result[i] = (char)(input[i] + 3);
    
}

Console.WriteLine(string.Join("", result));