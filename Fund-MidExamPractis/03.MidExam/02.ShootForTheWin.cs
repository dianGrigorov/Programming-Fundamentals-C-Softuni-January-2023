using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int cnt = 0;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if (index < 0 || index>= num.Length || num[index] == -1)
                {
                    continue;
                }
                int currNum = num[index];
                num[index] = -1;
                cnt++;

                for (int i = 0 ; i < num.Length; i++)
                {
                    if (currNum >= num[i] && num[i] != -1)
                    {
                        num[i] += currNum;
                    }
                    else if ( currNum < num[i] && num[i] != -1)
                    {
                        num[i] -= currNum;
                    }
                }
                
            }
            Console.WriteLine($"Shot targets: {cnt} -> {string.Join(" ", num)}");
        }
    }
}
