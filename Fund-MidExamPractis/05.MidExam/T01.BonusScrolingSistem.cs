using System;

namespace T01.BonusScrolingSistem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectuse = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int bestAttendance = 0;

            for (int i = 0; i < students; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double totalBonus = (double)attendance / lectuse * (5 + bonus);
                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    bestAttendance = attendance;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {bestAttendance} lectures.");
        }
    }
}
