using System;
using System.Linq;

namespace _05.TopInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

           

            for (int i = 0; i < arry.Length; i++)
            {
                int curentNum = arry[i];
                bool isTop = true;
               
                for (int j = i +1; j < arry.Length; j++)
                {
                    int nextNum = arry[j];
                    if (nextNum >= curentNum)
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write(curentNum + " ");
                }
            }

        }
    }
}
