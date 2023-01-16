double n1 = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();
double n2 = double.Parse(Console.ReadLine());

double sum = MathOperation(operation, n1, n2);
Console.WriteLine(sum);

static double MathOperation(string operation, double n1, double n2)
{
	double sum = 0;
	if (operation == "/")
	{
		sum = n1 / n2;
	}
	else if (operation == "*")
	{
		sum = n1 * n2;
	}
	else if (operation == "+")
	{
		sum = n1 + n2;
	}
	else if (operation == "-")
	{
		sum = n1 - n2;
	}
	return sum;
}