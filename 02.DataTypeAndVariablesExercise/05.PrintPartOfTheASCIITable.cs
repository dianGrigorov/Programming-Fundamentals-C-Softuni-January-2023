﻿using System;

namespace _05.PrintPartOfTheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            
            for (int i = start; i <= end; i++)
            {
               char character = (char)i;
                Console.Write(character + " ");
            }
           
        }
    }
}
