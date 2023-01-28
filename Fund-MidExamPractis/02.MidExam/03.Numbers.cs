using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> num = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

            List<int> result = new List<int>();
            double averageValue = num.Sum() / (double)num.Count;
            byte cnt = 0;
            foreach (int item in num)
            {
                if (item > averageValue)
                {
                    result.Add(item);
                    cnt++;
                    
                }
            }
            result.Sort();
            result.Reverse();

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (cnt >= 5)
            {
                Console.WriteLine(string.Join(" ", result.GetRange(0, 5)));
            }
            else
            {

                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
