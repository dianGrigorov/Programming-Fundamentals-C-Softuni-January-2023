using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string maxType = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (maxVolume < volume)
                {
                    maxVolume = volume;
                    maxType = modelOfKeg;
                }
            }
            Console.WriteLine(maxType);
        }
    }
}
