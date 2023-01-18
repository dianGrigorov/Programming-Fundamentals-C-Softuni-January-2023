int number = int.Parse(Console.ReadLine());

IsDivisibleByEight(number);

static void IsDivisibleByEight(int number)
{
    for (int i = 1; i <= number; i++)
    {
        int num = i;
        int curentNum = 0;
        bool isDiferentFromZero = false;

        while (num > 0)
        {
            curentNum += num % 10;
            if (num % 2 != 0)
            {
                isDiferentFromZero = true;
            }
            
            num /= 10;
        }
        if (curentNum % 8 == 0 && isDiferentFromZero == true)
        {
            Console.WriteLine(i);
        }
    }
}