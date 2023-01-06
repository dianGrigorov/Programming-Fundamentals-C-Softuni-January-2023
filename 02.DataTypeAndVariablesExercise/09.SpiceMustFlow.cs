using System;
using System.Numerics;
namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spice = int.Parse(Console.ReadLine());
            int daysCnt = 0;
            BigInteger produseSpice = 0;
            int consume = 26;

            if (spice < 100)
            {
                produseSpice -= consume;
                if (produseSpice < 0)
                {
                    produseSpice = 0;
                }
                Console.WriteLine(daysCnt);
                Console.WriteLine(produseSpice);
                return;
            }
            else
            {
                while (spice >= 100)
                {
                    daysCnt++;
                    produseSpice += (BigInteger)spice - consume;
                    spice -= 10;

                }
               
            }
            produseSpice -= consume;

            Console.WriteLine(daysCnt);
            Console.WriteLine(produseSpice);
        }
    }
}
