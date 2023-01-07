using System;

namespace _02.PrintTheNumberInReversOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }
            for (int j = num.Length -1; j >= 0; j--)
            {
                Console.Write(num[j] + " ");
            }
        }
    }
}
