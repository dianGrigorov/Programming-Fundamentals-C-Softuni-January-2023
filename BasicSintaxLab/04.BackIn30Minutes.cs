using System;

namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int addMin = minutes + 30;

            if (addMin > 60)
            {
                hours++;
               
                if (hours >=24)
                {
                    hours = 0;
                }
            }
            if (addMin > 60)
            {
                addMin -= 60;
            }
            Console.WriteLine($"{hours}:{addMin:d2}");

        }
    }
}
