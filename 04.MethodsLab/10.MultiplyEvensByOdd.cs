string input = Console.ReadLine();
int absNum = Math.Abs(int.Parse(input));

int sumEven = GetSumOfEvenSum(absNum.ToString());
int sumOdd = GetSumOfOddSum(absNum.ToString());

int multiply = sumEven * sumOdd;
Console.WriteLine(multiply);

static int GetSumOfOddSum(string input)
{
    int sum = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int curNum = int.Parse(input[i].ToString());
        if (curNum %2 != 0)
        {
            sum += curNum;
        }
    }
    return sum;
}

static int GetSumOfEvenSum(string input)
{
    int sum = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int curNum = int.Parse(input[i].ToString());
        if (curNum % 2 == 0)
        {
            sum += curNum;
        }
    }
    return sum;
}