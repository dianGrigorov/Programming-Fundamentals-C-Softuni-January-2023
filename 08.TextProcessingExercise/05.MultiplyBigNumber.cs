

using System.Text;

string bigNum = Console.ReadLine();
int multiply = int.Parse(Console.ReadLine());

var finalResult = new StringBuilder();

int reminder = 0;

for (int i = bigNum.Length - 1; i >= 0; i--)
{
    int currDig = int.Parse(bigNum[i].ToString());
    int product = currDig * multiply + reminder;
    int result = product % 10;
    reminder = product / 10;
    finalResult.Insert(0, result);

}
if (reminder > 0)
{
    finalResult.Insert(0, reminder);
}
Console.WriteLine(finalResult.ToString());