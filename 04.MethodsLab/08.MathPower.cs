double num = double.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
double result = MathPowerOfNum(num, power);
Console.WriteLine(result);
static double MathPowerOfNum(double num, int power)
{
    double result = Math.Pow(num, power);
   
    return result;
}