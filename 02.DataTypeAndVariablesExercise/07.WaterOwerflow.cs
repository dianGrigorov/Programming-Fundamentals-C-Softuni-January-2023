using System;

namespace _07.WaterOwerflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 255;
            int pouredLiters = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters <= tank)
                {
                    tank -= liters;
                    pouredLiters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }


            }
            Console.WriteLine(pouredLiters);


        }
    }
}
