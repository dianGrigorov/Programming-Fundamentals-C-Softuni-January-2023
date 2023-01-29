using System;

namespace _03.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int cnt = 0;
            bool flag = true;
            string input;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);
                if (distance <= energy)
                {
                    cnt++;
                    energy -= distance;
                    if (cnt % 3 == 0 )
                    {
                        energy += cnt;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {cnt} won battles and {energy} energy");
                    flag= false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Won battles: {cnt}. Energy left: {energy}");
            }
        }
    }
}
