using System;
using System.Linq;

namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            // 0 0 0 0
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {

                    for (int j = lift[i]; j < 4; j++)
                    {
                        lift[i]++;
                        people--;
                        if (people == 0)
                        {
                            
                            break;
                        }
                    }
                    if (people == 0)
                    {
                        break;
                    }
                }
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (lift.All(x => x == 4) && people == 0)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
