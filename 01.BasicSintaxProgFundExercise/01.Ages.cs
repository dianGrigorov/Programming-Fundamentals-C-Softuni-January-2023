﻿using System;

namespace BasicSyntaxConStatementExercis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            if (ages >= 0 &&   ages <=2)
            {
                Console.WriteLine("baby");
            }
            else if (ages > 2 && ages <= 13)
            {
                Console.WriteLine("child");

            }
            else if (ages > 13 && ages <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (ages > 19 && ages <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (ages > 65)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
