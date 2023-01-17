int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

int result1 = CalculateTheFactorielOfNumber(n1);
int result2 = CalculateTheFactorielOfNumber(n2);
double finalResult = (double)result1 / (double)result2;
Console.WriteLine($"{finalResult:f2}");
static int CalculateTheFactorielOfNumber(int n)
{
	int sum = 1;	
	for (int i = 1; i <= n; i++)
	{
		sum *= i;
	}
	return sum;
}