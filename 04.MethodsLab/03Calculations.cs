string command = Console.ReadLine();
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

if (command == "add")
{
    AddMethod(firstNum, secondNum);
}
else if (command == "multiply")
{
    MultiplyMethod(firstNum, secondNum);
}
else if (command == "subtract")
{
    SubstractMethod(firstNum, secondNum);
}
else if (command == "divide")
{
    DivideMethod(firstNum, secondNum);
}

static void AddMethod(int firstNum, int secondNum)
{
    int result = firstNum + secondNum;
}

static void MultiplyMethod(int firstNum, int secondNum)
{
    int result = firstNum * secondNum;
    Console.WriteLine(result);
}
static void SubstractMethod(int firstNum, int secondNum)
{
    int result = firstNum - secondNum;
    Console.WriteLine(result);
}
static void DivideMethod(int firstNum, int secondNum)
{ 
    int result = firstNum/ secondNum;
    Console.WriteLine(result);
}