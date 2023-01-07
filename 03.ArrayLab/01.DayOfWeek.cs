using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num =  int.Parse(Console.ReadLine());
            string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday",
                                   "Friday", "Saturday", "Sunday"};
            switch (num)
            {
                case 1:
                    Console.WriteLine(daysOfWeek[num -1]);
                    break;
                case 2:
                    Console.WriteLine(daysOfWeek[num - 1]);
                    break;
                case 3:
                    Console.WriteLine(daysOfWeek[num - 1]);
                    break;
                case 4:
                    Console.WriteLine(daysOfWeek[num - 1]);
                    break;
                case 5:
                    Console.WriteLine(daysOfWeek[num - 1]);
                    break;
                case 6:
                    Console.WriteLine(daysOfWeek[num - 1]);
                    break;
                case 7:
                    Console.WriteLine(daysOfWeek[num - 1]);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}
