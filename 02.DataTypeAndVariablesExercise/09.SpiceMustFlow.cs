using System;
using System.Numerics;
namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint spice = uint.Parse(Console.ReadLine());
            uint daysCnt = 0;
            BigInteger produseSpice = 0;
            uint consume = 26;

            while (spice >= 100)
            {
                daysCnt++;
                produseSpice += (BigInteger)spice - consume;
                spice -= 10;

            }
            produseSpice -= consume;
            if (spice <= consume)
            {
                produseSpice = 0;
            }
            Console.WriteLine(daysCnt);
            Console.WriteLine(produseSpice);
        }
    }
}
