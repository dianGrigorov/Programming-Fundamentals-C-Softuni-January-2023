using System;
using System.Linq;

namespace _04.ReverseArrayOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] arr = values.Split();
            string[] reversedString = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedString[i] = arr[arr.Length - 1 - i];
                Console.Write(reversedString[i] + " ");
            }
        }
    }
}
