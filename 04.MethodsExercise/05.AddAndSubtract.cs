int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int result= SubtractMethd(n1,n2, n3);
Console.WriteLine(result);
static int SumOfTwoNumbers(int n1, int n2)
{
    int sum = n1+ n2;
    return sum;
}
static int SubtractMethd(int n1, int n2, int n3)
{
    int result = SumOfTwoNumbers(n1,n2) - n3;
    return result;

}