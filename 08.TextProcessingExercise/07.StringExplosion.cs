
using System.Data.Common;
using System.Text;

string input = Console.ReadLine();

//abv>1>1>2>2asdasd
StringBuilder builder = new StringBuilder();

int power = 0;

for (int i = 0; i < input.Length; i++)
{
	char curr = (char)input[i];
	if (curr == '>')
	{
		power += int.Parse(input[i + 1].ToString());
		builder.Append(curr);
	}
	else if (power == 0)
	{
        builder.Append(curr);
    }
	else
	{
		power--;
	}

}

Console.WriteLine(builder);