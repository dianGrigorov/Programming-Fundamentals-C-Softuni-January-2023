using System;
using System.Net.Security;

namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int target = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCnt = 0;
            int startPower = power;

            while (power >= target)
            {
                pokeCnt++;
                power -= target;
                if (power != 0 && startPower != 0 && exhaustionFactor != 0)
                {
                    if (startPower / (double)power == 2)
                    {
                        power = power / exhaustionFactor;
                    }
                }

            }
            Console.WriteLine(power);
            Console.WriteLine(pokeCnt);


        }
    }
}
