using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte people = sbyte.Parse(Console.ReadLine());
            sbyte capacity = sbyte.Parse(Console.ReadLine());
            byte course = 0;

            while (people > 0)
            {
                people -= capacity;
                
                course++;
            }
            Console.WriteLine(course);
        }
    }
}
