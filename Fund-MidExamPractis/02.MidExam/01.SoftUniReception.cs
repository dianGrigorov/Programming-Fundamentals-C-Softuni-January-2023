using System;

namespace _01SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstrEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());

            int studentsQuestions = int.Parse(Console.ReadLine());

            int totalHours = 0;

            int questionsPerHour = firstrEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            while (studentsQuestions > 0)
            {
                totalHours++;
                if (totalHours % 4 == 0)
                {
                    if (studentsQuestions <= 0)
                    {
                        break;
                    }
                    continue;
                }
                studentsQuestions -= questionsPerHour;
            }

            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}
