﻿using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int integer = int.Parse(Console.ReadLine());
           int times = int.Parse(Console.ReadLine());
            int sum = 0;
            if (times > 10)
            {
                sum = integer * times;
                Console.WriteLine($"{integer} X {times} = {sum}");
            }
            else
            {
                for (int i = times; i <= 10; i++)
                {
                    sum = integer * i;
                    Console.WriteLine($"{integer} X {i} = {sum}");
                }
            }
        }
    }
}
